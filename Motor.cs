using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Task_One
{
    class Motor
    {
        // membuat variabel/field untuk class Motor
        public string NoMotor;
        public string Merk;
        public int Kecepatan;

        // membuat method untuk menampilkan object
        public void tampil()
        {
            Console.WriteLine("Motor: " + Merk + " Mempunyai Kecepatan " + Kecepatan + " Km/Jam, Nomor : " + NoMotor);
        }
    }
}
