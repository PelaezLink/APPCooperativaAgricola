
namespace TarongISW.GUI
{
    partial class FormAltaContrato
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
            this.comboBox_dni = new System.Windows.Forms.ComboBox();
            this.radioButton_fijo = new System.Windows.Forms.RadioButton();
            this.radioButton_temporal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cuentaBancaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_incio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NSS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_salario = new System.Windows.Forms.TextBox();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.checkBox_fin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI";
            // 
            // comboBox_dni
            // 
            this.comboBox_dni.FormattingEnabled = true;
            this.comboBox_dni.Location = new System.Drawing.Point(278, 35);
            this.comboBox_dni.Name = "comboBox_dni";
            this.comboBox_dni.Size = new System.Drawing.Size(362, 28);
            this.comboBox_dni.TabIndex = 4;
            // 
            // radioButton_fijo
            // 
            this.radioButton_fijo.AutoSize = true;
            this.radioButton_fijo.Location = new System.Drawing.Point(278, 108);
            this.radioButton_fijo.Name = "radioButton_fijo";
            this.radioButton_fijo.Size = new System.Drawing.Size(59, 24);
            this.radioButton_fijo.TabIndex = 6;
            this.radioButton_fijo.TabStop = true;
            this.radioButton_fijo.Text = "Fijo";
            this.radioButton_fijo.UseVisualStyleBackColor = true;
            this.radioButton_fijo.CheckedChanged += new System.EventHandler(this.radioButton_fijo_CheckedChanged);
            // 
            // radioButton_temporal
            // 
            this.radioButton_temporal.AutoSize = true;
            this.radioButton_temporal.Location = new System.Drawing.Point(278, 147);
            this.radioButton_temporal.Name = "radioButton_temporal";
            this.radioButton_temporal.Size = new System.Drawing.Size(100, 24);
            this.radioButton_temporal.TabIndex = 7;
            this.radioButton_temporal.TabStop = true;
            this.radioButton_temporal.Text = "Temporal";
            this.radioButton_temporal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modalidad";
            // 
            // textBox_cuentaBancaria
            // 
            this.textBox_cuentaBancaria.Location = new System.Drawing.Point(278, 200);
            this.textBox_cuentaBancaria.Name = "textBox_cuentaBancaria";
            this.textBox_cuentaBancaria.Size = new System.Drawing.Size(362, 26);
            this.textBox_cuentaBancaria.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cuenta Bancaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha Inicio";
            // 
            // dateTimePicker_incio
            // 
            this.dateTimePicker_incio.Location = new System.Drawing.Point(278, 262);
            this.dateTimePicker_incio.Name = "dateTimePicker_incio";
            this.dateTimePicker_incio.Size = new System.Drawing.Size(362, 26);
            this.dateTimePicker_incio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "NSS";
            // 
            // textBox_NSS
            // 
            this.textBox_NSS.Location = new System.Drawing.Point(278, 322);
            this.textBox_NSS.Name = "textBox_NSS";
            this.textBox_NSS.Size = new System.Drawing.Size(362, 26);
            this.textBox_NSS.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Salario";
            // 
            // textBox_salario
            // 
            this.textBox_salario.Location = new System.Drawing.Point(278, 383);
            this.textBox_salario.Name = "textBox_salario";
            this.textBox_salario.Size = new System.Drawing.Size(362, 26);
            this.textBox_salario.TabIndex = 16;
            this.textBox_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salario_KeyPress);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Location = new System.Drawing.Point(278, 444);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(362, 26);
            this.dateTimePicker_fin.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Fin";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(507, 529);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(133, 37);
            this.button_aceptar.TabIndex = 20;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(278, 529);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(133, 37);
            this.button_cancelar.TabIndex = 19;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // checkBox_fin
            // 
            this.checkBox_fin.AutoSize = true;
            this.checkBox_fin.Location = new System.Drawing.Point(241, 450);
            this.checkBox_fin.Name = "checkBox_fin";
            this.checkBox_fin.Size = new System.Drawing.Size(22, 21);
            this.checkBox_fin.TabIndex = 21;
            this.checkBox_fin.UseVisualStyleBackColor = true;
            this.checkBox_fin.CheckedChanged += new System.EventHandler(this.checkBox_fin_CheckedChanged);
            // 
            // FormAltaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 619);
            this.Controls.Add(this.checkBox_fin);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_salario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_NSS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_incio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cuentaBancaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_temporal);
            this.Controls.Add(this.radioButton_fijo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_dni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAltaContrato";
            this.Text = "FormAltaContrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_dni;
        private System.Windows.Forms.RadioButton radioButton_fijo;
        private System.Windows.Forms.RadioButton radioButton_temporal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cuentaBancaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_incio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_salario;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.CheckBox checkBox_fin;
    }
}