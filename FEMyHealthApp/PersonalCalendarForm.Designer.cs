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
            buttonAddWorkout = new Button();
            buttonAddFood = new Button();
            dataGridViewHealthCalendar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelCaloriesEatenTotal = new Label();
            labelCaloriesEatenAverage = new Label();
            labelCaloriesBurntAverage = new Label();
            labelCaloriesBurntTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHealthCalendar).BeginInit();
            SuspendLayout();
            // 
            // buttonAddWorkout
            // 
            buttonAddWorkout.Location = new Point(42, 287);
            buttonAddWorkout.Name = "buttonAddWorkout";
            buttonAddWorkout.Size = new Size(122, 29);
            buttonAddWorkout.TabIndex = 1;
            buttonAddWorkout.Text = "Add workout";
            buttonAddWorkout.UseVisualStyleBackColor = true;
            buttonAddWorkout.Click += buttonAddWorkout_Click;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Location = new Point(42, 252);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(122, 29);
            buttonAddFood.TabIndex = 2;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
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
            label3.Location = new Point(458, 349);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 6;
            label3.Text = "Average calories burnt/day:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 320);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 7;
            label4.Text = "Average calories eaten/day:";
            // 
            // labelCaloriesEatenTotal
            // 
            labelCaloriesEatenTotal.AutoSize = true;
            labelCaloriesEatenTotal.Location = new Point(697, 261);
            labelCaloriesEatenTotal.Name = "labelCaloriesEatenTotal";
            labelCaloriesEatenTotal.Size = new Size(17, 20);
            labelCaloriesEatenTotal.TabIndex = 8;
            labelCaloriesEatenTotal.Text = "0";
            // 
            // labelCaloriesEatenAverage
            // 
            labelCaloriesEatenAverage.AutoSize = true;
            labelCaloriesEatenAverage.Location = new Point(697, 320);
            labelCaloriesEatenAverage.Name = "labelCaloriesEatenAverage";
            labelCaloriesEatenAverage.Size = new Size(17, 20);
            labelCaloriesEatenAverage.TabIndex = 9;
            labelCaloriesEatenAverage.Text = "0";
            // 
            // labelCaloriesBurntAverage
            // 
            labelCaloriesBurntAverage.AutoSize = true;
            labelCaloriesBurntAverage.Location = new Point(697, 349);
            labelCaloriesBurntAverage.Name = "labelCaloriesBurntAverage";
            labelCaloriesBurntAverage.Size = new Size(17, 20);
            labelCaloriesBurntAverage.TabIndex = 10;
            labelCaloriesBurntAverage.Text = "0";
            // 
            // labelCaloriesBurntTotal
            // 
            labelCaloriesBurntTotal.AutoSize = true;
            labelCaloriesBurntTotal.Location = new Point(697, 291);
            labelCaloriesBurntTotal.Name = "labelCaloriesBurntTotal";
            labelCaloriesBurntTotal.Size = new Size(17, 20);
            labelCaloriesBurntTotal.TabIndex = 11;
            labelCaloriesBurntTotal.Text = "0";
            // 
            // PersonalCalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(labelCaloriesBurntTotal);
            Controls.Add(labelCaloriesBurntAverage);
            Controls.Add(labelCaloriesEatenAverage);
            Controls.Add(labelCaloriesEatenTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewHealthCalendar);
            Controls.Add(buttonAddFood);
            Controls.Add(buttonAddWorkout);
            Name = "PersonalCalendarForm";
            Text = "Personal Health Calendar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHealthCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddWorkout;
        private Button buttonAddFood;
        private DataGridView dataGridViewHealthCalendar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelCaloriesEatenTotal;
        private Label labelCaloriesEatenAverage;
        private Label labelCaloriesBurntAverage;
        private Label labelCaloriesBurntTotal;
    }
}