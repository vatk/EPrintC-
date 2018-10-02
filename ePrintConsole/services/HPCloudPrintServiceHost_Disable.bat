@ECHO OFF
net stop CPServiceHost /y
sc config CPServiceHost start= disabled
