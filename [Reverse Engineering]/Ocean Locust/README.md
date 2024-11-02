# OceanLocust: Reverse Engineering

Author: @JohnHammond

Wow-ee zow-ee!! Some advanced persistent threats have been doing some tricks with hiding payloads in image files!

We thought we would try our hand at it too.

NOTE: this challenge includes a debug build of the binary used to craft the image, as well as a release build... so you may choose to go an easier route or a harder route ;)

Download the file(s) below.  
Attachments: ocean_locust.7z

```
inconspicuous.png         -- PNG image, 7KB  
png-challenge-debug.exe   -- Windows exe, 466KB  
png-challenge.exe         -- Windows exe, 183KB  
```

## Write-up by v_17
> Solved on Windows 10 FlareVM  

First, I started off by trying to run the programs.  

Double-clicking either of the exe files, a cmd window would briefly appear and immediately close. This led me to believe the flag could be generated, maybe while the png is present, and saved elsewhere on the system somehow. So, I continued by using Procmon and recording logs.  

The inconspicuous.png appeared to be a normal image of the Huntress logo.  

### Procmon
Procmon, aka Sysinternals Process Monitor, showed that the program was doing some file-related activities, but I couldn't tell exactly what. Eventually, I realized the exe was meant to be run within a command prompt.  

### CMD
Running the exe in cmd we get:  

```
λ png-challenge.exe
thread 'main' panicked at png-challenge\src/main.rs:28:10:
PNG path is missing. User must supply a png to encode
note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace
```

Ok, it's written in Rust and requires a png as a user input.  

I initially tried running with inconspicuous.png as an argument:
```
Flag is required.
```

Inputting a string such as "test" as a second argument:
```
chunk size must be non-zero
```

After some further testing, I found that the minimum length for the "flag" input is 7 characters, at which point the program can run successfully without these errors. And within the same dir we find an "encoded" version of our input image.  

Here, it became clear that inconspicuous.png must contain an encoded version of the actual flag, but how? Also, how could I input a flag that I do not yet know? Maybe the program expects a 7-char password that allows the program to encode the png with the proper data.  

This train of thinking was only partially correct.  

At this point I figured the true flag might be hardcoded within the program, so I opened IDA to reveal more info.  

### IDA
With any reverse-engineering challenge, it's expected that we need to use a disassembler and/or debugger tool such as Ghidra or IDA. I was certain that reverse engineering the exe in this way would solve the challenge.  

After a while of attempting to reverse Rust, I could not understand anything further than identifying the main function, the 'PNG path' error, and the 'Flag required' error.

I also tried using Ghidra, Binary Ninja, and Rust plugins for the above, to no avail.  

I decided to come back another day.

### Testing and File Analysis
Ok, we know that the program takes a png input and embeds encoded flag data in some way. Let's produce some samples and take a closer look at the outputs.

Assuming that the flag input should match the challenge flag, I tried using a 38-char pseudo-flag:
```
png-challenge.exe inconspicuous.png flag{abcdef123456789abcdef123456789}
```

Comparing the file sizes for the original png and the encoded png, it seems that 136 bytes were added. This was consistent for any 38-char flag string and across different input pngs. A 7-char input yielded 91 bytes, 8-char = 104 bytes, 9-char = 117 bytes, revealing that each flag char is represented by 13 bytes. However, this is odd considering that a 38-char flag adds only 136 bytes (rather than the expected 38*13=494 bytes) or that 136 is not evenly divisible by 13.  

Using the same pseudo-flag, I tested each input from the first 7 chars up to the first 38 chars, recording file sizes along the way. ("flag{ab", "flag{abc", "flag{abcd", etc.) I identified a few patterns:  

```
Notes:
    7-13 chars --> incremented by 13 bytes  
    14-20 chars --> by 14 bytes but some lengths resulted in no increment  
    21-27 chars --> by 15 bytes, some no increment
    28-34 chars --> by 16 bytes, some no increment
    35-full flag --> by 17 bytes, some no increment
```

