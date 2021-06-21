using ParseTheParcel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParseTheParcel.Enums.Parcels;

namespace ParseTheParcel.Models
{
    public class LargeParcel : IParcel
    {
        public ParcelOptions Type { get; } = ParcelOptions.Large;
        public int Length { get; } = 400;
        public int Height { get; } = 250;
        public int Breadth { get; } = 600;
        public int Weight { get; set; } = 25000;
        public decimal Cost { get; } = 8.50m;
        public bool ContainsContents { get; set; } = false;
        public string SendAddress { get; set; }
        public string ReturnAddress { get; set; }
    }
}
