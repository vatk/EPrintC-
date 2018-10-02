@ECHO OFF
sc config CPServiceHost start= auto
net start CPServiceHost /y
