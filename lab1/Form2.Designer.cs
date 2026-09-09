namespace lab1
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Location = new Point(399, 361);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "N =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 84);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Медіана t*:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 114);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 3;
            label3.Text = "Кількість днів t*>med:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(18, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(267, 374);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "10";
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Location = new Point(476, 25);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 7;
            button2.Text = "Обрахувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Температура дня";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Одновимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
    }
}