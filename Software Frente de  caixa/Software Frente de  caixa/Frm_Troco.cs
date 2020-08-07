/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 19/04/2015
 * Hora: 19:00
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Frente_de__caixa
{

	public partial class Frm_Troco : Form
	{
		public Frm_Troco()
		{

			InitializeComponent();
		}
		void Frm_TrocoLoad(object sender, EventArgs e)
		{

			
		}
		void Txt_ValorKeyPress(object sender, KeyPressEventArgs e)
		{
			uint Valor;
			
	
			
			if(e.KeyChar == 13)
			{
			
				Valor = uint.Parse(Txt_Valor.Text);
				

					
					Lbl_100.Text = Convert.ToString(Valor / 100);
						
					Valor = Valor % 100;
					
					
					
					
					Lbl_50.Text = Convert.ToString(Valor / 50);
					
					
					Valor = Valor % 50;
					
			
				
					Lbl_20.Text = Convert.ToString(Valor / 20);
										
					Valor = Valor % 20;
				
				
					
					Lbl_10.Text = Convert.ToString(Valor / 10);
										
					Valor = Valor % 10;
					
					
					
			
					Lbl_5.Text = Convert.ToString(Valor / 5);
					
					Valor = Valor % 5;
					
					
					
					
					Lbl_2.Text = Convert.ToString(Valor / 2);
					
					Valor = Valor % 2;
					
					Lbl_1Real.Text = Convert.ToString(Valor/1);
					
			}
		}
	}
}
