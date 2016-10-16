using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework.Tests
{
    [TestClass()]
    public class CaculatorTests
    {
        [TestMethod()]
        public void 分頁取值_每3筆一組_取Cost加總_應得到_6_15_24_21()
        {
            var caculator = new Caculator();
            var products = this.GetProducts();

            var expectedAmount = 3;
            var expectedColumn = "Cost";
            var expected = new List<int> { 6, 15, 24, 21 };

            var actual = caculator.Sum(products, expectedAmount, expectedColumn).ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 分頁取值_每4筆一組_取Revenue加總_應得到_50_66_60()
        {
            var Caculator = new Caculator();
            var products = this.GetProducts();

            var expectedAmount = 4;
            var expectedColumn = "Revenue";
            var expected = new List<int> { 50, 66, 60 };

            var actual = Caculator.Sum(products, expectedAmount, expectedColumn).ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product {Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Product {Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Product {Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Product {Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Product {Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Product {Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Product {Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Product {Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Product {Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Product {Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Product {Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };

            return products;
        }
    }
}