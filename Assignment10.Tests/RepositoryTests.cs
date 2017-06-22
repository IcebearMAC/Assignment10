using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment10.Repostitories;

namespace Assignment10.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        #region Add Tests
        [TestMethod]
        public void AddGiven1_5And1_5Return3()
        {
            Repository respository = new Repository();
            double expectedResult = 3;

            double actualResult = respository.Add(1.5, 1.5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddGiven5_2And1_35Return6_5()
        {
            Repository respository = new Repository();
            double expectedResult = 6.5;

            double actualResult = respository.Add(5.2, 1.3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddGiven5AndNeg2Return3()
        {
            Repository respository = new Repository();
            double expectedResult = 3;

            double actualResult = respository.Add(5, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddGiven111_7And97_85Return209_5()
        {
            Repository respository = new Repository();
            double expectedResult = 209.5;

            double actualResult = respository.Add(111.7, 97.8);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DepositMoneyGiven111_7And97_85Return209_5()
        {
            Repository respository = new Repository();
            double expectedResult = 209.5;

            double actualResult = respository.DepositMoney(111.7, 97.8);

            Assert.AreEqual(expectedResult, actualResult);
        }


        #endregion

        #region Subtraction Tests
        [TestMethod]
        public void Subtract_5_2_3()
        {
            Repository respository = new Repository();
            double expectedResult = 3;

            double actualResult = respository.Subtract(5, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractGiven5_5AndNeg2Retun3_5()
        {
            Repository respository = new Repository();
            double expectedResult = 3.5;

            double actualResult = respository.Subtract(5.5, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractGivenNeg2_5And5Retun2_5()
        {
            Repository respository = new Repository();
            double expectedResult = -2.5;

            double actualResult = respository.Subtract(-2.5, 5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractGivenNeg2_5AndNeg5Retun2_5()
        {
            Repository respository = new Repository();
            double expectedResult = -2.5;

            double actualResult = respository.Subtract(-2.5, -5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractGiven3_8And0_8Retun3()
        {
            Repository respository = new Repository();
            double expectedResult = 3;

            double actualResult = respository.Subtract(3.8, 0.8);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WithDrawMoneyGiven3_8And0_8Retun3()
        {
            Repository respository = new Repository();
            double expectedResult = 3;

            double actualResult = respository.WithDrawMoney(3.8, 0.8);

            Assert.AreEqual(expectedResult, actualResult);
        }



        #endregion



    }


}
