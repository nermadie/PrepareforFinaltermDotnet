namespace BTCK.GUI
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
            this.dataGridViewQLSP = new System.Windows.Forms.DataGridView();
            this.comboBoxTinhTP = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxQLSP = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxNCC = new System.Windows.Forms.ComboBox();
            this.labelTinhTP = new System.Windows.Forms.Label();
            this.labelNCC = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSP)).BeginInit();
            this.groupBoxQLSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewQLSP
            // 
            this.dataGridViewQLSP.AllowUserToAddRows = false;
            this.dataGridViewQLSP.AllowUserToDeleteRows = false;
            this.dataGridViewQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLSP.Location = new System.Drawing.Point(16, 28);
            this.dataGridViewQLSP.Name = "dataGridViewQLSP";
            this.dataGridViewQLSP.ReadOnly = true;
            this.dataGridViewQLSP.RowTemplate.Height = 30;
            this.dataGridViewQLSP.Size = new System.Drawing.Size(1039, 302);
            this.dataGridViewQLSP.TabIndex = 0;
            // 
            // comboBoxTinhTP
            // 
            this.comboBoxTinhTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTinhTP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTinhTP.FormattingEnabled = true;
            this.comboBoxTinhTP.Location = new System.Drawing.Point(133, 29);
            this.comboBoxTinhTP.Name = "comboBoxTinhTP";
            this.comboBoxTinhTP.Size = new System.Drawing.Size(214, 29);
            this.comboBoxTinhTP.TabIndex = 1;
            this.comboBoxTinhTP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhTP_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Giá nhập",
            "Ngày nhập hàng",
            "Tình trạng",
            "Nhà cung cấp",
            "Tỉnh/TP"});
            this.comboBoxSort.Location = new System.Drawing.Point(772, 450);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(232, 29);
            this.comboBoxSort.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(807, 29);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(278, 29);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBoxQLSP
            // 
            this.groupBoxQLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxQLSP.Controls.Add(this.dataGridViewQLSP);
            this.groupBoxQLSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQLSP.Location = new System.Drawing.Point(30, 76);
            this.groupBoxQLSP.Name = "groupBoxQLSP";
            this.groupBoxQLSP.Size = new System.Drawing.Size(1074, 344);
            this.groupBoxQLSP.TabIndex = 5;
            this.groupBoxQLSP.TabStop = false;
            this.groupBoxQLSP.Text = "Quản lý sản phẩm";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(136, 449);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 31);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(287, 449);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(106, 31);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(635, 450);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(106, 31);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(440, 448);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(106, 31);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.Location = new System.Drawing.Point(483, 29);
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(222, 29);
            this.comboBoxNCC.TabIndex = 1;
            this.comboBoxNCC.TextChanged += new System.EventHandler(this.comboBoxNCC_TextChanged);
            // 
            // labelTinhTP
            // 
            this.labelTinhTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTinhTP.AutoSize = true;
            this.labelTinhTP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhTP.Location = new System.Drawing.Point(61, 32);
            this.labelTinhTP.Name = "labelTinhTP";
            this.labelTinhTP.Size = new System.Drawing.Size(66, 21);
            this.labelTinhTP.TabIndex = 7;
            this.labelTinhTP.Text = "Tỉnh/TP";
            // 
            // labelNCC
            // 
            this.labelNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNCC.AutoSize = true;
            this.labelNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCC.Location = new System.Drawing.Point(368, 32);
            this.labelNCC.Name = "labelNCC";
            this.labelNCC.Size = new System.Drawing.Size(109, 21);
            this.labelNCC.TabIndex = 7;
            this.labelNCC.Text = "Nhà cung cấp";
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(731, 32);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 21);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 512);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelNCC);
            this.Controls.Add(this.labelTinhTP);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxQLSP);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.comboBoxNCC);
            this.Controls.Add(this.comboBoxTinhTP);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "102200311_MF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSP)).EndInit();
            this.groupBoxQLSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQLSP;
        private System.Windows.Forms.ComboBox comboBoxTinhTP;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxQLSP;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxNCC;
        private System.Windows.Forms.Label labelTinhTP;
        private System.Windows.Forms.Label labelNCC;
        private System.Windows.Forms.Label labelSearch;
    }
}

