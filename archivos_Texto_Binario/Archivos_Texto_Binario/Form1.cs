using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos_Texto_Binario
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Abre ventana de busqueda de archivos y almacena la extension
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnselecBMP_Click(object sender, EventArgs e)
		{
			oFD1.ShowDialog();
			FileStream file = new FileStream(oFD1.FileName, FileMode.Open);
			StreamReader sr = new StreamReader(file);
			Bitmap img = new Bitmap(oFD1.FileName);
			string filext = Path.GetExtension(oFD1.FileName);
			filesize(img);
			validar(filext);
			file.Close();
			sr.Close();
		}

		/// <summary>
		/// Valida que la extension del archivo sea la correcta, de lo contrario muestra un
		/// mensaje de error
		/// </summary>
		/// <param name="exte"></param>
		private void validar(string exte)
		{
			string vldr = System.IO.Path.GetExtension(exte);
			if (vldr != ".bmp")
			{
				MessageBox.Show("¡FORMATO INCORRECTO!");
			}
		}
		
		private void filesize(Bitmap img)
		{
			
			var imgWidth = img.Width; //Ancho en pixeles 
			var imgHeight = img.Height; //Alto en pixeles
			byte tamano = Convert.ToByte(imgHeight * imgWidth); //tamaño en bytes
			txtCaractBMP.Text = "Ancho: " + Convert.ToString(imgWidth) + "Alto: " + Convert.ToString(imgHeight) + "Tamaño: " +
				Convert.ToString(tamano);
		}
	}
}
