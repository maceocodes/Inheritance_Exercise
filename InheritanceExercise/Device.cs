﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Device
    {
        public bool powerOn { get; set; }

        public void PowerOn(){
            Console.WriteLine("Powered On");
        }
    }
}
