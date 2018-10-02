@ECHO OFF
net stop CPControlService /y
sc config CPControlService start= disabled
