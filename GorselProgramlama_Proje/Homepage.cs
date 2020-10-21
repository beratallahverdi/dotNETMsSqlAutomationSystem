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
    public partial class Homepage : Form
    {
        DB_Baglan baglan = new DB_Baglan();
        public Homepage()
        {
            InitializeComponent();
        }
        public void cases_Click(object sender, EventArgs e)
        {
            casesDataGrid.DataSource = null;
            DataSet ts = baglan.Select("davalar");
            casesDataGrid.DataSource = ts.Tables["davalar"];
            quickLookView.Visible = false;
            casesView.Visible = true;
        }
        private void logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void quickLookButton_Click(object sender, EventArgs e)
        {
            quickLookDataGrid.DataSource = null;
            DataSet ts = baglan.Select("davalar", 20);
            quickLookDataGrid.DataSource = ts.Tables["davalar"];
            //comboBox1.DisplayMember = "dava_adi";
            //comboBox1.ValueMember = "id";
            quickLookView.Visible = true;
            casesView.Visible = false;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            quickLookDataGrid.DataSource = null;
            DataSet ts = baglan.Select("davalar", 20);
            quickLookDataGrid.DataSource = ts.Tables["davalar"];
            //comboBox1.DisplayMember = "dava_adi";
            //comboBox1.ValueMember = "id";
            quickLookView.Visible = true;
            casesView.Visible = false;
        }

        private void Kapatma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void casesSearch_TextChanged(object sender, EventArgs e)
        {
            casesDataGrid.DataSource = null;
            DataSet ts = baglan.Select("davalar",casesSearch.Text);
            //ts.Tables["davalar"].Columns["id"].ColumnName = "ID";
            //ts.Tables["davalar"].Columns["dava_adi"].ColumnName = "ADI";
            //ts.Tables["davalar"].Columns["dava_konusu"].ColumnName = "KONUSU";
            //ts.Tables["davalar"].Columns["muvekkil_adi"].ColumnName = "MUVEKKIL";
            //ts.Tables["davalar"].Columns["sanik_adi"].ColumnName = "SANIK";
            //ts.Tables["davalar"].Columns["adliye_adi"].ColumnName = "ADLİYE";
            //ts.Tables["davalar"].Columns["dava_turu"].ColumnName = "TUR";
            //ts.Tables["davalar"].Columns["dava_bilgi"].ColumnName = "BİLGİ";
            //ts.Tables["davalar"].Columns["muvekkil_iletisim"].ColumnName = "M. İLETİŞİM";
            //ts.Tables["davalar"].Columns["sanik_iletisim"].ColumnName = "S. İLETİŞİM";
            //ts.Tables["davalar"].Columns["muvekkil_kimlik"].ColumnName = "MU. KİMLİK";
            //ts.Tables["davalar"].Columns["sanik_kimlik"].ColumnName = "SA. KİMLİK";
            casesDataGrid.DataSource = ts.Tables["davalar"];
            quickLookView.Visible = false;
            casesView.Visible = true;
        }

        private void SatirSec_DoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.casesDataGrid.Rows[e.RowIndex];
            int id = System.Convert.ToInt32(row.Cells["id"].Value.ToString());
            UpdateCase update = new UpdateCase(row);
            update.Show();
        }

        private void caseAddBtn_Click(object sender, EventArgs e)
        {
            InsertCase insertCase = new InsertCase();
            insertCase.Show();
        }
    }
}
