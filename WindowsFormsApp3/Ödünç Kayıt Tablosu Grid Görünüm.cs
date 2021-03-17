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
    public partial class FormÖdünçKayıtGrid : Form
    {
        public FormÖdünçKayıtGrid()
        {
            InitializeComponent();
        }

        private void ödünçKayıtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ödünçKayıtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kütüphaneDataSet);

        }

        private void FormÖdünçKayıtGrid_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet.ÖdünçKayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ödünçKayıtTableAdapter.Fill(this.kütüphaneDataSet.ÖdünçKayıt);

        }
    }
}
