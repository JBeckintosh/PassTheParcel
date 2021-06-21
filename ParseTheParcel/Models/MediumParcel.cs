using ParseTheParcel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParseTheParcel.Enums.Parcels;

namespace ParseTheParcel.Models
{
    public class MediumParcel : IParcel
    {
        public ParcelOptions Type { get; } = ParcelOptions.Medium;
        public int Length { get; } = 300;
        public int Height { get; } = 200;
        public int Breadth { get; } = 400;
        public int Weight { get; set; } = 25000;
        public decimal Cost { get; } = 7.50m;
        public bool ContainsContents { get; set; } = false;
        public string SendAddress { get; set; }
        public string ReturnAddress { get; set; }
    }
}
