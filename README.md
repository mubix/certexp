# certexp
Certificate Export Utility v1.0

[![Build Status](https://travis-ci.org/mubix/certexp.svg?branch=master)](https://travis-ci.org/mubix/certexp)

Example Run:

```
C:\> certexp.exe
===== System Certificates ====
[+] Subject Name: CN=BLAH
[+] Thumbprint  : AB7570CE9AA2E3AABTF7CBF059B267B1DE3A99A1
----> COULD NOT EXPORT - NOT ADMIN OR NOT MARKED AS EXPORTABLE


===== User Certificates ======
[+] Subject Name: CN=BLAH L=San Jose, S=California, C=US
[+] Thumbprint  : AB7570CE9AA2E3AABTF7CBF059B267B1DE3A99A1
[+] Private Key : NO
MIIGngI <BASE64 OUTPUT SNIPPED FOR POSTING TO GITHUB>

[+] Subject Name: SERIALNUMBER=152107, CN=ABC
[+] Thumbprint  : AB7570CE9AA2E3AABTF7CBF059B267B1DE3A99A1
[+] Private Key : YES
MIIK <BASE64 OUTPUT SNIPPED FOR POSTING TO GITHUB>

[*] Export password is: asybdbrpld5
```
