using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCompDotNet
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
            AddProduct.Configurete();
        }
        public virtual int k { get; set; }
        private void button_ok_Click(object sender, EventArgs e)
        {
            k = int.Parse(textBox_id_update.Text);
            for (int i = 1; i < 100; i++)
            {
               
               if (k == i)
                {
                    Product prod = new Product();
                    prod.Id = int.Parse(textBox_id_update.Text); 
                    prod.Name = textBox_name.Text;
                    prod.Price = int.Parse(textBox_price.Text);
                    AddProduct.UpdateProduct(prod);
                    this.Close();
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
