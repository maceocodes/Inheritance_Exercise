using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Phone : Device
    {
        public double dimensions { get; set; }

        public double Dimensions
        {
            get{
                return dimensions;
            }
            set{
                dimensions = value;
            }
        }
    }

}
