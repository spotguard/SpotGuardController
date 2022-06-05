
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_B_port = new System.Windows.Forms.TextBox();
            this.button_conectar_port = new System.Windows.Forms.Button();
            this.button_B_port_status = new System.Windows.Forms.Button();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.button_signal_B_saludo = new System.Windows.Forms.Button();
            this.button_clear_Xbee_B = new System.Windows.Forms.Button();
            this.button_Xbee_B_ON = new System.Windows.Forms.Button();
            this.button_Xbee_B_OFF = new System.Windows.Forms.Button();
            this.button_escribir_XBee_B = new System.Windows.Forms.Button();
            this.button_guardar_XBee_B = new System.Windows.Forms.Button();
            this.textBox_descubrir_Xbee = new System.Windows.Forms.TextBox();
            this.button_descubrir_dispositivos = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Xbee_A_OFF = new System.Windows.Forms.Button();
            this.button_Xbee_A_ON = new System.Windows.Forms.Button();
            this.button_Xbee_C_OFF = new System.Windows.Forms.Button();
            this.button_Xbee_C_ON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_B_port
            // 
            this.textBox_B_port.Location = new System.Drawing.Point(122, 59);
            this.textBox_B_port.Name = "textBox_B_port";
            this.textBox_B_port.Size = new System.Drawing.Size(139, 20);
            this.textBox_B_port.TabIndex = 7;
            this.textBox_B_port.Text = "Introduzca puerto";
            // 
            // button_conectar_port
            // 
            this.button_conectar_port.Location = new System.Drawing.Point(16, 58);
            this.button_conectar_port.Name = "button_conectar_port";
            this.button_conectar_port.Size = new System.Drawing.Size(63, 23);
            this.button_conectar_port.TabIndex = 10;
            this.button_conectar_port.Text = "Conectar";
            this.button_conectar_port.UseVisualStyleBackColor = true;
            this.button_conectar_port.Click += new System.EventHandler(this.button_conectar_port_Click);
            // 
            // button_B_port_status
            // 
            this.button_B_port_status.BackColor = System.Drawing.Color.DimGray;
            this.button_B_port_status.Enabled = false;
            this.button_B_port_status.Location = new System.Drawing.Point(91, 58);
            this.button_B_port_status.Name = "button_B_port_status";
            this.button_B_port_status.Size = new System.Drawing.Size(25, 23);
            this.button_B_port_status.TabIndex = 11;
            this.button_B_port_status.Text = "x";
            this.button_B_port_status.UseVisualStyleBackColor = false;
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(273, 86);
            this.textBox_out.Multiline = true;
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.Size = new System.Drawing.Size(169, 200);
            this.textBox_out.TabIndex = 12;
            // 
            // button_signal_B_saludo
            // 
            this.button_signal_B_saludo.Location = new System.Drawing.Point(194, 86);
            this.button_signal_B_saludo.Name = "button_signal_B_saludo";
            this.button_signal_B_saludo.Size = new System.Drawing.Size(67, 23);
            this.button_signal_B_saludo.TabIndex = 13;
            this.button_signal_B_saludo.Text = "Modo AT";
            this.button_signal_B_saludo.UseVisualStyleBackColor = true;
            this.button_signal_B_saludo.Click += new System.EventHandler(this.button_signal_B_saludo_Click);
            // 
            // button_clear_Xbee_B
            // 
            this.button_clear_Xbee_B.Location = new System.Drawing.Point(420, 262);
            this.button_clear_Xbee_B.Name = "button_clear_Xbee_B";
            this.button_clear_Xbee_B.Size = new System.Drawing.Size(21, 23);
            this.button_clear_Xbee_B.TabIndex = 15;
            this.button_clear_Xbee_B.Text = "C";
            this.button_clear_Xbee_B.UseVisualStyleBackColor = true;
            this.button_clear_Xbee_B.Click += new System.EventHandler(this.button_clear_Xbee_B_Click);
            // 
            // button_Xbee_B_ON
            // 
            this.button_Xbee_B_ON.Location = new System.Drawing.Point(91, 144);
            this.button_Xbee_B_ON.Name = "button_Xbee_B_ON";
            this.button_Xbee_B_ON.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_B_ON.TabIndex = 16;
            this.button_Xbee_B_ON.Text = "ON";
            this.button_Xbee_B_ON.UseVisualStyleBackColor = true;
            this.button_Xbee_B_ON.Click += new System.EventHandler(this.button_Xbee_B_ON_Click);
            // 
            // button_Xbee_B_OFF
            // 
            this.button_Xbee_B_OFF.Location = new System.Drawing.Point(137, 144);
            this.button_Xbee_B_OFF.Name = "button_Xbee_B_OFF";
            this.button_Xbee_B_OFF.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_B_OFF.TabIndex = 17;
            this.button_Xbee_B_OFF.Text = "OFF";
            this.button_Xbee_B_OFF.UseVisualStyleBackColor = true;
            this.button_Xbee_B_OFF.Click += new System.EventHandler(this.button_Xbee_B_OFF_Click);
            // 
            // button_escribir_XBee_B
            // 
            this.button_escribir_XBee_B.Location = new System.Drawing.Point(194, 115);
            this.button_escribir_XBee_B.Name = "button_escribir_XBee_B";
            this.button_escribir_XBee_B.Size = new System.Drawing.Size(67, 23);
            this.button_escribir_XBee_B.TabIndex = 18;
            this.button_escribir_XBee_B.Text = "Escribir";
            this.button_escribir_XBee_B.UseVisualStyleBackColor = true;
            this.button_escribir_XBee_B.Click += new System.EventHandler(this.button_escribir_XBee_B_Click);
            // 
            // button_guardar_XBee_B
            // 
            this.button_guardar_XBee_B.Location = new System.Drawing.Point(194, 144);
            this.button_guardar_XBee_B.Name = "button_guardar_XBee_B";
            this.button_guardar_XBee_B.Size = new System.Drawing.Size(67, 23);
            this.button_guardar_XBee_B.TabIndex = 19;
            this.button_guardar_XBee_B.Text = "Guardar";
            this.button_guardar_XBee_B.UseVisualStyleBackColor = true;
            this.button_guardar_XBee_B.Click += new System.EventHandler(this.button_guardar_XBee_B_Click);
            // 
            // textBox_descubrir_Xbee
            // 
            this.textBox_descubrir_Xbee.Location = new System.Drawing.Point(16, 205);
            this.textBox_descubrir_Xbee.Multiline = true;
            this.textBox_descubrir_Xbee.Name = "textBox_descubrir_Xbee";
            this.textBox_descubrir_Xbee.Size = new System.Drawing.Size(164, 82);
            this.textBox_descubrir_Xbee.TabIndex = 21;
            // 
            // button_descubrir_dispositivos
            // 
            this.button_descubrir_dispositivos.Location = new System.Drawing.Point(16, 176);
            this.button_descubrir_dispositivos.Name = "button_descubrir_dispositivos";
            this.button_descubrir_dispositivos.Size = new System.Drawing.Size(164, 23);
            this.button_descubrir_dispositivos.TabIndex = 22;
            this.button_descubrir_dispositivos.Text = "Descubrir dispositivos XBee";
            this.button_descubrir_dispositivos.UseVisualStyleBackColor = true;
            this.button_descubrir_dispositivos.Click += new System.EventHandler(this.button_descubrir_dispositivos_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 11);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(324, 24);
            this.label_titulo.TabIndex = 23;
            this.label_titulo.Text = "SpotGuard Controller 802.15.4 TH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "XBee C";
            // 
            // button_Xbee_A_OFF
            // 
            this.button_Xbee_A_OFF.Location = new System.Drawing.Point(137, 86);
            this.button_Xbee_A_OFF.Name = "button_Xbee_A_OFF";
            this.button_Xbee_A_OFF.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_A_OFF.TabIndex = 26;
            this.button_Xbee_A_OFF.Text = "OFF";
            this.button_Xbee_A_OFF.UseVisualStyleBackColor = true;
            this.button_Xbee_A_OFF.Click += new System.EventHandler(this.button_Xbee_A_OFF_Click);
            // 
            // button_Xbee_A_ON
            // 
            this.button_Xbee_A_ON.Location = new System.Drawing.Point(91, 86);
            this.button_Xbee_A_ON.Name = "button_Xbee_A_ON";
            this.button_Xbee_A_ON.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_A_ON.TabIndex = 25;
            this.button_Xbee_A_ON.Text = "ON";
            this.button_Xbee_A_ON.UseVisualStyleBackColor = true;
            this.button_Xbee_A_ON.Click += new System.EventHandler(this.button_Xbee_A_ON_Click);
            // 
            // button_Xbee_C_OFF
            // 
            this.button_Xbee_C_OFF.Location = new System.Drawing.Point(137, 115);
            this.button_Xbee_C_OFF.Name = "button_Xbee_C_OFF";
            this.button_Xbee_C_OFF.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_C_OFF.TabIndex = 28;
            this.button_Xbee_C_OFF.Text = "OFF";
            this.button_Xbee_C_OFF.UseVisualStyleBackColor = true;
            this.button_Xbee_C_OFF.Click += new System.EventHandler(this.button_Xbee_C_OFF_Click);
            // 
            // button_Xbee_C_ON
            // 
            this.button_Xbee_C_ON.Location = new System.Drawing.Point(91, 115);
            this.button_Xbee_C_ON.Name = "button_Xbee_C_ON";
            this.button_Xbee_C_ON.Size = new System.Drawing.Size(43, 23);
            this.button_Xbee_C_ON.TabIndex = 27;
            this.button_Xbee_C_ON.Text = "ON";
            this.button_Xbee_C_ON.UseVisualStyleBackColor = true;
            this.button_Xbee_C_ON.Click += new System.EventHandler(this.button_Xbee_C_ON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "XBee B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "XBee A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "CONSOLA";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Demo loop 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 38);
            this.button3.TabIndex = 34;
            this.button3.Text = "Demo loop 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "V 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 299);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Xbee_C_OFF);
            this.Controls.Add(this.button_Xbee_C_ON);
            this.Controls.Add(this.button_Xbee_A_OFF);
            this.Controls.Add(this.button_Xbee_A_ON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.button_descubrir_dispositivos);
            this.Controls.Add(this.textBox_descubrir_Xbee);
            this.Controls.Add(this.button_guardar_XBee_B);
            this.Controls.Add(this.button_escribir_XBee_B);
            this.Controls.Add(this.button_Xbee_B_OFF);
            this.Controls.Add(this.button_Xbee_B_ON);
            this.Controls.Add(this.button_clear_Xbee_B);
            this.Controls.Add(this.button_signal_B_saludo);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.button_B_port_status);
            this.Controls.Add(this.button_conectar_port);
            this.Controls.Add(this.textBox_B_port);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpotGuard Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_B_port;
        private System.Windows.Forms.Button button_conectar_port;
        private System.Windows.Forms.Button button_B_port_status;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Button button_signal_B_saludo;
        private System.Windows.Forms.Button button_clear_Xbee_B;
        private System.Windows.Forms.Button button_Xbee_B_ON;
        private System.Windows.Forms.Button button_Xbee_B_OFF;
        private System.Windows.Forms.Button button_escribir_XBee_B;
        private System.Windows.Forms.Button button_guardar_XBee_B;
        private System.Windows.Forms.TextBox textBox_descubrir_Xbee;
        private System.Windows.Forms.Button button_descubrir_dispositivos;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Xbee_A_OFF;
        private System.Windows.Forms.Button button_Xbee_A_ON;
        private System.Windows.Forms.Button button_Xbee_C_OFF;
        private System.Windows.Forms.Button button_Xbee_C_ON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}

