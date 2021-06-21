using ParseTheParcel.Interfaces;
using ParseTheParcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel.Functions
{
    public class ParcelFunctions
    {
        public static IParcel SelectPackageSize(int length, int height, int breadth)
        {
            if (length <= 0)
            {
                throw new Exception("Length is invalid");
            }
            if (height <= 0)
            {
                throw new Exception("Height is invalid");
            }
            if (breadth <= 0)
            {
                throw new Exception("Breadth is invalid");
            }

            if (length > 300 || height > 200 || breadth > 400)
            {
                return new LargeParcel();
            }

            if (length > 200 || height > 150 || breadth > 300)
            {
                return new MediumParcel();
            }

            return new SmallParcel();
        }
    }
}
