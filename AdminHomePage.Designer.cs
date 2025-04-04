namespace Banking_management_system
{
    partial class AdminHomePage
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
            label3 = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            depositTextBox = new TextBox();
            createAccountButton = new Button();
            emailUpdateButton = new Button();
            label4 = new Label();
            label5 = new Label();
            accTypeTextBox = new TextBox();
            pwTextBox = new TextBox();
            passwordUpdateButton = new Button();
            accountDeleteButton = new Button();
            AdminComboBox1 = new ComboBox();
            adminUserDataView = new DataGridView();
            viewTransactionsButton = new Button();
            adminLogoutButton = new Button();
            nameUpdateButton = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)adminUserDataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 413);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(755, 410);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Deposit Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(768, 453);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Account Type";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(422, 410);
            nameTextBox.Margin = new Padding(4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(155, 31);
            nameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(422, 454);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(155, 31);
            emailTextBox.TabIndex = 4;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(920, 410);
            depositTextBox.Margin = new Padding(4);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(155, 31);
            depositTextBox.TabIndex = 5;
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccountButton.Location = new Point(637, 557);
            createAccountButton.Margin = new Padding(4);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(156, 36);
            createAccountButton.TabIndex = 6;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // emailUpdateButton
            // 
            emailUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailUpdateButton.Location = new Point(599, 451);
            emailUpdateButton.Margin = new Padding(4);
            emailUpdateButton.Name = "emailUpdateButton";
            emailUpdateButton.Size = new Size(118, 36);
            emailUpdateButton.TabIndex = 7;
            emailUpdateButton.Text = "Update";
            emailUpdateButton.UseVisualStyleBackColor = true;
            emailUpdateButton.Click += emailUpdateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(295, 454);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 9;
            label4.Text = "Email ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(284, 500);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // accTypeTextBox
            // 
            accTypeTextBox.Location = new Point(920, 454);
            accTypeTextBox.Margin = new Padding(4);
            accTypeTextBox.Name = "accTypeTextBox";
            accTypeTextBox.Size = new Size(155, 31);
            accTypeTextBox.TabIndex = 11;
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(422, 500);
            pwTextBox.Margin = new Padding(4);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(155, 31);
            pwTextBox.TabIndex = 12;
            // 
            // passwordUpdateButton
            // 
            passwordUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordUpdateButton.Location = new Point(599, 494);
            passwordUpdateButton.Margin = new Padding(4);
            passwordUpdateButton.Name = "passwordUpdateButton";
            passwordUpdateButton.Size = new Size(118, 36);
            passwordUpdateButton.TabIndex = 14;
            passwordUpdateButton.Text = "Update";
            passwordUpdateButton.UseVisualStyleBackColor = true;
            passwordUpdateButton.Click += passwordUpdateButton_Click;
            // 
            // accountDeleteButton
            // 
            accountDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountDeleteButton.Location = new Point(936, 20);
            accountDeleteButton.Margin = new Padding(4);
            accountDeleteButton.Name = "accountDeleteButton";
            accountDeleteButton.Size = new Size(179, 36);
            accountDeleteButton.TabIndex = 15;
            accountDeleteButton.Text = "Delete Account";
            accountDeleteButton.UseVisualStyleBackColor = true;
            accountDeleteButton.Click += accountDeleteButton_Click;
            // 
            // AdminComboBox1
            // 
            AdminComboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminComboBox1.FormattingEnabled = true;
            AdminComboBox1.Location = new Point(529, 23);
            AdminComboBox1.Margin = new Padding(4);
            AdminComboBox1.Name = "AdminComboBox1";
            AdminComboBox1.Size = new Size(358, 33);
            AdminComboBox1.TabIndex = 17;
            // 
            // adminUserDataView
            // 
            adminUserDataView.BackgroundColor = SystemColors.ButtonFace;
            adminUserDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminUserDataView.Location = new Point(187, 79);
            adminUserDataView.Margin = new Padding(4);
            adminUserDataView.Name = "adminUserDataView";
            adminUserDataView.RowHeadersWidth = 51;
            adminUserDataView.Size = new Size(1073, 309);
            adminUserDataView.TabIndex = 18;
            // 
            // viewTransactionsButton
            // 
            viewTransactionsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTransactionsButton.Location = new Point(1327, 13);
            viewTransactionsButton.Margin = new Padding(4);
            viewTransactionsButton.Name = "viewTransactionsButton";
            viewTransactionsButton.Size = new Size(205, 36);
            viewTransactionsButton.TabIndex = 19;
            viewTransactionsButton.Text = "View all transactions";
            viewTransactionsButton.UseVisualStyleBackColor = true;
            viewTransactionsButton.Click += viewTransactionsButton_Click;
            // 
            // adminLogoutButton
            // 
            adminLogoutButton.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminLogoutButton.Location = new Point(34, 555);
            adminLogoutButton.Margin = new Padding(4);
            adminLogoutButton.Name = "adminLogoutButton";
            adminLogoutButton.Size = new Size(136, 42);
            adminLogoutButton.TabIndex = 22;
            adminLogoutButton.Text = "Logout";
            adminLogoutButton.UseVisualStyleBackColor = true;
            adminLogoutButton.Click += adminLogoutButton_Click;
            // 
            // nameUpdateButton
            // 
            nameUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUpdateButton.Location = new Point(599, 407);
            nameUpdateButton.Margin = new Padding(4);
            nameUpdateButton.Name = "nameUpdateButton";
            nameUpdateButton.Size = new Size(118, 36);
            nameUpdateButton.TabIndex = 23;
            nameUpdateButton.Text = "Update";
            nameUpdateButton.UseVisualStyleBackColor = true;
            nameUpdateButton.Click += nameUpdateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(381, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 24;
            label6.Text = "Select User";
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1545, 625);
            Controls.Add(label6);
            Controls.Add(nameUpdateButton);
            Controls.Add(adminLogoutButton);
            Controls.Add(viewTransactionsButton);
            Controls.Add(adminUserDataView);
            Controls.Add(AdminComboBox1);
            Controls.Add(accountDeleteButton);
            Controls.Add(passwordUpdateButton);
            Controls.Add(pwTextBox);
            Controls.Add(accTypeTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(emailUpdateButton);
            Controls.Add(createAccountButton);
            Controls.Add(depositTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AdminHomePage";
            Text = "Admin Home Page";
            ((System.ComponentModel.ISupportInitialize)adminUserDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox depositTextBox;
        private Button createAccountButton;
        private Button emailUpdateButton;
        private Label label4;
        private Label label5;
        private TextBox accTypeTextBox;
        private TextBox pwTextBox;
        private Button passwordUpdateButton;
        private Button accountDeleteButton;
        private ComboBox AdminComboBox1;
        private DataGridView adminUserDataView;
        private Button viewTransactionsButton;
        private Button adminLogoutButton;
        private Button nameUpdateButton;
        private Label label6;
    }
}