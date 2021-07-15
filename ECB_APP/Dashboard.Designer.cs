namespace ECB_APP
{
    partial class Dashboard
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.pnl_submenu = new System.Windows.Forms.Panel();
            this.btn_religious = new System.Windows.Forms.Button();
            this.pnl_domesticSub = new System.Windows.Forms.Panel();
            this.btn_dome_billrate = new System.Windows.Forms.Button();
            this.btn_dome_cal = new System.Windows.Forms.Button();
            this.btn_domestic = new System.Windows.Forms.Button();
            this.btn_government = new System.Windows.Forms.Button();
            this.btn_hotel = new System.Windows.Forms.Button();
            this.btn_general = new System.Windows.Forms.Button();
            this.btn_industrial = new System.Windows.Forms.Button();
            this.btn_catergory = new System.Windows.Forms.Button();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left.SuspendLayout();
            this.pnl_button.SuspendLayout();
            this.pnl_submenu.SuspendLayout();
            this.pnl_domesticSub.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_left.Controls.Add(this.pnl_button);
            this.pnl_left.Controls.Add(this.pnl_name);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(200, 529);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_button
            // 
            this.pnl_button.Controls.Add(this.pnl_submenu);
            this.pnl_button.Controls.Add(this.btn_catergory);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_button.Location = new System.Drawing.Point(0, 103);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(200, 426);
            this.pnl_button.TabIndex = 1;
            // 
            // pnl_submenu
            // 
            this.pnl_submenu.Controls.Add(this.btn_religious);
            this.pnl_submenu.Controls.Add(this.pnl_domesticSub);
            this.pnl_submenu.Controls.Add(this.btn_domestic);
            this.pnl_submenu.Controls.Add(this.btn_government);
            this.pnl_submenu.Controls.Add(this.btn_hotel);
            this.pnl_submenu.Controls.Add(this.btn_general);
            this.pnl_submenu.Controls.Add(this.btn_industrial);
            this.pnl_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_submenu.Location = new System.Drawing.Point(0, 43);
            this.pnl_submenu.Name = "pnl_submenu";
            this.pnl_submenu.Size = new System.Drawing.Size(200, 329);
            this.pnl_submenu.TabIndex = 1;
            this.pnl_submenu.Visible = false;
            // 
            // btn_religious
            // 
            this.btn_religious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_religious.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_religious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_religious.Location = new System.Drawing.Point(0, 245);
            this.btn_religious.Name = "btn_religious";
            this.btn_religious.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_religious.Size = new System.Drawing.Size(200, 35);
            this.btn_religious.TabIndex = 11;
            this.btn_religious.Text = "Religious Purpose";
            this.btn_religious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_religious.UseVisualStyleBackColor = true;
            this.btn_religious.Click += new System.EventHandler(this.btn_religious_Click);
            // 
            // pnl_domesticSub
            // 
            this.pnl_domesticSub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_domesticSub.Controls.Add(this.btn_dome_billrate);
            this.pnl_domesticSub.Controls.Add(this.btn_dome_cal);
            this.pnl_domesticSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_domesticSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_domesticSub.Location = new System.Drawing.Point(0, 175);
            this.pnl_domesticSub.Name = "pnl_domesticSub";
            this.pnl_domesticSub.Size = new System.Drawing.Size(200, 70);
            this.pnl_domesticSub.TabIndex = 10;
            this.pnl_domesticSub.Visible = false;
            // 
            // btn_dome_billrate
            // 
            this.btn_dome_billrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dome_billrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dome_billrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dome_billrate.Location = new System.Drawing.Point(0, 35);
            this.btn_dome_billrate.Name = "btn_dome_billrate";
            this.btn_dome_billrate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_dome_billrate.Size = new System.Drawing.Size(200, 35);
            this.btn_dome_billrate.TabIndex = 6;
            this.btn_dome_billrate.Text = "Bill Rates";
            this.btn_dome_billrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dome_billrate.UseVisualStyleBackColor = true;
            this.btn_dome_billrate.Click += new System.EventHandler(this.btn_dome_billrate_Click);
            // 
            // btn_dome_cal
            // 
            this.btn_dome_cal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dome_cal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dome_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dome_cal.Location = new System.Drawing.Point(0, 0);
            this.btn_dome_cal.Name = "btn_dome_cal";
            this.btn_dome_cal.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_dome_cal.Size = new System.Drawing.Size(200, 35);
            this.btn_dome_cal.TabIndex = 5;
            this.btn_dome_cal.Text = "Calculate";
            this.btn_dome_cal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dome_cal.UseVisualStyleBackColor = true;
            this.btn_dome_cal.Click += new System.EventHandler(this.btn_dome_cal_Click);
            // 
            // btn_domestic
            // 
            this.btn_domestic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_domestic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_domestic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_domestic.Location = new System.Drawing.Point(0, 140);
            this.btn_domestic.Name = "btn_domestic";
            this.btn_domestic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_domestic.Size = new System.Drawing.Size(200, 35);
            this.btn_domestic.TabIndex = 6;
            this.btn_domestic.Text = "Domestic  Purpose";
            this.btn_domestic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_domestic.UseVisualStyleBackColor = true;
            this.btn_domestic.Click += new System.EventHandler(this.btn_domestic_Click);
            // 
            // btn_government
            // 
            this.btn_government.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_government.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_government.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_government.Location = new System.Drawing.Point(0, 105);
            this.btn_government.Name = "btn_government";
            this.btn_government.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_government.Size = new System.Drawing.Size(200, 35);
            this.btn_government.TabIndex = 7;
            this.btn_government.Text = "Government Purpose";
            this.btn_government.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_government.UseVisualStyleBackColor = true;
            this.btn_government.Click += new System.EventHandler(this.btn_government_Click);
            // 
            // btn_hotel
            // 
            this.btn_hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.Location = new System.Drawing.Point(0, 70);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_hotel.Size = new System.Drawing.Size(200, 35);
            this.btn_hotel.TabIndex = 8;
            this.btn_hotel.Text = "Hotel Purpose";
            this.btn_hotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hotel.UseVisualStyleBackColor = true;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // btn_general
            // 
            this.btn_general.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_general.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_general.Location = new System.Drawing.Point(0, 35);
            this.btn_general.Name = "btn_general";
            this.btn_general.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_general.Size = new System.Drawing.Size(200, 35);
            this.btn_general.TabIndex = 9;
            this.btn_general.Text = "General Purpose";
            this.btn_general.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_general.UseVisualStyleBackColor = true;
            this.btn_general.Click += new System.EventHandler(this.btn_general_Click);
            // 
            // btn_industrial
            // 
            this.btn_industrial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_industrial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_industrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_industrial.Location = new System.Drawing.Point(0, 0);
            this.btn_industrial.Name = "btn_industrial";
            this.btn_industrial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_industrial.Size = new System.Drawing.Size(200, 35);
            this.btn_industrial.TabIndex = 2;
            this.btn_industrial.Text = "Industrial Purpose";
            this.btn_industrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_industrial.UseVisualStyleBackColor = true;
            this.btn_industrial.Click += new System.EventHandler(this.btn_industrial_Click);
            // 
            // btn_catergory
            // 
            this.btn_catergory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_catergory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_catergory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_catergory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_catergory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_catergory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_catergory.Location = new System.Drawing.Point(0, 0);
            this.btn_catergory.Name = "btn_catergory";
            this.btn_catergory.Size = new System.Drawing.Size(200, 43);
            this.btn_catergory.TabIndex = 0;
            this.btn_catergory.Text = "Select Catergory";
            this.btn_catergory.UseVisualStyleBackColor = false;
            this.btn_catergory.Click += new System.EventHandler(this.btn_catergory_Click);
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.lbl_name2);
            this.pnl_name.Controls.Add(this.lbl_name);
            this.pnl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_name.Location = new System.Drawing.Point(0, 0);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(200, 103);
            this.pnl_name.TabIndex = 0;
            // 
            // lbl_name2
            // 
            this.lbl_name2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name2.Location = new System.Drawing.Point(0, 57);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(200, 32);
            this.lbl_name2.TabIndex = 1;
            this.lbl_name2.Text = "Electricity Board";
            this.lbl_name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Gold;
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(200, 57);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "CALCULATOR";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(200, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(606, 529);
            this.pnl_right.TabIndex = 1;
            this.pnl_right.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_right_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 529);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.MaximumSize = new System.Drawing.Size(822, 568);
            this.MinimumSize = new System.Drawing.Size(822, 568);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEB";
            this.pnl_left.ResumeLayout(false);
            this.pnl_button.ResumeLayout(false);
            this.pnl_submenu.ResumeLayout(false);
            this.pnl_domesticSub.ResumeLayout(false);
            this.pnl_name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_button;
        private System.Windows.Forms.Button btn_catergory;
        private System.Windows.Forms.Panel pnl_submenu;
        private System.Windows.Forms.Button btn_domestic;
        private System.Windows.Forms.Button btn_government;
        private System.Windows.Forms.Button btn_hotel;
        private System.Windows.Forms.Button btn_general;
        private System.Windows.Forms.Button btn_industrial;
        private System.Windows.Forms.Button btn_religious;
        private System.Windows.Forms.Panel pnl_domesticSub;
        private System.Windows.Forms.Button btn_dome_billrate;
        private System.Windows.Forms.Button btn_dome_cal;
    }
}

