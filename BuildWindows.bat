call MSBuildLocator.bat
"%MSBUILD%" StartAll.sln /target:build /p:Configuration=net-5.0-debug
pause