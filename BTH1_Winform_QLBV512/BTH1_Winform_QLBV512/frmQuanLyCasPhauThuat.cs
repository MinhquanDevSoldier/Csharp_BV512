using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Winform_QLBV512
{
    public partial class frmQuanLyCasPhauThuat : Form
    {
        private List<TTBenhnhan> ListBenhNhan = new List<TTBenhnhan>();
        public frmQuanLyCasPhauThuat()
        {
            InitializeComponent();
            cbKhoaPT.Text = cbKhoaPT.Items[0].ToString();
            cbBacsi.Text = cbBacsi.Items[0].ToString();
            
            
            TTBenhnhan benhnhan1 = new TTBenhnhan()
            {
                Id = "1",
                Sovv = "av01",
                Ten = "Nguyễn Văn A",
                Tuoi = "22",
                Dienthoai = "123456678",

                Diachi = "Bình Dương",
                Chuyenkhoa = "",
                Ngaymo= DateTime.Parse("2021/01/17"),
            Chuandoan = "",
                Bacsi = ""
            };
            ListBenhNhan.Add(benhnhan1);
            TTBenhnhan benhnhan2 = new TTBenhnhan();
            benhnhan2.Id = "2";
            benhnhan2.Sovv = "av02";
            benhnhan2.Ten = "Nguyễn Văn B";
            benhnhan2.Tuoi = "22";
            benhnhan2.Dienthoai = "123456678";
            benhnhan2.Diachi = "Bình Dương";
            benhnhan2.Chuyenkhoa = "";
            benhnhan2.Ngaymo = DateTime.Parse("2021/01/17");
            benhnhan2.Chuandoan = "";
            benhnhan2.Bacsi = "";
            ListBenhNhan.Add(benhnhan2);
            TTBenhnhan benhnhan3 = new TTBenhnhan();
            benhnhan3.Id = "3";
            benhnhan3.Sovv = "av03";
            benhnhan3.Ten = "Nguyễn Văn C";
            benhnhan3.Tuoi = "22";
            benhnhan3.Dienthoai = "123456678";
            benhnhan3.Diachi = "Bình Dương";
            benhnhan3.Chuyenkhoa = "";
            benhnhan3.Ngaymo= DateTime.Parse("2021/01/17");
            benhnhan3.Chuandoan = "";
            benhnhan3.Bacsi = "";
            ListBenhNhan.Add(benhnhan3);
            ShowData();
        }
        public void setgridview(DataGridView data)
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "STT";
            col1.DataPropertyName = "id";
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Số VV";
            col2.DataPropertyName = "sovv";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Họ tên";
            col3.DataPropertyName = "ten";
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Tuổi";
            col4.DataPropertyName = "tuoi";
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Điện thoại";
            col5.DataPropertyName = "dienthoai";
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Địa chỉ";
            col6.DataPropertyName = "diachi";
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Chuyên khoa";
            col7.DataPropertyName = "chuyenkhoa";
            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Ngày mỗ";
            col8.DataPropertyName = "ngaymo";
            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Chuẩn đoán";
            col9.DataPropertyName = "chuandoan";
            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.HeaderText = "Bác sĩ";
            col10.DataPropertyName = "bacsi";
            data.Columns.Add(col1);
            data.Columns.Add(col2);
            data.Columns.Add(col3);
            data.Columns.Add(col4);
            data.Columns.Add(col5);
            data.Columns.Add(col6);
            data.Columns.Add(col7);
            data.Columns.Add(col8);
            data.Columns.Add(col9);
            data.Columns.Add(col10);
            data.Columns[0].Width = 50;
            data.Columns[1].Width = 100;
            data.Columns[2].Width = 200;
            data.Columns[3].Width = 50;
            data.Columns[4].Width = 200;
            data.Columns[5].Width = 100;
            data.Columns[6].Width = 150;
            data.Columns[7].Width = 200;

        }
        public void ShowData()
        {
            dataGridView1.DataSource = null;
            setgridview(dataGridView1);
            dataGridView1.DataSource = ListBenhNhan;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemBN();
        }
        public bool kiemtratrunglap(string sovv)
        {
            for(int i =0;i<ListBenhNhan.Count;i++)
            {
                if(sovv.Equals(ListBenhNhan.ElementAt(i).Sovv))
                {
                    return false;
                }
            }
            return true;
        }
        public void ThemBN()
        {
            if(kiemtratrunglap(txtsovv.Text))
            {
                int stt =ListBenhNhan.Count+1;
                TTBenhnhan newbenhnhan = new TTBenhnhan();

                newbenhnhan.Id = stt.ToString();
                newbenhnhan.Sovv = txtsovv.Text;
                newbenhnhan.Ten = txtHoten.Text;
                newbenhnhan.Tuoi = txtTuoi.Text;
                newbenhnhan.Dienthoai = txtDienthoai.Text;
                newbenhnhan.Diachi = txtDiachi.Text;
                newbenhnhan.Chuyenkhoa = cbKhoaPT.SelectedItem.ToString();
                newbenhnhan.Chuandoan = txtChuandoan.Text;
                newbenhnhan.Bacsi = cbBacsi.SelectedItem.ToString();
                newbenhnhan.Ngaymo = dtpNgaymo.Value;
                ListBenhNhan.Add(newbenhnhan);
                ShowData();
            }
            else
            {
                MessageBox.Show("Đã tồn tại Số VV tương tự");
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentRow.Index;
            for(int i = ListBenhNhan.Count-1;i>id;i--)
            {
                ListBenhNhan.ElementAt(i).Id = ListBenhNhan.ElementAt(i-1).Id;
            }
            
            ListBenhNhan.RemoveAt(id);
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow TTBN = dataGridView1.SelectedRows[0];
            txtsovv.Text = TTBN.Cells[1].Value.ToString();
            txtHoten.Text = TTBN.Cells[2].Value.ToString();
            txtTuoi.Text = TTBN.Cells[3].Value.ToString();
            txtDienthoai.Text = TTBN.Cells[4].Value.ToString();
            txtDiachi.Text = TTBN.Cells[5].Value.ToString();
            cbKhoaPT.Text = TTBN.Cells[6].Value.ToString();
            dtpNgaymo.Text = TTBN.Cells[7].Value.ToString();
            txtChuandoan.Text = TTBN.Cells[8].Value.ToString();
            cbBacsi.Text = TTBN.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsovv.Text = "";
            txtHoten.Text = "";
            txtTuoi.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            cbKhoaPT.Text = cbKhoaPT.Items[0].ToString();
            dtpNgaymo.Text = "";
            txtChuandoan.Text = "";
            cbBacsi.Text = cbBacsi.Items[0].ToString();
       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string SovvTest = txtsovv.Text.ToString();
            for (int i = 0; i < ListBenhNhan.Count; i++)
            {
                if (SovvTest.Equals(ListBenhNhan.ElementAt(i).Sovv.ToString()))
                {
                    ListBenhNhan.ElementAt(i).Ten = txtHoten.Text.ToString();
                    ListBenhNhan.ElementAt(i).Tuoi= txtTuoi.Text.ToString();
                    ListBenhNhan.ElementAt(i).Dienthoai = txtDienthoai.Text.ToString();
                    ListBenhNhan.ElementAt(i).Diachi = txtDiachi.Text.ToString();
                    ListBenhNhan.ElementAt(i).Chuyenkhoa = cbKhoaPT.SelectedItem.ToString();
                    ListBenhNhan.ElementAt(i).Ngaymo = dtpNgaymo.Value;
                    ListBenhNhan.ElementAt(i).Chuandoan = txtChuandoan.Text.ToString();
                    ListBenhNhan.ElementAt(i).Bacsi = cbBacsi.SelectedItem.ToString();
                    MessageBox.Show("Lưu hoàn tất");
                    break;
                }
            }
            ShowData();
            
        }
    }
}
