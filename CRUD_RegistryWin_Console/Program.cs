﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {

    
    static void Main(string[] args) {

       RegistryWin hola = new RegistryWin(@"Computer\HKEY_CURRENT_USER\AppEvents");


        Console.WriteLine(hola.PATH);





        Console.ReadKey();
    }
}

