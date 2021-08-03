
namespace GuestTab
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnContacts = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.btnServices = new FontAwesome.Sharp.IconButton();
            this.btnActivity = new FontAwesome.Sharp.IconButton();
            this.btnCleaning = new FontAwesome.Sharp.IconButton();
            this.btnFood = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.btnContacts);
            this.panelDesktop.Controls.Add(this.btnBill);
            this.panelDesktop.Controls.Add(this.btnServices);
            this.panelDesktop.Controls.Add(this.btnActivity);
            this.panelDesktop.Controls.Add(this.btnCleaning);
            this.panelDesktop.Controls.Add(this.btnFood);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1231, 713);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnContacts.IconChar = FontAwesome.Sharp.IconChar.PhoneSquareAlt;
            this.btnContacts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContacts.IconSize = 150;
            this.btnContacts.Location = new System.Drawing.Point(826, 404);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(346, 250);
            this.btnContacts.TabIndex = 20;
            this.btnContacts.Text = "Emergency Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.btnBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.IconSize = 150;
            this.btnBill.Location = new System.Drawing.Point(435, 404);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(346, 250);
            this.btnBill.TabIndex = 19;
            this.btnBill.Text = "My Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnServices.IconChar = FontAwesome.Sharp.IconChar.HotTub;
            this.btnServices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServices.IconSize = 150;
            this.btnServices.Location = new System.Drawing.Point(49, 404);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(346, 250);
            this.btnServices.TabIndex = 18;
            this.btnServices.Text = "My Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnActivity.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnActivity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivity.IconSize = 150;
            this.btnActivity.Location = new System.Drawing.Point(826, 127);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(346, 250);
            this.btnActivity.TabIndex = 17;
            this.btnActivity.Text = "My Activity";
            this.btnActivity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnCleaning
            // 
            this.btnCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCleaning.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnCleaning.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCleaning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleaning.IconSize = 150;
            this.btnCleaning.Location = new System.Drawing.Point(435, 127);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(346, 250);
            this.btnCleaning.TabIndex = 16;
            this.btnCleaning.Text = "Cleaning Support";
            this.btnCleaning.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCleaning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCleaning.UseVisualStyleBackColor = false;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnFood.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnFood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFood.IconSize = 150;
            this.btnFood.Location = new System.Drawing.Point(49, 127);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(346, 250);
            this.btnFood.TabIndex = 15;
            this.btnFood.Text = "Food Order";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::GuestTab.Resources.maingif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 713);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1231, 713);
            this.Controls.Add(this.panelDesktop);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnContacts;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnServices;
        private FontAwesome.Sharp.IconButton btnActivity;
        private FontAwesome.Sharp.IconButton btnCleaning;
        private FontAwesome.Sharp.IconButton btnFood;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

