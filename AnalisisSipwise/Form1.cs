using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisSipwise
{
    public partial class Form1 : Form
    {
        //Variables Globales
        private decimal cont;


        string pass = "";

        // FUNCIONES

        public Form1()
        {
            InitializeComponent();
            leerConfig();
            cont = num_Segundos.Value;

        }
        /*Funcion que lee desde fichero la configuracion inicial del programa. En este caso lee los segundos que tarda en actualizar
         Y lee el fichero donde esta la clave privada para conectarse mendiante ssh */
        private void leerConfig()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"config.txt");
            while ((line = file.ReadLine()) != null)
            {


                if (counter == 0)
                {
                    num_Segundos.Value = Convert.ToDecimal(line);
                    num_segundos_2.Value = Convert.ToDecimal(line);
                }
                if (counter == 1)
                {
                    pass = line;
                }

                counter++;
            }


            file.Close();

            // Suspend the screen.  
            System.Console.ReadLine();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        /*Funcion que pasandole un dialer y la ip abre la ip mendiante ssh*/
        public void canales(string dialer)
        {

            // Variable que creamos una conexion con uso de claves privadas y publicas
            var con = new ConnectionInfo(dialer, 8228, "ivan", new PrivateKeyAuthenticationMethod("ivan", new PrivateKeyFile(pass)));

            SshClient sshclient = new SshClient(con);
            //SshClient sshclient = new SshClient("dialer1.menytel.com", 20022, "root", "MenyDial2017");
            sshclient.Connect();
            SshCommand test = sshclient.CreateCommand("./test.sh");
            test.Execute();
            txt_srv2.Text = test.Result;
            string[] caract = test.Result.Split(',');
            txt_srv3.Text = "";
            string aux ="";
            
           // Bucle que recorre el array con la consulta realizada
            for (int i=0;i<caract.Length;i++) {

                aux += caract[i] + "\n\r";
               
            }
            txt_srv3.Text = aux;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cont--;
            if (ch_autorefresco.Checked) { 
            LB_cuentaatras.Text = cont.ToString();
            }
            if (ch_autorefresco_2.Checked) { 
            LB_cuentaatras_2.Text = cont.ToString();
            }
            if (cont == 0 )
            {
                canales("srv3.menytel.com");
                cont = num_Segundos.Value;
            }
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Refresco.Enabled = false;
        }

        private void Ch_autorefresco_CheckedChanged(object sender, EventArgs e)
        {

            if (ch_autorefresco.Checked == true) { 
            Refresco.Enabled = true;

            }else
            {
            Refresco.Enabled = false;
            }
        }

        private void Ch_autorefresco_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_autorefresco_2.Checked == true)
            {
                Refresco.Enabled = true;

            }
            else
            {
                Refresco.Enabled = false;
            }
        }

        private void Num_Segundos_ValueChanged(object sender, EventArgs e)
        {
            cont = num_Segundos.Value;
            

        }

        private void Btm_refrescar_Click(object sender, EventArgs e)
        {
            canales("srv3.menytel.com");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_srv3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
