using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmaliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Gorev = TxtGorev.Text;
            ent.Maas =short.Parse(TxtMaas.Text);
            LogicPersonel.LLpersonelEkle(ent);
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {

            EntityPersonel pr = new EntityPersonel();
            pr.Id = int.Parse(TxtID.Text);
            LogicPersonel.LLPersonelSil(pr.Id);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel per = new EntityPersonel();
            per.Id = Convert.ToInt32(TxtID.Text);
            per.Ad = TxtAd.Text;
            per.Soyad = TxtSoyad.Text;
            per.Sehir = TxtSehir.Text;
            per.Gorev = TxtGorev.Text;
            per.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelGuncelle(per);

        }
    }
}
