namespace Banking_management_system
{
    partial class UserTransacHistory
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
            userDataGridView2 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView2).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView2
            // 
            userDataGridView2.BackgroundColor = SystemColors.ButtonFace;
            userDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView2.Location = new Point(39, 106);
            userDataGridView2.Margin = new Padding(4);
            userDataGridView2.Name = "userDataGridView2";
            userDataGridView2.RowHeadersWidth = 51;
            userDataGridView2.Size = new Size(1048, 398);
            userDataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 45);
            label1.TabIndex = 1;
            label1.Text = "Transaction history";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 512);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 2;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserTransacHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1111, 584);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(userDataGridView2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserTransacHistory";
            Text = "User transaction history";
            Load += UserTransacHistory_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userDataGridView2;
        private Label label1;
        private Button button1;
    }
}