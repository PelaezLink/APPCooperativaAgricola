
namespace TarongISW.GUI
{
    partial class TarongISWApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_alta_persona = new System.Windows.Forms.Button();
            this.button_asignar_viaje = new System.Windows.Forms.Button();
            this.button_alta_contrato = new System.Windows.Forms.Button();
            this.button_alta_cuadrilla = new System.Windows.Forms.Button();
            this.button_asignar_cajon = new System.Windows.Forms.Button();
            this.button_consultar_viajes = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_alta_persona
            // 
            this.button_alta_persona.Location = new System.Drawing.Point(35, 26);
            this.button_alta_persona.Name = "button_alta_persona";
            this.button_alta_persona.Size = new System.Drawing.Size(281, 81);
            this.button_alta_persona.TabIndex = 0;
            this.button_alta_persona.Text = "Alta persona";
            this.button_alta_persona.UseVisualStyleBackColor = true;
            this.button_alta_persona.Click += new System.EventHandler(this.button_alta_persona_Click);
            // 
            // button_asignar_viaje
            // 
            this.button_asignar_viaje.Location = new System.Drawing.Point(35, 153);
            this.button_asignar_viaje.Name = "button_asignar_viaje";
            this.button_asignar_viaje.Size = new System.Drawing.Size(281, 81);
            this.button_asignar_viaje.TabIndex = 1;
            this.button_asignar_viaje.Text = "Asignar viaje a camión";
            this.button_asignar_viaje.UseVisualStyleBackColor = true;
            this.button_asignar_viaje.Click += new System.EventHandler(this.button_asignar_viaje_Click);
            // 
            // button_alta_contrato
            // 
            this.button_alta_contrato.Location = new System.Drawing.Point(35, 278);
            this.button_alta_contrato.Name = "button_alta_contrato";
            this.button_alta_contrato.Size = new System.Drawing.Size(281, 81);
            this.button_alta_contrato.TabIndex = 2;
            this.button_alta_contrato.Text = "Alta contrato trabajador";
            this.button_alta_contrato.UseVisualStyleBackColor = true;
            this.button_alta_contrato.Click += new System.EventHandler(this.button_alta_contrato_Click);
            // 
            // button_alta_cuadrilla
            // 
            this.button_alta_cuadrilla.Location = new System.Drawing.Point(465, 26);
            this.button_alta_cuadrilla.Name = "button_alta_cuadrilla";
            this.button_alta_cuadrilla.Size = new System.Drawing.Size(281, 81);
            this.button_alta_cuadrilla.TabIndex = 3;
            this.button_alta_cuadrilla.Text = "Alta cuadrilla";
            this.button_alta_cuadrilla.UseVisualStyleBackColor = true;
            this.button_alta_cuadrilla.Click += new System.EventHandler(this.button_alta_cuadrilla_Click);
            // 
            // button_asignar_cajon
            // 
            this.button_asignar_cajon.Location = new System.Drawing.Point(465, 153);
            this.button_asignar_cajon.Name = "button_asignar_cajon";
            this.button_asignar_cajon.Size = new System.Drawing.Size(281, 81);
            this.button_asignar_cajon.TabIndex = 4;
            this.button_asignar_cajon.Text = "Asignar cajón a viaje";
            this.button_asignar_cajon.UseVisualStyleBackColor = true;
            this.button_asignar_cajon.Click += new System.EventHandler(this.button_asignar_cajon_Click);
            // 
            // button_consultar_viajes
            // 
            this.button_consultar_viajes.Location = new System.Drawing.Point(465, 278);
            this.button_consultar_viajes.Name = "button_consultar_viajes";
            this.button_consultar_viajes.Size = new System.Drawing.Size(281, 81);
            this.button_consultar_viajes.TabIndex = 5;
            this.button_consultar_viajes.Text = "Consultar viajes de camión";
            this.button_consultar_viajes.UseVisualStyleBackColor = true;
            this.button_consultar_viajes.Click += new System.EventHandler(this.button_consultar_viajes_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(293, 399);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(180, 45);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Salir";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // TarongISWApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_consultar_viajes);
            this.Controls.Add(this.button_asignar_cajon);
            this.Controls.Add(this.button_alta_cuadrilla);
            this.Controls.Add(this.button_alta_contrato);
            this.Controls.Add(this.button_asignar_viaje);
            this.Controls.Add(this.button_alta_persona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TarongISWApp";
            this.Text = "TarongISWApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_alta_persona;
        private System.Windows.Forms.Button button_asignar_viaje;
        private System.Windows.Forms.Button button_alta_contrato;
        private System.Windows.Forms.Button button_alta_cuadrilla;
        private System.Windows.Forms.Button button_asignar_cajon;
        private System.Windows.Forms.Button button_consultar_viajes;
        private System.Windows.Forms.Button button_exit;
    }
}

