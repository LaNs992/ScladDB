namespace склад
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullNameColumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGE2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduckt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDSColomun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Enabled = false;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить ";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forprogramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // forprogramToolStripMenuItem
            // 
            this.forprogramToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forprogramToolStripMenuItem.Name = "forprogramToolStripMenuItem";
            this.forprogramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forprogramToolStripMenuItem.Text = "О программе ";
            this.forprogramToolStripMenuItem.Click += new System.EventHandler(this.forprogramToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1169, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(220, 27);
            this.toolStripStatusLabel1.Text = "Колличество товаров на складе: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(220, 27);
            this.toolStripStatusLabel2.Text = "Общая цена товаров(безНДС)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(161, 27);
            this.toolStripStatusLabel3.Text = "Общая цена товаров(сНДС)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1169, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 28);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 28);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(89, 28);
            this.toolStripButton3.Text = "Изменить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColumm,
            this.AGE2Column,
            this.GenderColum,
            this.AgeColumn,
            this.AVGColumn,
            this.Deduckt,
            this.DepterColumn,
            this.NDSColomun,
            this.noNDS,
            this.Columnid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 482);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FullNameColumm
            // 
            this.FullNameColumm.DataPropertyName = "name";
            this.FullNameColumm.HeaderText = "Наз. товара";
            this.FullNameColumm.MinimumWidth = 8;
            this.FullNameColumm.Name = "FullNameColumm";
            this.FullNameColumm.ReadOnly = true;
            this.FullNameColumm.Width = 125;
            // 
            // AGE2Column
            // 
            this.AGE2Column.DataPropertyName = "raz";
            dataGridViewCellStyle1.Format = "#,#,#";
            dataGridViewCellStyle1.NullValue = null;
            this.AGE2Column.DefaultCellStyle = dataGridViewCellStyle1;
            this.AGE2Column.HeaderText = "Размер";
            this.AGE2Column.MinimumWidth = 8;
            this.AGE2Column.Name = "AGE2Column";
            this.AGE2Column.ReadOnly = true;
            this.AGE2Column.Width = 80;
            // 
            // GenderColum
            // 
            this.GenderColum.DataPropertyName = "mater";
            this.GenderColum.HeaderText = "Материал";
            this.GenderColum.MinimumWidth = 80;
            this.GenderColum.Name = "GenderColum";
            this.GenderColum.ReadOnly = true;
            this.GenderColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GenderColum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GenderColum.Width = 80;
            // 
            // AgeColumn
            // 
            this.AgeColumn.DataPropertyName = "kol";
            this.AgeColumn.HeaderText = "Кол. на складе";
            this.AgeColumn.MinimumWidth = 8;
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            this.AgeColumn.Width = 120;
            // 
            // AVGColumn
            // 
            this.AVGColumn.DataPropertyName = "min";
            this.AVGColumn.HeaderText = "Мин. передел кол.";
            this.AVGColumn.MinimumWidth = 8;
            this.AVGColumn.Name = "AVGColumn";
            this.AVGColumn.ReadOnly = true;
            this.AVGColumn.Width = 140;
            // 
            // Deduckt
            // 
            this.Deduckt.DataPropertyName = "price";
            this.Deduckt.HeaderText = "Цена(без НДС)";
            this.Deduckt.MinimumWidth = 8;
            this.Deduckt.Name = "Deduckt";
            this.Deduckt.ReadOnly = true;
            this.Deduckt.Width = 130;
            // 
            // DepterColumn
            // 
            this.DepterColumn.DataPropertyName = "price1";
            this.DepterColumn.HeaderText = "Цена (с НДС)";
            this.DepterColumn.MinimumWidth = 8;
            this.DepterColumn.Name = "DepterColumn";
            this.DepterColumn.ReadOnly = true;
            this.DepterColumn.Width = 130;
            // 
            // NDSColomun
            // 
            this.NDSColomun.DataPropertyName = "fulprice";
            this.NDSColomun.HeaderText = "Общая цена (с НДС)";
            this.NDSColomun.Name = "NDSColomun";
            this.NDSColomun.ReadOnly = true;
            // 
            // noNDS
            // 
            this.noNDS.DataPropertyName = "fulprice1";
            this.noNDS.HeaderText = "Общая цена (без НДС)";
            this.noNDS.Name = "noNDS";
            this.noNDS.ReadOnly = true;
            // 
            // Columnid
            // 
            this.Columnid.DataPropertyName = "Id";
            this.Columnid.HeaderText = "ID";
            this.Columnid.Name = "Columnid";
            this.Columnid.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад гвоздей";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forprogramToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduckt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDSColomun;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid;
    }
}

