using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {       
            InitializeComponent();
            combo.Items.Add("Futbol");
            combo.Items.Add("Basketbol");
            combo.Items.Add("Savaş");
            combo.Items.Add("Korku");
            combo.Items.Add("Bulmaca");
            combo.Items.Add("Gizem");
            combo.Items.Add("Aksiyon");

            MessageBox.Show("Oyunun Adresine Hoşgeldiniz!", "HOŞGELDİNİZ!");

        }
        public string Text { get; private set; }

    private void Ekle(object sender, RoutedEventArgs e)
        {
            if (oyunadi.Text.Length > 0 && combo.SelectedIndex >=  0 && fiyat.Text.Length > 0 && tarih.Text.Length > 0)
            {
                liste.Items.Add(oyunadi.Text);
                liste1.Items.Add(this.combo.Text);
                liste2.Items.Add(fiyat.Text);
                liste3.Items.Add(tarih.Text);
                oyunadi.Clear();
                fiyat.Clear();
                tarih.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata Penceresi");
            }
        }

        private void Sil(object sender, RoutedEventArgs e)
        {
            if(liste.SelectedItems.Count > 0)
            {
                liste1.Items.RemoveAt(0 + liste.SelectedIndex);
                liste2.Items.RemoveAt(0 + liste.SelectedIndex);
                liste3.Items.RemoveAt(0 + liste.SelectedIndex);
                liste.Items.Remove(liste.SelectedItem);        
                    MessageBox.Show("Silme başarılı!.", "Başarılı!");
            }
            if (liste1.SelectedItems.Count > 0)
            {
                liste.Items.RemoveAt(0 + liste1.SelectedIndex);
                liste2.Items.RemoveAt(0 + liste1.SelectedIndex);
                liste3.Items.RemoveAt(0 + liste1.SelectedIndex);
                liste1.Items.Remove(liste1.SelectedItem);
                MessageBox.Show("Silme başarılı!.", "Başarılı!");
            }
            if (liste2.SelectedItems.Count > 0)
            {
                liste1.Items.RemoveAt(0 + liste2.SelectedIndex);
                liste.Items.RemoveAt(0 + liste2.SelectedIndex);
                liste3.Items.RemoveAt(0 + liste2.SelectedIndex);
                liste2.Items.Remove(liste2.SelectedItem);
                MessageBox.Show("Silme başarılı!.", "Başarılı!");
            }
            if (liste3.SelectedItems.Count > 0)
            {
                liste1.Items.RemoveAt(0 + liste3.SelectedIndex);
                liste2.Items.RemoveAt(0 + liste3.SelectedIndex);
                liste.Items.RemoveAt(0 + liste3.SelectedIndex);
                liste3.Items.Remove(liste3.SelectedItem);
                MessageBox.Show("Silme başarılı!.", "Başarılı!");
            }

        }

        private void Güncelle(object sender, RoutedEventArgs e)
        {
            if(liste.SelectedItems.Count > 0 || liste1.SelectedItems.Count > 0 || liste2.SelectedItems.Count > 0 || liste3.SelectedItems.Count > 0)
            {
                if (liste.SelectedItems.Count == 1 && oyunadi.Text.Length > 0)
                {
                    int index = liste.SelectedIndex;
                    liste.Items.RemoveAt(index);
                    liste.Items.Insert(index, oyunadi.Text);
                }


                if (liste1.SelectedItems.Count == 1 && combo.Text.Length > 0)
                {
                    int index1 = liste1.SelectedIndex;
                    liste1.Items.RemoveAt(index1);
                    liste1.Items.Insert(index1, combo.Text);
                }

                if (liste2.SelectedItems.Count == 1 && fiyat.Text.Length > 0)
                {
                    int index2 = liste2.SelectedIndex;
                    liste2.Items.RemoveAt(index2);
                    liste2.Items.Insert(index2, fiyat.Text);
                }


                if (liste3.SelectedItems.Count == 1 && tarih.Text.Length > 0)
                {
                    int index3 = liste3.SelectedIndex;
                    liste3.Items.RemoveAt(index3);
                    liste3.Items.Insert(index3, tarih.Text);
                }
            }
            else
                MessageBox.Show("Lütfen güncellemek istediğiniz alanı seçiniz! (Sadece 1 alan seçilebilir!)", "Hata!");

        }
    }
}
