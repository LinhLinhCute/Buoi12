using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _30_NgoThiThuyLinh_Buoi12
{
    public partial class Form1 : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_QL;
        DataColumn[] key = new DataColumn[1];
        public Form1()
        {
            InitializeComponent();
            consql = cont.connect;
        }
        public string[] ThaoTac = { "Hiển Thị", "Thêm", "Xóa", "Sửa" };
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Load_DATA()
        {

            try
            {
                string read;
                read = "select MaSV,TenSV,LopHoc.TenLop,NgaySinh,DiaChi from SinhVien, LopHoc where LopHoc.MaLop=SinhVien.MaLop";
                DataSet ds = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds, "SinhVien");
                //Gán dữ liệu vào datagridview
                dgv_SinhVien.DataSource = ds.Tables["SinhVien"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int Tim_MaLop(string ten)
        {
            int id =-1;
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Tim;
                Tim = "select MaLop from LopHoc where LopHoc.TenLop=N'"+ten+"'";
                SqlCommand cmd = new SqlCommand(Tim, consql);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                if(rdr.Read()){
                   string ma=rdr["MaLop"].ToString();
                   id = int.Parse(ma.ToString()); 
                }
               
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
        private void Them(int id,string Ten,int MaLop ,string NgaySinh,string DiaChi)
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Insert;
                Insert = "insert into SinhVien values(" + id + ",N'" + Ten + "'," + MaLop + ",'" + NgaySinh + "',N'" + DiaChi + "', 'null')";
                SqlCommand cmd = new SqlCommand(Insert, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Xoa(int id)
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Delete;
                Delete = "Delete SinhVien where MaSV=" + id + "";

                SqlCommand cmd = new SqlCommand(Delete, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbB_Thaotac.Items.AddRange(ThaoTac);            
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            switch (cbB_Thaotac.SelectedIndex)
            {
                case 0:
                    dgv_SinhVien.ClearSelection();
                    Load_DATA();
                    break;
                case 1:
                    {
                        int malop =Tim_MaLop(txt_tenLop.Text);
                        if (malop == -1)
                        {
                            MessageBox.Show("Không tìm thấy tên lớp");
                        }
                        else
                        {
                            int masv = int.Parse(txt_MaSV.Text);
                            Them(masv, txt_ten.Text, malop, txt_NgaySinh.Text, txt_DiaChi.Text);
                        }
                        break;
                    }
                    
            }
        }


    }
}
