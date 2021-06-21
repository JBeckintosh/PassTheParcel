using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTheParcel.Functions;
using ParseTheParcel.Interfaces;
using ParseTheParcel.Models;
using System;
using static ParseTheParcel.Enums.Parcels;

namespace ParseTheParcelTests
{
    [TestClass]
    public class ParcelFunctionsTests
    {
        [TestMethod]
        public void SelectPackageSize_Should_Return_Exception_For_Invalid_Length()
        {
            // Arrange

            // Act
            try
            {
                ParcelFunctions.SelectPackageSize(0, 1, 1);

                // We'll never get here because we expect an exception to be thrown
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.IsNotNull(ex);
                Assert.AreEqual("Length is invalid", ex.Message);
            }
        }

        [TestMethod]
        public void SelectPackageSize_Should_Return_Exception_For_Invalid_Height()
        {
            // Arrange

            // Act
            try
            {
                ParcelFunctions.SelectPackageSize(1, 0, 1);

                // We'll never get here because we expect an exception to be thrown
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.IsNotNull(ex);
                Assert.AreEqual("Height is invalid", ex.Message);
            }
        }

        [TestMethod]
        public void SelectPackageSize_Should_Return_Exception_For_Invalid_Breadth()
        {
            // Arrange

            // Act
            try
            {
                ParcelFunctions.SelectPackageSize(1, 1, 0);

                // We'll never get here because we expect an exception to be thrown
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.IsNotNull(ex);
                Assert.AreEqual("Breadth is invalid", ex.Message);
            }

        }

        [TestMethod]
        public void SelectPackageSize_Should_Return_Large_Parcel()
        {
            // Arrange

            // Act
            IParcel parcel = ParcelFunctions.SelectPackageSize(301, 1, 1);

            // Assert
            Assert.AreEqual(ParcelOptions.Large, parcel.Type);
        }

        [TestMethod]
        public void SelectPackageSize_Should_Return_Medium_Parcel()
        {
            // Arrange

            // Act
            IParcel parcel = ParcelFunctions.SelectPackageSize(1, 151, 1);

            // Assert
            Assert.AreEqual(ParcelOptions.Medium, parcel.Type);
        }

        [TestMethod]
        public void SelectPackageSize_Should_Return_Small_Parcel()
        {
            // Arrange

            // Act
            IParcel parcel = ParcelFunctions.SelectPackageSize(1, 1, 1);

            // Assert
            Assert.AreEqual(ParcelOptions.Small, parcel.Type);
        }
    }
}
