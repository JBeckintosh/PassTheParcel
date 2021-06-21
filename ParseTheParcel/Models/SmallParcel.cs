using ParseTheParcel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParseTheParcel.Enums.Parcels;

namespace ParseTheParcel.Models
{
    public class SmallParcel : IParcel
    {
        public ParcelOptions Type { get; } = ParcelOptions.Small;
        public int Length { get; } = 200;
        public int Height { get; } = 150;
        public int Breadth { get; } = 300;
        public int Weight { get; set; }
        public decimal Cost { get; } = 5.00m;
        public bool ContainsContents { get; set; } = false;
        public string SendAddress { get; set; }
        public string ReturnAddress { get; set; }
    }
}
