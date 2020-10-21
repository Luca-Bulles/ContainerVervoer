namespace ContainerVervoer_Form
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
            this.Pnl_Start = new System.Windows.Forms.Panel();
            this.Nud_Width = new System.Windows.Forms.NumericUpDown();
            this.Nud_Length = new System.Windows.Forms.NumericUpDown();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Lbl_Width = new System.Windows.Forms.Label();
            this.Lbl_Length = new System.Windows.Forms.Label();
            this.Lbl_Header = new System.Windows.Forms.Label();
            this.Pnl_Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Start
            // 
            this.Pnl_Start.BackColor = System.Drawing.Color.DarkCyan;
            this.Pnl_Start.Controls.Add(this.Nud_Width);
            this.Pnl_Start.Controls.Add(this.Nud_Length);
            this.Pnl_Start.Controls.Add(this.Btn_Enter);
            this.Pnl_Start.Controls.Add(this.Lbl_Width);
            this.Pnl_Start.Controls.Add(this.Lbl_Length);
            this.Pnl_Start.Controls.Add(this.Lbl_Header);
            this.Pnl_Start.Location = new System.Drawing.Point(204, 78);
            this.Pnl_Start.Name = "Pnl_Start";
            this.Pnl_Start.Size = new System.Drawing.Size(879, 488);
            this.Pnl_Start.TabIndex = 0;
            // 
            // Nud_Width
            // 
            this.Nud_Width.Location = new System.Drawing.Point(320, 207);
            this.Nud_Width.Name = "Nud_Width";
            this.Nud_Width.Size = new System.Drawing.Size(150, 27);
            this.Nud_Width.TabIndex = 4;
            // 
            // Nud_Length
            // 
            this.Nud_Length.Location = new System.Drawing.Point(320, 144);
            this.Nud_Length.Name = "Nud_Length";
            this.Nud_Length.Size = new System.Drawing.Size(150, 27);
            this.Nud_Length.TabIndex = 4;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Enter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Enter.Location = new System.Drawing.Point(348, 255);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(94, 29);
            this.Btn_Enter.TabIndex = 3;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Lbl_Width
            // 
            this.Lbl_Width.AutoSize = true;
            this.Lbl_Width.Location = new System.Drawing.Point(366, 184);
            this.Lbl_Width.Name = "Lbl_Width";
            this.Lbl_Width.Size = new System.Drawing.Size(49, 20);
            this.Lbl_Width.TabIndex = 2;
            this.Lbl_Width.Text = "Width";
            // 
            // Lbl_Length
            // 
            this.Lbl_Length.AutoSize = true;
            this.Lbl_Length.Location = new System.Drawing.Point(366, 121);
            this.Lbl_Length.Name = "Lbl_Length";
            this.Lbl_Length.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Length.TabIndex = 2;
            this.Lbl_Length.Text = "Length";
            // 
            // Lbl_Header
            // 
            this.Lbl_Header.AutoSize = true;
            this.Lbl_Header.Location = new System.Drawing.Point(304, 24);
            this.Lbl_Header.Name = "Lbl_Header";
            this.Lbl_Header.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Header.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 684);
            this.Controls.Add(this.Pnl_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pnl_Start.ResumeLayout(false);
            this.Pnl_Start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Length)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Start;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label Lbl_Width;
        private System.Windows.Forms.Label Lbl_Length;
        private System.Windows.Forms.Label Lbl_Header;
        private System.Windows.Forms.NumericUpDown Nud_Length;
        private System.Windows.Forms.NumericUpDown Nud_Width;
    }
}

