using System;
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
    public partial class Main : Form
    {
        private Form currentChildForm;
        public Main()
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

        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Food food1 = new Food();
            //food1.ShowDialog();
            //this.Close();
            OpenChildForm(new Food());
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Food food1 = new Food();
            //food1.ShowDialog();
            //this.Close();
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
    }
}
