@ECHO OFF
net stop HP.Print.License.Service /y
sc config HP.Print.License.Service start= disabled
