namespace formsanbay
{
    partial class ThemMayBay
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtmamb = new TextBox();
            txtnamsx = new TextBox();
            txttenmb = new TextBox();
            txtsogiobay = new TextBox();
            them = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(548, 251);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "Số giờ bay :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(523, 198);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 8;
            label4.Text = "Năm sản xuất :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 251);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên máy bay :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 198);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã máy bay :";
            // 
            // txtmamb
            // 
            txtmamb.Location = new Point(299, 191);
            txtmamb.Name = "txtmamb";
            txtmamb.Size = new Size(188, 27);
            txtmamb.TabIndex = 10;
            // 
            // txtnamsx
            // 
            txtnamsx.Location = new Point(643, 191);
            txtnamsx.Name = "txtnamsx";
            txtnamsx.Size = new Size(173, 27);
            txtnamsx.TabIndex = 11;
            // 
            // txttenmb
            // 
            txttenmb.Location = new Point(299, 244);
            txttenmb.Name = "txttenmb";
            txttenmb.Size = new Size(188, 27);
            txttenmb.TabIndex = 12;
            // 
            // txtsogiobay
            // 
            txtsogiobay.Location = new Point(643, 244);
            txtsogiobay.Name = "txtsogiobay";
            txtsogiobay.Size = new Size(173, 27);
            txtsogiobay.TabIndex = 13;
            // 
            // them
            // 
            them.Location = new Point(688, 324);
            them.Name = "them";
            them.Size = new Size(128, 29);
            them.TabIndex = 14;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(358, 87);
            label1.Name = "label1";
            label1.Size = new Size(332, 35);
            label1.TabIndex = 15;
            label1.Text = "Thêm thông tin máy bay ";
            // 
            // ThemMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 452);
            Controls.Add(label1);
            Controls.Add(them);
            Controls.Add(txtsogiobay);
            Controls.Add(txttenmb);
            Controls.Add(txtnamsx);
            Controls.Add(txtmamb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ThemMayBay";
            Text = "ThemMayBay";
            Load += ThemMayBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtmamb;
        private TextBox txtnamsx;
        private TextBox txttenmb;
        private TextBox txtsogiobay;
        private Button them;
        private Label label1;
    }
}