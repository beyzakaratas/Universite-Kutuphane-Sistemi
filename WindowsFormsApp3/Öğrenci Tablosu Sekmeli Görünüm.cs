using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormÖğrenciSekmeli : Form
    {
        public FormÖğrenciSekmeli()
        {
            InitializeComponent();
        }

        private void öğrenciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.öğrenciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kütüphaneDataSet);

        }

        private void FormÖğrenciSekmeli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet.Öğrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.öğrenciTableAdapter.Fill(this.kütüphaneDataSet.Öğrenci);

        }
    }
}
