using NHibernate;
using ShopCompDotNet.callback;
using System;
using System.Collections;
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
            AddProduct.CreateTables();
            AddProduct.Configurete();
            

        }

        public void viewreason(IList<Product> list)
        {
            check.Text = "LOlo";
            listView1.View = View.Details;
            listView1.Items.Clear();
            foreach (Product product in list)
            {
                listView1.Items.Add(product.Id.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Name);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Price.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Price");
            listView1.Items.Clear();
        }

        private void addProduct(Product product)
        {
         
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            IList<Product> list = AddProduct.FindContacts(1);

            FormMain viewed = new FormMain();
            viewed.viewreason(list);
            check.Text = "!";

            //IList<Product> list = AddProduct.FindContacts(1);
            //listView1.View = View.Details;
            //listView1.Items.Clear();
            //foreach (Product product in list)
            //{
            //    listView1.Items.Add(product.Id.ToString());
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Name);
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(product.Price.ToString());
            //}
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDel form = new FormDel();
            form.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate form = new FormUpdate();
            form.Show();
        }



        
    }
}
