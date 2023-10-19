namespace note_taking_app
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
            Title = new Label();
            label1 = new Label();
            textTitle = new TextBox();
            textMessageBox = new TextBox();
            dataGridView1 = new DataGridView();
            buttonNew = new Button();
            buttonSave = new Button();
            buttonRead = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(72, 84);
            Title.Name = "Title";
            Title.Size = new Size(29, 15);
            Title.TabIndex = 0;
            Title.Text = "Title";
            Title.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 177);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Message";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(72, 102);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(275, 23);
            textTitle.TabIndex = 2;
            textTitle.TextChanged += textTitle_TextChanged;
            // 
            // textMessageBox
            // 
            textMessageBox.Location = new Point(72, 206);
            textMessageBox.Multiline = true;
            textMessageBox.Name = "textMessageBox";
            textMessageBox.Size = new Size(333, 174);
            textMessageBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(290, 300);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(103, 403);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(70, 35);
            buttonNew.TabIndex = 5;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(277, 403);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(70, 35);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(491, 403);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(70, 35);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(667, 403);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(70, 35);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRead);
            Controls.Add(buttonSave);
            Controls.Add(buttonNew);
            Controls.Add(dataGridView1);
            Controls.Add(textMessageBox);
            Controls.Add(textTitle);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Title;
        private Label label1;
        private TextBox textTitle;
        private TextBox textMessageBox;
        private DataGridView dataGridView1;
        private Button buttonNew;
        private Button buttonSave;
        private Button buttonRead;
        private Button buttonDelete;
    }
}