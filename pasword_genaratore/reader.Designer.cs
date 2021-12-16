
namespace pasword_genaratore
{
    partial class reader
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
            this.make_paswords = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // make_paswords
            // 
            this.make_paswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.make_paswords.Location = new System.Drawing.Point(580, 13);
            this.make_paswords.Name = "make_paswords";
            this.make_paswords.Size = new System.Drawing.Size(142, 80);
            this.make_paswords.TabIndex = 0;
            this.make_paswords.Text = "make paswords";
            this.make_paswords.UseVisualStyleBackColor = true;
            this.make_paswords.Click += new System.EventHandler(this.make_paswords_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(33, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(515, 154);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "pasword\'s name?";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(33, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 142);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "the pasword";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1_
            // 
            this.button1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1_.Location = new System.Drawing.Point(580, 219);
            this.button1_.Name = "button1_";
            this.button1_.Size = new System.Drawing.Size(142, 141);
            this.button1_.TabIndex = 4;
            this.button1_.Text = "read the pasword";
            this.button1_.UseVisualStyleBackColor = true;
            this.button1_.Click += new System.EventHandler(this.button1__Click);
            // 
            // reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 372);
            this.ControlBox = false;
            this.Controls.Add(this.button1_);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.make_paswords);
            this.Name = "reader";
            this.Text = "reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button make_paswords;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_;
    }
}