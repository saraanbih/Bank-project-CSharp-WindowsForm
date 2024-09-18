namespace Bank_project_CSharp_WindowsForm
{
    partial class FrmAddOREditClient
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
            this.lblAddOREdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClientID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblAddOREdit
            // 
            this.lblAddOREdit.AutoSize = false;
            this.lblAddOREdit.BackColor = System.Drawing.Color.Transparent;
            this.lblAddOREdit.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOREdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddOREdit.Location = new System.Drawing.Point(12, 12);
            this.lblAddOREdit.Name = "lblAddOREdit";
            this.lblAddOREdit.Size = new System.Drawing.Size(651, 40);
            this.lblAddOREdit.TabIndex = 0;
            this.lblAddOREdit.Text = "Add New Client";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AutoRoundedCorners = true;
            this.txtAccountNumber.BorderRadius = 27;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "Account Number";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FillColor = System.Drawing.Color.LightGray;
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(23, 145);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(328, 57);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.Click += new System.EventHandler(this.txtAccountNumber_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.AutoRoundedCorners = true;
            this.txtClientName.BorderRadius = 27;
            this.txtClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientName.DefaultText = "Client Name";
            this.txtClientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientName.FillColor = System.Drawing.Color.LightGray;
            this.txtClientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtClientName.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtClientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientName.Location = new System.Drawing.Point(23, 248);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PasswordChar = '\0';
            this.txtClientName.PlaceholderText = "";
            this.txtClientName.SelectedText = "";
            this.txtClientName.Size = new System.Drawing.Size(328, 57);
            this.txtClientName.TabIndex = 2;
            this.txtClientName.Click += new System.EventHandler(this.txtClientName_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BorderRadius = 27;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "Phone";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.LightGray;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(23, 362);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(328, 57);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderRadius = 27;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "Email";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.LightGray;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(508, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(328, 57);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtPinCode
            // 
            this.txtPinCode.AutoRoundedCorners = true;
            this.txtPinCode.BorderRadius = 27;
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.DefaultText = "PinCode";
            this.txtPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.FillColor = System.Drawing.Color.LightGray;
            this.txtPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPinCode.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Location = new System.Drawing.Point(508, 248);
            this.txtPinCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '\0';
            this.txtPinCode.PlaceholderText = "";
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(328, 57);
            this.txtPinCode.TabIndex = 5;
            this.txtPinCode.Click += new System.EventHandler(this.txtPinCode_Click);
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.AutoRoundedCorners = true;
            this.txtAccountBalance.BorderRadius = 27;
            this.txtAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountBalance.DefaultText = "Account Balance";
            this.txtAccountBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.FillColor = System.Drawing.Color.LightGray;
            this.txtAccountBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAccountBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAccountBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Location = new System.Drawing.Point(508, 362);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.PasswordChar = '\0';
            this.txtAccountBalance.PlaceholderText = "";
            this.txtAccountBalance.SelectedText = "";
            this.txtAccountBalance.Size = new System.Drawing.Size(328, 57);
            this.txtAccountBalance.TabIndex = 6;
            //this.txtAccountBalance.TextChanged += new System.EventHandler(this.txtAccountBalance_TextChanged);
            this.txtAccountBalance.Click += new System.EventHandler(this.txtAccountBalance_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(566, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.Size = new System.Drawing.Size(119, 106);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(167, 454);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(119, 106);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label
            // 
            this.label.AutoSize = false;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGreen;
            this.label.Location = new System.Drawing.Point(23, 90);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 33);
            this.label.TabIndex = 9;
            this.label.Text = "ID";
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.Color.Transparent;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblClientID.Location = new System.Drawing.Point(123, 90);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(51, 33);
            this.lblClientID.TabIndex = 10;
            this.lblClientID.Text = "???";
            // 
            // FrmAddOREditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 584);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAddOREdit);
            this.Name = "FrmAddOREditClient";
            this.Text = "Add OR Edit Client";
            this.Load += new System.EventHandler(this.FrmAddOREditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddOREdit;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtClientName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPinCode;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountBalance;
        private Guna.UI2.WinForms.Guna2CircleButton btnSave;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel label;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClientID;
    }
}