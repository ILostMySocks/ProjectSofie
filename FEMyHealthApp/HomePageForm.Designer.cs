namespace FEMyHealthApp
{
    partial class HomePageForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            buttonSearch = new Button();
            dataGridViewSearchResults = new DataGridView();
            buttonAddNewPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 68);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Find your personal calendar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 157);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 192);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 227);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.AccessibleRole = AccessibleRole.ButtonMenu;
            textBoxFirstName.Location = new Point(155, 157);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(217, 27);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(155, 193);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(217, 27);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(155, 227);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(142, 297);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(143, 36);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewSearchResults
            // 
            dataGridViewSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResults.Location = new Point(429, 68);
            dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            dataGridViewSearchResults.RowHeadersWidth = 51;
            dataGridViewSearchResults.RowTemplate.Height = 29;
            dataGridViewSearchResults.Size = new Size(318, 315);
            dataGridViewSearchResults.TabIndex = 8;
            // 
            // buttonAddNewPerson
            // 
            buttonAddNewPerson.Location = new Point(142, 339);
            buttonAddNewPerson.Name = "buttonAddNewPerson";
            buttonAddNewPerson.Size = new Size(143, 36);
            buttonAddNewPerson.TabIndex = 9;
            buttonAddNewPerson.Text = "Add new person";
            buttonAddNewPerson.UseVisualStyleBackColor = true;
            buttonAddNewPerson.Click += buttonAddNewPerson_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonAddNewPerson);
            Controls.Add(dataGridViewSearchResults);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomePageForm";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private Button buttonSearch;
        private DataGridView dataGridViewSearchResults;
        private Button buttonAddNewPerson;
    }
}