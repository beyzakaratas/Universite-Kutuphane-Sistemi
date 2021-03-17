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
    public partial class FormGiriş : Form
    {
        public FormGiriş()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            if (comboBoxTablo.Text=="Öğrenci"&& radioButtonSekmeli.Checked==true)
            {
                FormÖğrenciSekmeli ÖSekmeliForm = new FormÖğrenciSekmeli();
                ÖSekmeliForm.ShowDialog();
            }
            else if (comboBoxTablo.Text=="Ödünç Kayıt" && radioButtonSekmeli.Checked==true)
            {
                FormÖdünçKayıtSekmeli KayıtSekmeliForm = new FormÖdünçKayıtSekmeli();
                KayıtSekmeliForm.ShowDialog();
            }
            else if (comboBoxTablo.Text=="Kitap"&& radioButtonSekmeli.Checked==true)
            {
                FormKitapSekmeli KitapSekmeliForm = new FormKitapSekmeli();
                KitapSekmeliForm.ShowDialog();
            }
            if (comboBoxTablo.Text == "Öğrenci" && radioButtonGrid.Checked == true)
            {
                FormÖğrenciGrid ÖGridForm = new FormÖğrenciGrid();
                ÖGridForm.ShowDialog();
            }
            else if (comboBoxTablo.Text == "Ödünç Kayıt" && radioButtonGrid.Checked == true)
            {
                FormÖdünçKayıtGrid KayıtGridForm = new FormÖdünçKayıtGrid();
                KayıtGridForm.ShowDialog();
            }
            else if (comboBoxTablo.Text == "Kitap" && radioButtonGrid.Checked == true)
            {
                FormKitapGrid KitapGridForm = new FormKitapGrid();
                KitapGridForm.ShowDialog();
            }
            
            if (radioButtonGrid.Checked==false && radioButtonSekmeli.Checked==false)
            {
                MessageBox.Show("Bir Görünüm Seçiniz!");
            }
            if (comboBoxTablo.Text=="")
            {
                MessageBox.Show("Bir Tablo Seçiniz!");
            }
        }
    }
}
