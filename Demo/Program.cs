using Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    static class Program
    {
        private static ProductList      _productListForm;
        private static ProductEditForm  _productEditForm;
        private static SalesForm        _salesForm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _productListForm = new ProductList();
            _productEditForm = new ProductEditForm();
            _salesForm = new SalesForm();



            //var context = new DB(@"Data Source=.\SQLEXPRESS;Initial Catalog=kutuzov;Integrated Security=False;User ID=kutuzov;Password=laji*sjdSD");

            //var product = context.Products.FirstOrDefault();

            

            //using (kutuzovEntities prod = new kutuzovEntities())
            //{
            //    var prod1 = prod.Product.FirstOrDefault();


            //    var stop = true;
            //}

            

            Application.Run(_productListForm);


        }
    }
}
