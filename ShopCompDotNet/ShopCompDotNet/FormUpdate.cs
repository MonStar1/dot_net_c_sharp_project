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

        private void button_ok_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox_id_update.Text);
                    Product prod = new Product();
                    prod.Id = k; 
                    prod.Name = textBox_name.Text;
                    prod.Price = int.Parse(textBox_price.Text);
                    AddProduct.UpdateProduct(prod);
                    FormMain.updateHandler();
                    this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
