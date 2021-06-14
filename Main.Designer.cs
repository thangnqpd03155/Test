namespace InputDataApplication
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
            this.pn_Input = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.uC_Image1 = new InputDataApplication.UC_Image();
            this.SuspendLayout();
            // 
            // pn_Input
            // 
            this.pn_Input.AutoScroll = true;
            this.pn_Input.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.pn_Input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_Input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_Input.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Input.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pn_Input.Location = new System.Drawing.Point(724, 0);
            this.pn_Input.Name = "pn_Input";
            this.pn_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pn_Input.Size = new System.Drawing.Size(624, 726);
            this.pn_Input.TabIndex = 0;
            this.pn_Input.WrapContents = false;
            this.pn_Input.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pn_Input_PreviewKeyDown);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(12, 158);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(90, 38);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // uC_Image1
            // 
            this.uC_Image1.Location = new System.Drawing.Point(12, 202);
            this.uC_Image1.Name = "uC_Image1";
            this.uC_Image1.Size = new System.Drawing.Size(703, 512);
            this.uC_Image1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1348, 726);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.uC_Image1);
            this.Controls.Add(this.pn_Input);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pn_Input;
        private UC_Image uC_Image1;
        private System.Windows.Forms.Button btn_Load;
    }
}