using Project.BLL.DesignPatterns.GenericRepository.ConcRepository;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _appUser = new AppUserRepository();
        }
        AppUserRepository _appUser;
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKytKullanici.Text) || string.IsNullOrEmpty(txtKytSfr.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtTCNo.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppUser _aUser = new AppUser();
            _aUser.UserName = txtKytKullanici.Text.ToLower();
            _aUser.Password = txtKytSfr.Text.ToLower();
            _aUser.AppUserProfile = new AppUserProfile();
            _aUser.AppUserProfile.FirstName = txtFirstName.Text.ToLower();
            _aUser.AppUserProfile.LastName = txtLastName.Text.ToLower();
            _aUser.AppUserProfile.TCNo = txtTCNo.Text.ToLower();

            _appUser.Add(_aUser);
            MessageBox.Show("Kayıt Olunmuştur.");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (_appUser.Any(x => x.UserName == txtGrsKullanici.Text.ToLower() && x.Password == txtGrsSfr.Text.ToLower()))
            {
                AppUser appuser= _appUser.FirstOrDefault(x => x.UserName== txtGrsKullanici.Text.ToLower() && x.Password == txtGrsSfr.Text.ToLower());
                MessageBox.Show("GİRİŞ YAPILDI");
                Form2 form2 = new Form2(appuser);
                form2.ShowDialog();
                return;
            }
            MessageBox.Show("Tekrar Deneyiniz");
        }
    }
}
