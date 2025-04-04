namespace Banking_management_system
{
    partial class UserHomePage
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
            AccountNumTextBox = new TextBox();
            UserDataGridView1 = new DataGridView();
            emailTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pwTextBox = new TextBox();
            emailUpdateButton = new Button();
            pwUpdateButton = new Button();
            userTransactionbutton = new Button();
            depositButton = new Button();
            label5 = new Label();
            AmountTextBox = new TextBox();
            withdrawButton = new Button();
            label6 = new Label();
            RecipientAccNumTextBox = new TextBox();
            transferButton = new Button();
            button1 = new Button();
            viewUserDetailsButton = new Button();
            userNametTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "User acct. No.";
            // 
            // AccountNumTextBox
            // 
            AccountNumTextBox.Location = new Point(638, 13);
            AccountNumTextBox.Margin = new Padding(4);
            AccountNumTextBox.Name = "AccountNumTextBox";
            AccountNumTextBox.Size = new Size(155, 31);
            AccountNumTextBox.TabIndex = 1;
            // 
            // UserDataGridView1
            // 
            UserDataGridView1.BackgroundColor = SystemColors.ButtonFace;
            UserDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView1.Location = new Point(203, 96);
            UserDataGridView1.Margin = new Padding(4);
            UserDataGridView1.Name = "UserDataGridView1";
            UserDataGridView1.RowHeadersWidth = 51;
            UserDataGridView1.Size = new Size(1051, 127);
            UserDataGridView1.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(181, 401);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(155, 31);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 405);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "Email Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 456);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(181, 455);
            pwTextBox.Margin = new Padding(4);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(155, 31);
            pwTextBox.TabIndex = 8;
            // 
            // emailUpdateButton
            // 
            emailUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailUpdateButton.Location = new Point(360, 401);
            emailUpdateButton.Margin = new Padding(4);
            emailUpdateButton.Name = "emailUpdateButton";
            emailUpdateButton.Size = new Size(118, 36);
            emailUpdateButton.TabIndex = 10;
            emailUpdateButton.Text = "Update";
            emailUpdateButton.UseVisualStyleBackColor = true;
            emailUpdateButton.Click += emailUpdateButton_Click;
            // 
            // pwUpdateButton
            // 
            pwUpdateButton.BackColor = Color.White;
            pwUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwUpdateButton.Location = new Point(360, 455);
            pwUpdateButton.Margin = new Padding(4);
            pwUpdateButton.Name = "pwUpdateButton";
            pwUpdateButton.Size = new Size(118, 36);
            pwUpdateButton.TabIndex = 11;
            pwUpdateButton.Text = "Update";
            pwUpdateButton.UseVisualStyleBackColor = false;
            pwUpdateButton.Click += pwUpdateButton_Click;
            // 
            // userTransactionbutton
            // 
            userTransactionbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTransactionbutton.Location = new Point(602, 253);
            userTransactionbutton.Margin = new Padding(4);
            userTransactionbutton.Name = "userTransactionbutton";
            userTransactionbutton.Size = new Size(236, 36);
            userTransactionbutton.TabIndex = 12;
            userTransactionbutton.Text = "View transaction history";
            userTransactionbutton.UseVisualStyleBackColor = true;
            userTransactionbutton.Click += userTransactionButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.Location = new Point(1100, 374);
            depositButton.Margin = new Padding(4);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(154, 36);
            depositButton.TabIndex = 13;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(736, 400);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 14;
            label5.Text = "Enter Amount";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(907, 397);
            AmountTextBox.Margin = new Padding(4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(155, 31);
            AmountTextBox.TabIndex = 15;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.Location = new Point(1100, 421);
            withdrawButton.Margin = new Padding(4);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(154, 36);
            withdrawButton.TabIndex = 16;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(722, 503);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 17;
            label6.Text = "Recipient acct. No. ";
            // 
            // RecipientAccNumTextBox
            // 
            RecipientAccNumTextBox.Location = new Point(909, 503);
            RecipientAccNumTextBox.Margin = new Padding(4);
            RecipientAccNumTextBox.Name = "RecipientAccNumTextBox";
            RecipientAccNumTextBox.Size = new Size(155, 31);
            RecipientAccNumTextBox.TabIndex = 18;
            // 
            // transferButton
            // 
            transferButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferButton.Location = new Point(1102, 501);
            transferButton.Margin = new Padding(4);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(154, 36);
            transferButton.TabIndex = 19;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 535);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 20;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewUserDetailsButton
            // 
            viewUserDetailsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUserDetailsButton.Location = new Point(634, 52);
            viewUserDetailsButton.Margin = new Padding(4);
            viewUserDetailsButton.Name = "viewUserDetailsButton";
            viewUserDetailsButton.Size = new Size(169, 36);
            viewUserDetailsButton.TabIndex = 21;
            viewUserDetailsButton.Text = "View acc. details";
            viewUserDetailsButton.UseVisualStyleBackColor = true;
            viewUserDetailsButton.Click += viewUserDetailsButton_Click;
            // 
            // userNametTextBox
            // 
            userNametTextBox.Location = new Point(602, 557);
            userNametTextBox.Margin = new Padding(4);
            userNametTextBox.Name = "userNametTextBox";
            userNametTextBox.Size = new Size(155, 31);
            userNametTextBox.TabIndex = 4;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1418, 630);
            Controls.Add(viewUserDetailsButton);
            Controls.Add(button1);
            Controls.Add(transferButton);
            Controls.Add(RecipientAccNumTextBox);
            Controls.Add(label6);
            Controls.Add(withdrawButton);
            Controls.Add(AmountTextBox);
            Controls.Add(label5);
            Controls.Add(depositButton);
            Controls.Add(userTransactionbutton);
            Controls.Add(pwUpdateButton);
            Controls.Add(emailUpdateButton);
            Controls.Add(pwTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(userNametTextBox);
            Controls.Add(UserDataGridView1);
            Controls.Add(AccountNumTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserHomePage";
            Text = "User Home ";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AccountNumTextBox;
        private DataGridView UserDataGridView1;
        private TextBox emailTextBox;
        private Label label3;
        private Label label4;
        private TextBox pwTextBox;
        private Button emailUpdateButton;
        private Button pwUpdateButton;
        private Button userTransactionbutton;
        private Button depositButton;
        private Label label5;
        private TextBox AmountTextBox;
        private Button withdrawButton;
        private Label label6;
        private TextBox RecipientAccNumTextBox;
        private Button transferButton;
        private Button button1;
        private Button viewUserDetailsButton;
        private TextBox userNametTextBox;
    }
}