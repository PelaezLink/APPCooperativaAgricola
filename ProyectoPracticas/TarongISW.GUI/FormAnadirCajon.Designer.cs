
namespace TarongISW.GUI
{
    partial class FormAnadirCajon
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_parcela = new System.Windows.Forms.ComboBox();
            this.listBox_dni = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_matricula = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parcela";
            // 
            // comboBox_parcela
            // 
            this.comboBox_parcela.FormattingEnabled = true;
            this.comboBox_parcela.Location = new System.Drawing.Point(155, 49);
            this.comboBox_parcela.Name = "comboBox_parcela";
            this.comboBox_parcela.Size = new System.Drawing.Size(362, 28);
            this.comboBox_parcela.TabIndex = 4;
            // 
            // listBox_dni
            // 
            this.listBox_dni.FormattingEnabled = true;
            this.listBox_dni.ItemHeight = 20;
            this.listBox_dni.Location = new System.Drawing.Point(155, 109);
            this.listBox_dni.Name = "listBox_dni";
            this.listBox_dni.Size = new System.Drawing.Size(362, 164);
            this.listBox_dni.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // listBox_matricula
            // 
            this.listBox_matricula.FormattingEnabled = true;
            this.listBox_matricula.ItemHeight = 20;
            this.listBox_matricula.Location = new System.Drawing.Point(698, 109);
            this.listBox_matricula.Name = "listBox_matricula";
            this.listBox_matricula.Size = new System.Drawing.Size(362, 164);
            this.listBox_matricula.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Matrícula ";
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(155, 339);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(362, 28);
            this.comboBox_product.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Producto";
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(698, 336);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(153, 26);
            this.textBox_peso.TabIndex = 12;
            this.textBox_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_peso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Peso";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(613, 446);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(133, 37);
            this.button_aceptar.TabIndex = 15;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(384, 446);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(133, 37);
            this.button_cancelar.TabIndex = 14;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // FormAnadirCajon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 522);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_dni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_parcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAnadirCajon";
            this.Text = "Asignar Cajon a Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_parcela;
        private System.Windows.Forms.ListBox listBox_dni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
    }
}