@ECHO OFF
net stop CPAccountManagementService /y
sc config CPAccountManagementService start= disable