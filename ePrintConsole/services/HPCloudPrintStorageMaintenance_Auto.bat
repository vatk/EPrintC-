@ECHO OFF
sc config CPStorageMaintenanceService start= auto
net start CPStorageMaintenanceService /y