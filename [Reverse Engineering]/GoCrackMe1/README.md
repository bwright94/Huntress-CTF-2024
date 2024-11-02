GoCrackMe1: ELF exe.  

Run program on Linux, says "Access Denied!"  

Open disassembler (I used IDA). Find main function.  

Follow logic towards "Access Denied!", see a jump condition "jz short loc_" that goes to the denial after calling a check func.  

Patch program with "jnz short loc_" aka jump if not true.  

Run program.  
