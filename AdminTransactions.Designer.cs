namespace Banking_management_system
{
    partial class AdminTransactions
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
            adminDataGridView2 = new DataGridView();
            button1 = new Button();
            adminDataGridView3 = new DataGridView();
            adminComboBox2 = new ComboBox();
            viewUserTransacButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1014, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 0;
            label1.Text = "Every Transactions";
            // 
            // adminDataGridView2
            // 
            adminDataGridView2.BackgroundColor = SystemColors.ButtonFace;
            adminDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView2.Location = new Point(884, 127);
            adminDataGridView2.Margin = new Padding(4);
            adminDataGridView2.Name = "adminDataGridView2";
            adminDataGridView2.RowHeadersWidth = 51;
            adminDataGridView2.Size = new Size(582, 434);
            adminDataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 511);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 4;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adminDataGridView3
            // 
            adminDataGridView3.BackgroundColor = SystemColors.ButtonFace;
            adminDataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView3.Location = new Point(81, 127);
            adminDataGridView3.Margin = new Padding(4);
            adminDataGridView3.Name = "adminDataGridView3";
            adminDataGridView3.RowHeadersWidth = 51;
            adminDataGridView3.Size = new Size(596, 331);
            adminDataGridView3.TabIndex = 5;
            // 
            // adminComboBox2
            // 
            adminComboBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminComboBox2.FormattingEnabled = true;
            adminComboBox2.Location = new Point(154, 86);
            adminComboBox2.Margin = new Padding(4);
            adminComboBox2.Name = "adminComboBox2";
            adminComboBox2.Size = new Size(264, 33);
            adminComboBox2.TabIndex = 6;
            // 
            // viewUserTransacButton
            // 
            viewUserTransacButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUserTransacButton.Location = new Point(446, 83);
            viewUserTransacButton.Margin = new Padding(4);
            viewUserTransacButton.Name = "viewUserTransacButton";
            viewUserTransacButton.Size = new Size(178, 36);
            viewUserTransacButton.TabIndex = 7;
            viewUserTransacButton.Text = "View transaction";
            viewUserTransacButton.UseVisualStyleBackColor = true;
            viewUserTransacButton.Click += viewUserTransacButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(341, 45);
            label2.TabIndex = 8;
            label2.Text = "Each User transaction";
            // 
            // AdminTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1592, 574);
            Controls.Add(label2);
            Controls.Add(viewUserTransacButton);
            Controls.Add(adminComboBox2);
            Controls.Add(adminDataGridView3);
            Controls.Add(button1);
            Controls.Add(adminDataGridView2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AdminTransactions";
            Text = "Admin Transactions";
            Load += AdminTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView adminDataGridView2;
        private Button button1;
        private DataGridView adminDataGridView3;
        private ComboBox adminComboBox2;
        private Button viewUserTransacButton;
        private Label label2;
    }
}