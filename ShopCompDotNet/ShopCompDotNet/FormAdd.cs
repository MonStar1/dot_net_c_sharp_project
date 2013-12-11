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
    public partial class FormAdd : Form
    {
        
        public FormAdd()
        {
            InitializeComponent();
            AddProduct.Configurete();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
         //   prod.Id = int.Parse(textBox_id.Text); 
            prod.Name = textBox_name.Text;
            prod.Price = int.Parse(textBox_price.Text);
            AddProduct.InsertProduct(prod);
            FormMain.updateHandler();
            this.Close();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
