using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factory_Method.UnitTest
{
    [TestClass]
    public class ProductCategoryUnitTest
    {
        static readonly string _bookProductCategory_Code = "BOO";
        static readonly string _bookProductCategory_Name = "Books";

        [TestMethod]
        public void Must_Create_ProductCategory_As_Book()
        {
            var bookCategory = ProductCategory.CreateBook();
            Assert.AreEqual(bookCategory.Code, _bookProductCategory_Code);
            Assert.AreEqual(bookCategory.Name, _bookProductCategory_Name);
        }
    }
}
