namespace formsanbay
{
    partial class sanbay
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
            datamaybay = new DataGridView();
            label1 = new Label();
            btnthem = new Button();
            btnsua = new Button();
            ((System.ComponentModel.ISupportInitialize)datamaybay).BeginInit();
            SuspendLayout();
            // 
            // datamaybay
            // 
            datamaybay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datamaybay.Location = new Point(163, 86);
            datamaybay.Name = "datamaybay";
            datamaybay.RowHeadersWidth = 51;
            datamaybay.Size = new Size(583, 243);
            datamaybay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 34);
            label1.Name = "label1";
            label1.Size = new Size(325, 35);
            label1.TabIndex = 1;
            label1.Text = "Bảng thông tin máy bay ";
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(164, 366);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(135, 29);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm máy bay";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += button1_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(635, 366);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(111, 29);
            btnsua.TabIndex = 3;
            btnsua.Text = "Sửa máy bay";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // sanbay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 503);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(label1);
            Controls.Add(datamaybay);
            Name = "sanbay";
            Text = "Form1";
            Load += sanbay_Load;
            ((System.ComponentModel.ISupportInitialize)datamaybay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datamaybay;
        private Label label1;
        private Button btnthem;
        private Button btnsua;
    }
}
