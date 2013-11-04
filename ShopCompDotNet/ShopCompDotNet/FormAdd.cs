using ShopCompDotNet.callback;
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
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.Id = long.Parse(textBox_id.Text); 
            pr.Name = textBox_name.Text;
            pr.Price = long.Parse(textBox_price.Text); 
            AddCallback.callbackEventHandler(pr);
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
