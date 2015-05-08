namespace WindowsFormsApplication1
{
	partial class Form1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.proxyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proxylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.gov_auditDataSet = new WindowsFormsApplication1.gov_auditDataSet();
			this.proxy_listTableAdapter = new WindowsFormsApplication1.gov_auditDataSetTableAdapters.proxy_listTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proxylistBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gov_auditDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proxyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.proxylistBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(22, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// proxyDataGridViewTextBoxColumn
			// 
			this.proxyDataGridViewTextBoxColumn.DataPropertyName = "proxy";
			this.proxyDataGridViewTextBoxColumn.HeaderText = "proxy";
			this.proxyDataGridViewTextBoxColumn.Name = "proxyDataGridViewTextBoxColumn";
			// 
			// proxylistBindingSource
			// 
			this.proxylistBindingSource.DataMember = "proxy_list";
			this.proxylistBindingSource.DataSource = this.bindingSource1;
			this.proxylistBindingSource.CurrentChanged += new System.EventHandler(this.proxylistBindingSource_CurrentChanged);
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.gov_auditDataSet;
			this.bindingSource1.Position = 0;
			// 
			// gov_auditDataSet
			// 
			this.gov_auditDataSet.DataSetName = "gov_auditDataSet";
			this.gov_auditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// proxy_listTableAdapter
			// 
			this.proxy_listTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proxylistBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gov_auditDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private gov_auditDataSet gov_auditDataSet;
		private System.Windows.Forms.BindingSource proxylistBindingSource;
		private gov_auditDataSetTableAdapters.proxy_listTableAdapter proxy_listTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn proxyDataGridViewTextBoxColumn;
	}
}

