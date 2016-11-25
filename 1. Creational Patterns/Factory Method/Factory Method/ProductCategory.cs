using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class ProductCategory
    {
        public static ProductCategory CreateDeviceAcessories()
        {
            return new ProductCategory("ADA", "Amazon Device Accessories");
        }

        public static ProductCategory CreateBeauty()
        {
            return new ProductCategory("BEA", "Beauty");
        }
        public static ProductCategory CreateBook()
        {
            return new ProductCategory("BOO", "Books");
        }


        protected ProductCategory(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; private set; }
        public string Name { get; private set; }
    }
}
