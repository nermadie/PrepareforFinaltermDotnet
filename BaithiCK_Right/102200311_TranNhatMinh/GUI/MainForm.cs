using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102200311_TranNhatMinh.BLL;
using _102200311_TranNhatMinh.DTO;

namespace _102200311_TranNhatMinh.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewQLSV.Columns.AddRange(new DataGridViewColumn[] { ColSTT });
            comboBoxHocPhan.Items.AddRange(BLLQLSV.Instance.GetCBBHP().ToArray());
            comboBoxHocPhan.SelectedIndex = 0;
            ShowData();
        }

        private void ShowData(string str = "")
        {
            string id_HP = "00000";
            if (str == "")
            {
                if (comboBoxHocPhan.SelectedIndex >= 0)
                    id_HP = ((CBBItemHP)comboBoxHocPhan.SelectedItem)._Value;
            }
            else
            {
                comboBoxHocPhan.SelectedIndex = 0;
                id_HP = str;
            }
            dataGridViewQLSV.DataSource = BLLQLSV.Instance.GetSV_ViewByidHP(id_HP);
            dataGridViewQLSV.Columns["_IDSV"].Visible = false;
            dataGridViewQLSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQLSV.Columns[2].HeaderCell.Value = "Tên SV";
            dataGridViewQLSV.Columns[3].HeaderCell.Value = "Lớp SH";
            dataGridViewQLSV.Columns[4].HeaderCell.Value = "Tên học phần";
            dataGridViewQLSV.Columns[5].HeaderCell.Value = "Điểm BT";
            dataGridViewQLSV.Columns[6].HeaderCell.Value = "Điểm GK";
            dataGridViewQLSV.Columns[7].HeaderCell.Value = "Điểm CK";
            dataGridViewQLSV.Columns[8].HeaderCell.Value = "Tổng kết";
            dataGridViewQLSV.Columns[9].HeaderCell.Value = "Ngày thi";
        }
        private void dataGridViewQLSV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewQLSV.Rows[e.RowIndex].Cells["ColSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void comboBoxHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        private void changeStateButton()
        {
            if (buttonAdd.Enabled == true)
            {
                buttonAdd.Enabled = false;
                buttonDel.Enabled = false;
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonDel.Enabled = true;
                buttonEdit.Enabled = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.delOK = ShowData;//delegate
            f.delChangeButtonState = changeStateButton;
            f.Show();
            changeStateButton();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSV.SelectedRows.Count == 1)
            {
                string mssv = dataGridViewQLSV.SelectedRows[0].Cells[1].Value.ToString();
                DetailForm f = new DetailForm(mssv);
                f.delOK = ShowData;//delegate
                f.delChangeButtonState = changeStateButton;
                f.Show();
                changeStateButton();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá (những) sinh viên này khỏi lớp học phần không?", "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    List<string> mssv = new List<string>();
                    foreach (DataGridViewRow i in dataGridViewQLSV.SelectedRows)
                    {
                        mssv.Add(i.Cells[1].Value.ToString());
                    }
                    BLLQLSV.Instance.DeleteSVHP(mssv);
                    ShowData();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewQLSV.DataSource = BLLQLSV.Instance.Search(((CBBItemHP)comboBoxHocPhan.SelectedItem)._Value, textBoxSearch.Text);

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            List<string> mssv = new List<string>();
            List<string> mshp = new List<string>();
            foreach (DataGridViewRow i in dataGridViewQLSV.Rows)
            {
                mssv.Add(i.Cells[1].Value.ToString());
                mshp.Add(i.Cells[2].Value.ToString());
            }
            dataGridViewQLSV.DataSource = BLLQLSV.Instance.Sort(mssv, mshp, comboBoxSort.Text);
        }
    }
}
