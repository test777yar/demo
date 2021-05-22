using Demo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();

            DataBind();
        }

        private void DataBind()
        {
            var list = Repository.GetProducts();

            productLayout.SuspendLayout();
            SuspendLayout();

            foreach (var item in list)
            {

                var panel = new System.Windows.Forms.Panel();
                panel.SuspendLayout();
                panel.Size = new System.Drawing.Size(500, 235);
                panel.Location = new System.Drawing.Point(3, 3);

                var title = new System.Windows.Forms.Label();
                title.Text = item.Title;

                var price = new System.Windows.Forms.Label();
                price.Text = item.Cost.ToString();


                panel.Controls.Add(title);
                panel.Controls.Add(price);

                this.productLayout.Controls.Add(panel);

                panel.ResumeLayout(false);

            }

            productLayout.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
