namespace WindowsFormsApplication1
{
    partial class Transportation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministry_of_tourismDataSet1 = new WindowsFormsApplication1.Ministry_of_tourismDataSet1();
            this.ministry_of_tourismDataSet = new WindowsFormsApplication1.Ministry_of_tourismDataSet();
            this.ministryoftourismDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportationTableAdapter = new WindowsFormsApplication1.Ministry_of_tourismDataSet1TableAdapters.TransportationTableAdapter();
            this.transportationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportationIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.departurePlaceDataGridViewTextBoxColumn,
            this.arrivalPlaceDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-10, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // transportationIDDataGridViewTextBoxColumn
            // 
            this.transportationIDDataGridViewTextBoxColumn.DataPropertyName = "TransportationID";
            this.transportationIDDataGridViewTextBoxColumn.HeaderText = "TransportationID";
            this.transportationIDDataGridViewTextBoxColumn.Name = "transportationIDDataGridViewTextBoxColumn";
            this.transportationIDDataGridViewTextBoxColumn.Width = 187;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 79;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 170;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 137;
            // 
            // departurePlaceDataGridViewTextBoxColumn
            // 
            this.departurePlaceDataGridViewTextBoxColumn.DataPropertyName = "DeparturePlace";
            this.departurePlaceDataGridViewTextBoxColumn.HeaderText = "DeparturePlace";
            this.departurePlaceDataGridViewTextBoxColumn.Name = "departurePlaceDataGridViewTextBoxColumn";
            this.departurePlaceDataGridViewTextBoxColumn.Width = 172;
            // 
            // arrivalPlaceDataGridViewTextBoxColumn
            // 
            this.arrivalPlaceDataGridViewTextBoxColumn.DataPropertyName = "ArrivalPlace";
            this.arrivalPlaceDataGridViewTextBoxColumn.HeaderText = "ArrivalPlace";
            this.arrivalPlaceDataGridViewTextBoxColumn.Name = "arrivalPlaceDataGridViewTextBoxColumn";
            this.arrivalPlaceDataGridViewTextBoxColumn.Width = 139;
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.Width = 103;
            // 
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataMember = "Transportation";
            this.transportationBindingSource.DataSource = this.ministry_of_tourismDataSet1;
            // 
            // ministry_of_tourismDataSet1
            // 
            this.ministry_of_tourismDataSet1.DataSetName = "Ministry_of_tourismDataSet1";
            this.ministry_of_tourismDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // transportationTableAdapter
            // 
            this.transportationTableAdapter.ClearBeforeFill = true;
            // 
            // transportationBindingSource1
            // 
            this.transportationBindingSource1.DataMember = "Transportation";
            this.transportationBindingSource1.DataSource = this.ministry_of_tourismDataSet1;
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 364);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transportation";
            this.Text = "Transportation";
            this.Load += new System.EventHandler(this.Transportation_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministryoftourismDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Ministry_of_tourismDataSet ministry_of_tourismDataSet;
        private System.Windows.Forms.BindingSource ministryoftourismDataSetBindingSource;
        private Ministry_of_tourismDataSet1 ministry_of_tourismDataSet1;
        private System.Windows.Forms.BindingSource transportationBindingSource;
        private Ministry_of_tourismDataSet1TableAdapters.TransportationTableAdapter transportationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transportationBindingSource1;
    }
}