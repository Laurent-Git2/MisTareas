@echo off
title MisTareas

taskkill /IM MisTareas.exe /F >nul 2>&1

cd /d "C:\Projets\MisTareas\MisTareas"

start "" cmd /c "timeout /t 5 /nobreak >nul && start http://localhost:5254"

dotnet watch run