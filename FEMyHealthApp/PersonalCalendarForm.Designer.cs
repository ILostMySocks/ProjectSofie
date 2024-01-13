namespace FEMyHealthApp
{
    partial class PersonalCalendarForm
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
            button2 = new Button();
            button1 = new Button();
            dataGridViewHealthCalendar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHealthCalendar).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(42, 287);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 1;
            button2.Text = "Add workout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(42, 252);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 2;
            button1.Text = "Add food";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHealthCalendar
            // 
            dataGridViewHealthCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHealthCalendar.Location = new Point(42, 27);
            dataGridViewHealthCalendar.Name = "dataGridViewHealthCalendar";
            dataGridViewHealthCalendar.RowHeadersWidth = 51;
            dataGridViewHealthCalendar.RowTemplate.Height = 29;
            dataGridViewHealthCalendar.Size = new Size(711, 188);
            dataGridViewHealthCalendar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 261);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 4;
            label1.Text = "Total calories eaten:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 291);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 5;
            label2.Text = "Total calories burnt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 350);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 6;
            label3.Text = "Average calories burnt/day:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 320);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 7;
            label4.Text = "Average calories eaten/day:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 261);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 8;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(697, 320);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 350);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 10;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 291);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 11;
            label8.Text = "0";
            // 
            // PersonalCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewHealthCalendar);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "PersonalCalendar";
            Text = "Personal Health Calendar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHealthCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DataGridView dataGridViewHealthCalendar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}