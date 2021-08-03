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
    public partial class Bill : Form
    {
        private Form currentChildForm;
        public Bill()
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

        private void Bill_Load(object sender, EventArgs e)
        {
            btnBill.IconColor = Color.FromArgb(227, 253, 253);
            btnBill.ForeColor = Color.FromArgb(57, 62, 70);
            btnBill.BackColor = Color.FromArgb(0, 173, 181);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNow_Click(object sender, EventArgs e)
        {

        }

        private void btnShedule_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
