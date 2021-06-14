namespace InputDataApplication
{
    partial class UC_Image
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
            this.imageBox1 = new ImageGlass.ImageBox();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_ZoomIn = new System.Windows.Forms.Button();
            this.btn_ZoomOut = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(693, 442);
            this.imageBox1.TabIndex = 0;
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(96, 463);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(48, 39);
            this.btn_Left.TabIndex = 1;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Location = new System.Drawing.Point(192, 463);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(88, 39);
            this.btn_ZoomIn.TabIndex = 1;
            this.btn_ZoomIn.Text = "Zoom In";
            this.btn_ZoomIn.UseVisualStyleBackColor = true;
            this.btn_ZoomIn.Click += new System.EventHandler(this.btn_ZoomIn_Click);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Location = new System.Drawing.Point(348, 463);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(88, 39);
            this.btn_ZoomOut.TabIndex = 1;
            this.btn_ZoomOut.Text = "Zoom Out";
            this.btn_ZoomOut.UseVisualStyleBackColor = true;
            this.btn_ZoomOut.Click += new System.EventHandler(this.btn_ZoomOut_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(514, 463);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(88, 39);
            this.btn_Right.TabIndex = 1;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // UC_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_ZoomOut);
            this.Controls.Add(this.btn_ZoomIn);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.imageBox1);
            this.Name = "UC_Image";
            this.Size = new System.Drawing.Size(699, 526);
            this.Load += new System.EventHandler(this.UC_Image_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageGlass.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_ZoomIn;
        private System.Windows.Forms.Button btn_ZoomOut;
        private System.Windows.Forms.Button btn_Right;
    }
}
