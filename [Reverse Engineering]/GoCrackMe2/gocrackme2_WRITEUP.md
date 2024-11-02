# GoCrackMe2: Reverse Engineering

Author: @HuskyHacks

Not bad gophers, but that one was the easiest of the three! How will you do against something a little more involved? I wouldn't expect to get any help from debugging symbols on this one...

Archive password: infected

Download the file(s) below.  
Attachments: GoCrackMe2.zip  

```
GoCrackMe2      -- ELF64, written in Go, 1294KB  
```

## Write-up by v_17  
> Solved on Kali Linux  

Run program. Learned that it prints to console a piece of the flag, randomly selecting from a set of three unique pieces:  

```
$ ./GoCrackMe2  
flag{  

$ ./GoCrackMe2  
flag{57fc4d2324  

$ ./GoCrackMe2  
flag{f75087857fc4d2324  
```

Opened IDA, located main function, switched to graph view, and searched for flag in strings.  

No easy strings, time to review the main logic!  

Searched for print calls in main, found "fmt_Fprintln" and "runtime_concatstring2".  

```
loc_4882BF:
movups  [rsp+288h+var_1C8], xmm15
mov     rax, rdx
mov     rbx, rcx
call    runtime_convTstring
lea     rcx, RTYPE_string
mov     qword ptr [rsp+288h+var_1C8], rcx
mov     qword ptr [rsp+288h+var_1C8+8], rax
mov     rbx, cs:qword_5432D0
lea     rax, off_4CA1E8
lea     rcx, [rsp+288h+var_1C8]
mov     edi, 1
mov     rsi, rdi
* call    fmt_Fprintln *
add     rsp, 280h
pop     rbp
retn
```

```
loc_4882A2:
mov     rdi, [rax]
mov     rsi, [rax+8]
xor     eax, eax
mov     rbx, [rsp+288h+var_1D0]
mov     rcx, [rsp+288h+var_228]
* call    runtime_concatstring2 *
jmp     short loc_48824D
```

The surrounding logic looks like concatstring is used to put pieces of the flag together, and this happens 5 times before println is used to print the final flag to the console.

```
loc_488260:
cmp     rax, 5
jge     short loc_4882BF
```

Tried negating some conditional jumps (jz->jnz), similarly to the GoCrackMe1 solution, and also forcing other jumps (jge->jmp) to attempt to force the program into skipping some logic and printing the entire flag, but this just caused crashes or empty prints.  

Followed the logic further backwards from the print logic and noticed a few hardcoded hex values being loaded:  

```
loc_487E69:
* imul    rdx, rbx, 3B9ACA00h *
* and     ecx, 3FFFFFFFh *
movsxd  rcx, ecx
add     rcx, rdx        ; int
* mov     rdx, 0A1B203EB3D1A0000h *
lea     rax, [rdx+rcx]  ; int
call    math_rand_Seed
mov     [rsp+288h+var_242], 0
mov     [rsp+288h+var_23A], 0
* mov     word ptr [rsp+288h+var_242], 5A58h *
* mov     rcx, 595F5E5F09590E0Bh *
[...TRUNCATED...]
jmp     short loc_488132
```

Reviewed paths and found that these values pass through other logic before eventually reaching the print. The other logic includes an unusual looped function that seems to apply a XOR operation on some values using the hex key "6D" then passes them towards the print.  

```
loc_488324:
cmp     rbx, rcx
jl      short loc_488316

loc_488316:
movzx   esi, byte ptr [rdx+rbx]
* xor     esi, 6Dh *
mov     [rax+rbx], sil
inc     rbx
```

It seemed like a stretch, but I threw the values I found into CyberChef with a XOR using "6D", and the first three looked like nothing interesting, but the fourth and fifth were surprisingly readable:  

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Auto')XOR(%7B'option':'Hex','string':'6D'%7D,'Standard',false)&input=M0I5QUNBMDANM0ZGRkZGRkYNMEExQjIwM0VCM0QxQTAwMDANNUE1OA01OTVGNUU1RjA5NTkwRTBC&ieol=CR&oeol=CRLF

```
3B9ACA00
3FFFFFFF
0A1B203EB3D1A0000
5A58
595F5E5F09590E0B

> V÷§mRgvMSÞ¼Ímm754232d4cf
```

Here, I recognized the "4232" from the original provided flag piece "flag{f75087857fc4d2324" and realized the decoding was reversed, so I added that step into CyberChef, gathered the rest of the hex values, and continued the process (discarding the first 3 unreadables):  

```
loc_487E69:
imul    rdx, rbx, 3B9ACA00h
and     ecx, 3FFFFFFFh
movsxd  rcx, ecx
add     rcx, rdx        ; int
mov     rdx, 0A1B203EB3D1A0000h
lea     rax, [rdx+rcx]  ; int
call    math_rand_Seed
mov     [rsp+288h+var_242], 0
mov     [rsp+288h+var_23A], 0
* mov     word ptr [rsp+288h+var_242], 5A58h *
* mov     rcx, 595F5E5F09590E0Bh *
mov     [rsp+288h+var_242+2], rcx
mov     [rsp+288h+var_247], 0
mov     [rsp+288h+var_243], 0
* mov     byte ptr [rsp+288h+var_247], 0Bh *
* mov     [rsp+288h+var_247+1], 160A0C01h *
mov     qword ptr [rsp+288h+var_256+7], 0
* mov     rcx, 105C585A5D545E0Bh *
mov     qword ptr [rsp+288h+var_256+7], rcx
mov     dword ptr [rsp+288h+var_256], 0
mov     dword ptr [rsp+288h+var_256+3], 0
* mov     [rsp+288h+var_256], 0Bh *
* mov     word ptr [rsp+288h+var_256+1], 585Ah *
* mov     dword ptr [rsp+288h+var_256+3], 555A555Dh *
mov     [rsp+288h+var_25E], 0
* mov     rcx, 5B5B5B545D0E095Ch *
[...TRUNCATED...]
jmp     short loc_488132
```

> https://gchq.github.io/CyberChef/#recipe=From_Hex('Auto')XOR(%7B'option':'Hex','string':'6D'%7D,'Standard',false)Reverse('Character')&input=NUE1OA0KNTk1RjVFNUYwOTU5MEUwQg0KMEINCjE2MEEwQzAxDQoxMDVDNTg1QTVENTQ1RTBCDQowQg0KNTg1QQ0KNTU1QTU1NUQNCjVCNUI1QjU0NUQwRTA5NUM&ieol=CRLF

```
5A58
595F5E5F09590E0B
0B
160A0C01
105C585A5D545E0B
0B
585A
555A555D
5B5B5B545D0E095C
	
> 1dc09666087875ff390751}lag{ffc4d232457
```

> Added spacing to the output for clarity.  

```
1dc09666
0878
75
f
f390751}
lag{
f
fc4d2324
57
```

Removing the known flag pieces leaves only 2 pieces to reconstruct the final flag:  

```
flag{f75087857fc4d2324...

1dc09666
f390751}

.f.lag{.f.75.0878.57.fc4d2324.1dc09666.f390751}
```

###### P.S. Thanks for reading! :)