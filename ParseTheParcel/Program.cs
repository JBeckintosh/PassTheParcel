using ParseTheParcel.Functions;
using ParseTheParcel.Interfaces;
using ParseTheParcel.Models;
using ParseTheParcel.Validators;
using System;

namespace ParseTheParcel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ok, so here is the list of things that you could add to this application:
             * 
             * 1) Do you think you could add features for accessibility? (increasing the font size, voice, ... etc - look up 'how to add accessibility to your applicaton)
             * 2) Validators for the inputs in the Console.ReadLine().
             * 3) Some standard box sizes for small, medium, and large.
             * 4) Conditions for the custom package dimensions to see if they qualify as small, medium, or large.
             * 5) Add a test suite
             * 6) Offerring customer packaging as a service??? This could be very difficult
             * 7) Display the boxes because we are using a console application
             * 8) Put a send to address and a return address
             * 
             * */

            Console.WriteLine("Hi, and welcome to TradeMe Parcel Pipe.");
            DisplayExamplePackage();
            int[] packageDimensions = HandleCustomerPackage();

            if (packageDimensions == Array.Empty<int>())
            {
                Console.WriteLine("\nI'm sorry that we couldn't accomodate you and deliver your package.");
                Console.WriteLine("Hopefully we can help you with something in the future and have a great day!");
                return;
            }

            IParcel parcel = ParcelFunctions.SelectPackageSize(packageDimensions[0], packageDimensions[1], packageDimensions[2]);

            parcel.ContainsContents = true;
            Console.WriteLine("While we package your parcel, where would you like the parcel sent?");
            string sendAddress = GenerateAddress();

            if (sendAddress == string.Empty)
            {
                Console.WriteLine("Sorry, we couldn't find that address so we won't be able to send your parcel");
                Console.WriteLine("Hopefully we can help you with something in the future and have a great day!");
                return;
            }

            parcel.SendAddress = sendAddress;

            Console.WriteLine("And lastly, if you'd like to; a return address");
            parcel.ReturnAddress = GenerateAddress();

            Console.WriteLine("\nGreat, that's everything. We'll be sending your parcel");
            Console.WriteLine($"Just to confirm, that's a {parcel.Type} parcel sent to {parcel.SendAddress} for ${parcel.Cost}");
        }

        static void DisplayExamplePackage()
        {
            Console.WriteLine("Our packages are measured in the following dimensions: length, height, and breadth (all in millimeters (mm))\n");

            Console.WriteLine("__________");
            Console.WriteLine("|\\        \\");
            Console.WriteLine("| \\        \\");
            Console.WriteLine("|  \\        \\");
            Console.WriteLine("|   \\________\\");
            Console.WriteLine("\\   |        |");
            Console.WriteLine(" \\  |        |");
            Console.WriteLine("  \\ |        |");
            Console.WriteLine("   \\|________|\n");

            Console.WriteLine("Where this is the length of the box _______\n");

            Console.WriteLine("Where this is the height of the box |");
            Console.WriteLine("                                    |");
            Console.WriteLine("                                    |");
            Console.WriteLine("                                    |\n");

            Console.WriteLine("Where this is the breadth of the box \\   ");
            Console.WriteLine("                                      \\  ");
            Console.WriteLine("                                       \\ ");
            Console.WriteLine("                                        \\\n");
        }

        static int[] HandleCustomerPackage()
        {
            Console.WriteLine("We understand that you'd like to send a package today?");
            Console.WriteLine("Our packages can be as wide 400mm, as high as 250mm, as far as 600mm, with a maximum weight of 25000g");

            Console.WriteLine("In millimeters (mm), what is the Length of your package?");
            string length = Console.ReadLine();
            string validatedLength = PackageValidator.ValidateLength(length);
            if (validatedLength != "")
            {
                Console.WriteLine(validatedLength);
                return Array.Empty<int>();
            }

            Console.WriteLine("In millimeters (mm), what is the height of your package?");
            string height = Console.ReadLine();
            string validatedHeight = PackageValidator.ValidateHeight(height);
            if (validatedHeight != "")
            {
                Console.WriteLine(validatedHeight);
                return Array.Empty<int>();
            }

            Console.WriteLine("In millimeters (mm), what is the breadth of your package?");
            string breadth = Console.ReadLine();
            string validatedBreadth = PackageValidator.ValidateBreadth(breadth);
            if (validatedBreadth != "")
            {
                Console.WriteLine(validatedBreadth);
                return Array.Empty<int>();
            }

            Console.WriteLine("In grams (g), what is the weight of your package?");
            string weight = Console.ReadLine();
            string validatedWeight = PackageValidator.ValidateLength(weight);
            if (validatedWeight != "")
            {
                Console.WriteLine(validatedWeight);
                return Array.Empty<int>();
            }

            Console.WriteLine($"So you're package is {length}mm x {height}mm x {breadth}mm and weighs {weight}");

            return new int[] { int.Parse(length), int.Parse(height), int.Parse(breadth) };
        }

        static string GenerateAddress()
        {
            Console.WriteLine("The street number:");
            string streetNumber = Console.ReadLine();
            string validatedStreetNumber = AddressValidator.ValidateNumber(streetNumber);
            if (validatedStreetNumber != "")
            {
                Console.WriteLine(validatedStreetNumber);
                return string.Empty;
            }

            Console.WriteLine("The steet name");
            string streetName = Console.ReadLine();
            string validatedStreetName = AddressValidator.ValidateStreet(streetName);
            if (validatedStreetName != "")
            {
                Console.WriteLine(validatedStreetName);
                return string.Empty;
            }

            Console.WriteLine("The post code");
            string postCode = Console.ReadLine();
            string validatedPostCode = AddressValidator.ValidatePostCode(postCode);
            if (validatedPostCode != "")
            {
                Console.WriteLine(validatedPostCode);
                return string.Empty;
            }

            Console.WriteLine("And the city");
            string city = Console.ReadLine();
            string validatedCity = AddressValidator.ValidateCity(city);
            if (validatedCity != "")
            {
                Console.WriteLine(validatedCity);
                return string.Empty;
            }

            return $"{streetNumber}, {streetName}, {postCode}, {city}";
        }
    }
}
