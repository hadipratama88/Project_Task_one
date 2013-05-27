using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Task_One
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat instan class/object
            Motor mtr = new Motor();

            // memasukan data instan class/object
            mtr.Merk = "Honda";
            mtr.Kecepatan = 100;
            mtr.NoMotor = "D 1234 HP";

            // memanggil method
            mtr.tampil();
            Console.ReadLine();
        }
    }
}
