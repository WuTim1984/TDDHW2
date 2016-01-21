using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDHOMEWORD2.Tests
{
    [TestClass()]
    public class TDDHW2Tests
    {
        [TestMethod()] //case1 Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        public void AccountingTest_id_1_quantity_1_shouldbe_100()
        {  
            //arrange
            List<Book> book = new List<Book>() {
            new Book{Id=1,Quantity = 1,price =100},
            new Book{Id=2,Quantity = 0,price =100},
            new Book{Id=3,Quantity = 0,price =100},
            new Book{Id=4,Quantity = 0,price =100},
            new Book{Id=5,Quantity = 0,price =100},
            };

            var target = new TDDHW2();
            double actual = 0;
            int expected = 100;
            //act
            actual = target.Accounting(book);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()] //case2 Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        public void AccountingTest_id_1_quantity_1_id_2_quantity_1_shouldbe_190()
        {
            //arrange
            List<Book> book = new List<Book>() {
            new Book{Id=1,Quantity = 1},
            new Book{Id=2,Quantity = 1},
            new Book{Id=3,Quantity = 0},
            new Book{Id=4,Quantity = 0},
            new Book{Id=5,Quantity = 0},
            };
            var target = new TDDHW2();
            double actual = 0;
            int expected = 190;
            //act
            actual = target.Accounting(book);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}