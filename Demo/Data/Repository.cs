using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    public static class Repository
    {
        public static IEnumerable<Product> GetProducts()
        {
            using (kutuzovEntities prod = new kutuzovEntities())
            {
                return prod.Product.ToList();
            }
        }
    }
}
