namespace _102200311_TranNhatMinh.GUI
{
    partial class MainForm
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
            this.labelHocPhan = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewQLSV = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxHocPhan = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHocPhan
            // 
            this.labelHocPhan.AutoSize = true;
            this.labelHocPhan.Location = new System.Drawing.Point(195, 40);
            this.labelHocPhan.Name = "labelHocPhan";
            this.labelHocPhan.Size = new System.Drawing.Size(80, 21);
            this.labelHocPhan.TabIndex = 0;
            this.labelHocPhan.Text = "Học phần";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(724, 37);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(276, 29);
            this.textBoxSearch.TabIndex = 1;
            // 
            // dataGridViewQLSV
            // 
            this.dataGridViewQLSV.AllowUserToAddRows = false;
            this.dataGridViewQLSV.AllowUserToDeleteRows = false;
            this.dataGridViewQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLSV.Location = new System.Drawing.Point(65, 111);
            this.dataGridViewQLSV.Name = "dataGridViewQLSV";
            this.dataGridViewQLSV.ReadOnly = true;
            this.dataGridViewQLSV.Size = new System.Drawing.Size(1204, 334);
            this.dataGridViewQLSV.TabIndex = 0;
            this.dataGridViewQLSV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewQLSV_RowPostPaint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(171, 495);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 33);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(321, 495);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(119, 33);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(469, 495);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(119, 33);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(709, 495);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(119, 33);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Tên SV",
            "Lớp SH",
            "Tên học phần",
            "Điểm BT",
            "Điểm GK",
            "Điểm CK",
            "Tổng kết",
            "Ngày thi"});
            this.comboBoxSort.Location = new System.Drawing.Point(869, 498);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(294, 29);
            this.comboBoxSort.TabIndex = 4;
            // 
            // comboBoxHocPhan
            // 
            this.comboBoxHocPhan.FormattingEnabled = true;
            this.comboBoxHocPhan.Location = new System.Drawing.Point(319, 37);
            this.comboBoxHocPhan.Name = "comboBoxHocPhan";
            this.comboBoxHocPhan.Size = new System.Drawing.Size(268, 29);
            this.comboBoxHocPhan.TabIndex = 6;
            this.comboBoxHocPhan.SelectedIndexChanged += new System.EventHandler(this.comboBoxHocPhan_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1024, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 33);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.Name = "ColSTT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 573);
            this.Controls.Add(this.dataGridViewQLSV);
            this.Controls.Add(this.comboBoxHocPhan);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelHocPhan);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHocPhan;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewQLSV;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxHocPhan;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
    }
}