using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VjezbaOS1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();


            foreach (DriveInfo d in allDrives)
            {

                if (d.IsReady == true)
                {
                    Console.WriteLine("Disk: {0} \n Tip diska: {1} \n File system: {2} \n Ukupna velicina diska: {3} gb " +
                        "\n Dostupan slobodan prostor: {4} gb \n Ukupan dostupan prostor: {5} gb "
                        , d.Name, d.DriveType, d.DriveFormat, (float)d.TotalSize / 1024 / 1024 / 1024, (float)d.AvailableFreeSpace / 1024 / 1024 / 1024, (float)d.TotalFreeSpace / 1024 / 1024 / 1024);
                }
            }
        }
    }
}
