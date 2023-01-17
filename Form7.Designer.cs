
namespace саша1с
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chitayGorodDataSet = new саша1с.ChitayGorodDataSet();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new саша1с.ChitayGorodDataSetTableAdapters.КнигиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетTableAdapter = new саша1с.ChitayGorodDataSetTableAdapters.ОтчетTableAdapter();
            this.iDОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогЗаМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 68);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчеты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОтчетаDataGridViewTextBoxColumn,
            this.iDПродажиDataGridViewTextBoxColumn,
            this.датаОтчетаDataGridViewTextBoxColumn,
            this.итогЗаМесяцDataGridViewTextBoxColumn,
            this.номерОтчетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отчетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 277);
            this.dataGridView1.TabIndex = 5;
            // 
            // chitayGorodDataSet
            // 
            this.chitayGorodDataSet.DataSetName = "ChitayGorodDataSet";
            this.chitayGorodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.chitayGorodDataSet;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button2.Location = new System.Drawing.Point(336, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // отчетBindingSource
            // 
            this.отчетBindingSource.DataMember = "Отчет";
            this.отчетBindingSource.DataSource = this.chitayGorodDataSet;
            // 
            // отчетTableAdapter
            // 
            this.отчетTableAdapter.ClearBeforeFill = true;
            // 
            // iDОтчетаDataGridViewTextBoxColumn
            // 
            this.iDОтчетаDataGridViewTextBoxColumn.DataPropertyName = "IDОтчета";
            this.iDОтчетаDataGridViewTextBoxColumn.HeaderText = "IDОтчета";
            this.iDОтчетаDataGridViewTextBoxColumn.Name = "iDОтчетаDataGridViewTextBoxColumn";
            this.iDОтчетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDПродажиDataGridViewTextBoxColumn
            // 
            this.iDПродажиDataGridViewTextBoxColumn.DataPropertyName = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.HeaderText = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.Name = "iDПродажиDataGridViewTextBoxColumn";
            // 
            // датаОтчетаDataGridViewTextBoxColumn
            // 
            this.датаОтчетаDataGridViewTextBoxColumn.DataPropertyName = "ДатаОтчета";
            this.датаОтчетаDataGridViewTextBoxColumn.HeaderText = "ДатаОтчета";
            this.датаОтчетаDataGridViewTextBoxColumn.Name = "датаОтчетаDataGridViewTextBoxColumn";
            // 
            // итогЗаМесяцDataGridViewTextBoxColumn
            // 
            this.итогЗаМесяцDataGridViewTextBoxColumn.DataPropertyName = "ИтогЗаМесяц";
            this.итогЗаМесяцDataGridViewTextBoxColumn.HeaderText = "ИтогЗаМесяц";
            this.итогЗаМесяцDataGridViewTextBoxColumn.Name = "итогЗаМесяцDataGridViewTextBoxColumn";
            // 
            // номерОтчетаDataGridViewTextBoxColumn
            // 
            this.номерОтчетаDataGridViewTextBoxColumn.DataPropertyName = "НомерОтчета";
            this.номерОтчетаDataGridViewTextBoxColumn.HeaderText = "НомерОтчета";
            this.номерОтчетаDataGridViewTextBoxColumn.Name = "номерОтчетаDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ChitayGorodDataSet chitayGorodDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private ChitayGorodDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource отчетBindingSource;
        private ChitayGorodDataSetTableAdapters.ОтчетTableAdapter отчетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогЗаМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтчетаDataGridViewTextBoxColumn;
    }
}