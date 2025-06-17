﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhDanh();
            txtGiaTri.Text = "";
        }

        void HienThiDanhDanh()
        {
            lstDULieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                lstDULieu.Items.Add(x);
            }
        }

        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text); 
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienThiDanhDanh();
            txtViTriChen.Text = "";
            txtGiaTriChen.Text = "";
        }

        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhDanh();
        }

        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhDanh();
        }

        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDULieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phai con phan tu moi xoa duoc", "Thong bao loi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.RemoveAt(lstDULieu.SelectedIndex);
            HienThiDanhDanh();
        }

        private void BtnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDULieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phai con phan tu moi xoa duoc", "Thong bao loi", MessageBoxButton.OK);
                return;
            }

            while (lstDULieu.SelectedItems.Count > 0) {
                int data = (int)lstDULieu.SelectedItems[0];
                dsDuLieu.Remove(data);
                lstDULieu.Items.Remove(data);
            }
        }

        private void BtnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhDanh();
        }
    }
}