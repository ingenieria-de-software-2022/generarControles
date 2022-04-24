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
        Button button1, button2;
        MenuStrip menuStrip1;
        TextBox textBox1;
        ToolStripMenuItem Archivo, Editar, Ver, Firma, Salir;
        RadioButton radioButton1;
        DateTimePicker dateTimePicker1;
        PictureBox pictureBox1;
        CheckBox checkBox1;
        GroupBox groupBox1;
        ProgressBar progressBar1;
        TrackBar trackBar1;
        WebBrowser webBrowser1;
        ListBox listBox1;
        RichTextBox richTextBox1;
        TabControl tabControl1;
        TabPage tabPage1, tabPage2;
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1;
        System.Windows.Forms.DataVisualization.Charting.Legend legend1;
        System.Windows.Forms.DataVisualization.Charting.Series series1;
        System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public Form1()
        {
            InitializeComponent();
            GenerateControls();
            webBrowser1.Navigate("https://www.google.com/");
        }

        public void GenerateControls()
        {
            // * Generate a label control
            label1 = new Label();
            label1.Location = new Point(20, 30);
            label1.Width = 60;
            label1.Height = 30;
            label1.Text = "Luis Ángel";
            this.Controls.Add(label1);

            // * Button control
            button1 = new Button();
            button1.Location = new Point(100, 30);
            button1.Size = new Size(80, 30);
            button1.Text = "ESIME ICE";
            button1.Click += Button1_Click;
            this.Controls.Add(button1);
            
            button2 = new Button();
            button2.Location = new Point(325, 90);
            button2.Size = new Size(80, 30);
            button2.Text = "Graficar";
            button2.Click += Button2_Click;
            this.Controls.Add(button2);

            // * Menu stripe options
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

            // * Load the Firma and Salir options on the contextual Archivo menu
            Archivo.DropDownItems.AddRange(new ToolStripDropDownItem[] { Firma, Salir });

            // * Creates the stripe menu
            menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Archivo, Editar, Ver });
            this.Controls.Add(menuStrip1);

            // * Create a TextBox
            textBox1 = new TextBox();
            textBox1.Text = "Hola desde un textBox";
            textBox1.Location = new System.Drawing.Point(50, 75);
            textBox1.Width = 160;
            textBox1.Height = 30;
            this.Controls.Add(textBox1);

            // * Create a radio button
            radioButton1 = new RadioButton();
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(60, 205);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(85, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Radio button";
            radioButton1.UseVisualStyleBackColor = true;
            this.Controls.Add(radioButton1);

            // * Create a dateTimePicker
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Location = new System.Drawing.Point(432, 376);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            dateTimePicker1.TabIndex = 0;
            this.Controls.Add(dateTimePicker1);

            // * Create a pictureBox
            pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(432, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(190, 116);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Image = new Bitmap("image.jpg");
            this.Controls.Add(pictureBox1);

            // * checkBox
            checkBox1 = new CheckBox();
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(94, 286);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(80, 17);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            this.Controls.Add(checkBox1);

            // * GroupBox
            groupBox1 = new GroupBox();
            groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            groupBox1.Location = new System.Drawing.Point(94, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(137, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            this.Controls.Add(groupBox1);

            // * ProgressBar
            progressBar1 = new ProgressBar();
            progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar1.Location = new System.Drawing.Point(94, 245);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(100, 23);
            progressBar1.TabIndex = 2;
            this.Controls.Add(progressBar1);

            // TrackBar
            trackBar1 = new TrackBar();
            trackBar1.Location = new System.Drawing.Point(53, 134);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(104, 45);
            trackBar1.TabIndex = 3;
            this.Controls.Add(trackBar1);

            // WebBrowser 
            webBrowser1 = new WebBrowser();
            webBrowser1.Location = new System.Drawing.Point(233, 184);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(182, 119);
            webBrowser1.TabIndex = 4;
            this.Controls.Add(webBrowser1);

            // ListBox 
            listBox1 = new ListBox();
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] {
            "ListBox",
            "Component"});
            listBox1.Location = new System.Drawing.Point(264, 327);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(106, 56);
            listBox1.TabIndex = 5;
            this.Controls.Add(listBox1);

            // RichTextBox 
            richTextBox1 = new RichTextBox();
            richTextBox1.Location = new System.Drawing.Point(264, 401);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(137, 26);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "richTextBox";
            this.Controls.Add(richTextBox1);

            // * TabPage 1
            tabPage1 = new TabPage();
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(123, 176);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;

            // * TabPage 1
            tabPage2 = new TabPage();
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(123, 176);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;

            // TabControl 
            tabControl1 = new TabControl();
            tabControl1.ResumeLayout(false);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(642, 184);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(131, 202);
            tabControl1.TabIndex = 7;
            this.Controls.Add(tabControl1);

            // * Chart
            chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new System.Drawing.Point(444, 71);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new System.Drawing.Size(180, 138);
            chart1.TabIndex = 8;
            chart1.Text = "chart1";
            this.Controls.Add(chart1);
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
        
        private void Button2_Click(object sender, EventArgs e)
        {
            double x, y;

            for (int k = 0; k < 32; k++)
            {
                x = 4.75 + k;
                y = Math.Cos(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }
    }
}
