﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Stock_Tracking_System_with_Forms
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// product id girilecek
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// product name girilecek
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// unit type secilecek
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnitTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// product quantity girilecek
        /// sayi olmasi gerekiyori kontrol et!
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 
        /// elemani database e ekle!
        /// onceki form sayfasina geri don
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TurnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
