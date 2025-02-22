set current_dir=%cd%
cd %current_dir%
git clone https://github.com/AkibAshfaq/ShopZ-Project.git
mkdir "C:\CODE Files\VS 2022\ShopzZ"
set Search=%current_dir%\ShopZ-Project
cd %Search%
set Copy=%Search%\ShopzZ
xcopy %Copy% "C:\CODE Files\VS 2022\ShopzZ" /E /I
rm %Search% /S /Q
cd "C:\CODE Files\VS 2022"
echo @echo off > Run.bat
echo cd "C:\CODE Files\VS 2022\ShopzZ\bin\Debug" >> Run.bat
echo AmaZon.exe >> Run.bat
start .
