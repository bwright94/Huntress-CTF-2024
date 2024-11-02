![stack-it-ss1.png](stack-it-ss1.png)

Solve by opening a disassembler, setting a breakpoint, and viewing the registers.  
```
.data:0804A02E unk_804A02E db  31h ; 1 ; DATA XREF: start+29↑o
.data:0804A02F db  65h ; e
.data:0804A030 db  63h ; c
.data:0804A031 db  66h ; f
.data:0804A032 db  66h ; f
.data:0804A033 db  38h ; 8
.data:0804A034 db  62h ; b
.data:0804A035 db  65h ; e
.data:0804A036 db  63h ; c
.data:0804A037 db  65h ; e
.data:0804A038 db  39h ; 9
.data:0804A039 db  34h ; 4
.data:0804A03A db  38h ; 8
.data:0804A03B db  36h ; 6
.data:0804A03C db  32h ; 2
.data:0804A03D db  38h ; 8
.data:0804A03E db  37h ; 7
.data:0804A03F db  64h ; d
.data:0804A040 db  63h ; c
.data:0804A041 db  37h ; 7
.data:0804A042 db  36h ; 6
.data:0804A043 db  35h ; 5
.data:0804A044 db  32h ; 2
.data:0804A045 db  31h ; 1
.data:0804A046 db  61h ; a
.data:0804A047 db  38h ; 8
.data:0804A048 db  34h ; 4
.data:0804A049 db  62h ; b
.data:0804A04A db  62h ; b
.data:0804A04B db  37h ; 7
.data:0804A04C db  63h ; c
.data:0804A04D db  30h ; 0
.data:0804A04D _data ends
``` 

Or, use strings:   
```
$ strings stack_it.bin
Hello, World!
SQQUR^V
1ecff8bece9486287dc76521a84bb7c0
.shstrtab
.text
.data
.bss
```

> flag{1ecff8bece9486287dc76521a84bb7c0}  
