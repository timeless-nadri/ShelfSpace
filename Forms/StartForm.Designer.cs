namespace ShelfSpace
{
    partial class StartForm
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
            lblWelcome = new Label();
            btnOpenLibrary = new Button();
            btnAddBook = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(66, 42);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(230, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Willkommen, was möchtest du heute tun?";
            // 
            // btnOpenLibrary
            // 
            btnOpenLibrary.Location = new Point(162, 139);
            btnOpenLibrary.Name = "btnOpenLibrary";
            btnOpenLibrary.Size = new Size(183, 23);
            btnOpenLibrary.TabIndex = 1;
            btnOpenLibrary.Text = "Bibliothek öffnen";
            btnOpenLibrary.UseVisualStyleBackColor = true;
            btnOpenLibrary.Click += btnOpenLibrary_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(162, 168);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(183, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Buch hinzufügen";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(162, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAddBook);
            Controls.Add(btnOpenLibrary);
            Controls.Add(lblWelcome);
            Name = "StartForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnOpenLibrary;
        private Button btnAddBook;
        private Button btnExit;
    }
}
