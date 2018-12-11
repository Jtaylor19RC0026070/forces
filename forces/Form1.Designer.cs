namespace forces
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.N = new System.Windows.Forms.Label();
            this.Fy = new System.Windows.Forms.Label();
            this.Fx = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Zero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(399, 322);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.Calculatebutton.TabIndex = 1;
            this.Calculatebutton.Text = "Calaculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(172, 142);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(19, 13);
            this.F.TabIndex = 2;
            this.F.Text = "F=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::forces.Properties.Resources.Paint_Head_12;
            this.pictureBox1.Location = new System.Drawing.Point(98, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 306);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(255, 145);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(15, 13);
            this.N.TabIndex = 4;
            this.N.Text = "N";
            // 
            // Fy
            // 
            this.Fy.AutoSize = true;
            this.Fy.Location = new System.Drawing.Point(130, 223);
            this.Fy.Name = "Fy";
            this.Fy.Size = new System.Drawing.Size(24, 13);
            this.Fy.TabIndex = 5;
            this.Fy.Text = "Fy=";
            // 
            // Fx
            // 
            this.Fx.AutoSize = true;
            this.Fx.Location = new System.Drawing.Point(306, 389);
            this.Fx.Name = "Fx";
            this.Fx.Size = new System.Drawing.Size(24, 13);
            this.Fx.TabIndex = 6;
            this.Fx.Text = "Fx=";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Zero
            // 
            this.Zero.AutoSize = true;
            this.Zero.Location = new System.Drawing.Point(214, 311);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(13, 13);
            this.Zero.TabIndex = 8;
            this.Zero.Text = "o";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Fx);
            this.Controls.Add(this.Fy);
            this.Controls.Add(this.N);
            this.Controls.Add(this.F);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label Fy;
        private System.Windows.Forms.Label Fx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Zero;
    }
}

