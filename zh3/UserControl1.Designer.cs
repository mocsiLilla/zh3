namespace zh3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxFogás = new System.Windows.Forms.ListBox();
            this.listBoxHozzávaló = new System.Windows.Forms.ListBox();
            this.textBoxFogás = new System.Windows.Forms.TextBox();
            this.textBoxHozzávaló = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hozzávalóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFogás
            // 
            this.listBoxFogás.FormattingEnabled = true;
            this.listBoxFogás.ItemHeight = 20;
            this.listBoxFogás.Location = new System.Drawing.Point(16, 76);
            this.listBoxFogás.Name = "listBoxFogás";
            this.listBoxFogás.Size = new System.Drawing.Size(280, 484);
            this.listBoxFogás.TabIndex = 0;
            this.listBoxFogás.SelectedIndexChanged += new System.EventHandler(this.listBoxFogás_SelectedIndexChanged);
            // 
            // listBoxHozzávaló
            // 
            this.listBoxHozzávaló.FormattingEnabled = true;
            this.listBoxHozzávaló.ItemHeight = 20;
            this.listBoxHozzávaló.Location = new System.Drawing.Point(863, 76);
            this.listBoxHozzávaló.Name = "listBoxHozzávaló";
            this.listBoxHozzávaló.Size = new System.Drawing.Size(280, 484);
            this.listBoxHozzávaló.TabIndex = 1;
            // 
            // textBoxFogás
            // 
            this.textBoxFogás.Location = new System.Drawing.Point(16, 29);
            this.textBoxFogás.Name = "textBoxFogás";
            this.textBoxFogás.Size = new System.Drawing.Size(280, 27);
            this.textBoxFogás.TabIndex = 2;
            this.textBoxFogás.TextChanged += new System.EventHandler(this.textBoxFogás_TextChanged);
            // 
            // textBoxHozzávaló
            // 
            this.textBoxHozzávaló.Location = new System.Drawing.Point(863, 29);
            this.textBoxHozzávaló.Name = "textBoxHozzávaló";
            this.textBoxHozzávaló.Size = new System.Drawing.Size(280, 27);
            this.textBoxHozzávaló.TabIndex = 3;
            this.textBoxHozzávaló.TextChanged += new System.EventHandler(this.textBoxHozzávaló_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recetIDDataGridViewTextBoxColumn,
            this.fogasIDDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzávalóBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(302, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(555, 484);
            this.dataGridView1.TabIndex = 4;
            // 
            // receptekBindingSource
            // 
            this.receptekBindingSource.DataSource = typeof(zh3.Models.Receptek);
            // 
            // hozzávalóBindingSource
            // 
            this.hozzávalóBindingSource.DataSource = typeof(zh3.Hozzávaló);
            // 
            // recetIDDataGridViewTextBoxColumn
            // 
            this.recetIDDataGridViewTextBoxColumn.DataPropertyName = "RecetID";
            this.recetIDDataGridViewTextBoxColumn.HeaderText = "RecetID";
            this.recetIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recetIDDataGridViewTextBoxColumn.Name = "recetIDDataGridViewTextBoxColumn";
            this.recetIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            this.fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            this.fogasIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            this.nyersanyagNevDataGridViewTextBoxColumn.Width = 125;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            this.mennyiseg4foDataGridViewTextBoxColumn.Width = 125;
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            this.egysegNevDataGridViewTextBoxColumn.Width = 125;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxHozzávaló);
            this.Controls.Add(this.textBoxFogás);
            this.Controls.Add(this.listBoxHozzávaló);
            this.Controls.Add(this.listBoxFogás);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1163, 608);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFogás;
        private ListBox listBoxHozzávaló;
        private TextBox textBoxFogás;
        private TextBox textBoxHozzávaló;
        private DataGridView dataGridView1;
        public BindingSource bindingSource1;
        private BindingSource receptekBindingSource;
        private DataGridViewTextBoxColumn recetIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzávalóBindingSource;
    }
}
