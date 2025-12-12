namespace yakıtHesaplama
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
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(321, 36);
            label1.TabIndex = 0;
            label1.Text = "Yakıt Hesaplayıcı";
            label1.Click += label1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(326, 60);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "KM bilgisi:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(263, 20);
            label3.TabIndex = 3;
            label3.Text = "Ortalama yakıt tüketimi (L/100 km):";
            label3.Click += label3_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(326, 99);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 5;
            label4.Text = "Yakıt fiyatı (TL/L):";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(326, 138);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 27);
            maskedTextBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 180);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 7;
            label5.Text = "Ortalama hız (km/h):";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(326, 177);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(125, 27);
            maskedTextBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 220);
            label6.Name = "label6";
            label6.Size = new Size(309, 20);
            label6.TabIndex = 9;
            label6.Text = "Trafik katsayısı (1,0 ile 1,5 arası bir değer) :";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(326, 217);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(125, 27);
            maskedTextBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(190, 274);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 325);
            label7.Name = "label7";
            label7.Size = new Size(223, 20);
            label7.TabIndex = 12;
            label7.Text = "Sonucunuz Burada Gözükecektir.";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(maskedTextBox5);
            Controls.Add(label6);
            Controls.Add(maskedTextBox4);
            Controls.Add(label5);
            Controls.Add(maskedTextBox3);
            Controls.Add(label4);
            Controls.Add(maskedTextBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox3;
        private Label label5;
        private MaskedTextBox maskedTextBox4;
        private Label label6;
        private MaskedTextBox maskedTextBox5;
        private Button button1;
        private Label label7;
    }
}
