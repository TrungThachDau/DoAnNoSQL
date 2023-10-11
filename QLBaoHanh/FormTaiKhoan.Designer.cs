namespace QLBaoHanh
{
    partial class FormTaiKhoan
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
            dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvTaiKhoan.Location = new System.Drawing.Point(12, 12);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 57;
            dgvTaiKhoan.RowTemplate.Height = 32;
            dgvTaiKhoan.Size = new System.Drawing.Size(735, 238);
            dgvTaiKhoan.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Taikhoan";
            Column1.HeaderText = "Tài khoản";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Hoten";
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quyen";
            Column3.HeaderText = "Quyền";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 140;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(160, 356);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 32);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(350, 358);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 32);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(547, 365);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(105, 32);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(765, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvTaiKhoan);
            Name = "FormTaiKhoan";
            Text = "FormTaiKhoan";
            Load += FormTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}