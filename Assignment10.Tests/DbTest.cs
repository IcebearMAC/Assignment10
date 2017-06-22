using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10.Repostitories;

namespace Assignment10.Tests
{
    [TestClass]
    public class DbTest
    {
        //[TestMethod]
        //public class DbTests
        //{
        //    //Arrange


        //    //Act


        //    //Assert
        //}

     
            [TestMethod]
            public void ConnectionTest()
            {
                DataOperations da = new DataOperations();
                Assert.IsTrue(da.GetAllCustomers(), "Connection failed");
            }
         

    }
}
