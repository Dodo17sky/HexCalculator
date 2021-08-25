
namespace HexCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpAddition = new System.Windows.Forms.Button();
            this.OpMultiplication = new System.Windows.Forms.Button();
            this.OpSubtractB = new System.Windows.Forms.Button();
            this.OpSubtractA = new System.Windows.Forms.Button();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.labelA3 = new System.Windows.Forms.Label();
            this.labelB3 = new System.Windows.Forms.Label();
            this.labelB2 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.NumberA_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(407, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.NumberB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(213, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(621, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number";
            // 
            // OpAddition
            // 
            this.OpAddition.AutoSize = true;
            this.OpAddition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpAddition.Location = new System.Drawing.Point(26, 250);
            this.OpAddition.Name = "OpAddition";
            this.OpAddition.Size = new System.Drawing.Size(175, 32);
            this.OpAddition.TabIndex = 6;
            this.OpAddition.Text = "A + B";
            this.OpAddition.UseVisualStyleBackColor = true;
            this.OpAddition.Click += new System.EventHandler(this.OpAddition_Click);
            // 
            // OpMultiplication
            // 
            this.OpMultiplication.AutoSize = true;
            this.OpMultiplication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpMultiplication.Location = new System.Drawing.Point(215, 250);
            this.OpMultiplication.Name = "OpMultiplication";
            this.OpMultiplication.Size = new System.Drawing.Size(175, 32);
            this.OpMultiplication.TabIndex = 7;
            this.OpMultiplication.Text = "A x B";
            this.OpMultiplication.UseVisualStyleBackColor = true;
            this.OpMultiplication.Click += new System.EventHandler(this.OpMultiplication_Click);
            // 
            // OpSubtractB
            // 
            this.OpSubtractB.AutoSize = true;
            this.OpSubtractB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpSubtractB.Location = new System.Drawing.Point(407, 250);
            this.OpSubtractB.Name = "OpSubtractB";
            this.OpSubtractB.Size = new System.Drawing.Size(175, 32);
            this.OpSubtractB.TabIndex = 8;
            this.OpSubtractB.Text = "A - B";
            this.OpSubtractB.UseVisualStyleBackColor = true;
            this.OpSubtractB.Click += new System.EventHandler(this.OpSubtractB_Click);
            // 
            // OpSubtractA
            // 
            this.OpSubtractA.AutoSize = true;
            this.OpSubtractA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpSubtractA.Location = new System.Drawing.Point(600, 250);
            this.OpSubtractA.Name = "OpSubtractA";
            this.OpSubtractA.Size = new System.Drawing.Size(175, 32);
            this.OpSubtractA.TabIndex = 9;
            this.OpSubtractA.Text = "B - A";
            this.OpSubtractA.UseVisualStyleBackColor = true;
            this.OpSubtractA.Click += new System.EventHandler(this.OpSubtractA_Click);
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelA1.Location = new System.Drawing.Point(26, 115);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(56, 18);
            this.labelA1.TabIndex = 10;
            this.labelA1.Text = "label5";
            // 
            // labelA2
            // 
            this.labelA2.AutoSize = true;
            this.labelA2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelA2.Location = new System.Drawing.Point(26, 145);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(56, 18);
            this.labelA2.TabIndex = 11;
            this.labelA2.Text = "label6";
            // 
            // labelA3
            // 
            this.labelA3.AutoSize = true;
            this.labelA3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelA3.Location = new System.Drawing.Point(26, 175);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(56, 18);
            this.labelA3.TabIndex = 12;
            this.labelA3.Text = "label7";
            // 
            // labelB3
            // 
            this.labelB3.AutoSize = true;
            this.labelB3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB3.ForeColor = System.Drawing.Color.Maroon;
            this.labelB3.Location = new System.Drawing.Point(410, 175);
            this.labelB3.Name = "labelB3";
            this.labelB3.Size = new System.Drawing.Size(56, 18);
            this.labelB3.TabIndex = 15;
            this.labelB3.Text = "label7";
            // 
            // labelB2
            // 
            this.labelB2.AutoSize = true;
            this.labelB2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB2.ForeColor = System.Drawing.Color.Maroon;
            this.labelB2.Location = new System.Drawing.Point(410, 145);
            this.labelB2.Name = "labelB2";
            this.labelB2.Size = new System.Drawing.Size(56, 18);
            this.labelB2.TabIndex = 14;
            this.labelB2.Text = "label6";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB1.ForeColor = System.Drawing.Color.Maroon;
            this.labelB1.Location = new System.Drawing.Point(410, 115);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(56, 18);
            this.labelB1.TabIndex = 13;
            this.labelB1.Text = "label5";
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR3.ForeColor = System.Drawing.Color.Green;
            this.labelR3.Location = new System.Drawing.Point(250, 380);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(70, 22);
            this.labelR3.TabIndex = 18;
            this.labelR3.Text = "label7";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR2.ForeColor = System.Drawing.Color.Green;
            this.labelR2.Location = new System.Drawing.Point(250, 340);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(70, 22);
            this.labelR2.TabIndex = 17;
            this.labelR2.Text = "label6";
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR1.ForeColor = System.Drawing.Color.Green;
            this.labelR1.Location = new System.Drawing.Point(250, 300);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(70, 22);
            this.labelR1.TabIndex = 16;
            this.labelR1.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelR3);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.labelB3);
            this.Controls.Add(this.labelB2);
            this.Controls.Add(this.labelB1);
            this.Controls.Add(this.labelA3);
            this.Controls.Add(this.labelA2);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.OpSubtractA);
            this.Controls.Add(this.OpSubtractB);
            this.Controls.Add(this.OpMultiplication);
            this.Controls.Add(this.OpAddition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HEX-calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpAddition;
        private System.Windows.Forms.Button OpMultiplication;
        private System.Windows.Forms.Button OpSubtractB;
        private System.Windows.Forms.Button OpSubtractA;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label labelA3;
        private System.Windows.Forms.Label labelB3;
        private System.Windows.Forms.Label labelB2;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelR1;
    }
}

