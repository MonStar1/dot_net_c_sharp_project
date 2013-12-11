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
    public partial class FormDel : Form
    {
        public FormDel()
        {
            InitializeComponent();
            AddProduct.Configurete();
        }

        private void button_ok_del_Click(object sender, EventArgs e)
        {
         
                Product prod = new Product();
                prod.Id = int.Parse(textBox_id.Text);
                AddProduct.DeleteProduct(prod);
                this.Close();
                
            
        }

        private void button_cancel_del_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
     }
}
