namespace WindowsFormsApplication1
{
    partial class ViewTourist2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.touristIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.touristNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wayOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.touristBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministry_of_tourismDataSet2 = new WindowsFormsApplication1.Ministry_of_tourismDataSet2();
            this.ministry_of_tourismDataSet = new WindowsFormsApplication1.Ministry_of_tourismDataSet();
            this.ministryoftourismDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministry_of_tourismDataSet1 = new WindowsFormsApplication1.Ministry_of_tourismDataSet1();
            this.ministryoftourismDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.touristTableAdapter = new WindowsFormsApplication1.Ministry_of_tourismDataSet2TableAdapters.TouristTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.touristIDDataGridViewTextBoxColumn,
            this.touristNameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.wayOfPaymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.touristBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-41, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(744, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // touristIDDataGridViewTextBoxColumn
            // 
            this.touristIDDataGridViewTextBoxColumn.DataPropertyName = "TouristID";
            this.touristIDDataGridViewTextBoxColumn.HeaderText = "TouristID";
            this.touristIDDataGridViewTextBoxColumn.Name = "touristIDDataGridViewTextBoxColumn";
            this.touristIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.touristIDDataGridViewTextBoxColumn.Width = 118;
            // 
            // touristNameDataGridViewTextBoxColumn
            // 
            this.touristNameDataGridViewTextBoxColumn.DataPropertyName = "TouristName";
            this.touristNameDataGridViewTextBoxColumn.HeaderText = "TouristName";
            this.touristNameDataGridViewTextBoxColumn.Name = "touristNameDataGridViewTextBoxColumn";
            this.touristNameDataGridViewTextBoxColumn.Width = 149;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 71;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 129;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Width = 75;
            // 
            // wayOfPaymentDataGridViewTextBoxColumn
            // 
            this.wayOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "WayOfPayment";
            this.wayOfPaymentDataGridViewTextBoxColumn.HeaderText = "WayOfPayment";
            this.wayOfPaymentDataGridViewTextBoxColumn.Name = "wayOfPaymentDataGridViewTextBoxColumn";
            this.wayOfPaymentDataGridViewTextBoxColumn.Width = 172;
            // 
            // touristBindingSource
            // 
            this.touristBindingSource.DataMember = "Tourist";
            this.touristBindingSource.DataSource = this.ministry_of_tourismDataSet2;
            // 
            // ministry_of_tourismDataSet2
            // 
            this.ministry_of_tourismDataSet2.DataSetName = "Ministry_of_tourismDataSet2";
            this.ministry_of_tourismDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ministry_of_tourismDataSet
            // 
            this.ministry_of_tourismDataSet.DataSetName = "Ministry_of_tourismDataSet";
            this.ministry_of_tourismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ministryoftourismDataSetBindingSource
            // 
            this.ministryoftourismDataSetBindingSource.DataSource = this.ministry_of_tourismDataSet;
            this.ministryoftourismDataSetBindingSource.Position = 0;
            // 
            // ministry_of_tourismDataSet1
            // 
            this.ministry_of_tourismDataSet1.DataSetName = "Ministry_of_tourismDataSet1";
            this.ministry_of_tourismDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ministryoftourismDataSet1BindingSource
            // 
            this.ministryoftourismDataSet1BindingSource.DataSource = this.ministry_of_tourismDataSet1;
            this.ministryoftourismDataSet1BindingSource.Position = 0;
            // 
            // touristTableAdapter
            // 
            this.touristTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTourist2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewTourist2";
            this.Text = "ViewTourist2";
            this.Load += new System.EventHandler(this.ViewTourist2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ministryoftourismDataSetBindingSource;
        private Ministry_of_tourismDataSet ministry_of_tourismDataSet;
        private System.Windows.Forms.BindingSource ministryoftourismDataSet1BindingSource;
        private Ministry_of_tourismDataSet1 ministry_of_tourismDataSet1;
        private Ministry_of_tourismDataSet2 ministry_of_tourismDataSet2;
        private System.Windows.Forms.BindingSource touristBindingSource;
        private Ministry_of_tourismDataSet2TableAdapters.TouristTableAdapter touristTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn touristIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn touristNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wayOfPaymentDataGridViewTextBoxColumn;
    }
}