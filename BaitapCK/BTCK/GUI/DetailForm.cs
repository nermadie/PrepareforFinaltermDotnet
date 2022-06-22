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

namespace BTCK.Views
{
    public partial class DetailForm : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public string MSSP { get; set; }//Add : MSSP="", Edit = "0000xx"
        public DetailForm(string idSanPham)//constructor
        {
            InitializeComponent();
            MSSP = idSanPham;
            comboBoxTinhTP.Items.AddRange(BLLQLSP.Instance.GetCBBTinhTP(false).ToArray());
            comboBoxNCC.Items.AddRange(BLLQLSP.Instance.GetCBBNCCByIDTinhTP("All", false).ToArray());
            GUI();
        }

        private void GUI()
        {
            if (MSSP != "")
            {
                textBoxMa.Enabled = false;
                SanPham temp = BLLQLSP.Instance.GetSPByMSSP(MSSP);
                textBoxMa.Text = temp._IDSP;
                textBoxName.Text = temp._NameSP;
                textBoxGia.Text = temp._GiaNhap.ToString();
                textBoxSLSP.Text = temp._SoLuong.ToString();
                dateTimePickerNNH.Value = temp._NgayNhap;
                //Nen xem xet lai de toi uu hon
                for (int i = 0; i < comboBoxTinhTP.Items.Count; i++)
                {
                    if (comboBoxTinhTP.Items[i].ToString() == temp.NhaCungCap.DiaChi._NameTinhTP)
                    {
                        comboBoxTinhTP.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < comboBoxNCC.Items.Count; i++)
                {
                    if (comboBoxNCC.Items[i].ToString() == temp.NhaCungCap._NameNCC)
                    {
                        comboBoxNCC.SelectedIndex = i;
                    }
                }
                //===============================
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (textBoxMa.Text == "")
                temp += "  +Mã số sản phẩm\n";
            if (textBoxName.Text == "")
                temp += "  +Tên sản phẩm\n";
            float a;
            if (textBoxGia.Text == "" || !float.TryParse(textBoxGia.Text, out a))
                temp += "  +Giá nhập\n";
            int b;
            if (textBoxGia.Text == "" || !int.TryParse(textBoxGia.Text, out b))
                temp += "  +Số lượng sản phẩm\n";
            if (!(comboBoxTinhTP.SelectedIndex >= 0))
                temp += "  +Tỉnh/TP\n";
            if (!(comboBoxNCC.SelectedIndex >= 0))
                temp += "  +Nhà cung cấp\n";
            //Đủ rồi thì add
            if (temp == "")
            {
                SanPham s = new SanPham()
                {
                    _IDSP = textBoxMa.Text,
                    _NameSP = textBoxName.Text,
                    _GiaNhap = (float)Convert.ToDouble(textBoxGia.Text),
                    _SoLuong = Convert.ToInt32(textBoxSLSP.Text),
                    _NgayNhap = Convert.ToDateTime(dateTimePickerNNH.Value),
                    _IDNCC = ((CBBItemNCC)comboBoxNCC.SelectedItem).Value
                };
                BLLQLSP.Instance.Add_UpdateSP(s);
                d();
                this.Close();
            }
            else
                MessageBox.Show("Có các trường sau còn thiếu hoặc chưa đúng định dạng:\n" + temp, "Warning!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNCC.Items.Clear();
            comboBoxNCC.Items.AddRange(BLLQLSP.Instance.GetCBBNCCByIDTinhTP(comboBoxTinhTP.Text, false).ToArray());
            comboBoxNCC.SelectedIndex = 0;
        }
    }
}
