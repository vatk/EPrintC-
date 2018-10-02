@ECHO OFF
net stop CPLicenseService /y
sc config CPLicenseService start= disabled
pause
