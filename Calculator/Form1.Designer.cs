namespace Calculator
{
    partial class Form1
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(86, 115);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(150, 121);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(86, 248);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(150, 121);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(86, 381);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(150, 121);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(86, 513);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(150, 121);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(276, 163);
            this.lblPlus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(0, 25);
            this.lblPlus.TabIndex = 4;
            this.lblPlus.Visible = false;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Location = new System.Drawing.Point(276, 296);
            this.lblMinus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(0, 25);
            this.lblMinus.TabIndex = 5;
            this.lblMinus.Visible = false;
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.Location = new System.Drawing.Point(276, 429);
            this.lblDivide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(0, 25);
            this.lblDivide.TabIndex = 6;
            this.lblDivide.Visible = false;
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Location = new System.Drawing.Point(276, 562);
            this.lblMultiply.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(0, 25);
            this.lblMultiply.TabIndex = 7;
            this.lblMultiply.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 740);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Label lblMultiply;
    }
}

