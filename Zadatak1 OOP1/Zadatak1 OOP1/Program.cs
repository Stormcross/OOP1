using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadatak1_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacija pokrenuta...\n");
            Console.WriteLine("Primljenih argumenata: {0}", args.Length);
            Console.WriteLine(@"{--------------------------------------\n---}"); //@ nam uzima doslovno sve sto pise u string nizu

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}]=[{1}]", i, args[i]);
            }

            foreach (var a in args)
            {
                Console.WriteLine(a);
            }
            /*Doradite program tako da za dohvat i ispis argumenata iz
            komandne linije koristi razred
            Environmet i njegovu metodu GetCommandLineArgs*/

            string[] pozArg = Environment.GetCommandLineArgs();
            Console.WriteLine("Lokacija: {0}", pozArg); //prikazuje lokaciju programa


            /*Doradite program tako da ispisuje popis dostupnih logičkih diskova na operacijskom sustavu. 
            Pri tome koristite metodu Environment.GetLogicalDrives*/
            string[] pozDisk = Environment.GetLogicalDrives();
            foreach (var drive in pozDisk)
            {
                Console.WriteLine("Disk: {0}", drive);
            }
            Console.WriteLine("---------------------------------------------------------------\n");
            /*Dohvatite popis logičkih diskova dostupnih na
            operacijskom sustavu. Provjerite da li je disk spreman za rad te za svaki koji je ispišite
            : tip, koji datotečni sustav koristi, koliko ukupno podataka može pohraniti, količinu preostalog slobodnog prostora, 
            naziv te root direktori*/

            DriveInfo[] driveInfos = DriveInfo.GetDrives(); //https://bit.ly/2Adw9NQ
            foreach (DriveInfo drive in driveInfos)
            {

                if (drive.IsReady == true)
                {
                    Console.WriteLine("Disk: {0}", drive.Name);
                    Console.WriteLine("Disk tip: {0}", drive.DriveType);
                    Console.WriteLine("File type: {0}", drive.DriveFormat);
                    Console.WriteLine("Volume label: {0}", drive.VolumeLabel);
                    Console.WriteLine("Dostupan prostor korisniku(trenutnom): {0, 15} bytes", drive.AvailableFreeSpace);
                    Console.WriteLine("Cjelokupni dostupan prostor: {0, 15} bytes", drive.TotalFreeSpace);
                    Console.WriteLine("Totalni prostor na disku: {0, 15} bytes", drive.TotalSize);
                    Console.WriteLine("---------------------------------------------------------------\n");

                }

            }
            /*Doradite program tako da isp
            isuje verziju operacijskog sustava, ime računala, korisničko ime, 
            broj procesora, direktorij sustava, količinu memorije pridijeljene procesu u kilobajtima i 
            megabajtima, količinu dostupne virtualne memorije
            u kilobajtima i megabajtima.*/




            Console.ReadLine(); //zaustavlja rad programa u console

            /*U programu uključite
            Environmet.Exit
            metodu*/
            Environment.Exit(0);
        }

    }
}
