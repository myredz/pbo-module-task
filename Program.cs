using System;
using System.Runtime.ConstrainedExecution;

namespace Tugas3.raihan
{
    class Processor
    {
        public string Merk, Tipe;
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.Merk = "AMD";
        }
    }

    class Ahtlon : AMD
    {
        public Ahtlon()
        {
            base.Merk = "Ahtlon";
        }
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.Tipe = "Intel";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.Tipe = "Ryzen";
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            base.Tipe = "Corei3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            base.Tipe = "Corei5";
        }
    }

    class Corei7 : Intel
    {
        public Corei7()
        {
            base.Tipe = "Corei7";
        }
    }

    class VGA
    {
        public string Merk;
    }

    class Vga : AMD
    {
        public Vga()
        {
            base.Merk = "VGA";
        }
    }

    class Nvidia : VGA
    {
        public Nvidia()
        {
            base.Merk = "Nvidia";
        }
    }

    class Laptop
    {
        public string Merk, Tipe;
        public VGA vga;
        public Processor Processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} dinyalakan");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} dimatikan");
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.Tipe = "ROG";
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.Merk = "ASUS";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.Tipe = "Vivobook";
        }
        public void ngoding()
        {
            Console.WriteLine("Halooo!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.Merk = "ACER";
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.Tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.Tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang main game");
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.Tipe = "IdeaPad";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.Merk = "Lenovo";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.Tipe = "Legion";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Soal Nomer 1");
            //Laptop laptop1 = new IdeaPad();
            //laptop1.LaptopDinyalakan();
            //laptop1.LaptopDimatikan();

            //Console.WriteLine("Soal Nomer 2");
            //laptop laptop1 = new Vivobook();
            //laptop1.vga = new Nvidia();
            //laptop1.processor = new CoreI5();
            //laptop1.Ngoding();

            //Console.WriteLine("Soal Nomer 3");
            //Laptop laptop1 = new Vivobook();
            //laptop1.vga = new Nvidia();
            //laptop1.Processor = new Corei5();

            //Console.WriteLine(laptop1.vga.Merk);
            //Console.WriteLine(laptop1.Processor.Merk);
            //Console.WriteLine(laptop1.Processor.Tipe);

            //Console.WriteLine("Soal Nomer 4");
            //Predator predator = new Predator();
            //predator.vga = new VGA();
            //predator.Processor = new Corei7();
            //predator.BermainGame();

            //Console.WriteLine("Soal Nomer 5");
            //ACER acer  = new Predator();
            //acer.BermainGame();

        }

    }
}







