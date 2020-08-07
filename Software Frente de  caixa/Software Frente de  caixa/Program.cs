/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 16/04/2015
 * Hora: 16:23
 * 
 */
using System;
using System.Windows.Forms;

namespace Software_Frente_de__caixa
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
