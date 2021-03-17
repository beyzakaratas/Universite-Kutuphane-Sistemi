namespace WindowsFormsApp3
{
    partial class FormKitapSekmeli
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
            System.Windows.Forms.Label kitapNoLabel;
            System.Windows.Forms.Label kitapAdıLabel;
            System.Windows.Forms.Label yAYINEVILabel;
            System.Windows.Forms.Label iSBNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapSekmeli));
            this.kütüphaneDataSet = new WindowsFormsApp3.KütüphaneDataSet();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTableAdapter = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.KitapTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager();
            this.kitapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kitapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kitapNoTextBox = new System.Windows.Forms.TextBox();
            this.kitapAdıTextBox = new System.Windows.Forms.TextBox();
            this.yAYINEVITextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            kitapNoLabel = new System.Windows.Forms.Label();
            kitapAdıLabel = new System.Windows.Forms.Label();
            yAYINEVILabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingNavigator)).BeginInit();
            this.kitapBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapNoLabel
            // 
            kitapNoLabel.AutoSize = true;
            kitapNoLabel.Location = new System.Drawing.Point(12, 44);
            kitapNoLabel.Name = "kitapNoLabel";
            kitapNoLabel.Size = new System.Drawing.Size(51, 13);
            kitapNoLabel.TabIndex = 1;
            kitapNoLabel.Text = "Kitap No:";
            // 
            // kitapAdıLabel
            // 
            kitapAdıLabel.AutoSize = true;
            kitapAdıLabel.Location = new System.Drawing.Point(12, 70);
            kitapAdıLabel.Name = "kitapAdıLabel";
            kitapAdıLabel.Size = new System.Drawing.Size(52, 13);
            kitapAdıLabel.TabIndex = 3;
            kitapAdıLabel.Text = "Kitap Adı:";
            // 
            // yAYINEVILabel
            // 
            yAYINEVILabel.AutoSize = true;
            yAYINEVILabel.Location = new System.Drawing.Point(12, 96);
            yAYINEVILabel.Name = "yAYINEVILabel";
            yAYINEVILabel.Size = new System.Drawing.Size(59, 13);
            yAYINEVILabel.TabIndex = 5;
            yAYINEVILabel.Text = "YAYINEVI:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(12, 122);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 7;
            iSBNLabel.Text = "ISBN:";
            // 
            // kütüphaneDataSet
            // 
            this.kütüphaneDataSet.DataSetName = "KütüphaneDataSet";
            this.kütüphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kütüphaneDataSet;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KitapTableAdapter = this.kitapTableAdapter;
            this.tableAdapterManager.ÖdünçKayıtTableAdapter = null;
            this.tableAdapterManager.ÖğrenciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.KütüphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kitapBindingNavigator
            // 
            this.kitapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kitapBindingNavigator.BindingSource = this.kitapBindingSource;
            this.kitapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kitapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kitapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kitapBindingNavigatorSaveItem});
            this.kitapBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kitapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kitapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kitapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kitapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kitapBindingNavigator.Name = "kitapBindingNavigator";
            this.kitapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kitapBindingNavigator.Size = new System.Drawing.Size(431, 25);
            this.kitapBindingNavigator.TabIndex = 0;
            this.kitapBindingNavigator.Text = "bindingNavigator1";
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
            // kitapBindingNavigatorSaveItem
            // 
            this.kitapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kitapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapBindingNavigatorSaveItem.Image")));
            this.kitapBindingNavigatorSaveItem.Name = "kitapBindingNavigatorSaveItem";
            this.kitapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kitapBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.kitapBindingNavigatorSaveItem.Click += new System.EventHandler(this.kitapBindingNavigatorSaveItem_Click);
            // 
            // kitapNoTextBox
            // 
            this.kitapNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "KitapNo", true));
            this.kitapNoTextBox.Location = new System.Drawing.Point(77, 41);
            this.kitapNoTextBox.Name = "kitapNoTextBox";
            this.kitapNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kitapNoTextBox.TabIndex = 2;
            // 
            // kitapAdıTextBox
            // 
            this.kitapAdıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "KitapAdı", true));
            this.kitapAdıTextBox.Location = new System.Drawing.Point(77, 67);
            this.kitapAdıTextBox.Name = "kitapAdıTextBox";
            this.kitapAdıTextBox.Size = new System.Drawing.Size(100, 20);
            this.kitapAdıTextBox.TabIndex = 4;
            // 
            // yAYINEVITextBox
            // 
            this.yAYINEVITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "YAYINEVI", true));
            this.yAYINEVITextBox.Location = new System.Drawing.Point(77, 93);
            this.yAYINEVITextBox.Name = "yAYINEVITextBox";
            this.yAYINEVITextBox.Size = new System.Drawing.Size(100, 20);
            this.yAYINEVITextBox.TabIndex = 6;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(77, 119);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 8;
            // 
            // FormKitapSekmeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 215);
            this.Controls.Add(kitapNoLabel);
            this.Controls.Add(this.kitapNoTextBox);
            this.Controls.Add(kitapAdıLabel);
            this.Controls.Add(this.kitapAdıTextBox);
            this.Controls.Add(yAYINEVILabel);
            this.Controls.Add(this.yAYINEVITextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(this.kitapBindingNavigator);
            this.Name = "FormKitapSekmeli";
            this.Text = "Kitap Tablosu Sekmeli Görünüm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingNavigator)).EndInit();
            this.kitapBindingNavigator.ResumeLayout(false);
            this.kitapBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KütüphaneDataSet kütüphaneDataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KütüphaneDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private KütüphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kitapBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kitapBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kitapNoTextBox;
        private System.Windows.Forms.TextBox kitapAdıTextBox;
        private System.Windows.Forms.TextBox yAYINEVITextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
    }
}