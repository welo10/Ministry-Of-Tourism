namespace WindowsFormsApplication1
{
    partial class place
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministry_of_tourismDataSet = new WindowsFormsApplication1.Ministry_of_tourismDataSet();
            this.placeTableAdapter = new WindowsFormsApplication1.Ministry_of_tourismDataSetTableAdapters.PlaceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ministry_of_tourismDataSet3 = new WindowsFormsApplication1.Ministry_of_tourismDataSet3();
            this.placeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter1 = new WindowsFormsApplication1.Ministry_of_tourismDataSet3TableAdapters.PlaceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.ministry_of_tourismDataSet;
            // 
            // ministry_of_tourismDataSet
            // 
            this.ministry_of_tourismDataSet.DataSetName = "Ministry_of_tourismDataSet";
            this.ministry_of_tourismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeIDDataGridViewTextBoxColumn,
            this.placeNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.placeBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-35, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(880, 616);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeIDDataGridViewTextBoxColumn.Width = 118;
            // 
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "PlaceName";
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "PlaceName";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            this.placeNameDataGridViewTextBoxColumn.Width = 155;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 126;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 89;
            // 
            // ministry_of_tourismDataSet3
            // 
            this.ministry_of_tourismDataSet3.DataSetName = "Ministry_of_tourismDataSet3";
            this.ministry_of_tourismDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeBindingSource1
            // 
            this.placeBindingSource1.DataMember = "Place";
            this.placeBindingSource1.DataSource = this.ministry_of_tourismDataSet3;
            // 
            // placeTableAdapter1
            // 
            this.placeTableAdapter1.ClearBeforeFill = true;
            // 
            // place
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 331);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "place";
            this.Text = "place";
            this.Load += new System.EventHandler(this.place_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministry_of_tourismDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Ministry_of_tourismDataSet ministry_of_tourismDataSet;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private Ministry_of_tourismDataSetTableAdapters.PlaceTableAdapter placeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Ministry_of_tourismDataSet3 ministry_of_tourismDataSet3;
        private System.Windows.Forms.BindingSource placeBindingSource1;
        private Ministry_of_tourismDataSet3TableAdapters.PlaceTableAdapter placeTableAdapter1;
    }
}