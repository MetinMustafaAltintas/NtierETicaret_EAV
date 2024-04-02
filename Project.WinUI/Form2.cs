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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        public Form2(AppUser appUser)
        {
            InitializeComponent();
            label1.Text = $"Hoşgeldin {appUser.AppUserProfile.FirstName} {appUser.AppUserProfile.LastName}";
            _cRep = new CategoryRepository();
            _sRep = new SupplierRepository();
            _pRep = new ProductRepository();
            _ppRep = new ProductPropertyRepository();
            _pvRep = new ProductValueRepository();
            form3 = new Form3(appUser);
        }
        Form3 form3;
        private void Form2_Load(object sender, EventArgs e)
        {
            KategoriListele();
            TedarikciListele();
            UrunleriListele();
            UrunOzellikleriListele();
            UrunDegerleriListele();
        }
        #region KategoriEkleSilIslemleri
        CategoryRepository _cRep;
        Category _secCategory;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriIsmi.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Category _category = new Category();
            _category.CategoryName = txtKategoriIsmi.Text.ToLower();
            _category.Description = txtAciklama.Text.ToLower();
            _category.Products = new List<Product>();
            _cRep.Add(_category);
            KategoriListele();
        }

        private void KategoriListele()
        {
            lstKategoriler.DataSource = _cRep.GetActives();
            lstKategoriler.DisplayMember = "CategoryName";
            lstKategoriler.SelectedIndex = -1;

            txtKategoriIsmi.Clear();
            txtAciklama.Clear();
        }
        
        private void lstKategoriler_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex > -1)
            {
                _secCategory = lstKategoriler.SelectedItem as Category;
                txtKategoriIsmi.Text = _secCategory.CategoryName;
                txtAciklama.Text = _secCategory.Description;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex > -1)
            {
                _cRep.Delete(_secCategory);
                SecileniResetle();
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Silmek istedğiniz Kategoriyi seçiniz");
            }
        }

        private void SecileniResetle()
        {
            _secCategory = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex >-1)
            {
                if (string.IsNullOrEmpty(txtKategoriIsmi.Text) || string.IsNullOrEmpty(txtAciklama.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                _secCategory.CategoryName = txtKategoriIsmi.Text.ToLower();
                _secCategory.Description = txtAciklama.Text.ToLower();
                _cRep.Update(_secCategory);
                SecileniResetle();
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Güncellemek istedğiniz Kategoriyi seçiniz");
            }
        }

        #endregion

        #region TederikciEkleSilIslemleri
        SupplierRepository _sRep;
        Supplier _secSupplier;
        private void TedarikciListele()
        {
            lstTedarikci.DataSource = _sRep.GetActives();
            lstTedarikci.DisplayMember = "CompanyName";
            lstTedarikci.SelectedIndex = -1;
            txtTedarikci.Clear();
        }
        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTedarikci.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Supplier _supplier = new Supplier();
            _supplier.CompanyName = txtTedarikci.Text.ToLower();
            _supplier.SupplierProducts = new List<SupplierProduct>();
            _sRep.Add(_supplier);
            TedarikciListele();
        }

        private void lstTedarikci_Click(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedIndex > -1)
            {
                _secSupplier = lstTedarikci.SelectedItem as Supplier;
                txtTedarikci.Text = _secSupplier.CompanyName;
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedIndex > -1)
            {
                _sRep.Delete(_secSupplier);
                TedarikciListele();
                SecileniResetle2();
            }
            else
            {
                MessageBox.Show("Silmek istedğiniz Tedarikçiyi seçiniz");
            }
        }

        private void SecileniResetle2()
        {
            _secSupplier = null;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtTedarikci.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _secSupplier.CompanyName = txtTedarikci.Text.ToLower();
                _sRep.Update(_secSupplier);
                SecileniResetle2();
                TedarikciListele();
            }
            else
            {
                MessageBox.Show("Güncellemek istedğiniz Tedarikçiyi seçiniz");
            }
        }

        #endregion

        #region UrunlerinEkleSilIslemleri
        ProductRepository _pRep;
        Product _secProduct;
        private void UrunleriListele()
        {
            lstUrunler.DataSource = _pRep.GetActives();
            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.SelectedIndex = -1;

            txtUrunIsmi.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
        }

        private void btnKaydet3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunIsmi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtStok.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstKategoriler.SelectedIndex <= -1)
            {
                MessageBox.Show("Kategori Seçiniz");
                return;
            }
            if (lstTedarikci.SelectedIndex <= -1)
            {
                MessageBox.Show("Tedarikçi Seçiniz");
                return;
            }
            Product _product = new Product();
            _product.ProductName = txtUrunIsmi.Text.ToLower();
            _product.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
            _product.Stock = Convert.ToInt32(txtStok.Text);
            _product.Category = _secCategory;
            
            _pRep.Add(_product);
            UrunleriListele();

            SupplierProductRepository _spRep = new SupplierProductRepository();
            SupplierProduct _supplierProduct = new SupplierProduct();
            _supplierProduct.Product = _product;
            _supplierProduct.Supplier = _secSupplier;
            _spRep.Add(_supplierProduct);

        }

        private void btnSil3_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                _pRep.Delete(_secProduct);
                UrunleriListele();
                SecileniResetle3();

            }
            else
            {
                MessageBox.Show("Silmek istedğiniz Ürunleri seçiniz");
            }
        }

        private void SecileniResetle3()
        {
            _secProduct = null;
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                _secProduct = lstUrunler.SelectedItem as Product;
                txtUrunIsmi.Text = _secProduct.ProductName;
                txtFiyat.Text = _secProduct.UnitPrice.ToString();
                txtStok.Text = _secProduct.Stock.ToString();
            }
        }

        private void btnGuncelle3_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtUrunIsmi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtStok.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _secProduct.ProductName = txtUrunIsmi.Text.ToLower();
                _secProduct.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
                _secProduct.Stock = Convert.ToInt32(txtStok.Text);
                
                _pRep.Update(_secProduct);

                SecileniResetle3();
                UrunleriListele();
            }
            else
            {
                MessageBox.Show("Güncellemek istedğiniz Ürunleri seçiniz");
            }
        }




        #endregion


        #region UrununOzellikIslemleri
        ProductPropertyRepository _ppRep;
        private void btnKaydet4_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtUrunOzellikGir.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProductProperty _productProperty = new ProductProperty();
                foreach (ProductProperty item in lstUrunOzellik.Items)
                {
                    if (item.PropertyName == txtUrunOzellikGir.Text.ToLower())
                    {
                        lstUrunOzellik.SelectedIndex = lstUrunOzellik.Items.IndexOf(item);
                        _productProperty = lstUrunOzellik.SelectedItem as ProductProperty;

                        return;
                    }
                }
                _productProperty.PropertyName = txtUrunOzellikGir.Text.ToLower();
                _productProperty.ProductID = (lstUrunler.SelectedItem as Product).ID;
                _productProperty.ProductValues = new List<ProductValue>();
                _ppRep.Add(_productProperty);

                UrunOzellikleriListele();
            }
        }

        private void UrunOzellikleriListele()
        {
            lstUrunOzellik.DataSource = _ppRep.GetActives();
            lstUrunOzellik.DisplayMember = "PropertyName";
            lstUrunOzellik.SelectedIndex = -1;
        }

        #endregion

        #region OzellikDegerIslemleri
        ProductValueRepository _pvRep;
        private void btnKaydet5_Click(object sender, EventArgs e)
        {
            if (lstUrunOzellik.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtOzellikDegerGir.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProductValue _productValue = new ProductValue();
                _productValue.ProductValueName = txtOzellikDegerGir.Text.ToLower();
                _productValue.ProductID = (lstUrunler.SelectedItem as Product).ID;
                _productValue.ProductPropertyID = (lstUrunOzellik.SelectedItem as ProductProperty).ID;

                _pvRep.Add(_productValue);

                UrunDegerleriListele();
            }
        }

        private void UrunDegerleriListele()
        {
            lstOzellikDeger.DataSource = _pvRep.GetActives();
            lstOzellikDeger.DisplayMember = "ProductValueName";
            lstOzellikDeger.SelectedIndex = -1;
        }

        #endregion

        #region UrunDetaylariGoster
        string goster;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                goster += $"Kategori Ismi ={_secProduct.Category.CategoryName} \n";

                foreach (ProductValue item in lstOzellikDeger.Items)
                {
                    if (item.ProductID == (lstUrunler.SelectedItem as Product).ID)
                    {
                        goster += $"{item.ProductProperty.PropertyName} = {item.ProductValueName} \n";
                    }
                }
                DialogResult dr = MessageBox.Show($"{goster}", $"{_secProduct.ProductName.ToUpper()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goster = null;
            }
        }

        #endregion
        private void btnForm3_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }
    }
}
