using System.Diagnostics;

namespace Ocjenska
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtBrojKotača = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(54, 46);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(141, 26);
            this.txtModel.TabIndex = 0;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(54, 111);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(141, 26);
            this.txtGodina.TabIndex = 1;
            // 
            // txtBrojKotača
            // 
            this.txtBrojKotača.Location = new System.Drawing.Point(54, 180);
            this.txtBrojKotača.Name = "txtBrojKotača";
            this.txtBrojKotača.Size = new System.Drawing.Size(141, 26);
            this.txtBrojKotača.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj kotača";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(54, 249);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(104, 35);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(54, 315);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(104, 42);
            this.btnObrada.TabIndex = 8;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(58, 383);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(100, 36);
            this.btnIspis.TabIndex = 9;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 235);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(552, 459);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojKotača);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtBrojKotača;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        


        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.TextBox textBox1;
    }
}

