namespace WindowsFormsApp3
{
    partial class FormÖğrenciSekmeli
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
            System.Windows.Forms.Label öğrenciNoLabel;
            System.Windows.Forms.Label adıLabel;
            System.Windows.Forms.Label soyadıLabel;
            System.Windows.Forms.Label fakülteLabel;
            System.Windows.Forms.Label bölümLabel;
            System.Windows.Forms.Label üyelikDurumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÖğrenciSekmeli));
            this.kütüphaneDataSet = new WindowsFormsApp3.KütüphaneDataSet();
            this.öğrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciTableAdapter = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.ÖğrenciTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager();
            this.öğrenciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.öğrenciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.öğrenciNoTextBox = new System.Windows.Forms.TextBox();
            this.adıTextBox = new System.Windows.Forms.TextBox();
            this.soyadıTextBox = new System.Windows.Forms.TextBox();
            this.fakülteTextBox = new System.Windows.Forms.TextBox();
            this.bölümTextBox = new System.Windows.Forms.TextBox();
            this.üyelikDurumTextBox = new System.Windows.Forms.TextBox();
            öğrenciNoLabel = new System.Windows.Forms.Label();
            adıLabel = new System.Windows.Forms.Label();
            soyadıLabel = new System.Windows.Forms.Label();
            fakülteLabel = new System.Windows.Forms.Label();
            bölümLabel = new System.Windows.Forms.Label();
            üyelikDurumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingNavigator)).BeginInit();
            this.öğrenciBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // öğrenciNoLabel
            // 
            öğrenciNoLabel.AutoSize = true;
            öğrenciNoLabel.Location = new System.Drawing.Point(12, 41);
            öğrenciNoLabel.Name = "öğrenciNoLabel";
            öğrenciNoLabel.Size = new System.Drawing.Size(64, 13);
            öğrenciNoLabel.TabIndex = 1;
            öğrenciNoLabel.Text = "Öğrenci No:";
            // 
            // adıLabel
            // 
            adıLabel.AutoSize = true;
            adıLabel.Location = new System.Drawing.Point(12, 67);
            adıLabel.Name = "adıLabel";
            adıLabel.Size = new System.Drawing.Size(25, 13);
            adıLabel.TabIndex = 3;
            adıLabel.Text = "Adı:";
            // 
            // soyadıLabel
            // 
            soyadıLabel.AutoSize = true;
            soyadıLabel.Location = new System.Drawing.Point(12, 93);
            soyadıLabel.Name = "soyadıLabel";
            soyadıLabel.Size = new System.Drawing.Size(42, 13);
            soyadıLabel.TabIndex = 5;
            soyadıLabel.Text = "Soyadı:";
            // 
            // fakülteLabel
            // 
            fakülteLabel.AutoSize = true;
            fakülteLabel.Location = new System.Drawing.Point(12, 119);
            fakülteLabel.Name = "fakülteLabel";
            fakülteLabel.Size = new System.Drawing.Size(45, 13);
            fakülteLabel.TabIndex = 7;
            fakülteLabel.Text = "Fakülte:";
            // 
            // bölümLabel
            // 
            bölümLabel.AutoSize = true;
            bölümLabel.Location = new System.Drawing.Point(12, 145);
            bölümLabel.Name = "bölümLabel";
            bölümLabel.Size = new System.Drawing.Size(39, 13);
            bölümLabel.TabIndex = 9;
            bölümLabel.Text = "Bölüm:";
            // 
            // üyelikDurumLabel
            // 
            üyelikDurumLabel.AutoSize = true;
            üyelikDurumLabel.Location = new System.Drawing.Point(12, 171);
            üyelikDurumLabel.Name = "üyelikDurumLabel";
            üyelikDurumLabel.Size = new System.Drawing.Size(73, 13);
            üyelikDurumLabel.TabIndex = 11;
            üyelikDurumLabel.Text = "Üyelik Durum:";
            // 
            // kütüphaneDataSet
            // 
            this.kütüphaneDataSet.DataSetName = "KütüphaneDataSet";
            this.kütüphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // öğrenciBindingSource
            // 
            this.öğrenciBindingSource.DataMember = "Öğrenci";
            this.öğrenciBindingSource.DataSource = this.kütüphaneDataSet;
            // 
            // öğrenciTableAdapter
            // 
            this.öğrenciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.ÖdünçKayıtTableAdapter = null;
            this.tableAdapterManager.ÖğrenciTableAdapter = this.öğrenciTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // öğrenciBindingNavigator
            // 
            this.öğrenciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.öğrenciBindingNavigator.BindingSource = this.öğrenciBindingSource;
            this.öğrenciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.öğrenciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.öğrenciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.öğrenciBindingNavigatorSaveItem});
            this.öğrenciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.öğrenciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.öğrenciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.öğrenciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.öğrenciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.öğrenciBindingNavigator.Name = "öğrenciBindingNavigator";
            this.öğrenciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.öğrenciBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.öğrenciBindingNavigator.TabIndex = 0;
            this.öğrenciBindingNavigator.Text = "bindingNavigator1";
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
            // öğrenciBindingNavigatorSaveItem
            // 
            this.öğrenciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.öğrenciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciBindingNavigatorSaveItem.Image")));
            this.öğrenciBindingNavigatorSaveItem.Name = "öğrenciBindingNavigatorSaveItem";
            this.öğrenciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.öğrenciBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.öğrenciBindingNavigatorSaveItem.Click += new System.EventHandler(this.öğrenciBindingNavigatorSaveItem_Click);
            // 
            // öğrenciNoTextBox
            // 
            this.öğrenciNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "ÖğrenciNo", true));
            this.öğrenciNoTextBox.Location = new System.Drawing.Point(91, 38);
            this.öğrenciNoTextBox.Name = "öğrenciNoTextBox";
            this.öğrenciNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.öğrenciNoTextBox.TabIndex = 2;
            // 
            // adıTextBox
            // 
            this.adıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "Adı", true));
            this.adıTextBox.Location = new System.Drawing.Point(91, 64);
            this.adıTextBox.Name = "adıTextBox";
            this.adıTextBox.Size = new System.Drawing.Size(100, 20);
            this.adıTextBox.TabIndex = 4;
            // 
            // soyadıTextBox
            // 
            this.soyadıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "Soyadı", true));
            this.soyadıTextBox.Location = new System.Drawing.Point(91, 90);
            this.soyadıTextBox.Name = "soyadıTextBox";
            this.soyadıTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyadıTextBox.TabIndex = 6;
            // 
            // fakülteTextBox
            // 
            this.fakülteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "Fakülte", true));
            this.fakülteTextBox.Location = new System.Drawing.Point(91, 116);
            this.fakülteTextBox.Name = "fakülteTextBox";
            this.fakülteTextBox.Size = new System.Drawing.Size(100, 20);
            this.fakülteTextBox.TabIndex = 8;
            // 
            // bölümTextBox
            // 
            this.bölümTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "Bölüm", true));
            this.bölümTextBox.Location = new System.Drawing.Point(91, 142);
            this.bölümTextBox.Name = "bölümTextBox";
            this.bölümTextBox.Size = new System.Drawing.Size(100, 20);
            this.bölümTextBox.TabIndex = 10;
            // 
            // üyelikDurumTextBox
            // 
            this.üyelikDurumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.öğrenciBindingSource, "ÜyelikDurum", true));
            this.üyelikDurumTextBox.Location = new System.Drawing.Point(91, 168);
            this.üyelikDurumTextBox.Name = "üyelikDurumTextBox";
            this.üyelikDurumTextBox.Size = new System.Drawing.Size(100, 20);
            this.üyelikDurumTextBox.TabIndex = 12;
            // 
            // FormÖğrenciSekmeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 270);
            this.Controls.Add(öğrenciNoLabel);
            this.Controls.Add(this.öğrenciNoTextBox);
            this.Controls.Add(adıLabel);
            this.Controls.Add(this.adıTextBox);
            this.Controls.Add(soyadıLabel);
            this.Controls.Add(this.soyadıTextBox);
            this.Controls.Add(fakülteLabel);
            this.Controls.Add(this.fakülteTextBox);
            this.Controls.Add(bölümLabel);
            this.Controls.Add(this.bölümTextBox);
            this.Controls.Add(üyelikDurumLabel);
            this.Controls.Add(this.üyelikDurumTextBox);
            this.Controls.Add(this.öğrenciBindingNavigator);
            this.Name = "FormÖğrenciSekmeli";
            this.Text = "Öğrenci Tablosu Sekmeli Görünüm";
            this.Load += new System.EventHandler(this.FormÖğrenciSekmeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingNavigator)).EndInit();
            this.öğrenciBindingNavigator.ResumeLayout(false);
            this.öğrenciBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KütüphaneDataSet kütüphaneDataSet;
        private System.Windows.Forms.BindingSource öğrenciBindingSource;
        private KütüphaneDataSetTableAdapters.ÖğrenciTableAdapter öğrenciTableAdapter;
        private KütüphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator öğrenciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton öğrenciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox öğrenciNoTextBox;
        private System.Windows.Forms.TextBox adıTextBox;
        private System.Windows.Forms.TextBox soyadıTextBox;
        private System.Windows.Forms.TextBox fakülteTextBox;
        private System.Windows.Forms.TextBox bölümTextBox;
        private System.Windows.Forms.TextBox üyelikDurumTextBox;
    }
}