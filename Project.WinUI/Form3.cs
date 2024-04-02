using Project.BLL.DesignPatterns.GenericRepository.ConcRepository;
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
    public partial class Form3 : Form
    {
        public Form3(AppUser appUser)
        {
            InitializeComponent();
            _shRep = new ShipperRepository();
            _orRep = new OrderProductRepository();
            _appUser = appUser;
        }
        AppUser _appUser;
        Product _secProduct;
        private void Form3_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            GondericiListele();
            btnSiparisVer.Visible = false;
            btnUrunEkle.Visible = false;
            lstUrunler.Visible = false;
            lstSiparis.Visible = false;

            txtSiparis.Visible = false;
            btnEkle.Visible = false;
            label1.Visible= false;
            label4.Visible= false;
        }
        #region GondericiIslemleri

        ShipperRepository _shRep;
        private void btnGonderici_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGonderici.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Shipper _shipper = new Shipper();
            _shipper.CompanyName = txtGonderici.Text;
            _shRep.Add(_shipper);
            GondericiListele();
        }

        Shipper _secShipper;
        private void lstGonderici_Click(object sender, EventArgs e)
        {
            if (lstGonderici.SelectedIndex > -1)
            {
                _secShipper = new Shipper();
                _secShipper = lstGonderici.SelectedItem as Shipper;

                txtSiparis.Visible = true;
                btnEkle.Visible = true;
                label1.Visible = true;
            }
        }

        private void GondericiListele()
        {
            lstGonderici.DataSource = _shRep.GetActives();
            lstGonderici.DisplayMember = "CompanyName";
            lstGonderici.SelectedIndex = -1;
        }

        #endregion

        private void UrunleriListele()
        {
            ProductRepository _pRep = new ProductRepository();
            lstUrunler.DataSource = _pRep.GetActives();
            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.SelectedIndex = -1;
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                _secProduct = new Product();
                _secProduct = lstUrunler.SelectedItem as Product;
            }
        }
        Order _order;
        OrderProductRepository _orRep;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSiparis.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _order = new Order();
            _order.RequestAddress = txtSiparis.Text.ToLower();
            btnUrunEkle.Visible = true;
            btnSiparisVer.Visible = true;
            lstSiparis.Visible=true;
            lstUrunler.Visible=true;
            label4.Visible = true;
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                lstSiparis.Items.Add(_secProduct);
                lstSiparis.DisplayMember = "ProductName";
                lstSiparis.SelectedIndex = -1;
            }
        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            OrderRepository _oRep = new OrderRepository();
            _order.OrderProducts = new List<OrderProduct>();
            _order.AppUser = _appUser;
            _order.Shipper = _secShipper;
            _oRep.Add(_order);
            
            foreach (Product item in lstSiparis.Items)
            {
             OrderProduct _orderProduct = new OrderProduct();
                _orderProduct.ProductID = item.ID;
                _orderProduct.OrderID=_order.ID;
                _orRep.Add(_orderProduct);
            }

            string siparisToplam = $"{_order.RequestAddress.ToString()} adresine \n" ;
            decimal toplam = 0;
            if (lstSiparis.TabIndex > -1)
            {
                foreach (Product item in lstSiparis.Items)
                {
                    siparisToplam += $"{item.ProductName} => {item.UnitPrice.ToString()} \n";
                    toplam += item.UnitPrice;
                }
                siparisToplam += $"Toplam Tutar ->{toplam}";
                DialogResult dr = MessageBox.Show($"{siparisToplam}", $"{_appUser.UserName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                siparisToplam = "";
            }
            lstSiparis.Items.Clear();
        }
        
    }
}
