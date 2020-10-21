using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_Proje
{
    public partial class UpdateCase : Form
    {
        private int id;
        public UpdateCase()
        {
            InitializeComponent();
        }

        public UpdateCase(DataGridViewRow row)
        {
            InitializeComponent();
            id = System.Convert.ToInt32(row.Cells["id"].Value.ToString());
            adi_Txt.Text = row.Cells["dava_adi"].Value.ToString();
            konusu_Txt.Text = row.Cells["dava_konusu"].Value.ToString();
            mAdi_Txt.Text = row.Cells["muvekkil_adi"].Value.ToString();
            sAdi_Txt.Text = row.Cells["sanik_adi"].Value.ToString();
            adliye_Txt.Text = row.Cells["adliye_adi"].Value.ToString();
            turu_Txt.Text = row.Cells["dava_turu"].Value.ToString();
            bilgi_Txt.Text = row.Cells["dava_bilgi"].Value.ToString();
            mIletisim_Txt.Text = row.Cells["muvekkil_iletisim"].Value.ToString();
            mKimlik_Txt.Text = row.Cells["muvekkil_kimlik"].Value.ToString();
            sIletisim_Txt.Text = row.Cells["sanik_iletisim"].Value.ToString();
            sKimlik_Txt.Text = row.Cells["sanik_kimlik"].Value.ToString();
        }

        private void btnClick(object sender, EventArgs e)
        {
            DB_Baglan db = new DB_Baglan();
            db.Update("davalar", id, adi_Txt.Text, konusu_Txt.Text, mAdi_Txt.Text, sAdi_Txt.Text, adliye_Txt.Text, turu_Txt.Text, bilgi_Txt.Text,mIletisim_Txt.Text,sIletisim_Txt.Text,mKimlik_Txt.Text,sKimlik_Txt.Text);
            MessageBox.Show("Güncellendi\nSoldaki Menüden Tekrar Seçiniz");
            this.Hide();
        }

        private void deleteButon_Click(object sender, EventArgs e)
        {
            DB_Baglan db = new DB_Baglan();
            db.Delete("davalar", id);
            MessageBox.Show("Silindi\nSoldaki Menüden Tekrar Seçiniz");
            this.Hide();
        }
    }
}
