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
            button2.Location = new Point(37, 215);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 22);
            button2.TabIndex = 1;
            button2.Text = "Add workout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(37, 189);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 22);
            button1.TabIndex = 2;
            button1.Text = "Add food";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHealthCalendar
            // 
            dataGridViewHealthCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHealthCalendar.Location = new Point(37, 20);
            dataGridViewHealthCalendar.Margin = new Padding(3, 2, 3, 2);
            dataGridViewHealthCalendar.Name = "dataGridViewHealthCalendar";
            dataGridViewHealthCalendar.RowHeadersWidth = 51;
            dataGridViewHealthCalendar.RowTemplate.Height = 29;
            dataGridViewHealthCalendar.Size = new Size(622, 141);
            dataGridViewHealthCalendar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 196);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Total calories eaten:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 218);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 5;
            label2.Text = "Total calories burnt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 262);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 6;
            label3.Text = "Average calories burnt/day:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 240);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 7;
            label4.Text = "Average calories eaten/day:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 196);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 8;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(610, 240);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(610, 262);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 10;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(610, 218);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 11;
            label8.Text = "0";
            // 
            // PersonalCalendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonalCalendarForm";
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