# How to pack SSC project

Use this command in Self-Service-Checkout\Self-Service-Checkout:

```shell
dotnet publish -c Release -r win-x64 --self-contained
```

This creates release in Self-Service-Checkout\Self-Service-Checkout\bin folder witch is used to setup application.