namespace FEMyHealthApp
{
    partial class DayForm
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
            dataGridViewFood = new DataGridView();
            dataGridViewWorkouts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkouts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFood
            // 
            dataGridViewFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFood.Location = new Point(12, 107);
            dataGridViewFood.Name = "dataGridViewFood";
            dataGridViewFood.RowHeadersWidth = 51;
            dataGridViewFood.RowTemplate.Height = 29;
            dataGridViewFood.Size = new Size(382, 331);
            dataGridViewFood.TabIndex = 0;
            // 
            // dataGridViewWorkouts
            // 
            dataGridViewWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkouts.Location = new Point(406, 107);
            dataGridViewWorkouts.Name = "dataGridViewWorkouts";
            dataGridViewWorkouts.RowHeadersWidth = 51;
            dataGridViewWorkouts.RowTemplate.Height = 29;
            dataGridViewWorkouts.Size = new Size(382, 331);
            dataGridViewWorkouts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Food eaten";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 51);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Workouts done";
            // 
            // DayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewWorkouts);
            Controls.Add(dataGridViewFood);
            Name = "DayForm";
            Text = "DayForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkouts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFood;
        private DataGridView dataGridViewWorkouts;
        private Label label1;
        private Label label2;
    }
}