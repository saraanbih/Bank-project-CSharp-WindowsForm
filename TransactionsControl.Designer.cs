namespace Bank_project_CSharp_WindowsForm
{
    partial class TransactionsControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchByAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.brnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(365, 79);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Transactions";
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
            this.txtSearchByAccountNumber.Location = new System.Drawing.Point(692, 45);
            this.txtSearchByAccountNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearchByAccountNumber.Name = "txtSearchByAccountNumber";
            this.txtSearchByAccountNumber.PasswordChar = '\0';
            this.txtSearchByAccountNumber.PlaceholderText = "";
            this.txtSearchByAccountNumber.SelectedText = "";
            this.txtSearchByAccountNumber.Size = new System.Drawing.Size(501, 55);
            this.txtSearchByAccountNumber.TabIndex = 3;
            this.txtSearchByAccountNumber.TextChanged += new System.EventHandler(this.txtSearchByAccountNumber_TextChanged);
            this.txtSearchByAccountNumber.Click += new System.EventHandler(this.txtSearchByAccountNumber_Click);
            this.txtSearchByAccountNumber.Leave += new System.EventHandler(this.txtSearchByAccountNumber_Leave);
            // 
            // brnDeposit
            // 
            this.brnDeposit.AutoRoundedCorners = true;
            this.brnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.brnDeposit.BorderRadius = 26;
            this.brnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brnDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brnDeposit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDeposit.ForeColor = System.Drawing.Color.DimGray;
            this.brnDeposit.Location = new System.Drawing.Point(3, 18);
            this.brnDeposit.Name = "brnDeposit";
            this.brnDeposit.Size = new System.Drawing.Size(173, 55);
            this.brnDeposit.TabIndex = 4;
            this.brnDeposit.Text = "Deposit";
            this.brnDeposit.Click += new System.EventHandler(this.brnDeposit_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToOrderColumns = true;
            this.dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactions.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeight = 4;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(0, 232);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(1199, 549);
            this.dgvTransactions.TabIndex = 8;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTransactions.ThemeStyle.ReadOnly = true;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.Controls.Add(this.brnDeposit);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ImageButton1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 134);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(249, 87);
            this.guna2CustomGradientPanel1.TabIndex = 10;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Bank_project_CSharp_WindowsForm.Properties.Resources.deposit;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(182, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 78);
            this.guna2ImageButton1.TabIndex = 9;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel2.Controls.Add(this.btnWithdraw);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2ImageButton2);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(299, 134);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(249, 87);
            this.guna2CustomGradientPanel2.TabIndex = 11;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AutoRoundedCorners = true;
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BorderRadius = 26;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.DimGray;
            this.btnWithdraw.Location = new System.Drawing.Point(3, 18);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(167, 55);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = global::Bank_project_CSharp_WindowsForm.Properties.Resources.withdrawal;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(176, 3);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(64, 78);
            this.guna2ImageButton2.TabIndex = 9;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.Controls.Add(this.btnTransfer);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2ImageButton3);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(595, 134);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(249, 87);
            this.guna2CustomGradientPanel3.TabIndex = 11;
            // 
            // btnTransfer
            // 
            this.btnTransfer.AutoRoundedCorners = true;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BorderRadius = 26;
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransfer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.btnTransfer.Location = new System.Drawing.Point(3, 18);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(173, 55);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = global::Bank_project_CSharp_WindowsForm.Properties.Resources.pay;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.Location = new System.Drawing.Point(182, 7);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(64, 74);
            this.guna2ImageButton3.TabIndex = 9;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2Button3);
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2ImageButton4);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(878, 134);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(281, 87);
            this.guna2CustomGradientPanel4.TabIndex = 12;
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 26;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button3.Location = new System.Drawing.Point(3, 18);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(205, 55);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Transfer Log";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Image = global::Bank_project_CSharp_WindowsForm.Properties.Resources.file_transfer_1_;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.Location = new System.Drawing.Point(214, 7);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(64, 74);
            this.guna2ImageButton4.TabIndex = 9;
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.txtSearchByAccountNumber);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(1199, 781);
            this.Load += new System.EventHandler(this.TransactionsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByAccountNumber;
        private Guna.UI2.WinForms.Guna2Button brnDeposit;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
    }
}
