namespace _102200311_TranNhatMinh.GUI
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
            delChangeButtonState();
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
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.textBoxDBT = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDBT = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLSH = new System.Windows.Forms.ComboBox();
            this.comboBoxHP = new System.Windows.Forms.ComboBox();
            this.labelNgayThi = new System.Windows.Forms.Label();
            this.labelLSH = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDGK = new System.Windows.Forms.TextBox();
            this.labelDGK = new System.Windows.Forms.Label();
            this.textBoxDCK = new System.Windows.Forms.TextBox();
            this.labelDTK = new System.Windows.Forms.Label();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.labelTK = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(199, 55);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(243, 29);
            this.textBoxMa.TabIndex = 0;
            // 
            // textBoxDBT
            // 
            this.textBoxDBT.Location = new System.Drawing.Point(682, 131);
            this.textBoxDBT.Name = "textBoxDBT";
            this.textBoxDBT.Size = new System.Drawing.Size(243, 29);
            this.textBoxDBT.TabIndex = 0;
            this.textBoxDBT.TextChanged += new System.EventHandler(this.textBoxDiem_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(199, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 29);
            this.textBoxName.TabIndex = 0;
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(82, 59);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(53, 21);
            this.labelMa.TabIndex = 1;
            this.labelMa.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // labelDBT
            // 
            this.labelDBT.AutoSize = true;
            this.labelDBT.Location = new System.Drawing.Point(525, 135);
            this.labelDBT.Name = "labelDBT";
            this.labelDBT.Size = new System.Drawing.Size(70, 21);
            this.labelDBT.TabIndex = 1;
            this.labelDBT.Text = "Điểm BT";
            // 
            // dateTimePickerNgayThi
            // 
            this.dateTimePickerNgayThi.Location = new System.Drawing.Point(682, 55);
            this.dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            this.dateTimePickerNgayThi.Size = new System.Drawing.Size(281, 29);
            this.dateTimePickerNgayThi.TabIndex = 2;
            // 
            // comboBoxLSH
            // 
            this.comboBoxLSH.FormattingEnabled = true;
            this.comboBoxLSH.Location = new System.Drawing.Point(199, 216);
            this.comboBoxLSH.Name = "comboBoxLSH";
            this.comboBoxLSH.Size = new System.Drawing.Size(243, 29);
            this.comboBoxLSH.TabIndex = 3;
            // 
            // comboBoxHP
            // 
            this.comboBoxHP.FormattingEnabled = true;
            this.comboBoxHP.Location = new System.Drawing.Point(199, 295);
            this.comboBoxHP.Name = "comboBoxHP";
            this.comboBoxHP.Size = new System.Drawing.Size(243, 29);
            this.comboBoxHP.TabIndex = 3;
            // 
            // labelNgayThi
            // 
            this.labelNgayThi.AutoSize = true;
            this.labelNgayThi.Location = new System.Drawing.Point(525, 61);
            this.labelNgayThi.Name = "labelNgayThi";
            this.labelNgayThi.Size = new System.Drawing.Size(71, 21);
            this.labelNgayThi.TabIndex = 1;
            this.labelNgayThi.Text = "Ngày thi";
            // 
            // labelLSH
            // 
            this.labelLSH.AutoSize = true;
            this.labelLSH.Location = new System.Drawing.Point(82, 219);
            this.labelLSH.Name = "labelLSH";
            this.labelLSH.Size = new System.Drawing.Size(63, 21);
            this.labelLSH.TabIndex = 1;
            this.labelLSH.Text = "Lớp SH";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(82, 299);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(80, 21);
            this.labelHP.TabIndex = 1;
            this.labelHP.Text = "Học phần";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(325, 482);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(117, 34);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(603, 482);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDGK
            // 
            this.textBoxDGK.Location = new System.Drawing.Point(682, 211);
            this.textBoxDGK.Name = "textBoxDGK";
            this.textBoxDGK.Size = new System.Drawing.Size(243, 29);
            this.textBoxDGK.TabIndex = 0;
            this.textBoxDGK.TextChanged += new System.EventHandler(this.textBoxDiem_TextChanged);
            // 
            // labelDGK
            // 
            this.labelDGK.AutoSize = true;
            this.labelDGK.Location = new System.Drawing.Point(525, 215);
            this.labelDGK.Name = "labelDGK";
            this.labelDGK.Size = new System.Drawing.Size(73, 21);
            this.labelDGK.TabIndex = 1;
            this.labelDGK.Text = "Điểm GK";
            // 
            // textBoxDCK
            // 
            this.textBoxDCK.Location = new System.Drawing.Point(682, 291);
            this.textBoxDCK.Name = "textBoxDCK";
            this.textBoxDCK.Size = new System.Drawing.Size(243, 29);
            this.textBoxDCK.TabIndex = 0;
            this.textBoxDCK.TextChanged += new System.EventHandler(this.textBoxDiem_TextChanged);
            // 
            // labelDTK
            // 
            this.labelDTK.AutoSize = true;
            this.labelDTK.Location = new System.Drawing.Point(525, 295);
            this.labelDTK.Name = "labelDTK";
            this.labelDTK.Size = new System.Drawing.Size(72, 21);
            this.labelDTK.TabIndex = 1;
            this.labelDTK.Text = "Điểm CK";
            // 
            // textBoxTK
            // 
            this.textBoxTK.Enabled = false;
            this.textBoxTK.Location = new System.Drawing.Point(682, 372);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(243, 29);
            this.textBoxTK.TabIndex = 0;
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(525, 376);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(75, 21);
            this.labelTK.TabIndex = 1;
            this.labelTK.Text = "Tổng kết";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(97, 363);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(345, 82);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(192, 45);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(80, 25);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(59, 45);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(64, 25);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 562);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxHP);
            this.Controls.Add(this.comboBoxLSH);
            this.Controls.Add(this.dateTimePickerNgayThi);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelTK);
            this.Controls.Add(this.labelDTK);
            this.Controls.Add(this.labelDGK);
            this.Controls.Add(this.labelDBT);
            this.Controls.Add(this.labelLSH);
            this.Controls.Add(this.labelNgayThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxTK);
            this.Controls.Add(this.textBoxDCK);
            this.Controls.Add(this.textBoxDGK);
            this.Controls.Add(this.textBoxDBT);
            this.Controls.Add(this.textBoxMa);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.TextBox textBoxDBT;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDBT;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThi;
        private System.Windows.Forms.ComboBox comboBoxLSH;
        private System.Windows.Forms.ComboBox comboBoxHP;
        private System.Windows.Forms.Label labelNgayThi;
        private System.Windows.Forms.Label labelLSH;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxDGK;
        private System.Windows.Forms.Label labelDGK;
        private System.Windows.Forms.TextBox textBoxDCK;
        private System.Windows.Forms.Label labelDTK;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
    }
}