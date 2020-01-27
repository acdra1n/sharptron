@echo off

set PLATFORM_TARGET=x64
set PLATFORM_CONFIG=Debug

echo Building all projects...
cd "%~dp0.."

msbuild /p:Configuration=%PLATFORM_CONFIG% /p:Platform=%PLATFORM_TARGET%
if not "%ERRORLEVEL%"=="0" (
	echo Build failed, please check logs.
	goto end
)

echo Build succeeded, creating distribution at "%~dp0..\dist"...
set DIST_DIR=%~dp0..\dist
set SHARPTRON_MAIN_DIR=%DIST_DIR%\Sharptron_%PLATFORM_CONFIG%_%PLATFORM_TARGET%
if not exist "%DIST_DIR%" mkdir "%DIST_DIR%"
if not exist "%SHARPTRON_MAIN_DIR%" mkdir "%SHARPTRON_MAIN_DIR%"

:end
