using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFgenerarControles
{
    public partial class Form1 : Form
    {
        Label label1;
        Button button1;
        MenuStrip menuStrip1;
        ToolStripMenuItem Archivo, Editar, Ver, Firma, Salir;

        public Form1()
        {
            InitializeComponent();
            GenerateControls();
        }

        public void GenerateControls()
        {
            // ! Generate a laber control
            label1 = new Label();
            label1.Location = new Point(20, 30);
            label1.Width = 60;
            label1.Height = 30;
            label1.Text = "Luis Ángel";
            this.Controls.Add(label1);

            // ! Button control
            button1 = new Button();
            button1.Location = new Point(100, 30);
            button1.Size = new Size(80, 30);
            button1.Text = "ESIME ICE";
            button1.Click += Button1_Click;
            this.Controls.Add(button1);

            // ! Menu stripe options
            Archivo = new ToolStripMenuItem();
            Archivo.Text = "&Archivo";
            Editar = new ToolStripMenuItem();
            Editar.Text = "&Editar";
            Ver = new ToolStripMenuItem();
            Ver.Text = "&Ver";

            Firma = new ToolStripMenuItem();
            Firma.Text = "&Firma";
            Firma.Click += Firma_Click;

            Salir = new ToolStripMenuItem();
            Salir.Text = "&Salir";
            Salir.Click += Salir_Click;

            // ! Load the Firma and Salir options on the contextual Archivo menu
            Archivo.DropDownItems.AddRange(new ToolStripDropDownItem[] { Firma, Salir });

            // ! Creates the stripe menu
            menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Archivo, Editar, Ver });
            this.Controls.Add(menuStrip1);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IPN-ESIME");
        }
    }
}
