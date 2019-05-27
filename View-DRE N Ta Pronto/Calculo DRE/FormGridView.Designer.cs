namespace Calculo_DRE
{
    partial class FormGridView
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColunaIndicadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndicadoresJan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnaliseVerAtvDez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnaliseVerAtvJar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnáliseVertPassDez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnáliseVertPassJan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaIndicadores,
            this.IndicadoresJan,
            this.AnaliseVerAtvDez,
            this.AnaliseVerAtvJar,
            this.AnáliseVertPassDez,
            this.AnáliseVertPassJan});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1001, 450);
            this.dataGridView.TabIndex = 0;
            // 
            // ColunaIndicadores
            // 
            this.ColunaIndicadores.HeaderText = "Indicadores Dezembro";
            this.ColunaIndicadores.Name = "ColunaIndicadores";
            this.ColunaIndicadores.ReadOnly = true;
            this.ColunaIndicadores.Width = 200;
            // 
            // IndicadoresJan
            // 
            this.IndicadoresJan.HeaderText = "Indicadores Janeiro";
            this.IndicadoresJan.Name = "IndicadoresJan";
            this.IndicadoresJan.ReadOnly = true;
            this.IndicadoresJan.Width = 200;
            // 
            // AnaliseVerAtvDez
            // 
            this.AnaliseVerAtvDez.HeaderText = "Análise Vertical Ativo Dezembro";
            this.AnaliseVerAtvDez.Name = "AnaliseVerAtvDez";
            this.AnaliseVerAtvDez.ReadOnly = true;
            this.AnaliseVerAtvDez.Width = 200;
            // 
            // AnaliseVerAtvJar
            // 
            this.AnaliseVerAtvJar.HeaderText = "Análise Vertical Ativo Janeiro";
            this.AnaliseVerAtvJar.Name = "AnaliseVerAtvJar";
            this.AnaliseVerAtvJar.ReadOnly = true;
            this.AnaliseVerAtvJar.Width = 200;
            // 
            // AnáliseVertPassDez
            // 
            this.AnáliseVertPassDez.HeaderText = "Análise Vertical Passivo Dezembro";
            this.AnáliseVertPassDez.Name = "AnáliseVertPassDez";
            this.AnáliseVertPassDez.ReadOnly = true;
            this.AnáliseVertPassDez.Width = 200;
            // 
            // AnáliseVertPassJan
            // 
            this.AnáliseVertPassJan.HeaderText = "Análise Vertical Passivo Janeiro";
            this.AnáliseVertPassJan.Name = "AnáliseVertPassJan";
            this.AnáliseVertPassJan.ReadOnly = true;
            this.AnáliseVertPassJan.Width = 200;
            // 
            // FormGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormGridView";
            this.Text = "FormGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaIndicadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndicadoresJan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnaliseVerAtvDez;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnaliseVerAtvJar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnáliseVertPassDez;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnáliseVertPassJan;
    }
}