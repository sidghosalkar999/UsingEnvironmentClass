using System;
using System.Collections;

namespace UsingEnvironmentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("OSVersion: " + Environment.OSVersion.ToString()); //Operating system Details  
            ar.Add("OSVersion Platform: " + Environment.OSVersion.Platform.ToString()); //Operating system Platform Details  
            ar.Add("OS Version: " + Environment.OSVersion.Version.ToString()); //Operating system version Details  
            ar.Add("NewLine :" + Environment.NewLine.ToString()); //string will spilt into New line   
            ar.Add("MachineName :" + Environment.MachineName.ToString());//Machine Name of the current computer  
            ar.Add("Is64BitProcess : " + Environment.Is64BitProcess.ToString());//Checks whether the OS has 64 bit process  
            ar.Add("UserDomainName: " + Environment.UserDomainName.ToString());//gets the network domain name which is currently associated with current User Computer  
            ar.Add("UserName :  " + Environment.UserName.ToString());//gets the username of person who currenlty logged on  the windows operating Sytem system  
            ar.Add("WorkingSet :" + Environment.WorkingSet.ToString());//gets the Amount of physical memory mapped to the process contex   
            ar.Add("CurrentDirectory: " + Environment.CurrentDirectory.ToString());//gets the full path of current working directory.  
            ar.Add("HasShutdownStarted:" + Environment.HasShutdownStarted.ToString());//Gets the Value whether  CLR is shutting down  
            ar.Add("SystemPageSize:" + Environment.SystemPageSize.ToString());//gets the Amount of memory for an operating system's Page file.   


            Console.WriteLine(Environment.NewLine + "Environment Class Details" + Environment.NewLine + "---------------------------");
            foreach (var item in ar)
            {

                Console.WriteLine(item);

            }
            Console.ReadLine();

        }
    }
}
