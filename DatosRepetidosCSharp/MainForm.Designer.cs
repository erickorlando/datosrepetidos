namespace DatosRepetidosCSharp
{
	partial class MainForm
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
			this.consultoraPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consultoraPedidoDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datoRepetidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.datoRepetidoDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTotal2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.consultoraPedidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoraPedidoDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datoRepetidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datoRepetidoDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// consultoraPedidoBindingSource
			// 
			this.consultoraPedidoBindingSource.DataSource = typeof(DatosRepetidosCSharp.ConsultoraPedido);
			// 
			// consultoraPedidoDataGridView
			// 
			this.consultoraPedidoDataGridView.AutoGenerateColumns = false;
			this.consultoraPedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.consultoraPedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.consultoraPedidoDataGridView.DataSource = this.consultoraPedidoBindingSource;
			this.consultoraPedidoDataGridView.Location = new System.Drawing.Point(12, 28);
			this.consultoraPedidoDataGridView.Name = "consultoraPedidoDataGridView";
			this.consultoraPedidoDataGridView.Size = new System.Drawing.Size(256, 299);
			this.consultoraPedidoDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Consultora";
			this.dataGridViewTextBoxColumn1.HeaderText = "Consultora";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Pedido";
			this.dataGridViewTextBoxColumn2.HeaderText = "Pedido";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// datoRepetidoBindingSource
			// 
			this.datoRepetidoBindingSource.DataSource = typeof(DatosRepetidosCSharp.DatoRepetido);
			// 
			// datoRepetidoDataGridView
			// 
			this.datoRepetidoDataGridView.AutoGenerateColumns = false;
			this.datoRepetidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datoRepetidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.datoRepetidoDataGridView.DataSource = this.datoRepetidoBindingSource;
			this.datoRepetidoDataGridView.Location = new System.Drawing.Point(343, 28);
			this.datoRepetidoDataGridView.Name = "datoRepetidoDataGridView";
			this.datoRepetidoDataGridView.Size = new System.Drawing.Size(258, 299);
			this.datoRepetidoDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
			this.dataGridViewTextBoxColumn3.HeaderText = "Total";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
			this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 337);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Total";
			// 
			// txtTotal1
			// 
			this.txtTotal1.Location = new System.Drawing.Point(100, 334);
			this.txtTotal1.Name = "txtTotal1";
			this.txtTotal1.Size = new System.Drawing.Size(100, 20);
			this.txtTotal1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(348, 333);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total";
			// 
			// txtTotal2
			// 
			this.txtTotal2.Location = new System.Drawing.Point(436, 330);
			this.txtTotal2.Name = "txtTotal2";
			this.txtTotal2.Size = new System.Drawing.Size(100, 20);
			this.txtTotal2.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 385);
			this.Controls.Add(this.txtTotal2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotal1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datoRepetidoDataGridView);
			this.Controls.Add(this.consultoraPedidoDataGridView);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.consultoraPedidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoraPedidoDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datoRepetidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datoRepetidoDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource consultoraPedidoBindingSource;
		private System.Windows.Forms.DataGridView consultoraPedidoDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.BindingSource datoRepetidoBindingSource;
		private System.Windows.Forms.DataGridView datoRepetidoDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTotal2;
	}
}