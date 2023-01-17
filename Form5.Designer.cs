
namespace саша1с
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chitayGorodDataSet = new саша1с.ChitayGorodDataSet();
            this.chitayGorodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new саша1с.ChitayGorodDataSetTableAdapters.КнигиTableAdapter();
            this.iDКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИздательстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСтеллажаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастныеОграниченияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обложкаКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 47);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(284, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список книг";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(309, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКнигиDataGridViewTextBoxColumn,
            this.iDИздательстваDataGridViewTextBoxColumn,
            this.iDЖанраDataGridViewTextBoxColumn,
            this.iDСтеллажаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.возрастныеОграниченияDataGridViewTextBoxColumn,
            this.количествоСтраницDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.обложкаКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.книгиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 301);
            this.dataGridView1.TabIndex = 9;
            // 
            // chitayGorodDataSet
            // 
            this.chitayGorodDataSet.DataSetName = "ChitayGorodDataSet";
            this.chitayGorodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitayGorodDataSetBindingSource
            // 
            this.chitayGorodDataSetBindingSource.DataSource = this.chitayGorodDataSet;
            this.chitayGorodDataSetBindingSource.Position = 0;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.chitayGorodDataSetBindingSource;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // iDКнигиDataGridViewTextBoxColumn
            // 
            this.iDКнигиDataGridViewTextBoxColumn.DataPropertyName = "IDКниги";
            this.iDКнигиDataGridViewTextBoxColumn.HeaderText = "IDКниги";
            this.iDКнигиDataGridViewTextBoxColumn.Name = "iDКнигиDataGridViewTextBoxColumn";
            this.iDКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDИздательстваDataGridViewTextBoxColumn
            // 
            this.iDИздательстваDataGridViewTextBoxColumn.DataPropertyName = "IDИздательства";
            this.iDИздательстваDataGridViewTextBoxColumn.HeaderText = "IDИздательства";
            this.iDИздательстваDataGridViewTextBoxColumn.Name = "iDИздательстваDataGridViewTextBoxColumn";
            // 
            // iDЖанраDataGridViewTextBoxColumn
            // 
            this.iDЖанраDataGridViewTextBoxColumn.DataPropertyName = "IDЖанра";
            this.iDЖанраDataGridViewTextBoxColumn.HeaderText = "IDЖанра";
            this.iDЖанраDataGridViewTextBoxColumn.Name = "iDЖанраDataGridViewTextBoxColumn";
            // 
            // iDСтеллажаDataGridViewTextBoxColumn
            // 
            this.iDСтеллажаDataGridViewTextBoxColumn.DataPropertyName = "IDСтеллажа";
            this.iDСтеллажаDataGridViewTextBoxColumn.HeaderText = "IDСтеллажа";
            this.iDСтеллажаDataGridViewTextBoxColumn.Name = "iDСтеллажаDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // возрастныеОграниченияDataGridViewTextBoxColumn
            // 
            this.возрастныеОграниченияDataGridViewTextBoxColumn.DataPropertyName = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.HeaderText = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.Name = "возрастныеОграниченияDataGridViewTextBoxColumn";
            // 
            // количествоСтраницDataGridViewTextBoxColumn
            // 
            this.количествоСтраницDataGridViewTextBoxColumn.DataPropertyName = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.HeaderText = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.Name = "количествоСтраницDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // обложкаКнигиDataGridViewTextBoxColumn
            // 
            this.обложкаКнигиDataGridViewTextBoxColumn.DataPropertyName = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.HeaderText = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.Name = "обложкаКнигиDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource chitayGorodDataSetBindingSource;
        private ChitayGorodDataSet chitayGorodDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private ChitayGorodDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЖанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСтеллажаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастныеОграниченияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обложкаКнигиDataGridViewTextBoxColumn;
    }
}