using ParseTheParcel.AddressValidationReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParseTheParcel.AddressValidationReferences.StreetSuffixes;
using static ParseTheParcel.Enums.Cities;

namespace ParseTheParcel.Validators
{
    public class AddressValidator
    {
        public static string ValidateNumber(string number)
        {
            try
            {
                int numberAsNumber = int.Parse(number);
            }
            catch
            {
                return $"{number} was not able to be converted into a number";
            }

            return "";
        }

        public static string ValidateStreet(string street)
        {
            if (street == "" || street == null)
            {
                return "The street cannot be empty or null";
            }

            string[] streetSplit = street.Split(' ');
            string streetSuffix = streetSplit[streetSplit.Length - 1];

            if (!Enum.IsDefined(typeof(SuffixOptions), streetSuffix.ToLower()))
            {
                return $"The street option: {streetSuffix} is invalid";
            }

            return "";
        }

        public static string ValidatePostCode(string postCode)
        {
            try
            {
                int postCodeAsNumber = int.Parse(postCode);

                if (postCode.Length != 4)
                {
                    return $"{postCode} is not a valid New Zealand postcode";
                }
            }
            catch
            {
                return $"{postCode} was not able to converted into a number";
            }

            return "";
        }

        public static string ValidateCity(string city)
        {
            if (city == "" || city == null)
            {
                return "The city cannot be empty or null";
            }

            if (!Enum.IsDefined(typeof(CityOptions), city.ToLower()))
            {
                return $"The city option: {city} is invalid";
            }

            return "";
        }
    }


}
