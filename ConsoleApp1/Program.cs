using System;
using ConsoleApp1.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Department dp = new Department();

            Helper.Print("Departamentin adini daxil edin", ConsoleColor.Green);
            string dpn = Console.ReadLine();
            dp.Name = dpn;

            Helper.Print("Departamentin umumi isci sayin qeyd edin:", ConsoleColor.Green);
            Iscisayi:
            string dpi =Console.ReadLine();
            bool issayi = int.TryParse(dpi, out int num);
            if (!issayi)
            {
                Helper.Print("Daxil etdiyiniz say yanlisdir, duzgun daxil edin ", ConsoleColor.Red);
                goto Iscisayi;
            }
            dp.EmployeeLimit = num;
            Helper.Print("Departament umumi budcesin daxil edin:", ConsoleColor.Green);
            Salary:
            string dpb = Console.ReadLine();
            bool budce = int.TryParse(dpb, out int budget);
            if (!budce)
            {
                Helper.Print("Daxil etdiyiniz budce yansildir, yeniden daxil edin :", ConsoleColor.Red);
                goto Salary;
            }
            dp.Budget = budget;
            Helper.Print("Iscilerin en az is tecrubesi nece il olmalidir:", ConsoleColor.Green);
            Tecrube:
            string dpt = Console.ReadLine();
            bool tecrube = int.TryParse(dpt, out int tcrb);
            if (!tecrube)
            {
                Helper.Print("Daxil etdiyiniz tecrube ili yanlisdir,yeniden daxil edin:", ConsoleColor.Red);
                goto Tecrube;
            }
            dp.RequiredExperience = tcrb;
            Helper.Print("Ali tehsil vacibdirmi:   yes/no", ConsoleColor.Green);
            Tehsil:
            string t = Console.ReadLine();
            if (t.ToLower() == "yes".ToLower())
            {
                dp.IsBachelorDegreeRequired = true;
            }
            else if (t.ToUpper() == "no".ToUpper())
            {
                dp.IsBachelorDegreeRequired = false;
            }
            else
            {
                Helper.Print("Yanlis daxil etdiniz,yeniden daxil edin :", ConsoleColor.Red);
                goto Tehsil;
            }
            string rsl = "";
            do
            {
                Helper.Print("Isci elave etmek isteyirsiz?", ConsoleColor.DarkGreen);
                rsl = Console.ReadLine();
                if (rsl.ToUpper() == "no".ToUpper())
                {
                    Helper.Print("Isci daxil etmediyiniz ucun proqram sonlandirildi",ConsoleColor.Red);
                    return;

                }
                
            }
            while (rsl!="yes");
            string result = "";
            do
                {
                    Employee ep = new Employee();

                    Helper.Print("Iscinin adi:", ConsoleColor.Yellow);
                    string isn = Console.ReadLine();
                    ep.Name = isn;
                    Helper.Print("Iscinin soyadi:", ConsoleColor.Yellow);
                    string iss = Console.ReadLine();
                    ep.Surname = iss;
                    Helper.Print("Iscinin emek haqqi:", ConsoleColor.Yellow);
                    Maas:
                    string ism = Console.ReadLine();
                    bool maas = int.TryParse(ism, out int masss);
                    if (!maas)
                    {
                        Helper.Print("Yanlis daxil edilib,yeniden daxil edin:", ConsoleColor.Red);
                        goto Maas;
                    }
                    ep.Salary = masss;
                    Helper.Print("Iscinin tecrubesi:", ConsoleColor.Yellow);
                    Tec:
                    string ist = Console.ReadLine();
                    bool tec = int.TryParse(ist, out int tecr);
                    if (!tec)
                    {
                        Helper.Print("Yanlis daxil edilib,yeniden daxil edin:", ConsoleColor.Red);
                        goto Tec;
                    }
                    ep.Experience = tecr;
                    Helper.Print("Ali tehsil varmi?   yes/no", ConsoleColor.Yellow);
                    Thsl:
                    string tt = Console.ReadLine();
                    if (tt.ToUpper() == "yes".ToUpper())
                    {
                        ep.HasBachelorDegree = true;
                    }
                    else if (tt.ToUpper() == "no".ToUpper())
                    {
                        ep.HasBachelorDegree = false;

                    }
                    else
                    {
                        Helper.Print("Yanlis daxil edildi,yeniden daxil edin:", ConsoleColor.Red);
                        goto Thsl;
                    }


                    if (dp.AddEmployee(ep))
                    {
                        Helper.Print("Isci elave olundu,Buyurun.", ConsoleColor.DarkBlue);
                    }
                    else if (!(dp.AddEmployee(ep)))
                    {
                        Helper.Print("Isci elave etmek olmadi", ConsoleColor.Red);
                    }
                    Helper.Print("Isci elave etmek isteyirsiz", ConsoleColor.DarkGreen);
                    result = Console.ReadLine();

                } while (result.ToUpper() == "yes".ToUpper());
               
            
             dp.Ortalama();
            
        }

    }
}

