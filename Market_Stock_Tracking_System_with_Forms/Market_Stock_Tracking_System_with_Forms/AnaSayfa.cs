using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Market_Stock_Tracking_System_with_Forms
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// 
        /// Listeleme butonu, urunleri listeler
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form listProducts = new ListProducts();
            listProducts.ShowDialog();
        }


        /// <summary>
        /// 
        /// yeni ürün eklenir (Yeni ürün girisi)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form addNewProduct = new AddNewProduct();
            addNewProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// urun cikarilir (urun cikisi)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //Form deleteProduct = new DeleteProduct();
            //deleteProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// urun arar
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //Form searchProduct = new SearchProduct();
            //searchProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// sistemden cikilir
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exited!");
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
