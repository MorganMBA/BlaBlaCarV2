﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaCarV2
{
    class Program
    {
        static void Main(string[] args)
        {
            BlaBlaCarDBContext db = new BlaBlaCarDBContext();
            AUTHENTIFICATION UserAuth = new AUTHENTIFICATION();

            UserAuth.NOM = "NEMMENE";
            UserAuth.PRENOM = "Dumesnil";

            Console.WriteLine("BlaBlaCarV2");
            Console.ReadLine();
        }
    }
}
