namespace arenda
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодавтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьзасуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arendaDataSet = new arenda.arendaDataSet();
            this.автомобилиTableAdapter = new arenda.arendaDataSetTableAdapters.АвтомобилиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 118;
            this.button1.Text = "Арендовать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодавтоDataGridViewTextBoxColumn,
            this.госномерDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.годвыпускаDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.стоимостьзасуткиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.автомобилиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(843, 289);
            this.dataGridView2.TabIndex = 119;
            // 
            // кодавтоDataGridViewTextBoxColumn
            // 
            this.кодавтоDataGridViewTextBoxColumn.DataPropertyName = "Код_авто";
            this.кодавтоDataGridViewTextBoxColumn.HeaderText = "Код_авто";
            this.кодавтоDataGridViewTextBoxColumn.Name = "кодавтоDataGridViewTextBoxColumn";
            // 
            // госномерDataGridViewTextBoxColumn
            // 
            this.госномерDataGridViewTextBoxColumn.DataPropertyName = "Госномер";
            this.госномерDataGridViewTextBoxColumn.HeaderText = "Госномер";
            this.госномерDataGridViewTextBoxColumn.Name = "госномерDataGridViewTextBoxColumn";
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // годвыпускаDataGridViewTextBoxColumn
            // 
            this.годвыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.Name = "годвыпускаDataGridViewTextBoxColumn";
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // стоимостьзасуткиDataGridViewTextBoxColumn
            // 
            this.стоимостьзасуткиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_за_сутки";
            this.стоимостьзасуткиDataGridViewTextBoxColumn.HeaderText = "Стоимость_за_сутки";
            this.стоимостьзасуткиDataGridViewTextBoxColumn.Name = "стоимостьзасуткиDataGridViewTextBoxColumn";
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.arendaDataSet;
            // 
            // arendaDataSet
            // 
            this.arendaDataSet.DataSetName = "arendaDataSet";
            this.arendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 358);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private arendaDataSet arendaDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private arendaDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодавтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьзасуткиDataGridViewTextBoxColumn;
    }
}