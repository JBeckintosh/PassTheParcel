using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTheParcel.Validators;

namespace ParseTheParcelTests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void AddressValidator_ValidateNumber_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedNumber = AddressValidator.ValidateNumber("NotNumber");

            // Assert
            Assert.AreEqual("NotNumber was not able to be converted into a number", validatedNumber);
        }

        [TestMethod]
        public void AddressValidator_ValidateNumber_Should_Return_Empty_String_For_Valid_Number()
        {
            // Arrange

            // Act
            string validatedNumber = AddressValidator.ValidateNumber("123");

            // Assert
            Assert.AreEqual("", validatedNumber);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void AddressValidator_ValidateStreet_Should_Fail_If_Null_Or_Empty(string street)
        {
            // Arrange

            // Act
            string validatedStreet = AddressValidator.ValidateStreet(street);

            // Assert
            Assert.AreEqual("The street cannot be empty or null", validatedStreet);
        }

        [TestMethod]
        public void AddressValidator_ValidateStreet_Should_Fail_With_Invalid_Street()
        {
            // Arrange

            // Act
            string validateStreet = AddressValidator.ValidateStreet("Test");

            // Assert
            Assert.AreEqual("The street option: Test is invalid", validateStreet);
        }

        [TestMethod]
        public void AddressValidator_ValidateStreet_Should_Return_Empty_String_For_Valid_Street()
        {
            // Arrange

            // Act
            string validatedStreet = AddressValidator.ValidateStreet("Test Road");

            // Assert
            Assert.AreEqual("", validatedStreet);
        }

        [TestMethod]
        public void AddressValidator_ValidatePostCode_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedPostCode = AddressValidator.ValidatePostCode("Test");

            // Assert
            Assert.AreEqual("Test was not able to converted into a number", validatedPostCode);
        }

        [TestMethod]
        public void AddressValidator_ValidatePostCode_Should_Fail_With_Invalid_Post_Code_Length()
        {
            // Arrange

            // Act
            string validatedPostCode = AddressValidator.ValidatePostCode("123456");

            // Assert
            Assert.AreEqual("123456 is not a valid New Zealand postcode", validatedPostCode);
        }

        [TestMethod]
        public void AddressValidator_ValidatePostCode_Should_Return_Empty_String_For_Valid_Number()
        {
            // Arrange

            // Act
            string validatePostCode = AddressValidator.ValidatePostCode("6000");

            // Assert
            Assert.AreEqual("", validatePostCode);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void AddressValidator_ValidateCity_Should_Fail_If_Null_Or_Empty(string city)
        {
            // Arrange

            // Act
            string validatedCity = AddressValidator.ValidateCity(city);

            // Assert
            Assert.AreEqual("The city cannot be empty or null", validatedCity);
        }

        [TestMethod]
        public void AddressValidator_ValidateCity_Should_Fail_With_Invalid_City()
        {
            // Arrange

            // Act
            string validatedCity = AddressValidator.ValidateCity("Test");

            // Assert
            Assert.AreEqual("The city option: Test is invalid", validatedCity);
        }

        [TestMethod]
        public void AddressValidator_ValidateCity_Should_Return_Empty_String_For_Valid_City()
        {
            // Arrange

            // Act
            string validatedCity = AddressValidator.ValidateCity("Wellington");

            // Assert
            Assert.AreEqual("", validatedCity);
        }

        [TestMethod]
        public void PackageValidator_ValidateLength_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedLength = PackageValidator.ValidateLength("Test");

            // Assert
            Assert.AreEqual("Test was not able to converted into a number", validatedLength);
        }

        [TestMethod]
        public void PackageValidator_ValidateLength_Should_Fail_If_Value_Is_Over_400()
        {
            // Arrange

            // Act
            string validatedLength = PackageValidator.ValidateLength("500");

            // Assert
            Assert.AreEqual("The length of your package: 500mm is wider than we can transport", validatedLength);
        }

        [TestMethod]
        public void PackageValidator_ValidateLength_Should_Return_Empty_String_For_Valid_Length()
        {
            // Arrange

            // Act
            string validatedLength = PackageValidator.ValidateLength("300");

            // Assert
            Assert.AreEqual("", validatedLength);
        }

        [TestMethod]
        public void PackageValidator_ValidateHeight_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedHeight = PackageValidator.ValidateHeight("Test");

            // Assert
            Assert.AreEqual("Test was not able to converted into a number", validatedHeight);
        }

        [TestMethod]
        public void PackageValidator_ValidateHeight_Should_Fail_If_Value_Is_Over_250()
        {
            // Arrange

            // Act
            string validatedHeight = PackageValidator.ValidateHeight("300");

            // Assert
            Assert.AreEqual("The height of your package: 300mm is higher than we can transport", validatedHeight);
        }

        [TestMethod]
        public void PackageValidator_ValidateHeight_Should_Return_Empty_String_For_Valid_Height()
        {
            // Arrange

            // Act
            string validatedHeight = PackageValidator.ValidateHeight("200");

            // Assert
            Assert.AreEqual("", validatedHeight);
        }

        [TestMethod]
        public void PackageValidator_ValidateBreadth_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedBreadth = PackageValidator.ValidateBreadth("Test");

            // Assert
            Assert.AreEqual("Test was not able to converted into a number", validatedBreadth);
        }

        [TestMethod]
        public void PackageValidator_ValidateBreadth_Should_Fail_If_Value_Is_Over_600()
        {
            // Arrange

            // Act
            string validatedBreadth = PackageValidator.ValidateBreadth("700");

            // Assert
            Assert.AreEqual("The breadth of your package: 700mm is longer than we can transport", validatedBreadth);
        }

        [TestMethod]
        public void PackageValidator_ValidateBreadth_Should_Return_Empty_String_For_Valid_Breadth()
        {
            // Arrange

            // Act
            string validatedBreadth = PackageValidator.ValidateBreadth("500");

            // Assert
            Assert.AreEqual("", validatedBreadth);
        }

        [TestMethod]
        public void PackageValidator_ValidateWeight_Should_Fail_With_Invalid_Number()
        {
            // Arrange

            // Act
            string validatedWeight = PackageValidator.ValidateWeight("Test");

            // Assert
            Assert.AreEqual("Test was not able to converted into a number", validatedWeight);
        }

        [TestMethod]
        public void PackageValidator_ValidateWeight_Should_Fail_If_Value_Is_Over_25000()
        {
            // Arrange

            // Act
            string validatedWeight = PackageValidator.ValidateWeight("30000");

            // Assert
            Assert.AreEqual("The weight of your package: 30000g is heavier than we can transport", validatedWeight);
        }

        [TestMethod]
        public void PackageValidator_ValidateWeight_Should_Return_Empty_String_For_Valid_Weight()
        {
            // Arrange

            // Act
            string validatedWeight = PackageValidator.ValidateWeight("20000");

            // Assert
            Assert.AreEqual("", validatedWeight);
        }
    }
}
