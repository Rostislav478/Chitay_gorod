
namespace саша1с
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chitayGorodDataSet = new саша1с.ChitayGorodDataSet();
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажиTableAdapter = new саша1с.ChitayGorodDataSetTableAdapters.ПродажиTableAdapter();
            this.продажиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.продажаКнигиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаКнигиTableAdapter = new саша1с.ChitayGorodDataSetTableAdapters.ПродажаКнигиTableAdapter();
            this.продажаКнигиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПродажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСоставленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаКнигиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаКнигиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 61);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список продаж";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button1.Location = new System.Drawing.Point(335, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПродажиDataGridViewTextBoxColumn,
            this.колвоПродажDataGridViewTextBoxColumn,
            this.датаСоставленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продажиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 301);
            this.dataGridView1.TabIndex = 6;
            // 
            // chitayGorodDataSet
            // 
            this.chitayGorodDataSet.DataSetName = "ChitayGorodDataSet";
            this.chitayGorodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.chitayGorodDataSet;
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // продажиBindingSource1
            // 
            this.продажиBindingSource1.DataMember = "Продажи";
            this.продажиBindingSource1.DataSource = this.chitayGorodDataSet;
            // 
            // продажаКнигиBindingSource
            // 
            this.продажаКнигиBindingSource.DataMember = "ПродажаКниги";
            this.продажаКнигиBindingSource.DataSource = this.chitayGorodDataSet;
            // 
            // продажаКнигиTableAdapter
            // 
            this.продажаКнигиTableAdapter.ClearBeforeFill = true;
            // 
            // продажаКнигиBindingSource1
            // 
            this.продажаКнигиBindingSource1.DataMember = "ПродажаКниги";
            this.продажаКнигиBindingSource1.DataSource = this.chitayGorodDataSet;
            // 
            // iDПродажиDataGridViewTextBoxColumn
            // 
            this.iDПродажиDataGridViewTextBoxColumn.DataPropertyName = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.HeaderText = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.Name = "iDПродажиDataGridViewTextBoxColumn";
            this.iDПродажиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колвоПродажDataGridViewTextBoxColumn
            // 
            this.колвоПродажDataGridViewTextBoxColumn.DataPropertyName = "КолвоПродаж";
            this.колвоПродажDataGridViewTextBoxColumn.HeaderText = "КолвоПродаж";
            this.колвоПродажDataGridViewTextBoxColumn.Name = "колвоПродажDataGridViewTextBoxColumn";
            // 
            // датаСоставленияDataGridViewTextBoxColumn
            // 
            this.датаСоставленияDataGridViewTextBoxColumn.DataPropertyName = "ДатаСоставления";
            this.датаСоставленияDataGridViewTextBoxColumn.HeaderText = "ДатаСоставления";
            this.датаСоставленияDataGridViewTextBoxColumn.Name = "датаСоставленияDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаКнигиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаКнигиBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ChitayGorodDataSet chitayGorodDataSet;
        private System.Windows.Forms.BindingSource продажиBindingSource;
        private ChitayGorodDataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        private System.Windows.Forms.BindingSource продажиBindingSource1;
        private System.Windows.Forms.BindingSource продажаКнигиBindingSource;
        private ChitayGorodDataSetTableAdapters.ПродажаКнигиTableAdapter продажаКнигиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПродажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСоставленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продажаКнигиBindingSource1;
    }
}