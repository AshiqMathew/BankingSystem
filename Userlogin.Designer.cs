namespace Banking_management_system
{
    partial class Userlogin
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
            emailTextBox = new TextBox();
            pwTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 244);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(423, 162);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(198, 31);
            emailTextBox.TabIndex = 2;
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(423, 238);
            pwTextBox.Margin = new Padding(4);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(198, 31);
            pwTextBox.TabIndex = 3;
            pwTextBox.TextChanged += pwTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 315);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(144, 67);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(63, 471);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(91, 36);
            button2.TabIndex = 5;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Userlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 535);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pwTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Userlogin";
            Text = "User login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox pwTextBox;
        private Button button1;
        private Button button2;
    }
}