﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELMANAGEMENT_FRONTEND
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var mainpage = new Form2();
            mainpage.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            var profile = new Form3();
            profile.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }
    }
}
