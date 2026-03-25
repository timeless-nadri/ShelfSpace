namespace ShelfSpace.Forms
{
    partial class FirstRunForm
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
            lblTitle = new Label();
            lblQuestion = new Label();
            txtUserName = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(101, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Willkommen bei ShelfSpace!";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(111, 96);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(158, 15);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Wie dürfen wir dich nennen?";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(137, 137);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(149, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Speichern und starten";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(150, 204);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FirstRunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtUserName);
            Controls.Add(lblQuestion);
            Controls.Add(lblTitle);
            Name = "FirstRunForm";
            Text = "FirstRunForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestion;
        private TextBox txtUserName;
        private Button btnSave;
        private Button btnExit;
    }
}