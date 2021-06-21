using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParseTheParcel.Enums.Parcels;

namespace ParseTheParcel.Interfaces
{
    public interface IParcel
    {
        ParcelOptions Type { get; }
        int Length { get; }
        int Height { get; }
        int Breadth { get; }
        int Weight { get; set; }
        decimal Cost { get; }
        bool ContainsContents { get; set; }
        string SendAddress { get; set; }
        string ReturnAddress { get; set; }
    }
}
