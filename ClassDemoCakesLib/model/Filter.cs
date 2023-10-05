using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoCakesLib.model
{
    public class Filter2
    {
        public int? MaxPris { get; set; }

        // constructor
        // tostring


    }

    public record Filter (int? MaxPris);
}
