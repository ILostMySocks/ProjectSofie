namespace FEMyHealthApp
{
    partial class AddFoodForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxFoodName = new TextBox();
            textBoxCalorieCount = new TextBox();
            buttonSaveFood = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Food name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 80);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Calorie count:";
            // 
            // textBoxFoodName
            // 
            textBoxFoodName.Location = new Point(190, 38);
            textBoxFoodName.Name = "textBoxFoodName";
            textBoxFoodName.Size = new Size(112, 27);
            textBoxFoodName.TabIndex = 2;
            // 
            // textBoxCalorieCount
            // 
            textBoxCalorieCount.Location = new Point(190, 73);
            textBoxCalorieCount.Name = "textBoxCalorieCount";
            textBoxCalorieCount.Size = new Size(112, 27);
            textBoxCalorieCount.TabIndex = 3;
            // 
            // buttonSaveFood
            // 
            buttonSaveFood.Location = new Point(140, 119);
            buttonSaveFood.Name = "buttonSaveFood";
            buttonSaveFood.Size = new Size(94, 29);
            buttonSaveFood.TabIndex = 4;
            buttonSaveFood.Text = "Save food";
            buttonSaveFood.UseVisualStyleBackColor = true;
            buttonSaveFood.Click += buttonSaveFood_Click;
            // 
            // AddFoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 186);
            Controls.Add(buttonSaveFood);
            Controls.Add(textBoxCalorieCount);
            Controls.Add(textBoxFoodName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFoodForm";
            Text = "AddFoodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFoodName;
        private TextBox textBoxCalorieCount;
        private Button buttonSaveFood;
    }
}