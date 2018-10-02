@ECHO OFF
sc config CPPrinterMonitor start= auto
net start CPPrinterMonitor /y
pause