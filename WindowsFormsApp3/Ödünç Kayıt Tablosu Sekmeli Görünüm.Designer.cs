namespace WindowsFormsApp3
{
    partial class FormÖdünçKayıtSekmeli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kayıtNoLabel;
            System.Windows.Forms.Label öğrNoLabel;
            System.Windows.Forms.Label kitapNoLabel;
            System.Windows.Forms.Label ödünçAlmaTarihiLabel;
            System.Windows.Forms.Label gerekenTeslimTarihiLabel;
            System.Windows.Forms.Label teslimTarihiLabel;
            System.Windows.Forms.Label gecikenGünLabel;
            System.Windows.Forms.Label borçLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÖdünçKayıtSekmeli));
            this.kütüphaneDataSet = new WindowsFormsApp3.KütüphaneDataSet();
            this.ödünçKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödünçKayıtTableAdapter = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.ÖdünçKayıtTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager();
            this.ödünçKayıtBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ödünçKayıtBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kayıtNoTextBox = new System.Windows.Forms.TextBox();
            this.öğrNoTextBox = new System.Windows.Forms.TextBox();
            this.kitapNoTextBox = new System.Windows.Forms.TextBox();
            this.ödünçAlmaTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gerekenTeslimTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teslimTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gecikenGünTextBox = new System.Windows.Forms.TextBox();
            this.borçTextBox = new System.Windows.Forms.TextBox();
            kayıtNoLabel = new System.Windows.Forms.Label();
            öğrNoLabel = new System.Windows.Forms.Label();
            kitapNoLabel = new System.Windows.Forms.Label();
            ödünçAlmaTarihiLabel = new System.Windows.Forms.Label();
            gerekenTeslimTarihiLabel = new System.Windows.Forms.Label();
            teslimTarihiLabel = new System.Windows.Forms.Label();
            gecikenGünLabel = new System.Windows.Forms.Label();
            borçLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödünçKayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödünçKayıtBindingNavigator)).BeginInit();
            this.ödünçKayıtBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayıtNoLabel
            // 
            kayıtNoLabel.AutoSize = true;
            kayıtNoLabel.Location = new System.Drawing.Point(25, 42);
            kayıtNoLabel.Name = "kayıtNoLabel";
            kayıtNoLabel.Size = new System.Drawing.Size(50, 13);
            kayıtNoLabel.TabIndex = 1;
            kayıtNoLabel.Text = "Kayıt No:";
            // 
            // öğrNoLabel
            // 
            öğrNoLabel.AutoSize = true;
            öğrNoLabel.Location = new System.Drawing.Point(25, 68);
            öğrNoLabel.Name = "öğrNoLabel";
            öğrNoLabel.Size = new System.Drawing.Size(44, 13);
            öğrNoLabel.TabIndex = 3;
            öğrNoLabel.Text = "Öğr No:";
            // 
            // kitapNoLabel
            // 
            kitapNoLabel.AutoSize = true;
            kitapNoLabel.Location = new System.Drawing.Point(25, 94);
            kitapNoLabel.Name = "kitapNoLabel";
            kitapNoLabel.Size = new System.Drawing.Size(51, 13);
            kitapNoLabel.TabIndex = 5;
            kitapNoLabel.Text = "Kitap No:";
            // 
            // ödünçAlmaTarihiLabel
            // 
            ödünçAlmaTarihiLabel.AutoSize = true;
            ödünçAlmaTarihiLabel.Location = new System.Drawing.Point(25, 121);
            ödünçAlmaTarihiLabel.Name = "ödünçAlmaTarihiLabel";
            ödünçAlmaTarihiLabel.Size = new System.Drawing.Size(97, 13);
            ödünçAlmaTarihiLabel.TabIndex = 7;
            ödünçAlmaTarihiLabel.Text = "Ödünç Alma Tarihi:";
            // 
            // gerekenTeslimTarihiLabel
            // 
            gerekenTeslimTarihiLabel.AutoSize = true;
            gerekenTeslimTarihiLabel.Location = new System.Drawing.Point(25, 147);
            gerekenTeslimTarihiLabel.Name = "gerekenTeslimTarihiLabel";
            gerekenTeslimTarihiLabel.Size = new System.Drawing.Size(113, 13);
            gerekenTeslimTarihiLabel.TabIndex = 9;
            gerekenTeslimTarihiLabel.Text = "Gereken Teslim Tarihi:";
            // 
            // teslimTarihiLabel
            // 
            teslimTarihiLabel.AutoSize = true;
            teslimTarihiLabel.Location = new System.Drawing.Point(25, 173);
            teslimTarihiLabel.Name = "teslimTarihiLabel";
            teslimTarihiLabel.Size = new System.Drawing.Size(69, 13);
            teslimTarihiLabel.TabIndex = 11;
            teslimTarihiLabel.Text = "Teslim Tarihi:";
            // 
            // gecikenGünLabel
            // 
            gecikenGünLabel.AutoSize = true;
            gecikenGünLabel.Location = new System.Drawing.Point(25, 198);
            gecikenGünLabel.Name = "gecikenGünLabel";
            gecikenGünLabel.Size = new System.Drawing.Size(73, 13);
            gecikenGünLabel.TabIndex = 13;
            gecikenGünLabel.Text = "Geciken Gün:";
            // 
            // borçLabel
            // 
            borçLabel.AutoSize = true;
            borçLabel.Location = new System.Drawing.Point(25, 224);
            borçLabel.Name = "borçLabel";
            borçLabel.Size = new System.Drawing.Size(32, 13);
            borçLabel.TabIndex = 15;
            borçLabel.Text = "Borç:";
            // 
            // kütüphaneDataSet
            // 
            this.kütüphaneDataSet.DataSetName = "KütüphaneDataSet";
            this.kütüphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ödünçKayıtBindingSource
            // 
            this.ödünçKayıtBindingSource.DataMember = "ÖdünçKayıt";
            this.ödünçKayıtBindingSource.DataSource = this.kütüphaneDataSet;
            // 
            // ödünçKayıtTableAdapter
            // 
            this.ödünçKayıtTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.ÖdünçKayıtTableAdapter = this.ödünçKayıtTableAdapter;
            this.tableAdapterManager.ÖğrenciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ödünçKayıtBindingNavigator
            // 
            this.ödünçKayıtBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ödünçKayıtBindingNavigator.BindingSource = this.ödünçKayıtBindingSource;
            this.ödünçKayıtBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ödünçKayıtBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ödünçKayıtBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ödünçKayıtBindingNavigatorSaveItem});
            this.ödünçKayıtBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ödünçKayıtBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ödünçKayıtBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ödünçKayıtBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ödünçKayıtBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ödünçKayıtBindingNavigator.Name = "ödünçKayıtBindingNavigator";
            this.ödünçKayıtBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ödünçKayıtBindingNavigator.Size = new System.Drawing.Size(477, 25);
            this.ödünçKayıtBindingNavigator.TabIndex = 0;
            this.ödünçKayıtBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ödünçKayıtBindingNavigatorSaveItem
            // 
            this.ödünçKayıtBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ödünçKayıtBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ödünçKayıtBindingNavigatorSaveItem.Image")));
            this.ödünçKayıtBindingNavigatorSaveItem.Name = "ödünçKayıtBindingNavigatorSaveItem";
            this.ödünçKayıtBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ödünçKayıtBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.ödünçKayıtBindingNavigatorSaveItem.Click += new System.EventHandler(this.ödünçKayıtBindingNavigatorSaveItem_Click);
            // 
            // kayıtNoTextBox
            // 
            this.kayıtNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ödünçKayıtBindingSource, "KayıtNo", true));
            this.kayıtNoTextBox.Location = new System.Drawing.Point(144, 39);
            this.kayıtNoTextBox.Name = "kayıtNoTextBox";
            this.kayıtNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.kayıtNoTextBox.TabIndex = 2;
            // 
            // öğrNoTextBox
            // 
            this.öğrNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ödünçKayıtBindingSource, "ÖğrNo", true));
            this.öğrNoTextBox.Location = new System.Drawing.Point(144, 65);
            this.öğrNoTextBox.Name = "öğrNoTextBox";
            this.öğrNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.öğrNoTextBox.TabIndex = 4;
            // 
            // kitapNoTextBox
            // 
            this.kitapNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ödünçKayıtBindingSource, "KitapNo", true));
            this.kitapNoTextBox.Location = new System.Drawing.Point(144, 91);
            this.kitapNoTextBox.Name = "kitapNoTextBox";
            this.kitapNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.kitapNoTextBox.TabIndex = 6;
            // 
            // ödünçAlmaTarihiDateTimePicker
            // 
            this.ödünçAlmaTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ödünçKayıtBindingSource, "ÖdünçAlmaTarihi", true));
            this.ödünçAlmaTarihiDateTimePicker.Location = new System.Drawing.Point(144, 117);
            this.ödünçAlmaTarihiDateTimePicker.Name = "ödünçAlmaTarihiDateTimePicker";
            this.ödünçAlmaTarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ödünçAlmaTarihiDateTimePicker.TabIndex = 8;
            // 
            // gerekenTeslimTarihiDateTimePicker
            // 
            this.gerekenTeslimTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ödünçKayıtBindingSource, "GerekenTeslimTarihi", true));
            this.gerekenTeslimTarihiDateTimePicker.Location = new System.Drawing.Point(144, 143);
            this.gerekenTeslimTarihiDateTimePicker.Name = "gerekenTeslimTarihiDateTimePicker";
            this.gerekenTeslimTarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.gerekenTeslimTarihiDateTimePicker.TabIndex = 10;
            // 
            // teslimTarihiDateTimePicker
            // 
            this.teslimTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ödünçKayıtBindingSource, "TeslimTarihi", true));
            this.teslimTarihiDateTimePicker.Location = new System.Drawing.Point(144, 169);
            this.teslimTarihiDateTimePicker.Name = "teslimTarihiDateTimePicker";
            this.teslimTarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.teslimTarihiDateTimePicker.TabIndex = 12;
            // 
            // gecikenGünTextBox
            // 
            this.gecikenGünTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ödünçKayıtBindingSource, "GecikenGün", true));
            this.gecikenGünTextBox.Location = new System.Drawing.Point(144, 195);
            this.gecikenGünTextBox.Name = "gecikenGünTextBox";
            this.gecikenGünTextBox.Size = new System.Drawing.Size(200, 20);
            this.gecikenGünTextBox.TabIndex = 14;
            // 
            // borçTextBox
            // 
            this.borçTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ödünçKayıtBindingSource, "Borç", true));
            this.borçTextBox.Location = new System.Drawing.Point(144, 221);
            this.borçTextBox.Name = "borçTextBox";
            this.borçTextBox.Size = new System.Drawing.Size(200, 20);
            this.borçTextBox.TabIndex = 16;
            // 
            // FormÖdünçKayıtSekmeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 324);
            this.Controls.Add(kayıtNoLabel);
            this.Controls.Add(this.kayıtNoTextBox);
            this.Controls.Add(öğrNoLabel);
            this.Controls.Add(this.öğrNoTextBox);
            this.Controls.Add(kitapNoLabel);
            this.Controls.Add(this.kitapNoTextBox);
            this.Controls.Add(ödünçAlmaTarihiLabel);
            this.Controls.Add(this.ödünçAlmaTarihiDateTimePicker);
            this.Controls.Add(gerekenTeslimTarihiLabel);
            this.Controls.Add(this.gerekenTeslimTarihiDateTimePicker);
            this.Controls.Add(teslimTarihiLabel);
            this.Controls.Add(this.teslimTarihiDateTimePicker);
            this.Controls.Add(gecikenGünLabel);
            this.Controls.Add(this.gecikenGünTextBox);
            this.Controls.Add(borçLabel);
            this.Controls.Add(this.borçTextBox);
            this.Controls.Add(this.ödünçKayıtBindingNavigator);
            this.Name = "FormÖdünçKayıtSekmeli";
            this.Text = "ÖdünçKayıt Tablosu Sekmeli Görünüm";
            this.Load += new System.EventHandler(this.FormÖdünçKayıtSekmeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödünçKayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödünçKayıtBindingNavigator)).EndInit();
            this.ödünçKayıtBindingNavigator.ResumeLayout(false);
            this.ödünçKayıtBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KütüphaneDataSet kütüphaneDataSet;
        private System.Windows.Forms.BindingSource ödünçKayıtBindingSource;
        private KütüphaneDataSetTableAdapters.ÖdünçKayıtTableAdapter ödünçKayıtTableAdapter;
        private KütüphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ödünçKayıtBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ödünçKayıtBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kayıtNoTextBox;
        private System.Windows.Forms.TextBox öğrNoTextBox;
        private System.Windows.Forms.TextBox kitapNoTextBox;
        private System.Windows.Forms.DateTimePicker ödünçAlmaTarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker gerekenTeslimTarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker teslimTarihiDateTimePicker;
        private System.Windows.Forms.TextBox gecikenGünTextBox;
        private System.Windows.Forms.TextBox borçTextBox;
    }
}