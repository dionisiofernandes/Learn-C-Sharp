using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // Adicionar isto aqui!

namespace ReadXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Label1_Click(object sender, EventArgs e) // ainda nao funciona! :( 
        {

            Int32 app1name;

            XmlDocument xml = new XmlDocument();
            xml.Load(@"C:\Users\luis.fernandes\Desktop\config.xml");
            app1name = Convert.ToInt32(xml.SelectSingleNode("config/app1/name").InnerText); // nome da app1 no xml file.
            //app1path = Convert.ToInt32(xml.SelectSingleNode("config/app1/path").InnerText); // caminho da app1 no xml file.


            label1.Text = Convert.ToString(app1name);
        }
    }
}