```
Raw Data:
    original png "s1.png" = 17,684 bytes (+0 bytes)

    flag{ab > 17,775 (+13 bytes * 7 chars) (+91 bytes)
    flag{abc > 17,788
    flag{abcd > 17,801
    ...abcde > ...814
    f > 827
    0 > 840
    1 > 17,853 (+13 bytes * 13 chars) (+169 bytes)
    2 > 17,782 (+14 bytes * 7) (+98 bytes)
    3 > 796 (+14 bytes * 8) (+112 bytes)
    4 > 796 (+ 0 bytes)
    5 > 810
    6 > 810
    7 > 824
    8 > 17,824 () (+140 bytes)
    9 > 17,789
    flag{abcdef0123456789a > 17,804 (+15 bytes)
    b > 804
    c > 804
    d > 819
    e > 819 () (+135 bytes)
    f > 819
    0 > 796
    1 > 812 (+16 bytes)
    2 > 812
    3 > 812
    4 > 812
    5 > 828
    6 > 828 () (+144 bytes)
    7 > 803
    8 > 820 (+17 bytes)
    9 > 820
    flag{abcdef0123456789abcdef0123456789} > 17,820
```

So, a full flag would instead count by 17 bytes. And, it's more likely that each char is represented by one byte of data with some constant 'padding'.  

This confirmed that the oddity in expected file size was done purposefully by the program and that a flag with length 38 would indeed add only 136 bytes, a number which also happens to be divisible by 17 and 8.  

This clarity assured me that the program was not faulty, and so I turned my attention to inconspicuous.png.  

### Decoding the PNG
To gain a better understanding of PNG data, I gathered some normal png images and analyzed them in a tool called Detect It Easy (DIE). DIE summarizes the data of any file in various ways, including Hex, Strings, Visualization, Memory Map, and Entropy. Across these tools, I found Visualization and Memory Map to be the most useful for this challenge.  

An ordinary png file contains various chunks of data such as Header, IHDR, IDAT, and IEND. Utilizing the Visualization, it became clear that the encoded png contained several extra unusual chunks not found in a normal png, each with a name following the format "biTx", and Memory Map allowed me to quickly parse the hex data for every chunk.  

```
Unusual chunks in inconspicuous.png, ordered alphabetically:
biTa	00 00 00 05   62 69 54 61   04 05 35 06 19   9d c5 69 88   
biTb	00 00 00 05   62 69 54 62   04 0c 37 5a 55   0c b9 9f 21   
biTc	00 00 00 05   62 69 54 63   01 5f 6d 53 00   7d 55 d6 ec   
biTd	00 00 00 05   62 69 54 64   5a 0c 37 5c 06   f9 fb aa 5e   
biTe	00 00 00 05   62 69 54 65   54 5c 36 5d 00   b7 20 36 7b   
biTf	00 00 00 05   62 69 54 66   00 58 64 03 07   a6 21 a5 2e   
biTg	00 00 00 05   62 69 54 67   55 0b 36 51 57   c8 e8 02 80   
biTh	00 00 00 05   62 69 54 68   06 59 29 c2 c8   0a af 71 26   
```

The chunks follow a standard format of: length of data (4 bytes), identifier (4 bytes), data (x bytes), and CRC (4 bytes). Notice that there are 8 chunks and each contains exactly 17 bytes, for 136 total bytes. Furthermore, each chunk contains 5 bytes of data, totaling 40 bytes. We can safely assume a 38-byte flag was fit within these 40 bytes. But, how?  

Maybe, by inputting a known plaintext and viewing its encoded data, I could reverse engineer the encoding process and decode the flag. For simplicity, I chose "1234567" (satisfying minimum length of 7) and passed it through the program with a normal png:

```
Chunks of normal png encoded with '1234567':   
biTa	00 00 00 01   62 69 54 61   53   [...]
biTb	00 00 00 01   62 69 54 62   50   [...]
biTc	00 00 00 01   62 69 54 63   51   [...]
biTd	00 00 00 01   62 69 54 64   56   [...]
biTe	00 00 00 01   62 69 54 65   57   [...]
biTf	00 00 00 01   62 69 54 66   54   [...]
biTg	00 00 00 01   62 69 54 67   55   [...]
```

