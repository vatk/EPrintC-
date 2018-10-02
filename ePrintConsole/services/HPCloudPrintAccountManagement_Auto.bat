@ECHO OFF
sc config CPAccountManagementService start= auto
net start CPAccountManagementService /y