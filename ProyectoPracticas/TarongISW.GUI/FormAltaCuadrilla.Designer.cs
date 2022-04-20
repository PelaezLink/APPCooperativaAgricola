
namespace TarongISW.GUI
{
    partial class FormAltaCuadrilla
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
            this.comboBox_parcela = new System.Windows.Forms.ComboBox();
            this.listBox_trabajadores = new System.Windows.Forms.CheckedListBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_parcela
            // 
            this.comboBox_parcela.FormattingEnabled = true;
            this.comboBox_parcela.Location = new System.Drawing.Point(244, 51);
            this.comboBox_parcela.Name = "comboBox_parcela";
            this.comboBox_parcela.Size = new System.Drawing.Size(362, 28);
            this.comboBox_parcela.TabIndex = 0;
            // 
            // listBox_trabajadores
            // 
            this.listBox_trabajadores.Location = new System.Drawing.Point(244, 114);
            this.listBox_trabajadores.Name = "listBox_trabajadores";
            this.listBox_trabajadores.Size = new System.Drawing.Size(362, 234);
            this.listBox_trabajadores.TabIndex = 0;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(244, 383);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(133, 37);
            this.button_cancelar.TabIndex = 1;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(473, 383);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(133, 37);
            this.button_aceptar.TabIndex = 2;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parcela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trabajadores";
            // 
            // FormAltaCuadrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.listBox_trabajadores);
            this.Controls.Add(this.comboBox_parcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAltaCuadrilla";
            this.Text = "Alta Cuadrilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_parcela;
        private System.Windows.Forms.CheckedListBox listBox_trabajadores;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}