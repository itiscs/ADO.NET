namespace WindowsFormsApplication14
{
    partial class FormReport1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.myBaseDataSet = new WindowsFormsApplication14.myBaseDataSet();
            this.Zadacha1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Zadacha1TableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.Zadacha1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Zadacha1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication14.ReportZadacha1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(440, 289);
            this.reportViewer1.TabIndex = 0;
            // 
            // myBaseDataSet
            // 
            this.myBaseDataSet.DataSetName = "myBaseDataSet";
            this.myBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Zadacha1BindingSource
            // 
            this.Zadacha1BindingSource.DataMember = "Zadacha1";
            this.Zadacha1BindingSource.DataSource = this.myBaseDataSet;
            // 
            // Zadacha1TableAdapter
            // 
            this.Zadacha1TableAdapter.ClearBeforeFill = true;
            // 
            // FormReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 303);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport1";
            this.Text = "FormReport1";
            this.Load += new System.EventHandler(this.FormReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Zadacha1BindingSource;
        private myBaseDataSet myBaseDataSet;
        private myBaseDataSetTableAdapters.Zadacha1TableAdapter Zadacha1TableAdapter;
    }
}