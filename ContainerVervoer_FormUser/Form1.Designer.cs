namespace ContainerVervoer_FormUser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Lbl_Width = new System.Windows.Forms.Label();
            this.Lbl_Length = new System.Windows.Forms.Label();
            this.Nud_Width = new System.Windows.Forms.NumericUpDown();
            this.Nud_Length = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Btn_Enter);
            this.panel1.Controls.Add(this.Lbl_Width);
            this.panel1.Controls.Add(this.Lbl_Length);
            this.panel1.Controls.Add(this.Nud_Width);
            this.panel1.Controls.Add(this.Nud_Length);
            this.panel1.Location = new System.Drawing.Point(209, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 589);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Location = new System.Drawing.Point(386, 352);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(162, 55);
            this.Btn_Enter.TabIndex = 2;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Lbl_Width
            // 
            this.Lbl_Width.AutoSize = true;
            this.Lbl_Width.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Width.Location = new System.Drawing.Point(386, 268);
            this.Lbl_Width.Name = "Lbl_Width";
            this.Lbl_Width.Size = new System.Drawing.Size(188, 23);
            this.Lbl_Width.TabIndex = 1;
            this.Lbl_Width.Text = "Width of the ship 1-9:";
            // 
            // Lbl_Length
            // 
            this.Lbl_Length.AutoSize = true;
            this.Lbl_Length.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Length.Location = new System.Drawing.Point(386, 168);
            this.Lbl_Length.Name = "Lbl_Length";
            this.Lbl_Length.Size = new System.Drawing.Size(194, 23);
            this.Lbl_Length.TabIndex = 1;
            this.Lbl_Length.Text = "Length of the ship 1-9:";
            // 
            // Nud_Width
            // 
            this.Nud_Width.Location = new System.Drawing.Point(386, 294);
            this.Nud_Width.Name = "Nud_Width";
            this.Nud_Width.Size = new System.Drawing.Size(188, 27);
            this.Nud_Width.TabIndex = 0;
            // 
            // Nud_Length
            // 
            this.Nud_Length.Location = new System.Drawing.Point(386, 213);
            this.Nud_Length.Name = "Nud_Length";
            this.Nud_Length.Size = new System.Drawing.Size(188, 27);
            this.Nud_Length.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 722);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Length)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Nud;
        private System.Windows.Forms.Label Lbl_Width;
        private System.Windows.Forms.Label Lbl_Length;
        private System.Windows.Forms.NumericUpDown Nud_Width;
        private System.Windows.Forms.NumericUpDown Nud_Length;
        private System.Windows.Forms.Button Btn_Enter;
    }
}

