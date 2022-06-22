using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCK.BLL;
using BTCK.DTO;
using BTCK.Model;

namespace BTCK.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            QLSP db = new QLSP();
            comboBoxTinhTP.Items.AddRange(BLLQLSP.Instance.GetCBBTinhTP().ToArray());
            comboBoxTinhTP.SelectedIndex = 0;
            ShowData();
        }
        private void ShowData()
        {
            int ID_NCC = 0;
            if (comboBoxNCC.SelectedIndex >= 0)
                ID_NCC = ((CBBItemNCC)comboBoxNCC.SelectedItem).Value;
            dataGridViewQLSP.DataSource = BLLQLSP.Instance.GetSPViewByIDNCC(ID_NCC);
            dataGridViewQLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQLSP.Columns[0].HeaderCell.Value = "Mã sản phẩm";
            dataGridViewQLSP.Columns[1].HeaderCell.Value = "Tên sản phẩm";
            dataGridViewQLSP.Columns[2].HeaderCell.Value = "Giá nhập";
            dataGridViewQLSP.Columns[3].HeaderCell.Value = "Ngày nhập hàng";
            dataGridViewQLSP.Columns[4].HeaderCell.Value = "Tình trạng";
            dataGridViewQLSP.Columns[5].HeaderCell.Value = "Nhà cung cấp";
            dataGridViewQLSP.Columns[6].HeaderCell.Value = "Tỉnh/TP";
        }

        //private void changeStateButton()
        //{
        //    if (buttonAdd.Enabled == true)
        //    {
        //        buttonAdd.Enabled = false;
        //        buttonDel.Enabled = false;
        //        buttonEdit.Enabled = false;
        //    }
        //    else
        //    {
        //        buttonAdd.EndInvoke
        //    }
        //}
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.d = new DetailForm.MyDel(ShowData);//delegate
            f.Show();
            //changeStateButton();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSP.SelectedRows.Count == 1)
            {
                string MSSP = dataGridViewQLSP.SelectedRows[0].Cells[0].Value.ToString();
                DetailForm f = new DetailForm(MSSP);
                f.d = new DetailForm.MyDel(ShowData);//delegate
                f.Show();
                //disableButton();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSP.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá (những) sản phẩm này không?", "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    List<string> id = new List<string>();
                    foreach (DataGridViewRow i in dataGridViewQLSP.SelectedRows)
                    {
                        id.Add(i.Cells[0].Value.ToString());
                    }
                    BLLQLSP.Instance.DeleteSP(id);
                    ShowData();
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            List<string> id = new List<string>();
            foreach (DataGridViewRow i in dataGridViewQLSP.Rows)
            {
                id.Add(i.Cells[0].Value.ToString());
            }
            dataGridViewQLSP.DataSource = BLLQLSP.Instance.Sort(id, comboBoxSort.Text);
        }

        private void comboBoxTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNCC.Items.Clear();
            comboBoxNCC.Items.AddRange(BLLQLSP.Instance.GetCBBNCCByIDTinhTP(comboBoxTinhTP.Text).ToArray());
            comboBoxNCC.SelectedIndex = 0;
        }

        private void comboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewQLSP.DataSource = BLLQLSP.Instance.Search(((CBBItemNCC)comboBoxNCC.SelectedItem).Value, textBoxSearch.Text);
        }
    }
}
