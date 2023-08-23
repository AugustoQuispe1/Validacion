namespace Validacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPat = new System.Windows.Forms.TextBox();
            this.txtBoxCuil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPat = new System.Windows.Forms.Button();
            this.BtnCuil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificacion de patente/CUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patente";
            // 
            // txtBoxPat
            // 
            this.txtBoxPat.Location = new System.Drawing.Point(101, 137);
            this.txtBoxPat.Name = "txtBoxPat";
            this.txtBoxPat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPat.TabIndex = 2;
            // 
            // txtBoxCuil
            // 
            this.txtBoxCuil.Location = new System.Drawing.Point(101, 188);
            this.txtBoxCuil.Name = "txtBoxCuil";
            this.txtBoxCuil.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCuil.TabIndex = 3;
            this.txtBoxCuil.TextChanged += new System.EventHandler(this.txtBoxCuil_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CUIL";
            // 
            // BtnPat
            // 
            this.BtnPat.Location = new System.Drawing.Point(223, 135);
            this.BtnPat.Name = "BtnPat";
            this.BtnPat.Size = new System.Drawing.Size(98, 23);
            this.BtnPat.TabIndex = 5;
            this.BtnPat.Text = "Verificar patente";
            this.BtnPat.UseVisualStyleBackColor = true;
            this.BtnPat.Click += new System.EventHandler(this.BtnPat_Click);
            // 
            // BtnCuil
            // 
            this.BtnCuil.Location = new System.Drawing.Point(223, 186);
            this.BtnCuil.Name = "BtnCuil";
            this.BtnCuil.Size = new System.Drawing.Size(98, 23);
            this.BtnCuil.TabIndex = 6;
            this.BtnCuil.Text = "Verificar CUIL";
            this.BtnCuil.UseVisualStyleBackColor = true;
            this.BtnCuil.Click += new System.EventHandler(this.BtnCuil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 234);
            this.Controls.Add(this.BtnCuil);
            this.Controls.Add(this.BtnPat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCuil);
            this.Controls.Add(this.txtBoxPat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPat;
        private System.Windows.Forms.TextBox txtBoxCuil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPat;
        private System.Windows.Forms.Button BtnCuil;
        }
    }

