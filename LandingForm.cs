﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDesktopApp
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void restaurantMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurantMenuForm restaurantMenuForm = new RestaurantMenuForm();
            restaurantMenuForm.Show();

        }

        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredientsForm = new IngredientsForm();
            ingredientsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}