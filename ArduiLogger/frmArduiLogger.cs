/// Proyecto realizado por UnboundDarkness, de www.programnation.com
/// Licencia: LGPL3 http://www.gnu.org/licenses/lgpl.html
/// 
/// Parte de este trabajo se basa en el trabajo de:
/// http://www.johnciacia.com/2010/06/03/interacting-with-the-arduino-with-c/
/// Otras fuentes:
/// http://msdn.microsoft.com/en-us/library/system.io.ports.serialport.datareceived.aspx
/// http://www.dotnetperls.com/savefiledialog

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Arduino_Logger
{
    public partial class frmArduiLogger : Form
    {
        #region Globales
        SerialPort puerto;
        #endregion

        #region Inicialización de los objetos.
        public frmArduiLogger()
        {
            InitializeComponent();
        }

        private void frmArduinoLogger_Load(object sender, EventArgs e)
        {
            cargarVelocidadesTransmision();
            listarPuertos();
            // Condiciones iniciales.
            txtLog.Text = "";
            lblEstado.Text = "Estado: Desconectado.";
            if (cboPuerto.Items.Count >= 1)
                cboPuerto.SelectedIndex = 0;
            cboBaudios.SelectedIndex = 2;
            habilitarBotones(true, false, false);
            verPlayPausa(true);
        }

        /// <summary>
        /// Carga las posibles velocidades de transmisión en el combo correspondiente.
        /// </summary>
        private void cargarVelocidadesTransmision() {
            cboBaudios.Items.Clear();
            cboBaudios.Items.Add(2400);
            cboBaudios.Items.Add(4800);
            cboBaudios.Items.Add(9600);
            cboBaudios.Items.Add(14400);
            cboBaudios.Items.Add(19200);
            cboBaudios.Items.Add(28800);
            cboBaudios.Items.Add(38400);
        }

        /// <summary>
        /// Sirve para listar los puertos seriales disponibles para su uso en el combo correspondiente.
        /// </summary>
        private void listarPuertos(){
            cboPuerto.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            foreach (string puerto in puertos)
            {
                cboPuerto.Items.Add(puerto);
            }
        }
        #endregion

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            mnuSalir_Click(null, null);
        }

        private void tsbConectar_Click(object sender, EventArgs e)
        {
            mnuConectar_Click(null, null);
        }

        private void mnuConectar_Click(object sender, EventArgs e)
        {
            try
            {
                puerto = new SerialPort(cboPuerto.Text, int.Parse(cboBaudios.Text));
                if (!puerto.IsOpen)
                {
                    puerto.Open();
                    pnlConfiguracion.Visible = false;
                    lblEstado.Text = "Estado: Conectado en el puerto " + cboPuerto.Text;
                    puerto.DataReceived += new SerialDataReceivedEventHandler(puerto_DataReceived);
                    habilitarBotones(false, true, false);
                }
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }
        }

        delegate void MostrarTextoCallback(string texto);
        private void MostrarTexto(string texto)
        {
            if (this.txtLog.InvokeRequired)
            {
                MostrarTextoCallback d = new MostrarTextoCallback(MostrarTexto);
                this.BeginInvoke(d, new object[] { texto });
            }
            else
            {
                txtLog.AppendText(texto);
            }
        }

        private void puerto_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                MostrarTexto(puerto.ReadExisting());
            }

            catch (Exception ex)
            {
                MostrarTexto(ex.ToString());
            }
        }

        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        /// <summary>
        /// Determina que botones están habilitados en la interfaz.
        /// </summary>
        /// <param name="conf">Controla los botones de configuración.</param>
        /// <param name="ctl">Controla los botones de control.</param>
        /// <param name="edit">Controla los botones de edición.</param>
        private void habilitarBotones(bool conf, bool ctl, bool edit)
        {
            // Botones de configuración.
            tsbConectar.Enabled = conf;
            mnuConectar.Enabled = conf;
            // Botones de control.
            tsbPlay.Enabled = ctl;
            tsbPausa.Enabled = ctl;
            tsbStop.Enabled = ctl;
            mnuIniciar.Enabled = ctl;
            mnuPausar.Enabled = ctl;
            mnuDetener.Enabled = ctl;
            // Botones de edición.
            tsbGuardar.Enabled = edit;
            tsbLimpiar.Enabled = edit;
        }

        /// <summary>
        /// Define la visibilidad de Play/Pausa.
        /// </summary>
        /// <param name="valor">Determina la visibilidad de Play.</param>
        private void verPlayPausa(bool valor)
        {
            mnuIniciar.Visible = valor;
            tsbPlay.Visible = valor;
            mnuPausar.Visible = !valor;
            tsbPausa.Visible = !valor;
        }

        private void mnuIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                puerto.Write("1");
                verPlayPausa(false);
            }
            catch (Exception Ex)
            {
                lblEstado.Text = "Error de transmisión: " + Ex.Message;
            }
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            mnuIniciar_Click(null, null);
        }

        private void mnuPausar_Click(object sender, EventArgs e)
        {
            try
            {
                puerto.Write("2");
                verPlayPausa(true);
            }
            catch (Exception Ex)
            {
                lblEstado.Text = "Error de transmisión: " + Ex.Message;
            }
        }

        private void tsbPausa_Click(object sender, EventArgs e)
        {
            mnuPausar_Click(null, null);
        }

        private void mnuDetener_Click(object sender, EventArgs e)
        {
            try
            {
                mnuPausar_Click(null, null);
                puerto.Close();
                habilitarBotones(true, false, true);
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            mnuDetener_Click(null, null);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            string nombre = sfd.FileName;
            File.WriteAllText(nombre, txtLog.Text);
        }

        private void mnuAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcerca frm = new frmAcerca();
            frm.ShowDialog();
        }

        private void frmArduinoLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            mnuDetener_Click(null, null);
        }
    }
}