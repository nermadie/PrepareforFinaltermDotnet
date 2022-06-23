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
    public partial class DetailForm : Form
    {
        public delegate void MyDel();

        public delegate void MyDel2(string str);

        public MyDel delChangeButtonState { get; set; }
        public MyDel2 delOK { get; set; }
        public string MSSV { get; set; }

        public DetailForm(string mssv)
        {
            InitializeComponent();
            MSSV = mssv;
            comboBoxHP.Items.AddRange(BLLQLSV.Instance.GetCBBHP(true).ToArray());
            comboBoxLSH.Items.AddRange(BLLQLSV.Instance.GetCBBLSH().ToArray());
            GUI();
        }

        private void GUI()
        {
            if (MSSV != "")
            {
                textBoxMa.Enabled = false;
                SinhVien temp = BLLQLSV.Instance.GetSVByMSSV(MSSV);
                textBoxMa.Text = temp._IDSV;
                textBoxName.Text = temp._NameSV;
                dateTimePickerNgayThi.Value = temp._NgayThi;
                textBoxDBT.Text = temp._DiemBT.ToString();
                textBoxDGK.Text = temp._DiemGK.ToString();
                textBoxDCK.Text = temp._DiemCK.ToString();
                textBoxTK.Text =
                    (temp._DiemBT * 0.2 + temp._DiemGK * 0.2 + temp._DiemCK * 0.6)
                    .ToString();
                if (temp._Gender == true)
                {
                    radioButtonMale.Checked = true;
                }
                else radioButtonFemale.Checked = true;

                //Nen xem xet lai de toi uu hon
                for (int i = 0; i < comboBoxLSH.Items.Count; i++)
                {
                    if (comboBoxLSH.Items[i].ToString() == temp._LopSH)
                    {
                        comboBoxLSH.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < comboBoxHP.Items.Count; i++)
                {
                    if (comboBoxHP.Items[i].ToString() == temp.HocPhan._NameHP)
                    {
                        comboBoxHP.SelectedIndex = i;
                    }
                }
                //===============================
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (textBoxMa.Text == "")
                temp += "  +MSSV\n";
            if (textBoxName.Text == "")
                temp += "  +Name\n";
            if (!(comboBoxHP.SelectedIndex >= 0))
                temp += "  +Học phần\n";
            if (!(comboBoxLSH.SelectedIndex >= 0))
                temp += "  +Lớp SH\n";
            if (radioButtonFemale.Checked == false && radioButtonMale.Checked == false)
                temp += "  +Gender\n";
            double a;
            if (textBoxDBT.Text == "" || !double.TryParse(textBoxDBT.Text, out a))
                temp += "  +Điểm BT\n";
            double b;
            if (textBoxDBT.Text == "" || !double.TryParse(textBoxDBT.Text, out b))
                temp += "  +Điểm GK\n";
            double c;
            if (textBoxDBT.Text == "" || !double.TryParse(textBoxDBT.Text, out c))
                temp += "  +Điểm CK\n";
            //Đủ rồi thì add

            if (temp == "")
            {
                SinhVien sv = new SinhVien()
                {
                    _IDSV = textBoxMa.Text,
                    _NameSV = textBoxName.Text,
                    _LopSH = comboBoxLSH.Text,
                    _Gender = radioButtonMale.Checked,
                    _DiemBT = Convert.ToDouble(textBoxDBT.Text),
                    _DiemGK = Convert.ToDouble(textBoxDGK.Text),
                    _DiemCK = Convert.ToDouble(textBoxDCK.Text),
                    _NgayThi = Convert.ToDateTime(dateTimePickerNgayThi.Value),
                    _IDHP = ((CBBItemHP)comboBoxHP.SelectedItem)._Value,
                };
                BLLQLSV.Instance.Add_UpdateSV(sv);
                delOK("00000");
                this.Close();
            }
            else
                MessageBox.Show("Có các trường sau còn thiếu hoặc chưa đúng định dạng:\n" + temp, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDiem_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            if (textBoxDBT.Text == "" || !double.TryParse(textBoxDBT.Text, out a))
                textBoxTK.Text = "N/A";
            else if (textBoxDGK.Text == "" || !double.TryParse(textBoxDGK.Text, out b))
                textBoxTK.Text = "N/A";
            else if (textBoxDCK.Text == "" || !double.TryParse(textBoxDCK.Text, out c))
                textBoxTK.Text = "N/A";
            else
                textBoxTK.Text =
                    (Convert.ToDouble(textBoxDBT.Text) * 0.2 + Convert.ToDouble(textBoxDGK.Text) * 0.2 +
                     Convert.ToDouble(textBoxDCK.Text) * 0.6).ToString();
        }
    }
}
