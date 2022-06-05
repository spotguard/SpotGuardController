using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class XBeeSerialController
    {
        private SerialPort puertoActivo;
        bool status;
        public XBeeSerialController(string puerto)
        {
            try
            {
                puertoActivo = new SerialPort(puerto);
                status = true;
                puertoActivo.BaudRate = 9600;
                puertoActivo.Parity = Parity.None;
                puertoActivo.DataBits = 8;
                puertoActivo.StopBits = StopBits.One;

                puertoActivo.Open();
            } catch (Exception e)
            {
                status = false;
            }
        }

        public bool testSaludo()
        {
            string r = "";
            if (status)
            {
                enviarSeñal(20, 0);
                Thread.Sleep(1250);
                r = leerPuerto();
                puertoActivo.Close();
                if (r == "OK\r")
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
            
        }

        public bool getStatus()
        {
            return status;
        }

        public void abrirPuerto()
        {
            if (!puertoActivo.IsOpen)
            {
                puertoActivo.Open();
            }
        }

        public void cerrarPuerto()
        {
            if (puertoActivo.IsOpen)
            {
                puertoActivo.Close();
            }
        }

        public string leerPuerto()
        {
            string r;
            r = puertoActivo.ReadExisting();
    
            return r;
        }

        public void enviarSeñal(int action, int dio)
        {
            //Biblioteca de señales
            byte[] saludo =     { 0x2B, 0x2B, 0x2B }; //Act 20
            byte[] escribir =   { 0x41, 0x54, 0x57, 0x52, 0x0D }; //Act 21
            byte[] guardar =    { 0x41, 0x54, 0x43, 0x4E, 0x0D }; //Act 22
            byte[] d1_h =       { 0x41, 0x54, 0x44, 0x31, 0x35, 0x0D }; //Act 1 Dio 1
            byte[] d1_l =       { 0x41, 0x54, 0x44, 0x31, 0x34, 0x0D }; //Act 0 Dio 1
            byte[] d0_h =       { 0x41, 0x54, 0x44, 0x30, 0x35, 0x0D }; //Act 1 Dio 1
            byte[] d0_l =       { 0x41, 0x54, 0x44, 0x30, 0x34, 0x0D }; //Act 0 Dio 1 
            byte[] d3_h =       { 0x41, 0X54, 0X44, 0x33, 0x35, 0x0D }; //Act 1 Dio 3
            byte[] d3_l =       { 0x41, 0X54, 0X44, 0x33, 0x34, 0x0D }; //Act 0 Dio 3 
            byte[] d4_h =       { 0x41, 0X54, 0X44, 0x34, 0x35, 0x0D }; //Act 1 Dio 4 
            byte[] d4_l =       { 0x41, 0X54, 0X44, 0x34, 0x34, 0x0D }; //Act 0 Dio 4 
            byte[] d5_h =       { 0x41, 0X54, 0X44, 0x35, 0x35, 0x0D }; //Act 1 Dio 5 
            byte[] d5_l =       { 0x41, 0X54, 0X44, 0x35, 0x34, 0x0D }; //Act 0 Dio 5 

            switch (action)
            {
                case 0: //Apagar
                    switch (dio)
                    {
                        case 0:
                            puertoActivo.Write(d0_l, 0, d0_l.Length);
                            break;

                        case 1:
                            puertoActivo.Write(d1_l, 0, d1_l.Length);
                            break;

                        case 3:
                            puertoActivo.Write(d3_l, 0, d0_l.Length);
                            break;

                        case 4:
                            puertoActivo.Write(d4_l, 0, d0_l.Length);
                            break;

                        case 5:
                            puertoActivo.Write(d5_l, 0, d0_l.Length);
                            break;
                    }
                break;

                case 1:
                    switch (dio)
                    {
                        case 0:
                            puertoActivo.Write(d0_h, 0, d0_h.Length);
                            break;

                        case 1:
                            puertoActivo.Write(d1_h, 0, d1_h.Length);
                            break;

                        case 3:
                            puertoActivo.Write(d3_h, 0, d1_h.Length);
                            break;

                        case 4:
                            puertoActivo.Write(d4_h, 0, d1_h.Length);
                            break;

                        case 5:
                            puertoActivo.Write(d5_h, 0, d1_h.Length);
                            break;
                    }
                break;

                case 20: //Saludo
                    puertoActivo.Write(saludo, 0, saludo.Length);
                break;

                case 21: //escribir
                    puertoActivo.Write(escribir, 0, escribir.Length);
                break;

                case 22:
                    puertoActivo.Write(guardar, 0, guardar.Length);
                break;
            }
            
        }
    }
}
