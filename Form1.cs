using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    
    public partial class frmLatihanTiga3 : Form // Mendefinisikan kelas form dengan nama "frmLatihanTiga3"
    {
        public frmLatihanTiga3() // Konstruktor kelas yang akan dijalankan saat objek kelas dibuat 
        { 
            InitializeComponent(); // Inisialisasi komponen-komponen form
        }

        private void Form1_Load(object sender, EventArgs e) // Metode ini akan dijalankan saat form dimuat (Load)
        {
            // Tidak ada tindakan yang diambil saat form dimuat, sehingga kosong.
        }

        private void btnOk_Click(object sender, EventArgs e) // Metode ini akan dijalankan saat tombol "btnOk" diklik
        {
            var nama = txtNama.Text; // Mengambil nilai dari kotak teks "txtNama"
            var pendidikan = cmbPendidikan.Text; // Mengambil nilai dari pilihan dalam ComboBox "cmbPendidikan"
            var pekerjaan = lstPekerjaan.Text; // Mengambil nilai dari elemen dalam ListBox "lstPekerjaan"

            txtPesan1.Text = string.Format("Halo {0}", nama); // Menyusun teks dan menampilkannya pada kotak teks "txtPesan1"
            txtPesan2.Text = string.Format("Pendidikan anda {0} ya? ", pendidikan); // Menyusun teks dan menampilkannya pada kotak teks "txtPesan2"
            txtPesan3.Text = string.Format("Anda Seorang {0}, hebat !!!", pekerjaan); // Menyusun teks dan menampilkannya pada kotak teks "txtPesan3"
        }

        // Metode ini akan dijalankan saat isi dari kotak teks "txtPesan1" berubah
        private void txtPesan1_TextChanged(object sender, EventArgs e)
        {
            // Tidak ada tindakan yang diambil saat isi teks berubah, sehingga kosong.
        }

        // Metode ini akan dijalankan saat label di klik
        private void label1_Click(object sender, EventArgs e)
        {
            // Tidak ada tindakan yang diambil saat label di klik, sehingga kosong.
        }

        // Metode ini akan dijalankan saat isi dari kotak teks "txtPesan2" berubah
        private void txtPesan2_TextChanged(object sender, EventArgs e)
        {
            // Tidak ada tindakan yang diambil saat isi teks berubah, sehingga kosong.
        }
    }
}
