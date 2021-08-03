
namespace GuestTab
{
    partial class Cleaning
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
            this.btnDone = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnContacts = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.btnServices = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnActivity = new FontAwesome.Sharp.IconButton();
            this.btnFood = new FontAwesome.Sharp.IconButton();
            this.btnCleaning = new FontAwesome.Sharp.IconButton();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShedule = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.btnDone);
            this.panelDesktop.Controls.Add(this.checkBox1);
            this.panelDesktop.Controls.Add(this.btnContacts);
            this.panelDesktop.Controls.Add(this.btnBill);
            this.panelDesktop.Controls.Add(this.btnServices);
            this.panelDesktop.Controls.Add(this.btnHome);
            this.panelDesktop.Controls.Add(this.btnActivity);
            this.panelDesktop.Controls.Add(this.btnFood);
            this.panelDesktop.Controls.Add(this.btnCleaning);
            this.panelDesktop.Controls.Add(this.calender);
            this.panelDesktop.Controls.Add(this.btnCancel);
            this.panelDesktop.Controls.Add(this.btnShedule);
            this.panelDesktop.Controls.Add(this.btnNow);
            this.panelDesktop.Controls.Add(this.panel4);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1231, 713);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDone.Location = new System.Drawing.Point(326, 616);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(794, 60);
            this.btnDone.TabIndex = 60;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.checkBox1.Location = new System.Drawing.Point(531, 570);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(377, 21);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "This is an additional request. Add this amount to my bill";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnContacts.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            this.btnContacts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContacts.IconSize = 70;
            this.btnContacts.Location = new System.Drawing.Point(1033, 22);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(175, 81);
            this.btnContacts.TabIndex = 58;
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.btnBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.IconSize = 70;
            this.btnBill.Location = new System.Drawing.Point(852, 22);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(175, 81);
            this.btnBill.TabIndex = 57;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnServices.IconChar = FontAwesome.Sharp.IconChar.HotTub;
            this.btnServices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServices.IconSize = 70;
            this.btnServices.Location = new System.Drawing.Point(671, 22);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(175, 81);
            this.btnServices.TabIndex = 56;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 70;
            this.btnHome.Location = new System.Drawing.Point(23, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 81);
            this.btnHome.TabIndex = 52;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnActivity.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnActivity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivity.IconSize = 70;
            this.btnActivity.Location = new System.Drawing.Point(490, 22);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(175, 81);
            this.btnActivity.TabIndex = 55;
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnFood.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnFood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFood.IconSize = 70;
            this.btnFood.Location = new System.Drawing.Point(128, 22);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(175, 81);
            this.btnFood.TabIndex = 53;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnCleaning
            // 
            this.btnCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btnCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.btnCleaning.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnCleaning.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCleaning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleaning.IconSize = 70;
            this.btnCleaning.Location = new System.Drawing.Point(309, 22);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(175, 81);
            this.btnCleaning.TabIndex = 54;
            this.btnCleaning.UseVisualStyleBackColor = false;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // calender
            // 
            this.calender.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.calender.Location = new System.Drawing.Point(326, 148);
            this.calender.Name = "calender";
            this.calender.TabIndex = 51;
            this.calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calender_DateChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCancel.Location = new System.Drawing.Point(40, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 159);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnShedule
            // 
            this.btnShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnShedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnShedule.Location = new System.Drawing.Point(40, 324);
            this.btnShedule.Name = "btnShedule";
            this.btnShedule.Size = new System.Drawing.Size(184, 159);
            this.btnShedule.TabIndex = 49;
            this.btnShedule.Text = "Shedule";
            this.btnShedule.UseVisualStyleBackColor = false;
            // 
            // btnNow
            // 
            this.btnNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNow.Location = new System.Drawing.Point(40, 148);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(184, 159);
            this.btnNow.TabIndex = 48;
            this.btnNow.Text = "Request Now";
            this.btnNow.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel4.Location = new System.Drawing.Point(249, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 567);
            this.panel4.TabIndex = 46;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::GuestTab.Properties.Resources.cleaninggif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 713);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Cleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1231, 713);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cleaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaning";
            this.Load += new System.EventHandler(this.Cleaning_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnContacts;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnServices;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnActivity;
        private FontAwesome.Sharp.IconButton btnFood;
        private FontAwesome.Sharp.IconButton btnCleaning;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShedule;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}