namespace Medicalcalculator
{
    partial class IMT
    {

        private System.ComponentModel.IContainer components = null;


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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Твой вес";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.Location = new Point(246, 6);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Coral;
            label2.Location = new Point(362, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "кг.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Coral;
            label3.Location = new Point(186, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Твой рост";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Location = new Point(246, 43);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Coral;
            label4.Location = new Point(362, 46);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 5;
            label4.Text = "см.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Coral;
            label5.Location = new Point(186, 79);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "ИМТ= ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 79);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.wallpaperflare_com_wallpaper__1_;
            button1.Location = new Point(10, 4);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 134);
            button1.TabIndex = 8;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IMT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poppingcatpack;
            ClientSize = new Size(1003, 529);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IMT";
            Text = "Калькулятор";
            Load += IMT_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}