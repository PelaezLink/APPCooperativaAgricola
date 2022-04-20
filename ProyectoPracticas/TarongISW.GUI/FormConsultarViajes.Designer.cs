
namespace TarongISW.GUI
{
    partial class FormConsultarViajes
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
            this.DNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.DateTimePicker();
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.comboBox_camion = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(0, 0);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(112, 29);
            this.DNI.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha llegada";
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(156, 128);
            this.salida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(224, 26);
            this.salida.TabIndex = 5;
            // 
            // llegada
            // 
            this.llegada.Location = new System.Drawing.Point(549, 128);
            this.llegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(224, 26);
            this.llegada.TabIndex = 6;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // comboBox_camion
            // 
            this.comboBox_camion.FormattingEnabled = true;
            this.comboBox_camion.Location = new System.Drawing.Point(156, 42);
            this.comboBox_camion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_camion.Name = "comboBox_camion";
            this.comboBox_camion.Size = new System.Drawing.Size(136, 28);
            this.comboBox_camion.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.Fecha,
            this.Cajas,
            this.Peso});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 249);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 378);
            this.dataGridView1.TabIndex = 11;
            // 
            // Parcela
            // 
            this.Parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Parcela.DataPropertyName = "ds_Parcela";
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.MinimumWidth = 6;
            this.Parcela.Name = "Parcela";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "ds_Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Cajas
            // 
            this.Cajas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cajas.DataPropertyName = "ds_Cajas";
            this.Cajas.HeaderText = "Nº de cajas";
            this.Cajas.MinimumWidth = 6;
            this.Cajas.Name = "Cajas";
            // 
            // Peso
            // 
            this.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Peso.DataPropertyName = "ds_Peso";
            this.Peso.HeaderText = "Peso total";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 634);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(549, 42);
            this.consultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(96, 46);
            this.consultar.TabIndex = 13;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // FormConsultarViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 689);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_camion);
            this.Controls.Add(this.llegada);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConsultarViajes";
            this.Text = "Consultar Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker salida;
        private System.Windows.Forms.DateTimePicker llegada;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox comboBox_camion;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button consultar;
    }
}