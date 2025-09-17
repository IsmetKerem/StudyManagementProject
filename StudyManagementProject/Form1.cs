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
using System.IO;

namespace StudyManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=StudyTestDb;Integrated Security=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.ValueMember = "DERSID";
            cmbders.DisplayMember = "DERSAD";

            cmbders.DataSource = dt;




        }


        // Etüt Listesi
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute Etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbbrans.ValueMember = "DERSID";
            cmbbrans.DisplayMember = "DERSAD";
            cmbbrans.DataSource = dt;

        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID, Concat(Ad,' ',SOYAD) as FullName From TBLOGRETMEN where BRANSID="+cmbders.SelectedValue,baglanti);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);
            cmbogretmen.ValueMember = "OGRTID";
            cmbogretmen.DisplayMember = "FullName";
            cmbogretmen.DataSource = dt2; 
        }

        private void btnetutadd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbders.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbogretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3",msktarih.Text);
            komut.Parameters.AddWithValue("@p4",msksaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtetutıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnetutver_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1,durum=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1",txtogrenciid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3",txtetutıd.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Etüt Öğrenciye Verildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnfotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation= openFileDialog1.FileName;
        }

        private void btnogrenciekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4",txtsinif.Text);
            komut.Parameters.AddWithValue("@p5",msktelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtogretmenad.Text);
            komut.Parameters.AddWithValue("@p2",txtogretmensoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbbrans.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Öğretmen Ekleme İşlemi Başarılı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtders.Text);
            komut.ExecuteNonQuery() ;
            baglanti.Close() ;
            MessageBox.Show("Ders Ekleme Başarılı");
        }
    }
}
