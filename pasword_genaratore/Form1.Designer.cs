
namespace pasword_genaratore
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.num = new System.Windows.Forms.TextBox();
            this.b_letters = new System.Windows.Forms.TextBox();
            this.genareate = new System.Windows.Forms.Button();
            this.lenthg_checker = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(639, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "save the pasword?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num.Location = new System.Drawing.Point(639, 88);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(149, 79);
            this.num.TabIndex = 1;
            this.num.Text = "how many number carectors do you want?";
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // b_letters
            // 
            this.b_letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_letters.Location = new System.Drawing.Point(639, 188);
            this.b_letters.Multiline = true;
            this.b_letters.Name = "b_letters";
            this.b_letters.Size = new System.Drawing.Size(149, 79);
            this.b_letters.TabIndex = 2;
            this.b_letters.Text = "how many big letters do you want?";
            this.b_letters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_letters.TextChanged += new System.EventHandler(this.b_letters_TextChanged);
            // 
            // genareate
            // 
            this.genareate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.genareate.Location = new System.Drawing.Point(639, 466);
            this.genareate.Name = "genareate";
            this.genareate.Size = new System.Drawing.Size(149, 78);
            this.genareate.TabIndex = 3;
            this.genareate.Text = "generate pasword";
            this.genareate.UseVisualStyleBackColor = true;
            this.genareate.Click += new System.EventHandler(this.genareate_Click);
            // 
            // lenthg_checker
            // 
            this.lenthg_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lenthg_checker.Location = new System.Drawing.Point(639, 291);
            this.lenthg_checker.Multiline = true;
            this.lenthg_checker.Name = "lenthg_checker";
            this.lenthg_checker.Size = new System.Drawing.Size(149, 79);
            this.lenthg_checker.TabIndex = 4;
            this.lenthg_checker.Text = "how long should the pasword be?";
            this.lenthg_checker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lenthg_checker.TextChanged += new System.EventHandler(this.lenthg_checker_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(39, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 358);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "pasword will apear here(the lenght cant be less than 4)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(39, 428);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(529, 116);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "pasword\'s name?";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "read saved pasword";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "exit the program";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lenthg_checker);
            this.Controls.Add(this.genareate);
            this.Controls.Add(this.b_letters);
            this.Controls.Add(this.num);
            this.Controls.Add(this.checkBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "macker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox b_letters;
        private System.Windows.Forms.Button genareate;
        private System.Windows.Forms.TextBox lenthg_checker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

