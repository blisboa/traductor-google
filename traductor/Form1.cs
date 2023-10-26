using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traductor
{
    public partial class Form1 : Form
    {
        GoogleTranslateApi.Language source;
        GoogleTranslateApi.Language target;
        GoogleTranslateApi.GoogleTranslator translate;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // definir idiomas 
            source = GoogleTranslateApi.Language.Parse("es");
            target = GoogleTranslateApi.Language.Parse("en");        

            // declarar e inicializar Traductor
            translate = new GoogleTranslateApi.GoogleTranslator(
                source,
                target
            );

            string textSource = "buenos dias";
            string textTarget ="";

            // el metodo Text del objeto translate es que traduce
            textTarget =  translate.Text(textSource);

            MessageBox.Show(textTarget);
        }
    }
}
