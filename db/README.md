# Notes on database import/export

## Export

```shell
pg_dump -U postgres SSCDB > dbexport.pgsql
```

NOTE: Change file encoding. pgsql supports utf8.

```shell
Get-Content -Encoding Unicode .\dbexport.pgsql | Set-Content -Encoding UTF8 .\dbexport_utf8.pgsql
```

## Import

Create database in pgadmin or by pgsql command named: "SSCDB"

And import db:

```shell
psql -d SSCDB -U postgres -f .\dbexport_utf8.pgsql
```