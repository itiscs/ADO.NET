﻿namespace WindowsFormsApplication14
{
    partial class FormReport2
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
            this.Zadacha2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBaseDataSet = new WindowsFormsApplication14.myBaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Zadacha2TableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.Zadacha2TableAdapter();
            this.RasxodDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RasxodDocTableAdapter = new WindowsFormsApplication14.myBaseDataSetTableAdapters.RasxodDocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RasxodDocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Zadacha2BindingSource
            // 
            this.Zadacha2BindingSource.DataMember = "Zadacha2";
            this.Zadacha2BindingSource.DataSource = this.myBaseDataSet;
            // 
            // myBaseDataSet
            // 
            this.myBaseDataSet.DataSetName = "myBaseDataSet";
            this.myBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RasxodDocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication14.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // Zadacha2TableAdapter
            // 
            this.Zadacha2TableAdapter.ClearBeforeFill = true;
            // 
            // RasxodDocBindingSource
            // 
            this.RasxodDocBindingSource.DataMember = "RasxodDoc";
            this.RasxodDocBindingSource.DataSource = this.myBaseDataSet;
            // 
            // RasxodDocTableAdapter
            // 
            this.RasxodDocTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport2";
            this.Text = "FormReport2";
            this.Load += new System.EventHandler(this.FormReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RasxodDocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Zadacha2BindingSource;
        private myBaseDataSet myBaseDataSet;
        private myBaseDataSetTableAdapters.Zadacha2TableAdapter Zadacha2TableAdapter;
        private System.Windows.Forms.BindingSource RasxodDocBindingSource;
        private myBaseDataSetTableAdapters.RasxodDocTableAdapter RasxodDocTableAdapter;
    }
}