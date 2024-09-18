namespace Bank_project_CSharp_WindowsForm
{
    partial class ClientCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchByAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccountNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccountBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPinCode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(230, 43);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Client Card";
            // 
            // txtSearchByAccountNumber
            // 
            this.txtSearchByAccountNumber.AutoRoundedCorners = true;
            this.txtSearchByAccountNumber.BorderRadius = 26;
            this.txtSearchByAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByAccountNumber.DefaultText = "Search By Account Number";
            this.txtSearchByAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByAccountNumber.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByAccountNumber.Location = new System.Drawing.Point(6, 55);
            this.txtSearchByAccountNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearchByAccountNumber.Name = "txtSearchByAccountNumber";
            this.txtSearchByAccountNumber.PasswordChar = '\0';
            this.txtSearchByAccountNumber.PlaceholderText = "";
            this.txtSearchByAccountNumber.SelectedText = "";
            this.txtSearchByAccountNumber.Size = new System.Drawing.Size(341, 55);
            this.txtSearchByAccountNumber.TabIndex = 4;
           // this.txtSearchByAccountNumber.TextChanged += new System.EventHandler(this.txtSearchByAccountNumber_TextChanged);
            this.txtSearchByAccountNumber.Enter += new System.EventHandler(this.txtSearchByAccountNumber_Enter);
            // 
            // btnFind
            // 
            this.btnFind.AutoRoundedCorners = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderRadius = 26;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFind.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.DimGray;
            this.btnFind.Location = new System.Drawing.Point(396, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(194, 55);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(6, 140);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(40, 28);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = false;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(91, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 28);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "???";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(6, 184);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(183, 28);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Account Number";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = false;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(209, 184);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(84, 28);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "???";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(6, 235);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(183, 28);
            this.guna2HtmlLabel6.TabIndex = 10;
            this.guna2HtmlLabel6.Text = "Account Balance";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = false;
            this.lblAccountBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountBalance.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.ForeColor = System.Drawing.Color.Black;
            this.lblAccountBalance.Location = new System.Drawing.Point(209, 235);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(114, 28);
            this.lblAccountBalance.TabIndex = 11;
            this.lblAccountBalance.Text = "???";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(343, 140);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(74, 28);
            this.guna2HtmlLabel8.TabIndex = 12;
            this.guna2HtmlLabel8.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(440, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 28);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "???";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(343, 184);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(100, 28);
            this.guna2HtmlLabel10.TabIndex = 14;
            this.guna2HtmlLabel10.Text = "PinCode";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = false;
            this.lblPinCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPinCode.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.ForeColor = System.Drawing.Color.Black;
            this.lblPinCode.Location = new System.Drawing.Point(440, 184);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(186, 28);
            this.lblPinCode.TabIndex = 15;
            this.lblPinCode.Text = "???";
            // 
            // ClientCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchByAccountNumber);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ClientCardControl";
            this.Size = new System.Drawing.Size(629, 291);
            this.Load += new System.EventHandler(this.ClientCardControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByAccountNumber;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountBalance;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPinCode;
    }
}
