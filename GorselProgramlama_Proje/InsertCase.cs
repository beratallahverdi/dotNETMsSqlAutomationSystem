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
    public partial class InsertCase : Form
    {
        DB_Baglan baglan = new DB_Baglan();
        public InsertCase()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DB_Baglan db = new DB_Baglan();
            db.Insert("davalar", adi_Txt.Text, konusu_Txt.Text, mAdi_Txt.Text, sAdi_Txt.Text, adliye_Txt.Text, turu_Txt.Text, bilgi_Txt.Text, mIletisim_Txt.Text, sIletisim_Txt.Text, mKimlik_Txt.Text, sKimlik_Txt.Text);
            MessageBox.Show("Eklendi\nSoldaki Menüden Tekrar Seçiniz");
            this.Hide();
        }
    }
}
