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
    public partial class Form2 : Form
    {
        Connect2 cont = new Connect2();
        SqlConnection consql;
        DataSet ds_HN;
        DataColumn[] key = new DataColumn[1];
        public Form2()
        {
            InitializeComponent();
            consql = cont.connect;
        }
        private void Load_cbB()
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string read;
                read = "select tenLoaiPhong from LoaiPhong";
                SqlCommand cmd = new SqlCommand(read, consql);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cbB_LoaiPH.Items.Add( rdr["tenLoaiPhong"].ToString());
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
        }
        private void Load_DS()
        {
            try
            {
                string read;
                read = "select maHoiNghi,tenHoiNghi,SoNguoi,tenLoaiPhong from LoaiPhong,HoiNghi where LoaiPhong.maLoaiPhong=HoiNghi.maLoaiPhong";
                DataSet ds_HN = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds_HN, "HoiNghi");
                //Gán dữ liệu vào datagridview
                dataGridView1.DataSource = ds_HN.Tables["HoiNghi"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Load_cbB();
            Load_DS();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            
            try
            {

                try
                {
                    string read;
                    read = "select maHoiNghi,tenHoiNghi,SoNguoi,tenLoaiPhong from HoiNghi,LoaiPhong where LoaiPhong.maLoaiPhong=HoiNghi.maLoaiPhong and LoaiPhong.tenLoaiPhong= N'" + cbB_LoaiPH.SelectedItem + "'";
                    DataSet ds_HN = new DataSet();
                    // tạo dataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(read, consql);
                    // đổ dữ liệu vào dataset
                    da.Fill(ds_HN, "HoiNghiLoc");
                    //Gán dữ liệu vào datagridview
                    dataGridView1.DataSource = ds_HN.Tables["HoiNghiLoc"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void ThemHN(string maphong)
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Insert;
                Insert = "INSERT HoiNghi VALUES ('"+txt_MaHN.Text+"', N'"+txt_TenHN.Text+"',"+txt_SoNguoi.Text+",N'"+maphong+"')";
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
        private string TimPhong()
        {
            string ma = "";
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Tim;
                Tim = "select maLoaiPhong from LoaiPhong where tenLoaiPhong =N'"+cbB_LoaiPH.SelectedItem+"'";
                SqlCommand cmd = new SqlCommand(Tim, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    ma = rdr["maLoaiPhong"].ToString();
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
            return ma;
        }
        private void Xoa()
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Delete;
                Delete = "Delete HoiNghi where maHoiNghi =N'"+txt_MaHN.Text+"'";

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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaHN.Focus();
            txt_MaHN.Clear();
            txt_TenHN.Clear();
            txt_SoNguoi.Clear();
            
        }
        
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ThemHN(TimPhong());
            dataGridView1.ClearSelection();
            Load_DS();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Xoa();
            dataGridView1.ClearSelection();
            Load_DS();
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
