using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel.Validators
{
    public class PackageValidator
    {
        public static string ValidateLength(string length)
        {
            try
            {
                int lengthAsNumber = int.Parse(length);

                if (lengthAsNumber > 400)
                {
                    return $"The length of your package: {length}mm is wider than we can transport";
                }
            }
            catch
            {
                return $"{length} was not able to converted into a number";
            }

            return "";
        }

        public static string ValidateHeight(string height)
        {
            try
            {
                int heightAsNumber = int.Parse(height);

                if (heightAsNumber > 250)
                {
                    return $"The height of your package: {height}mm is higher than we can transport";
                }
            }
            catch
            {
                return $"{height} was not able to converted into a number";
            }

            return "";
        }

        public static string ValidateBreadth(string breadth)
        {
            try
            {
                int breadthAsNumber = int.Parse(breadth);

                if (breadthAsNumber > 600)
                {
                    return $"The breadth of your package: {breadth}mm is longer than we can transport";
                }
            }
            catch
            {
                return $"{breadth} was not able to converted into a number";
            }

            return "";
        }

        public static string ValidateWeight(string weight)
        {
            try
            {
                int weightAsNumber = int.Parse(weight);

                if (weightAsNumber > 25000)
                {
                    return $"The weight of your package: {weight}g is heavier than we can transport";
                }
            }
            catch
            {
                return $"{weight} was not able to converted into a number";
            }

            return "";
        }
    }
}
