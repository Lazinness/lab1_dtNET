namespace lab1
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(371, 389);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(470, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "5";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(470, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 3;
            label1.Text = "N =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 78);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "M =";
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Location = new Point(442, 371);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 5;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Location = new Point(442, 119);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 6;
            button2.Text = "Обрахувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 168);
            label3.Name = "label3";
            label3.Size = new Size(141, 40);
            label3.TabIndex = 7;
            label3.Text = "Кількість <0 нижче\r\nлівої діагоналі:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}