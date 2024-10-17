namespace тестирование_1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(159, 291);
            button1.Name = "button1";
            button1.Size = new Size(183, 53);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(10, 137);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 1;
            label1.Text = "Сторона 1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(159, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 43);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(159, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 43);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(10, 186);
            label2.Name = "label2";
            label2.Size = new Size(145, 37);
            label2.TabIndex = 3;
            label2.Text = "Сторона 2";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(159, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 43);
            textBox3.TabIndex = 6;
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(10, 235);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 5;
            label3.Text = "Сторона 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(359, 186);
            label4.Name = "label4";
            label4.Size = new Size(141, 37);
            label4.TabIndex = 7;
            label4.Text = "Результат:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(365, 232);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 43);
            textBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(366, 291);
            button2.Name = "button2";
            button2.Size = new Size(262, 53);
            button2.TabIndex = 9;
            button2.Text = "Сбросить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(330, 37);
            label5.TabIndex = 10;
            label5.Text = "Какой вид треугольника?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 72);
            label6.Name = "label6";
            label6.Size = new Size(378, 15);
            label6.TabIndex = 11;
            label6.Text = "введите три стороны треугольника и нажмите кнопку \"Рассчитать\"";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 93);
            label7.Name = "label7";
            label7.Size = new Size(390, 15);
            label7.TabIndex = 12;
            label7.Text = "Если необходимо повторить процедуру, нажмите кнопку \"Сбросить\"";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(12, 72);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 13;
            label8.Text = "Инструкция:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 404);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
