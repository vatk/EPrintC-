@ECHO OFF
sc config CPLicenseService start= auto
net start CPLicenseService /y