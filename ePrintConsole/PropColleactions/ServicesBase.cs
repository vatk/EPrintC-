using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ePrintConsole.PropColleactions
{
    class ServicesBase
    {
        Process p = new Process();
        string targetDir = string.Format(@"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\services");//batch script file path;        
        public void AccountManagement()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintAccountManagement_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintAccountManagement_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void ContentService()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintContentService_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintContentService_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void ControlService()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintControlService_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintControlService_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void CloudPrintLicenseService()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintLicenseService_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintLicenseService_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void PrinterMonitor()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintPrinterMonitor_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintPrinterMonitor_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void ServiceHost()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintServiceHost_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintServiceHost_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void StorageMaintenance()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintStorageMaintenance_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPCloudPrintStorageMaintenance_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }

        public void LicenseService()
        {
            try
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPPrintLicenseService_Disable.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();

                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "HPPrintLicenseService_Auto.bat"; Thread.Sleep(5000);
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.WaitForExit();


                Thread.Sleep(5000);
            }
            catch (Exception e) { }
        }
    }
}