Notice that there are 7 bytes of data and only 7 total chunks. "1234567" encodes to the hex "53 50 51 56 57 54 55". In CyberChef, From Hex shows the characters "SPQVWTU", and CyberChef's Magic function is able to identify the encoding operation as XOR with a hex key of "62" or "b".  

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Auto')Magic(3,true,false,'1234567')&input=NTMgNTAgNTEgNTYgNTcgNTQgNTU  

```
Chunks of png encoded with '12345671234567':
biTa	00 00 00 02   62 69 54 61   53 5b
biTb	00 00 00 02   62 69 54 62   51 5d
biTc	00 00 00 02   62 69 54 63   57 5f
biTd	00 00 00 02   62 69 54 64   55 58
biTe	00 00 00 02   62 69 54 65   50 5a
biTf	00 00 00 02   62 69 54 66   56 5c
biTg	00 00 00 02   62 69 54 67   54 5e
```

"12345671234567" encodes to "53 5b 51 5d 57 5f 55 58 50 5a 56 5c 54 5e", and through some educated guessing, we can find the correct XOR hex key "62 69" or "bi".

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Auto')XOR(%7B'option':'Hex','string':'62%2069'%7D,'Standard',false)&input=NTMgNWIgNTEgNWQgNTcgNWYgNTUgNTggNTAgNWEgNTYgNWMgNTQgNWU  

```
Chunks of png encoded with '123456712345671234567':
biTa	00 00 00 03   62 69 54 61   53 5b 67
biTb	00 00 00 03   62 69 54 62   56 5c 62
biTc	00 00 00 03   62 69 54 63   55 58 66
biTd	00 00 00 03   62 69 54 64   51 5d 61
biTe	00 00 00 03   62 69 54 65   54 5e 65
biTf	00 00 00 03   62 69 54 66   50 5a 60
biTg	00 00 00 03   62 69 54 67   57 5f 63
```

"123456712345671234567" encodes to "53 5b 67 56 5c 62 55 58 66 51 5d 61 54 5e 65 50 5a 60 57 5f 63" using the XOR key "62 69 54" or "biT". Here I recognized that the XOR key matched the chunk identifiers, and I assumed that the actual flag data would require a XOR key length of 5.  

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Space')XOR(%7B'option':'Hex','string':'62%2069%2054'%7D,'Standard',false)&input=NTMgNWIgNjcgNTYgNWMgNjIgNTUgNTggNjYgNTEgNWQgNjEgNTQgNWUgNjUgNTAgNWEgNjAgNTcgNWYgNjM&oeol=VT

### Getting the Flag
I extracted the 40-byte encoded flag data from inconspicuous.png and loaded it into CyberChef with From Hex and XOR with a key. Since the chunk ids were shorter than the assumed XOR key length, I simply tried extending the key to "62 69 54 61 62" or "biTab".  

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Auto')XOR(%7B'option':'Hex','string':'62%2069%2054%2061%2062'%7D,'Standard',false)&input=MDQgMDUgMzUgMDYgMTkNCjA0IDBjIDM3IDVhIDU1DQowMSA1ZiA2ZCA1MyAwMA0KNWEgMGMgMzcgNWMgMDYNCjU0IDVjIDM2IDVkIDAwDQowMCA1OCA2NCAwMyAwNw0KNTUgMGIgMzYgNTEgNTcNCjA2IDU5IDI5IGMyIGM4&ieol=CRLF

This revealed the flag format "flag{...}" with 2 extra characters on the end, but some chars within the hash portion of the flag were incorrect.  

Eventually, I realized that instead of just stretching a single chunk id for the key, the program was really iterating through each chunk id for each respective 5-byte block of data. (i.e. XOR with "biTa" for the first set of 5 bytes, XOR with "biTb" for the second set of 5 bytes, XOR with "biTc" for the third set, etc.)  

Doing this for all 8 chunks and concatentating the output reveals the final flag: flag{fec87...}  

## Steps to Reproduce the Flag
> View hex data of inconspicuous.png.  

> Extract the 40-bytes of encoded data that is divided across the 8 'biTx' chunks.  

> Convert from hex to raw bytes and apply XOR using chunk identifier as key.  

> Repeat for each set of 5 bytes iterating through the 8 chunk ids.  

###### P.S. Thanks for reading! :)
