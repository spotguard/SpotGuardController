using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private XBeeSerialController XBee_C;

        private Thread thLoop1;
        private Thread thLoop2;

        public Form1()
        {
            InitializeComponent();
            habilitarPanel(false);
            button3.Enabled = false;
            button2.Enabled = false;

            thLoop1 = new Thread(demoLoop_1);
            thLoop2 = new Thread(demoLoop_2);
        }

        private void button_conectar_port_Click(object sender, EventArgs e)
        {
            XBee_C = new XBeeSerialController(textBox_B_port.Text);
            if (XBee_C.getStatus())
            {
                button_B_port_status.BackColor = Color.Green;
                button3.Enabled = true;
                button2.Enabled = true;
                habilitarPanel(true);
                
            } else
            {
                button_B_port_status.BackColor = Color.Red;
                button3.Enabled = false;
                button2.Enabled = false;
                habilitarPanel(false);
            }
        }

        private string esperarRespuesta()
        {
            string response = "";
            int timeout = 0;
            while (String.IsNullOrEmpty(response) && timeout < 30) //3 segundos
            {
                Thread.Sleep(300);
                response = XBee_C.leerPuerto();
                timeout++;
            }
            if (timeout >= 30)
            {
                response += "SIN RESPUESTA";
            }
            return response + " ";
        }

        private void button_descubrir_dispositivos_Click(object sender, EventArgs e)
        {
            textBox_descubrir_Xbee.Text = "Dispositivos descubiertos: \r\n";

            //Primeros 12 puertos
            XBeeSerialController aux;
            for (int i = 0; i < 12; i++)
            {
                aux = new XBeeSerialController("COM" + i.ToString());
                if (aux.testSaludo())
                {
                    textBox_descubrir_Xbee.Text += "COM" + i.ToString() + "\r\n";
                }
            }

            if (textBox_descubrir_Xbee.Text == "Dispositivos descubiertos: \r\n")
            {
                textBox_descubrir_Xbee.Text += "No se han detectado dispositivos XBee";
            }

        }

        private void button_signal_B_saludo_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(20, 0);
                textBox_out.Text += feedbackSeñal(20, 0) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_clear_Xbee_B_Click(object sender, EventArgs e)
        {
            textBox_out.Text = "";
        }

        private void button_leer_Xbee_B_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                textBox_out.Text = XBee_C.leerPuerto();
            }
        }

        private void button_escribir_XBee_B_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(21, 0);
                textBox_out.Text += feedbackSeñal(21, 0) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_guardar_XBee_B_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(22, 0);
                textBox_out.Text += feedbackSeñal(22, 0) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }


        private void button_Xbee_B_ON_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(1, 5);
                textBox_out.Text += feedbackSeñal(1, 5) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_Xbee_B_OFF_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(0, 5);
                textBox_out.Text += feedbackSeñal(0, 5) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }


        private void button_Xbee_C_ON_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(1, 4);
                textBox_out.Text += feedbackSeñal(1, 4) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_Xbee_C_OFF_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(0, 4);
                textBox_out.Text += feedbackSeñal(0, 4) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_Xbee_A_ON_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(1, 3);
                textBox_out.Text += feedbackSeñal(1, 3) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        private void button_Xbee_A_OFF_Click(object sender, EventArgs e)
        {
            if (XBee_C.getStatus())
            {
                XBee_C.enviarSeñal(0, 3);
                textBox_out.Text += feedbackSeñal(0, 3) + ": ";
                textBox_out.Text += esperarRespuesta() + "\r\n";
            }
        }

        public void habilitarPanel(bool value)
        {
            button_escribir_XBee_B.Enabled = value;
            button_guardar_XBee_B.Enabled = value;
            button_signal_B_saludo.Enabled = value;
            button_Xbee_A_ON.Enabled = value;
            button_Xbee_A_OFF.Enabled = value;
            button_Xbee_B_ON.Enabled = value;
            button_Xbee_B_OFF.Enabled = value;
            button_Xbee_C_ON.Enabled = value;
            button_Xbee_C_OFF.Enabled = value;
        }

        public string feedbackSeñal(int act, int dio)
        {
            switch (act)
            {
                case 0: //Apagar
                    switch (dio)
                    {
                        case 3:
                            return "ATD34";
                            break;

                        case 4:
                            return "ATD44";
                            break;

                        case 5:
                            return "ATD54";
                            break;
                    }
                    break;

                case 1:
                    switch (dio)
                    {                 
                        case 3:
                            return "ATD35";
                            break;

                        case 4:
                            return "ATD45";
                            break;

                        case 5:
                            return "ATD55";
                            break;
                    }
                    break;

                case 20: //Saludo
                    return "+++";
                    break;

                case 21: //escribir
                    return "ATWR";
                    break;

                case 22:
                    return "ATCN";
                    break;
                default:
                    return "ATERROR";
            }
            return "ATERROR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (thLoop1.IsAlive)
            {
                habilitarPanel(true);
                button3.Enabled = true;
                thLoop1.Interrupt();

            } else
            {
                habilitarPanel(false);
                button3.Enabled = false;
                thLoop1 = new Thread(demoLoop_1);
                thLoop1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thLoop2.IsAlive)
            {
                habilitarPanel(true);
                button2.Enabled = true;
                thLoop2.Interrupt();
            }
            else
            {

                habilitarPanel(false);
                button2.Enabled = false;
                thLoop2 = new Thread(demoLoop_2);
                thLoop2.Start();
            }
        }

        public void demoLoop_1()
        {

            int delay = 800;
            try
            {
                while (XBee_C.getStatus())
                {
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 5);
                    XBee_C.enviarSeñal(1, 4);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 4);
                    XBee_C.enviarSeñal(1, 3);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 3);
                    XBee_C.enviarSeñal(1, 5);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                }
            } catch (Exception x)
            {
                return;
            }
        }


        public void demoLoop_2()
        {

            int delay = 800;
            try
            {
                while (XBee_C.getStatus())
                {
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(1, 4);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(1, 3);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(1, 5);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 4);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 3);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                    Thread.Sleep(delay);
                    XBee_C.enviarSeñal(20, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(0, 5);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(21, 0);
                    esperarRespuesta();
                    XBee_C.enviarSeñal(22, 0);
                    esperarRespuesta();
                }
            }
            catch (Exception x)
            {
                return;
            }
        }

       
    }
}
