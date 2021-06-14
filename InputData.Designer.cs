namespace InputDataApplication
{
    partial class InputData
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lb_Add = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Name.Location = new System.Drawing.Point(71, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(201, 20);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.Tag = "Input";
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            this.txt_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_Name_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject: ";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(431, 8);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(62, 20);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.Tag = "Input";
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubject_KeyDown);
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubject_KeyPress);
            this.txtSubject.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSubject_PreviewKeyDown);
            // 
            // lb_Add
            // 
            this.lb_Add.AutoSize = true;
            this.lb_Add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add.Location = new System.Drawing.Point(523, 9);
            this.lb_Add.Name = "lb_Add";
            this.lb_Add.Size = new System.Drawing.Size(18, 18);
            this.lb_Add.TabIndex = 3;
            this.lb_Add.Text = "+";
            this.lb_Add.Click += new System.EventHandler(this.lb_Add_Click);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.Location = new System.Drawing.Point(547, 9);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(14, 18);
            this.lb_Delete.TabIndex = 1;
            this.lb_Delete.Text = "-";
            this.lb_Delete.Click += new System.EventHandler(this.lb_Delete_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(316, 8);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(54, 20);
            this.txt_value.TabIndex = 1;
            this.txt_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_value_KeyPress);
            this.txt_value.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_value_PreviewKeyDown);
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lb_Delete);
            this.Controls.Add(this.lb_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txt_Name);
            this.Name = "InputData";
            this.Size = new System.Drawing.Size(597, 37);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InputData_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_Delete;
        public System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txt_value;
    }
}
