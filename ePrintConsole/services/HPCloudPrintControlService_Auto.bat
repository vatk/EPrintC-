@ECHO OFF
sc config CPControlService start= auto
net start CPControlService /y