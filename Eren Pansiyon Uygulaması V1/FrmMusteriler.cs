﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Form işlemleri
using System.Data.Sql; // SQL
using System.Data.SqlClient; // SQL
using System.Diagnostics; // Log ifadeleri için


namespace Eren_Pansiyon_Uygulaması_V1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturuluyor.
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B49SIQ5\\SQLEXPRESS;Initial Catalog=ErenPansiyon;Integrated Security=True");

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler buraya eklenir, şu an boş.

        }

        private void verilerigoster()
        {
            try
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Musteriid"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    listView1.Items.Add(ekle);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                Trace.TraceError($"Hata: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)     // Her bir müşteri için yeni bir ListViewItem oluşturuluyor.

        {
            // Oluşturulan ListViewItem'e sırasıyla Musteriid, Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, Ucret, GirisTarihi, CikisTarihi ekleniyor.

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNumara.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
           //DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNumara.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid='" + id + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            catch (Exception ex)
            {
                Trace.TraceError($"Hata: {ex.Message}");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNumara.Text =="101")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "102")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "103")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "104")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "105")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "106")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "107")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "108")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
            if (TxtOdaNumara.Text == "109")
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            // TextBox, ComboBox ve diğer kontrol değerleri temizleniyor.

            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text="";
            TxtMail.Text="";
            MskTxtTelefon.Clear();
            TxtMail.Text="";
            TxtKimlikNo.Clear();
            TxtOdaNumara.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";

      
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like'%"+textBox1.Text+"%'" , baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                // Okunan veriler ListView öğelerine ekleniyor.

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-B49SIQ5\SQLEXPRESS;Initial Catalog=ErenPansiyon;Integrated Security=True