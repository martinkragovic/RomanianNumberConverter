
namespace Converter
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
            this.rimski = new System.Windows.Forms.Label();
            this.arapski = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.RB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // rimski
            // 
            this.rimski.AutoSize = true;
            this.rimski.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimski.Location = new System.Drawing.Point(24, 111);
            this.rimski.Name = "rimski";
            this.rimski.Size = new System.Drawing.Size(375, 37);
            this.rimski.TabIndex = 1;
            this.rimski.Text = "Enter Romanian number:";
            this.rimski.Click += new System.EventHandler(this.label2_Click);
            // 
            // arapski
            // 
            this.arapski.AutoSize = true;
            this.arapski.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arapski.Location = new System.Drawing.Point(24, 177);
            this.arapski.Name = "arapski";
            this.arapski.Size = new System.Drawing.Size(281, 37);
            this.arapski.TabIndex = 2;
            this.arapski.Text = "Arabian numbers: ";
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.Location = new System.Drawing.Point(438, 117);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(148, 35);
            this.TB1.TabIndex = 3;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB2.Location = new System.Drawing.Point(356, 177);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(148, 35);
            this.TB2.TabIndex = 4;
            this.TB2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RB
            // 
            this.RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB.Location = new System.Drawing.Point(240, 316);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(285, 90);
            this.RB.TabIndex = 5;
            this.RB.Text = "Convert";
            this.RB.UseVisualStyleBackColor = true;
            this.RB.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 738);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.arapski);
            this.Controls.Add(this.rimski);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rimski;
        private System.Windows.Forms.Label arapski;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Button RB;
    }
}

