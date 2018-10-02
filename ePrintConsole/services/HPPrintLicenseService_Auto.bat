@ECHO OFF
sc config HP.Print.License.Service start= auto
net start HP.Print.License.Service /y