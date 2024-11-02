![plantopia-ss1.png](./screenshots/plantopia-ss1.png)

# Plantopia

> Login page

![plantopia-ss2.png](./screenshots/plantopia-ss2.png)

> Dashboard

![plantopia-ss3.png](./screenshots/plantopia-ss3.png)

> API Docs

![plantopia-ss4.png](./screenshots/plantopia-ss4.png)

> Ability to authorize as admin by entering a valid Base64 apiKey.  
> The expiration time is any future date in Unix timestamp format.  

![plantopia-ss5.png](./screenshots/plantopia-ss5.png)

> Authorize as admin to view logs.  
> Can view the output of executed commands.  

![plantopia-ss6.png](./screenshots/plantopia-ss6.png)

> Built-in sendmail command is vulnerable to pass anything as long as sendmail is included.  
> "/usr/sbin/sendmail -t; cat flag.txt"

![plantopia-ss7.png](./screenshots/plantopia-ss7.png)

> Trigger the sendmail command that we have modified to include our payload.

![plantopia-ss8.png](./screenshots/plantopia-ss8.png)

> View logs and retrieve the flag.

![plantopia-ss9.png](./screenshots/plantopia-ss9.png)
