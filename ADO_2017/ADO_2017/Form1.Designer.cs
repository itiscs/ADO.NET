namespace ADO_2017
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pOKUPATELIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBaseDataSet = new ADO_2017.myBaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPokup = new System.Windows.Forms.DataGridView();
            this.dgvTovar = new System.Windows.Forms.DataGridView();
            this.kODTOVARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOVARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDIZMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTTOVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOVARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRasxod = new System.Windows.Forms.DataGridView();
            this.tOVRASHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOKUPATELITableAdapter = new ADO_2017.myBaseDataSetTableAdapters.POKUPATELITableAdapter();
            this.tOVARYTableAdapter = new ADO_2017.myBaseDataSetTableAdapters.TOVARYTableAdapter();
            this.rASXODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rASXODTableAdapter = new ADO_2017.myBaseDataSetTableAdapters.RASXODTableAdapter();
            this.pOKRASHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kODRASHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATARASHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tovar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.POKUP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kOLVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOKUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gORODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOKUPATELIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasxod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVRASHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASXODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOKRASHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.pOKUPATELIBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(801, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // pOKUPATELIBindingSource
            // 
            this.pOKUPATELIBindingSource.DataMember = "POKUPATELI";
            this.pOKUPATELIBindingSource.DataSource = this.myBaseDataSet;
            // 
            // myBaseDataSet
            // 
            this.myBaseDataSet.DataSetName = "myBaseDataSet";
            this.myBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvPokup
            // 
            this.dgvPokup.AutoGenerateColumns = false;
            this.dgvPokup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pOKUPDataGridViewTextBoxColumn,
            this.gORODDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn});
            this.dgvPokup.DataSource = this.pOKUPATELIBindingSource;
            this.dgvPokup.Location = new System.Drawing.Point(0, 28);
            this.dgvPokup.Name = "dgvPokup";
            this.dgvPokup.Size = new System.Drawing.Size(575, 107);
            this.dgvPokup.TabIndex = 1;
            this.dgvPokup.Click += new System.EventHandler(this.dgvPokup_Click);
            // 
            // dgvTovar
            // 
            this.dgvTovar.AutoGenerateColumns = false;
            this.dgvTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kODTOVARDataGridViewTextBoxColumn,
            this.tOVARDataGridViewTextBoxColumn,
            this.eDIZMDataGridViewTextBoxColumn,
            this.zENADataGridViewTextBoxColumn,
            this.cOUNTTOVDataGridViewTextBoxColumn});
            this.dgvTovar.DataSource = this.tOVARYBindingSource;
            this.dgvTovar.Location = new System.Drawing.Point(0, 141);
            this.dgvTovar.Name = "dgvTovar";
            this.dgvTovar.Size = new System.Drawing.Size(603, 127);
            this.dgvTovar.TabIndex = 2;
            this.dgvTovar.Click += new System.EventHandler(this.dgvTovar_Click);
            // 
            // kODTOVARDataGridViewTextBoxColumn
            // 
            this.kODTOVARDataGridViewTextBoxColumn.DataPropertyName = "KOD_TOVAR";
            this.kODTOVARDataGridViewTextBoxColumn.HeaderText = "KOD_TOVAR";
            this.kODTOVARDataGridViewTextBoxColumn.Name = "kODTOVARDataGridViewTextBoxColumn";
            this.kODTOVARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOVARDataGridViewTextBoxColumn
            // 
            this.tOVARDataGridViewTextBoxColumn.DataPropertyName = "TOVAR";
            this.tOVARDataGridViewTextBoxColumn.HeaderText = "TOVAR";
            this.tOVARDataGridViewTextBoxColumn.Name = "tOVARDataGridViewTextBoxColumn";
            // 
            // eDIZMDataGridViewTextBoxColumn
            // 
            this.eDIZMDataGridViewTextBoxColumn.DataPropertyName = "ED_IZM";
            this.eDIZMDataGridViewTextBoxColumn.HeaderText = "ED_IZM";
            this.eDIZMDataGridViewTextBoxColumn.Name = "eDIZMDataGridViewTextBoxColumn";
            // 
            // zENADataGridViewTextBoxColumn
            // 
            this.zENADataGridViewTextBoxColumn.DataPropertyName = "ZENA";
            this.zENADataGridViewTextBoxColumn.HeaderText = "ZENA";
            this.zENADataGridViewTextBoxColumn.Name = "zENADataGridViewTextBoxColumn";
            // 
            // cOUNTTOVDataGridViewTextBoxColumn
            // 
            this.cOUNTTOVDataGridViewTextBoxColumn.DataPropertyName = "COUNT_TOV";
            this.cOUNTTOVDataGridViewTextBoxColumn.HeaderText = "COUNT_TOV";
            this.cOUNTTOVDataGridViewTextBoxColumn.Name = "cOUNTTOVDataGridViewTextBoxColumn";
            // 
            // tOVARYBindingSource
            // 
            this.tOVARYBindingSource.DataMember = "TOVARY";
            this.tOVARYBindingSource.DataSource = this.myBaseDataSet;
            // 
            // dgvRasxod
            // 
            this.dgvRasxod.AutoGenerateColumns = false;
            this.dgvRasxod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRasxod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kODRASHDataGridViewTextBoxColumn,
            this.dATARASHDataGridViewTextBoxColumn,
            this.Tovar,
            this.POKUP,
            this.kOLVODataGridViewTextBoxColumn,
            this.sTOIMDataGridViewTextBoxColumn});
            this.dgvRasxod.DataSource = this.rASXODBindingSource;
            this.dgvRasxod.Location = new System.Drawing.Point(0, 276);
            this.dgvRasxod.Name = "dgvRasxod";
            this.dgvRasxod.Size = new System.Drawing.Size(675, 146);
            this.dgvRasxod.TabIndex = 3;
            this.dgvRasxod.Click += new System.EventHandler(this.dgvRasxod_Click);
            // 
            // tOVRASHBindingSource
            // 
            this.tOVRASHBindingSource.DataMember = "TOV_RASH";
            this.tOVRASHBindingSource.DataSource = this.tOVARYBindingSource;
            // 
            // pOKUPATELITableAdapter
            // 
            this.pOKUPATELITableAdapter.ClearBeforeFill = true;
            // 
            // tOVARYTableAdapter
            // 
            this.tOVARYTableAdapter.ClearBeforeFill = true;
            // 
            // rASXODBindingSource
            // 
            this.rASXODBindingSource.DataMember = "RASXOD";
            this.rASXODBindingSource.DataSource = this.myBaseDataSet;
            // 
            // rASXODTableAdapter
            // 
            this.rASXODTableAdapter.ClearBeforeFill = true;
            // 
            // pOKRASHBindingSource
            // 
            this.pOKRASHBindingSource.DataMember = "POK_RASH";
            this.pOKRASHBindingSource.DataSource = this.pOKUPATELIBindingSource;
            // 
            // kODRASHDataGridViewTextBoxColumn
            // 
            this.kODRASHDataGridViewTextBoxColumn.DataPropertyName = "KOD_RASH";
            this.kODRASHDataGridViewTextBoxColumn.HeaderText = "KOD_RASH";
            this.kODRASHDataGridViewTextBoxColumn.Name = "kODRASHDataGridViewTextBoxColumn";
            this.kODRASHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATARASHDataGridViewTextBoxColumn
            // 
            this.dATARASHDataGridViewTextBoxColumn.DataPropertyName = "DATA_RASH";
            this.dATARASHDataGridViewTextBoxColumn.HeaderText = "DATA_RASH";
            this.dATARASHDataGridViewTextBoxColumn.Name = "dATARASHDataGridViewTextBoxColumn";
            // 
            // Tovar
            // 
            this.Tovar.DataPropertyName = "KOD_TOVAR";
            this.Tovar.DataSource = this.tOVARYBindingSource;
            this.Tovar.DisplayMember = "TOVAR";
            this.Tovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tovar.HeaderText = "Tovar";
            this.Tovar.Name = "Tovar";
            this.Tovar.ValueMember = "KOD_TOVAR";
            // 
            // POKUP
            // 
            this.POKUP.DataPropertyName = "KOD_POKUP";
            this.POKUP.DataSource = this.pOKUPATELIBindingSource;
            this.POKUP.DisplayMember = "POKUP";
            this.POKUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POKUP.HeaderText = "POKUP";
            this.POKUP.Name = "POKUP";
            this.POKUP.ValueMember = "KOD_POKUP";
            // 
            // kOLVODataGridViewTextBoxColumn
            // 
            this.kOLVODataGridViewTextBoxColumn.DataPropertyName = "KOLVO";
            this.kOLVODataGridViewTextBoxColumn.HeaderText = "KOLVO";
            this.kOLVODataGridViewTextBoxColumn.Name = "kOLVODataGridViewTextBoxColumn";
            // 
            // sTOIMDataGridViewTextBoxColumn
            // 
            this.sTOIMDataGridViewTextBoxColumn.DataPropertyName = "STOIM";
            this.sTOIMDataGridViewTextBoxColumn.HeaderText = "STOIM";
            this.sTOIMDataGridViewTextBoxColumn.Name = "sTOIMDataGridViewTextBoxColumn";
            // 
            // pOKUPDataGridViewTextBoxColumn
            // 
            this.pOKUPDataGridViewTextBoxColumn.DataPropertyName = "POKUP";
            this.pOKUPDataGridViewTextBoxColumn.HeaderText = "Покупатель";
            this.pOKUPDataGridViewTextBoxColumn.Name = "pOKUPDataGridViewTextBoxColumn";
            // 
            // gORODDataGridViewTextBoxColumn
            // 
            this.gORODDataGridViewTextBoxColumn.DataPropertyName = "GOROD";
            this.gORODDataGridViewTextBoxColumn.HeaderText = "Город";
            this.gORODDataGridViewTextBoxColumn.Name = "gORODDataGridViewTextBoxColumn";
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 454);
            this.Controls.Add(this.dgvRasxod);
            this.Controls.Add(this.dgvTovar);
            this.Controls.Add(this.dgvPokup);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOKUPATELIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasxod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVRASHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASXODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOKRASHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvPokup;
        private System.Windows.Forms.DataGridView dgvTovar;
        private System.Windows.Forms.DataGridView dgvRasxod;
        private myBaseDataSet myBaseDataSet;
        private System.Windows.Forms.BindingSource pOKUPATELIBindingSource;
        private myBaseDataSetTableAdapters.POKUPATELITableAdapter pOKUPATELITableAdapter;
        private System.Windows.Forms.BindingSource tOVARYBindingSource;
        private myBaseDataSetTableAdapters.TOVARYTableAdapter tOVARYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODTOVARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOVARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDIZMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTTOVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rASXODBindingSource;
        private myBaseDataSetTableAdapters.RASXODTableAdapter rASXODTableAdapter;
        private System.Windows.Forms.BindingSource pOKRASHBindingSource;
        private System.Windows.Forms.BindingSource tOVRASHBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODRASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tovar;
        private System.Windows.Forms.DataGridViewComboBoxColumn POKUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOLVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOKUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gORODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
    }
}

