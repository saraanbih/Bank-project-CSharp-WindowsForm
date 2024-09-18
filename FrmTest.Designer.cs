namespace Bank_project_CSharp_WindowsForm
{
    partial class FrmTest
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
            this.ctrClientCardWithoutFind1 = new Bank_project_CSharp_WindowsForm.ctrClientCardWithoutFind();
            this.SuspendLayout();
            // 
            // ctrClientCardWithoutFind1
            // 
            this.ctrClientCardWithoutFind1.AccountBalanceText = "???";
            this.ctrClientCardWithoutFind1.AccountNumberText = "???";
            this.ctrClientCardWithoutFind1.IDText = "???";
            this.ctrClientCardWithoutFind1.Location = new System.Drawing.Point(26, 44);
            this.ctrClientCardWithoutFind1.Name = "ctrClientCardWithoutFind1";
            this.ctrClientCardWithoutFind1.NameText = "???";
            this.ctrClientCardWithoutFind1.PinCodeText = "???";
            this.ctrClientCardWithoutFind1.Size = new System.Drawing.Size(637, 222);
            this.ctrClientCardWithoutFind1.TabIndex = 0;
            //this.ctrClientCardWithoutFind1.Load += new System.EventHandler(this.ctrClientCardWithoutFind1_Load);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrClientCardWithoutFind1);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrClientCardWithoutFind ctrClientCardWithoutFind1;
    }
}