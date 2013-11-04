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

    public delegate void Del(string message);

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCallback.callbackEventHandler = new AddCallback.callbackEvent(this.addProduct);
            Main mainClazz = new Main();
            List<Product> listProducts = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                Product pr = new Product();
                pr.Id = i;
                pr.Name = "name";
                pr.Price = i * 2;
                listProducts.Add(pr);
            }
           

            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Price");
            listView1.Items.Clear();


        }

        private void addProduct(Product product)
        {
            listView1.Items.Add(product.Id.ToString());
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Name);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Price.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
