﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestTab
{
    public partial class Food : Form
    {
        private Form currentChildForm;
        public Food()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void Food_Load(object sender, EventArgs e)
        {
            btnFood.IconColor = Color.FromArgb(227, 253, 253);
            btnFood.ForeColor = Color.FromArgb(57, 62, 70);
            btnFood.BackColor = Color.FromArgb(0, 173, 181);
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Food());
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cleaning());
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Activity());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Services());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bill());
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Contact());
        }

        private void gridFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
