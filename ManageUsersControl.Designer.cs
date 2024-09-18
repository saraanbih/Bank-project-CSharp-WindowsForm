namespace Bank_project_CSharp_WindowsForm
{
    partial class ManageUsersControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchByAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGetAllUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(365, 79);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Manage Clients";
            // 
            // txtSearchByAccountNumber
            // 
            this.txtSearchByAccountNumber.AutoRoundedCorners = true;
            this.txtSearchByAccountNumber.BorderRadius = 26;
            this.txtSearchByAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByAccountNumber.DefaultText = "Search By User Name";
            this.txtSearchByAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByAccountNumber.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByAccountNumber.Location = new System.Drawing.Point(17, 143);
            this.txtSearchByAccountNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearchByAccountNumber.Name = "txtSearchByAccountNumber";
            this.txtSearchByAccountNumber.PasswordChar = '\0';
            this.txtSearchByAccountNumber.PlaceholderText = "";
            this.txtSearchByAccountNumber.SelectedText = "";
            this.txtSearchByAccountNumber.Size = new System.Drawing.Size(504, 55);
            this.txtSearchByAccountNumber.TabIndex = 3;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.AutoRoundedCorners = true;
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.BorderRadius = 26;
            this.btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddNewClient.Location = new System.Drawing.Point(896, 143);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(242, 55);
            this.btnAddNewClient.TabIndex = 4;
            this.btnAddNewClient.Text = "Add New";
            // 
            // dgvGetAllUsers
            // 
            this.dgvGetAllUsers.AllowUserToAddRows = false;
            this.dgvGetAllUsers.AllowUserToDeleteRows = false;
            this.dgvGetAllUsers.AllowUserToOrderColumns = true;
            this.dgvGetAllUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvGetAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGetAllUsers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvGetAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGetAllUsers.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGetAllUsers.ColumnHeadersHeight = 4;
            this.dgvGetAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGetAllUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGetAllUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGetAllUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGetAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGetAllUsers.Location = new System.Drawing.Point(0, 232);
            this.dgvGetAllUsers.Name = "dgvGetAllUsers";
            this.dgvGetAllUsers.ReadOnly = true;
            this.dgvGetAllUsers.RowHeadersVisible = false;
            this.dgvGetAllUsers.RowHeadersWidth = 51;
            this.dgvGetAllUsers.RowTemplate.Height = 24;
            this.dgvGetAllUsers.Size = new System.Drawing.Size(1199, 549);
            this.dgvGetAllUsers.TabIndex = 5;
            this.dgvGetAllUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGetAllUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGetAllUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGetAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGetAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGetAllUsers.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGetAllUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGetAllUsers.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvGetAllUsers.ThemeStyle.ReadOnly = true;
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.Height = 24;
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGetAllUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ManageUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dgvGetAllUsers);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.txtSearchByAccountNumber);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ManageUsersControl";
            this.Size = new System.Drawing.Size(1199, 781);
            this.Load += new System.EventHandler(this.ManageUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByAccountNumber;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGetAllUsers;
    }
}
