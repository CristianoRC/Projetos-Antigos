/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 16/04/2015
 * Hora: 16:23
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Frente_de__caixa
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			if(Txt_Login.Text == "Admin" && Txt_Senha.Text == "Admin")
			{
				
				Lbl_Login.Text = "logado!";
				
			Lbl_Login.ForeColor = Color.Green;
				
				
				Frm_Principal principal = new Frm_Principal();
				
				principal.Show();
			
				this.Visible = false;
								
				
				
			}
			else
			{
				
			MessageBox.Show("Erro tente novamente!");
				
				Lbl_Login.Text = "Erro Login ou Senha Invalidos!";
				Txt_Senha.Clear();
			    Txt_Login.Clear();
				
			}
				
			
		}
		void Button2Click(object sender, EventArgs e)
		{
				if(MessageBox.Show("Deseja sair do programa?", "Software Caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				
				Application.Exit();

			}
			
			
		}
		void Txt_SenhaKeyPress(object sender, KeyPressEventArgs e)
		{

			
		}
		void Txt_LoginKeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
