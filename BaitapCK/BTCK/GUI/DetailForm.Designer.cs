namespace BTCK.Views
{
    partial class DetailForm
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
            this.labelMa = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelNNH = new System.Windows.Forms.Label();
            this.labelNCC = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTinhTP = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.dateTimePickerNNH = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTinhTP = new System.Windows.Forms.ComboBox();
            this.comboBoxNCC = new System.Windows.Forms.ComboBox();
            this.labelSLSP = new System.Windows.Forms.Label();
            this.textBoxSLSP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMa.Location = new System.Drawing.Point(30, 57);
            this.labelMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(106, 21);
            this.labelMa.TabIndex = 0;
            this.labelMa.Text = "Mã sản phẩm";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(30, 129);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên sản phẩm";
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(30, 203);
            this.labelGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(73, 21);
            this.labelGia.TabIndex = 0;
            this.labelGia.Text = "Giá nhập";
            // 
            // labelNNH
            // 
            this.labelNNH.AutoSize = true;
            this.labelNNH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNNH.Location = new System.Drawing.Point(500, 57);
            this.labelNNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNNH.Name = "labelNNH";
            this.labelNNH.Size = new System.Drawing.Size(128, 21);
            this.labelNNH.TabIndex = 0;
            this.labelNNH.Text = "Ngày nhập hàng";
            // 
            // labelNCC
            // 
            this.labelNCC.AutoSize = true;
            this.labelNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCC.Location = new System.Drawing.Point(500, 203);
            this.labelNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNCC.Name = "labelNCC";
            this.labelNCC.Size = new System.Drawing.Size(109, 21);
            this.labelNCC.TabIndex = 0;
            this.labelNCC.Text = "Nhà cung cấp";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(304, 328);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 37);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTinhTP
            // 
            this.labelTinhTP.AutoSize = true;
            this.labelTinhTP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhTP.Location = new System.Drawing.Point(500, 129);
            this.labelTinhTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTinhTP.Name = "labelTinhTP";
            this.labelTinhTP.Size = new System.Drawing.Size(66, 21);
            this.labelTinhTP.TabIndex = 0;
            this.labelTinhTP.Text = "Tỉnh/TP";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(614, 328);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 37);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(199, 199);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(270, 29);
            this.textBoxGia.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(199, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(199, 53);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(270, 29);
            this.textBoxMa.TabIndex = 2;
            // 
            // dateTimePickerNNH
            // 
            this.dateTimePickerNNH.Location = new System.Drawing.Point(661, 57);
            this.dateTimePickerNNH.Name = "dateTimePickerNNH";
            this.dateTimePickerNNH.Size = new System.Drawing.Size(283, 29);
            this.dateTimePickerNNH.TabIndex = 3;
            // 
            // comboBoxTinhTP
            // 
            this.comboBoxTinhTP.FormattingEnabled = true;
            this.comboBoxTinhTP.Location = new System.Drawing.Point(661, 126);
            this.comboBoxTinhTP.Name = "comboBoxTinhTP";
            this.comboBoxTinhTP.Size = new System.Drawing.Size(283, 29);
            this.comboBoxTinhTP.TabIndex = 4;
            this.comboBoxTinhTP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhTP_SelectedIndexChanged);
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.Location = new System.Drawing.Point(661, 195);
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(283, 29);
            this.comboBoxNCC.TabIndex = 4;
            // 
            // labelSLSP
            // 
            this.labelSLSP.AutoSize = true;
            this.labelSLSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSLSP.Location = new System.Drawing.Point(30, 274);
            this.labelSLSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSLSP.Name = "labelSLSP";
            this.labelSLSP.Size = new System.Drawing.Size(149, 21);
            this.labelSLSP.TabIndex = 0;
            this.labelSLSP.Text = "Số lượng sản phẩm";
            // 
            // textBoxSLSP
            // 
            this.textBoxSLSP.Location = new System.Drawing.Point(199, 271);
            this.textBoxSLSP.Name = "textBoxSLSP";
            this.textBoxSLSP.Size = new System.Drawing.Size(270, 29);
            this.textBoxSLSP.TabIndex = 2;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 397);
            this.Controls.Add(this.comboBoxNCC);
            this.Controls.Add(this.comboBoxTinhTP);
            this.Controls.Add(this.dateTimePickerNNH);
            this.Controls.Add(this.textBoxMa);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSLSP);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTinhTP);
            this.Controls.Add(this.labelNCC);
            this.Controls.Add(this.labelSLSP);
            this.Controls.Add(this.labelNNH);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMa);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailForm";
            this.Text = "102200311_DF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelNNH;
        private System.Windows.Forms.Label labelNCC;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTinhTP;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.DateTimePicker dateTimePickerNNH;
        private System.Windows.Forms.ComboBox comboBoxTinhTP;
        private System.Windows.Forms.ComboBox comboBoxNCC;
        private System.Windows.Forms.Label labelSLSP;
        private System.Windows.Forms.TextBox textBoxSLSP;
    }
}