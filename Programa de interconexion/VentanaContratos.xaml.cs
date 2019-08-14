using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
// Le decimos a C# que usaremos la Libreria de Word
using Word = Microsoft.Office.Interop.Word;

namespace Programa_de_interconexion
{
    /// <summary>
    /// Lógica de interacción para VentanaContratos.xaml
    /// </summary>
    public partial class VentanaContratos : Window
    {
        public VentanaContratos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Abrimos un nuevo proceso de word para abrir el documento
            var apWord = new Word.Application();
            // Le decimos a word que el tipo de archivo es .doc
            Word.Document doc;
            // Le decimos que guarde un objeto vacio por si no se encuentra el archivo
            object opc = Type.Missing;
            // Le decimos que queremos que abra word al terminar
            apWord.Visible = true;
            // Le decimos donde esta el archivo
            string ruta = @"C:\Users\Robotica\Downloads\Botella-master\Botella-master\Programa de interconexion\bin\Debug\ejemplo.docx";
            // Guardamos la ruta como un objeto para el metodo de la libreria
            object param = ruta;
            // Guardamos el nombre del marcador para el metodo de la libreria
            object nombre = "Texto";


            // Abrimos el documento pasando los datos anteriores como referencias
            doc = apWord.Documents.Open(ref param, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc, ref opc);

            //en caso que el marcador con el nombre "Texto" exista
            if (doc.Bookmarks.Exists("Texto"))
            {
                // Le decimos a word que encuentre el marcador con nombre "Texto"
                Word.Range texto = doc.Bookmarks.get_Item(ref nombre).Range;
                // Le asignamos el valor al marcador
                texto.Text = txtNombre.Text;
                // Recreamos el marcador por si lo ocupamos de nuevo en el formato
                object nuevorango = texto;
                doc.Bookmarks.Add("Texto", ref nuevorango);

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
