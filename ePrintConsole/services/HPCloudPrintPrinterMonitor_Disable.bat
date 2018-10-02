@ECHO OFF
net stop CPPrinterMonitor /y
sc config CPPrinterMonitor start= disabled
