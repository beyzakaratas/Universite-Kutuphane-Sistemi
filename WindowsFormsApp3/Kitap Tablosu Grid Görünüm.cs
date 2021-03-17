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
    public partial class FormKitapGrid : Form
    {
        public FormKitapGrid()
        {
            InitializeComponent();
        }

        private void kitapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kitapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kütüphaneDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter.Fill(this.kütüphaneDataSet.Kitap);

        }
    }
}
