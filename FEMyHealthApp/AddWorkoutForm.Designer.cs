namespace FEMyHealthApp
{
    partial class AddWorkoutForm
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
            buttonSaveWorkout = new Button();
            textBoxCaloriesBurnt = new TextBox();
            textBoxWorkoutName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonSaveWorkout
            // 
            buttonSaveWorkout.Location = new Point(130, 119);
            buttonSaveWorkout.Name = "buttonSaveWorkout";
            buttonSaveWorkout.Size = new Size(111, 29);
            buttonSaveWorkout.TabIndex = 9;
            buttonSaveWorkout.Text = "Save workout";
            buttonSaveWorkout.UseVisualStyleBackColor = true;
            buttonSaveWorkout.Click += buttonSaveWorkout_Click;
            // 
            // textBoxCaloriesBurnt
            // 
            textBoxCaloriesBurnt.Location = new Point(190, 73);
            textBoxCaloriesBurnt.Name = "textBoxCaloriesBurnt";
            textBoxCaloriesBurnt.Size = new Size(112, 27);
            textBoxCaloriesBurnt.TabIndex = 8;
            // 
            // textBoxWorkoutName
            // 
            textBoxWorkoutName.Location = new Point(190, 38);
            textBoxWorkoutName.Name = "textBoxWorkoutName";
            textBoxWorkoutName.Size = new Size(112, 27);
            textBoxWorkoutName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 6;
            label2.Text = "Calories burnt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Workout name:";
            // 
            // AddWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 186);
            Controls.Add(buttonSaveWorkout);
            Controls.Add(textBoxCaloriesBurnt);
            Controls.Add(textBoxWorkoutName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddWorkoutForm";
            Text = "AddWorkoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveWorkout;
        private TextBox textBoxCaloriesBurnt;
        private TextBox textBoxWorkoutName;
        private Label label2;
        private Label label1;
    }
}