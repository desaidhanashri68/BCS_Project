namespace WindowsFormsApplication3
{
    partial class Form36
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
            this.antivirus_servicesDataSet = new WindowsFormsApplication3.antivirus_servicesDataSet();
            this.antiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiTableAdapter = new WindowsFormsApplication3.antivirus_servicesDataSetTableAdapters.antiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.antivirus_servicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.antiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // antivirus_servicesDataSet
            // 
            this.antivirus_servicesDataSet.DataSetName = "antivirus_servicesDataSet";
            this.antivirus_servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // antiBindingSource
            // 
            this.antiBindingSource.DataMember = "anti";
            this.antiBindingSource.DataSource = this.antivirus_servicesDataSet;
            // 
            // antiTableAdapter
            // 
            this.antiTableAdapter.ClearBeforeFill = true;
            // 
            // Form36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 517);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form36";
            this.Text = "Form36";
            this.Load += new System.EventHandler(this.Form36_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antivirus_servicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource antiBindingSource;
        private antivirus_servicesDataSet antivirus_servicesDataSet;
        private antivirus_servicesDataSetTableAdapters.antiTableAdapter antiTableAdapter;
    }
}