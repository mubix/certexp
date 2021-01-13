# certexp

Certificate Export Utility v1.0

[![Build Status](https://travis-ci.org/mubix/certexp.svg?branch=master)](https://travis-ci.org/mubix/certexp)

## Build

To run an build this project you need Visual Studio 2019 16.3.0 or higher. As alternative you can use VsCode with a dotnet core >= 3.0.0.
For the manually build run this commands:

```bash
dotnet restore
dotnet build
# to start the CLI
dotnet run
# to pack the nuget package
dotnet pack
```

The output of pack is an NuGet package that can be published to a NuGet feed.

## Installation and update

Install the tool is straight forward.

```bash
dotnet tool install -g certexp
```

The update is also very easy:

```bash
dotnet tool update -g certexp
```

## Example

```bash
C:\> certexp
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
