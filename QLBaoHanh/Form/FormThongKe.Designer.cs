namespace QLBaoHanh
{
    partial class FormThongKe
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            btn_thongke = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txt_doanhthu = new System.Windows.Forms.TextBox();
            txt_nhap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-8, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1185, 447);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Firebrick;
            label1.Location = new System.Drawing.Point(367, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(455, 65);
            label1.TabIndex = 1;
            label1.Text = "Thống kê doanh thu";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(838, 157);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(56, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tất cả";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(900, 157);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(51, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Năm";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(957, 157);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(58, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tháng";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btn_thongke
            // 
            btn_thongke.Location = new System.Drawing.Point(1035, 181);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new System.Drawing.Size(142, 23);
            btn_thongke.TabIndex = 10;
            btn_thongke.Text = "Thống kê";
            btn_thongke.UseVisualStyleBackColor = true;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(838, 679);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 32);
            label2.TabIndex = 11;
            label2.Text = "Tổng doanh thu";
            // 
            // txt_doanhthu
            // 
            txt_doanhthu.Location = new System.Drawing.Point(1046, 688);
            txt_doanhthu.Name = "txt_doanhthu";
            txt_doanhthu.Size = new System.Drawing.Size(131, 23);
            txt_doanhthu.TabIndex = 12;
            // 
            // txt_nhap
            // 
            txt_nhap.Location = new System.Drawing.Point(838, 182);
            txt_nhap.Name = "txt_nhap";
            txt_nhap.Size = new System.Drawing.Size(174, 23);
            txt_nhap.TabIndex = 13;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1189, 756);
            Controls.Add(txt_nhap);
            Controls.Add(txt_doanhthu);
            Controls.Add(label2);
            Controls.Add(btn_thongke);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormThongKe";
            ShowIcon = false;
            Text = " Thống kê doanh thu";
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.TextBox txt_nhap;
    }
}