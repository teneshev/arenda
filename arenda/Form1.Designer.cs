namespace arenda
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.выданныеАвтомобилиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.arendaDataSet = new arenda.arendaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.выданныеАвтомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выданные_автомобилиTableAdapter = new arenda.arendaDataSetTableAdapters.Выданные_автомобилиTableAdapter();
            this.выданныеАвтомобилиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.выданныеАвтомобилиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.выданныеАвтомобилиBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаСкидокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.штрафыПоПрокатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 292);
            this.dataGridView1.TabIndex = 1;
            // 
            // выданныеАвтомобилиBindingSource2
            // 
            this.выданныеАвтомобилиBindingSource2.DataMember = "Выданные автомобили";
            this.выданныеАвтомобилиBindingSource2.DataSource = this.arendaDataSet;
            // 
            // arendaDataSet
            // 
            this.arendaDataSet.DataSetName = "arendaDataSet";
            this.arendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1067, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 117;
            this.button1.Text = "Арендовать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(1067, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 29);
            this.button9.TabIndex = 104;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(1067, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 27);
            this.button6.TabIndex = 120;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(1067, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 28);
            this.button7.TabIndex = 119;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(1067, 154);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 30);
            this.button8.TabIndex = 118;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // выданныеАвтомобилиBindingSource
            // 
            this.выданныеАвтомобилиBindingSource.DataMember = "Выданные автомобили";
            this.выданныеАвтомобилиBindingSource.DataSource = this.arendaDataSet;
            // 
            // выданные_автомобилиTableAdapter
            // 
            this.выданные_автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // выданныеАвтомобилиBindingSource1
            // 
            this.выданныеАвтомобилиBindingSource1.DataMember = "Выданные автомобили";
            this.выданныеАвтомобилиBindingSource1.DataSource = this.arendaDataSet;
            // 
            // выданныеАвтомобилиBindingSource3
            // 
            this.выданныеАвтомобилиBindingSource3.DataMember = "Выданные автомобили";
            this.выданныеАвтомобилиBindingSource3.DataSource = this.arendaDataSet;
            // 
            // выданныеАвтомобилиBindingSource4
            // 
            this.выданныеАвтомобилиBindingSource4.DataMember = "Выданные автомобили";
            this.выданныеАвтомобилиBindingSource4.DataSource = this.arendaDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 24);
            this.menuStrip1.TabIndex = 131;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ингредиентыToolStripMenuItem,
            this.автомобилиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.системаСкидокToolStripMenuItem,
            this.типыАвтомобилейToolStripMenuItem,
            this.штрафыПоПрокатуToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ингредиентыToolStripMenuItem.Text = "Выданные автомобили";
            this.ингредиентыToolStripMenuItem.Click += new System.EventHandler(this.ингредиентыToolStripMenuItem_Click);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // системаСкидокToolStripMenuItem
            // 
            this.системаСкидокToolStripMenuItem.Name = "системаСкидокToolStripMenuItem";
            this.системаСкидокToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.системаСкидокToolStripMenuItem.Text = "Система скидок";
            this.системаСкидокToolStripMenuItem.Click += new System.EventHandler(this.системаСкидокToolStripMenuItem_Click);
            // 
            // типыАвтомобилейToolStripMenuItem
            // 
            this.типыАвтомобилейToolStripMenuItem.Name = "типыАвтомобилейToolStripMenuItem";
            this.типыАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.типыАвтомобилейToolStripMenuItem.Text = "Типы автомобилей";
            this.типыАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.типыАвтомобилейToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1067, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 134;
            this.textBox1.Tag = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1104, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 133;
            this.label1.Text = "Поиск";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1067, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(146, 20);
            this.textBox9.TabIndex = 132;
            this.textBox9.Tag = "";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Wide Latin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1086, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 138;
            this.label10.Text = "Фильтрация";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Выданные автомобили",
            "Автомобили",
            "Клиенты ",
            "Система скидок",
            "Типы автомобилей",
            "Штрафы по прокату"});
            this.comboBox1.Location = new System.Drawing.Point(1064, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 139;
            // 
            // штрафыПоПрокатуToolStripMenuItem
            // 
            this.штрафыПоПрокатуToolStripMenuItem.Name = "штрафыПоПрокатуToolStripMenuItem";
            this.штрафыПоПрокатуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.штрафыПоПрокатуToolStripMenuItem.Text = "Штрафы по прокату";
            this.штрафыПоПрокатуToolStripMenuItem.Click += new System.EventHandler(this.штрафыПоПрокатуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 325);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданныеАвтомобилиBindingSource4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private arendaDataSet arendaDataSet;
        private System.Windows.Forms.BindingSource выданныеАвтомобилиBindingSource;
        private arendaDataSetTableAdapters.Выданные_автомобилиTableAdapter выданные_автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource выданныеАвтомобилиBindingSource1;
        private System.Windows.Forms.BindingSource выданныеАвтомобилиBindingSource2;
        private System.Windows.Forms.BindingSource выданныеАвтомобилиBindingSource4;
        private System.Windows.Forms.BindingSource выданныеАвтомобилиBindingSource3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системаСкидокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem штрафыПоПрокатуToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

