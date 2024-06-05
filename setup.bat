@echo off
setlocal

REM Ustaw zmienne ścieżki
set "APP_DIR=%~dp0"
set "SQL_FILE=.\db\dbexport_utf8.pgsql"

REM Monitowanie użytkownika o nazwę bazy danych, nazwę użytkownika i hasło
set /p DB_USER="Enter the database username: "
set /p DB_PASSWORD="Enter the database password: "

REM Tworzenie bazy danych
echo Creating SSCDB database...
createdb.exe -U %DB_USER% SSCDB
if %errorlevel% neq 0 (
    echo Failed to create SSCDB database.
    pause
    exit /b %errorlevel%
)

REM Import danych do bazy danych
echo Importing data to the database...
psql.exe -U %DB_USER% -d SSCDB -f "%SQL_FILE%"
if %errorlevel% neq 0 (
    echo Failed to import data.
    pause
    exit /b %errorlevel%
)

REM Instalacja aplikacji (kopiowanie plików)
echo Installing application...
xcopy "%APP_DIR%Self-Service-Checkout\bin\release\net8.0-windows\win-x64\publish" "C:\Program Files\SSC" /E /I /Y
if %errorlevel% neq 0 (
    echo Failed to copy application files.
    pause
    exit /b %errorlevel%
)

REM Tworzenie skrótu na pulpicie
set "SHORTCUT_NAME=SSC"
set "SHORTCUT_PATH=%USERPROFILE%\Desktop\%SHORTCUT_NAME%.lnk"
set "TARGET_PATH=C:\Program Files\SSC\Self-Service-Checkout.exe"

echo Creating desktop shortcut...
powershell "$s=(New-Object -COM WScript.Shell).CreateShortcut('%SHORTCUT_PATH%');$s.TargetPath='%TARGET_PATH%';$s.Save()"
if %errorlevel% neq 0 (
    echo Failed to create desktop shortcut.
    pause
    exit /b %errorlevel%
)

REM Uruchom aplikację (opcjonalnie)
echo Launching application...
start "" "C:\Program Files\SSC\Self-Service-Checkout.exe"
if %errorlevel% neq 0 (
    echo Failed to launch application.
    pause
    exit /b %errorlevel%
)

endlocal
echo Done!
pause
