using _02_ClaimRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ClaimTest
{
    [TestClass]
    public class ClaimsTest
    {
        private Claims _claim;
        private ClaimsRepo _claimRepo;

        [TestInitialize]
        public void Arrange()
        {
            _claimRepo = new ClaimsRepo();
            _claim = new Claims(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2021, 02, 15), new DateTime(2021, 03, 27));
            _claimRepo.EnterNewClaim(_claim);
        }


        [TestMethod]
        public void SeeAllClaims_ShouldDisplayAllClaims()
        {
            Claims testClaim = new Claims();
            ClaimsRepo testRepo = new ClaimsRepo();
            testRepo.EnterNewClaim(testClaim);

            Queue<Claims> testQueue = testRepo.SeeAllClaims();
            bool directoryHasClaims = testQueue.Contains(testClaim);

            Assert.IsTrue(directoryHasClaims);
        }

        [TestMethod]
        public void SeeNextClaim_ShouldShowNextClaim()
        {
            Claims nextClaim = _claimRepo.SeeNextClaim();

            Assert.AreEqual(_claimRepo.SeeNextClaim(), _claim);
        }

        [TestMethod]
        public void DealWithClaim_ShouldRemoveClaim()
        {
            Claims ClaimA = new Claims(2, ClaimType.Home, "House fire in kitchen", 4000.00m, new DateTime(20201, 02, 11), new DateTime(2021, 03, 10));

            _claimRepo.EnterNewClaim(ClaimA);
            _claimRepo.DealWithClaim();

            int expected = 1;
            int actual = _claimRepo.SeeAllClaims().Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnterNewClaim_ShouldAddClaim()
        {
            //Arrange -TestInitialize

            //Act
            int expected = 1;
            int actual = _claimRepo.SeeAllClaims().Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
