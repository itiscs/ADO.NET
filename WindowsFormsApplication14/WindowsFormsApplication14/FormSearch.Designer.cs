namespace WindowsFormsApplication14
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tOVARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBaseDataSet = new WindowsFormsApplication14.myBaseDataSet();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tOVARYTableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.TOVARYTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtEdizm = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATARASHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODPOKUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POKUP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pOKUPATELIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOVRASHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rASXODTableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.RASXODTableAdapter();
            this.pOKUPATELITableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.POKUPATELITableAdapter();
            this.btnKod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnName = new System.Windows.Forms.Button();
            this.btnEdizm = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOKUPATELIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVRASHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tOVARYBindingSource;
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
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(791, 25);
            this.bindingNavigator1.TabIndex = 3;
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
            // tOVARYBindingSource
            // 
            this.tOVARYBindingSource.DataMember = "TOVARY";
            this.tOVARYBindingSource.DataSource = this.myBaseDataSet;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOVARYBindingSource, "TOVAR", true));
            this.txtName.Location = new System.Drawing.Point(127, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 4;
            // 
            // tOVARYTableAdapter
            // 
            this.tOVARYTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Код";
            // 
            // txtKod
            // 
            this.txtKod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOVARYBindingSource, "KOD_TOVAR", true));
            this.txtKod.Location = new System.Drawing.Point(127, 37);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(185, 20);
            this.txtKod.TabIndex = 8;
            // 
            // txtEdizm
            // 
            this.txtEdizm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOVARYBindingSource, "ED_IZM", true));
            this.txtEdizm.Location = new System.Drawing.Point(127, 89);
            this.txtEdizm.Name = "txtEdizm";
            this.txtEdizm.Size = new System.Drawing.Size(185, 20);
            this.txtEdizm.TabIndex = 9;
            // 
            // txtCena
            // 
            this.txtCena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOVARYBindingSource, "ZENA", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtCena.Location = new System.Drawing.Point(127, 115);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(185, 20);
            this.txtCena.TabIndex = 10;
            // 
            // txtCount
            // 
            this.txtCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOVARYBindingSource, "COUNT_TOV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCount.Location = new System.Drawing.Point(127, 141);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(185, 20);
            this.txtCount.TabIndex = 11;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ед.Изм.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATARASHDataGridViewTextBoxColumn,
            this.kOLVODataGridViewTextBoxColumn,
            this.sTOIMDataGridViewTextBoxColumn,
            this.kODPOKUPDataGridViewTextBoxColumn,
            this.POKUP});
            this.dataGridView1.DataSource = this.tOVRASHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 149);
            this.dataGridView1.TabIndex = 16;
            // 
            // dATARASHDataGridViewTextBoxColumn
            // 
            this.dATARASHDataGridViewTextBoxColumn.DataPropertyName = "DATA_RASH";
            this.dATARASHDataGridViewTextBoxColumn.Frozen = true;
            this.dATARASHDataGridViewTextBoxColumn.HeaderText = "DATA_RASH";
            this.dATARASHDataGridViewTextBoxColumn.Name = "dATARASHDataGridViewTextBoxColumn";
            // 
            // kOLVODataGridViewTextBoxColumn
            // 
            this.kOLVODataGridViewTextBoxColumn.DataPropertyName = "KOLVO";
            this.kOLVODataGridViewTextBoxColumn.Frozen = true;
            this.kOLVODataGridViewTextBoxColumn.HeaderText = "KOLVO";
            this.kOLVODataGridViewTextBoxColumn.Name = "kOLVODataGridViewTextBoxColumn";
            // 
            // sTOIMDataGridViewTextBoxColumn
            // 
            this.sTOIMDataGridViewTextBoxColumn.DataPropertyName = "STOIM";
            this.sTOIMDataGridViewTextBoxColumn.Frozen = true;
            this.sTOIMDataGridViewTextBoxColumn.HeaderText = "STOIM";
            this.sTOIMDataGridViewTextBoxColumn.Name = "sTOIMDataGridViewTextBoxColumn";
            // 
            // kODPOKUPDataGridViewTextBoxColumn
            // 
            this.kODPOKUPDataGridViewTextBoxColumn.DataPropertyName = "KOD_POKUP";
            this.kODPOKUPDataGridViewTextBoxColumn.Frozen = true;
            this.kODPOKUPDataGridViewTextBoxColumn.HeaderText = "KOD_POKUP";
            this.kODPOKUPDataGridViewTextBoxColumn.Name = "kODPOKUPDataGridViewTextBoxColumn";
            // 
            // POKUP
            // 
            this.POKUP.DataPropertyName = "KOD_POKUP";
            this.POKUP.DataSource = this.pOKUPATELIBindingSource;
            this.POKUP.DisplayMember = "POKUP";
            this.POKUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POKUP.HeaderText = "Покупатель";
            this.POKUP.Name = "POKUP";
            this.POKUP.ReadOnly = true;
            this.POKUP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.POKUP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.POKUP.ValueMember = "KOD_POKUP";
            // 
            // pOKUPATELIBindingSource
            // 
            this.pOKUPATELIBindingSource.DataMember = "POKUPATELI";
            this.pOKUPATELIBindingSource.DataSource = this.myBaseDataSet;
            // 
            // tOVRASHBindingSource
            // 
            this.tOVRASHBindingSource.DataMember = "TOV_RASH";
            this.tOVRASHBindingSource.DataSource = this.tOVARYBindingSource;
            // 
            // rASXODTableAdapter
            // 
            this.rASXODTableAdapter.ClearBeforeFill = true;
            // 
            // pOKUPATELITableAdapter
            // 
            this.pOKUPATELITableAdapter.ClearBeforeFill = true;
            // 
            // btnKod
            // 
            this.btnKod.Location = new System.Drawing.Point(327, 35);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(75, 23);
            this.btnKod.TabIndex = 17;
            this.btnKod.Text = "Искать";
            this.btnKod.UseVisualStyleBackColor = true;
            this.btnKod.Click += new System.EventHandler(this.btnKod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tOVARYBindingSource, "PICTURE", true));
            this.pictureBox1.Location = new System.Drawing.Point(432, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 148);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(327, 65);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 19;
            this.btnName.Text = "Искать";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnEdizm
            // 
            this.btnEdizm.Location = new System.Drawing.Point(327, 95);
            this.btnEdizm.Name = "btnEdizm";
            this.btnEdizm.Size = new System.Drawing.Size(75, 23);
            this.btnEdizm.TabIndex = 20;
            this.btnEdizm.Text = "Искать";
            this.btnEdizm.UseVisualStyleBackColor = true;
            this.btnEdizm.Click += new System.EventHandler(this.btnEdizm_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(127, 170);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(0, 13);
            this.lblNotFound.TabIndex = 21;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(666, 33);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 50);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Загрузить рисунок";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 443);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnEdizm);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtEdizm);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOKUPATELIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVRASHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtName;
        private myBaseDataSet myBaseDataSet;
        private System.Windows.Forms.BindingSource tOVARYBindingSource;
        private myBaseDataSetTableAdapters.TOVARYTableAdapter tOVARYTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtEdizm;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tOVRASHBindingSource;
        private myBaseDataSetTableAdapters.RASXODTableAdapter rASXODTableAdapter;
        private System.Windows.Forms.BindingSource pOKUPATELIBindingSource;
        private myBaseDataSetTableAdapters.POKUPATELITableAdapter pOKUPATELITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOLVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODPOKUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn POKUP;
        private System.Windows.Forms.Button btnKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnEdizm;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnImage;
    }
}