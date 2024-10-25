/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 23/10/2024
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCSharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Para seleccionar los 2 ultimos digitos del año y mes
			int year = mcNacimiento.SelectionStart.Year;
			int month = mcNacimiento.SelectionStart.Month;
			
			string UltimosDosY = (year % 100).ToString("D2");
			string UltimosDosM = month.ToString("D2");
			
			//Para seleccionar los 2 primeros digitos del apellido 1, 1 del 2 y 1 del nombre
			if(txtMaterno.Text.Length >= 2 && txtPaterno.Text.Length >= 1 && txtName.Text.Length >= 1)
			{
				//Se agregan al label los datos
				lblRFC.Text = txtPaterno.Text.Substring(0, 2) + txtMaterno.Text.Substring(0, 1)
				+ txtName.Text.Substring(0, 1) + UltimosDosY + UltimosDosM + mcNacimiento.SelectionStart.Day.ToString();
			}
		}
	}
}
