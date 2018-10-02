@ECHO OFF
net stop CPStorageMaintenanceService /y
sc config CPStorageMaintenanceService start= disabled
