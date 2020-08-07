/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 16/04/2015
 * Hora: 16:34
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Frente_de__caixa
{

	public partial class Frm_Principal : Form
	{
		
		#region Variaveis
		
		//Variaveis
		
		short Quantidade;              //Quantidade de Produtos
		String Codigo;			      //Código do produto.
		Double Valor_Total;          //Valor Total depois do Troco.
		Double Valor_Pago;          //Valor por Unidade.
	    Double Valor_Unitario;     //Troco Dado.
		Double Troco;         	  //Troco Dado.
		Double Acumulador;       //Acumula os valores de cada soma.
 		Boolean Verificador;    //Verificador.
 		String Nome_Produto;   //Nome do produto para a nota.

		
		
		#endregion
		
		public Frm_Principal()
		{
			InitializeComponent();
		}
		
		#region Metodo Calcular
		private void Calcular()
		{

				//Pegando os valores do código e da quantidade.

					Codigo = Txt_Codigo.Text;
	
					Quantidade = short.Parse(Txt_Quantidade.Text);
					
			
			
					//Metodo  de verificar valor foto e outro.
			
					Verificar();


            if (Verificador == true)  //Verificar se o código foi achado.
            {




                //Calculos do valor total * quantidade.

                Acumulador = Valor_Unitario * Quantidade;


                Valor_Total += Acumulador;

                //Mandando os Valores.
                Lbl_ValorUni.Text = Convert.ToString(Valor_Unitario);
                Lbl_Troco.Text = "0,00";
                Lbl_Total.Text = Convert.ToString(Valor_Total);
                Lbl_NomeProd.Text = Nome_Produto;


                Txt_NotaFiscal.Text += "\n\r                \r\n";

                Txt_NotaFiscal.Text += Nome_Produto;


                



                //Limpando os TextBox.

                Txt_Codigo.Text = null;
                Txt_Quantidade.Text = "1";
                Txt_ValorPago.Text = "0,00";

            }
            else
            {
                Txt_Codigo.Clear();

                MessageBox.Show("Erro Verifique o Código");
            }

                   
					
			}

        #endregion

        #region Metodo Verificação de código Valor e Imagem

        private void Verificar()
		{
			Verificador = true;
			switch(Codigo)
			{
					case "1":

                    //Fanta
                    Pic_Produto.Image = Properties.Resources.Fanta;

						Valor_Unitario = 4.50;

                        Nome_Produto = "Fanta 2L";
						
						break;
					case "2":

                    //Coca
                    Pic_Produto.Image = Properties.Resources.coca_pet2l;

                        Valor_Unitario = 5.00;

                        Nome_Produto = "Coca-Cola 2L";
                        
						break;
					case "3":

                    //Arroz
                    Pic_Produto.Image = Properties.Resources.Arroz;

                        Valor_Unitario = 3.50;

                        Nome_Produto = "Arroz Tio João";
                        
						break;
					case "4": 

                    //Bola
                    Pic_Produto.Image = Properties.Resources.Bola;

                        Valor_Unitario = 69.00;

                        Nome_Produto = "Nike Mercurial";
                        
						break;
					case "5":

                    //Fifa 15
                    Pic_Produto.Image = Properties.Resources.Fifa_15;

                        Valor_Unitario = 185.00;

                        Nome_Produto = "Fifa 15";
                        
						break;
					case "6":

                    //Chinelo
                    Pic_Produto.Image = Properties.Resources.havaiana;

                        Valor_Unitario =25.00 ;

                        Nome_Produto = "Havaianas";
                        
						break;
					case "7":

                    //Xbox 360
                    Pic_Produto.Image = Properties.Resources.Xbox;

                        Valor_Unitario = 1200.00;

                        Nome_Produto = "Xbox 360";
                        
						break;
					case "8":

                    //Pendrive
                    Pic_Produto.Image = Properties.Resources.Pendrive;

                        Valor_Unitario = 20.00;

                        Nome_Produto = "Pendrive";
                        
						break;
					case "9":

                    //HD
                    Pic_Produto.Image = Properties.Resources.HD;

                        Valor_Unitario = 587.00;

                        Nome_Produto = "HD 1 TB";
                        
						break;
					case "10":

                    //Calculadora
                    Pic_Produto.Image = Properties.Resources.Calculadora;

                        Valor_Unitario = 12.00;

                        Nome_Produto = "Calculadora";
                        
						break;
					case "11":

                    //Cooler
                    Pic_Produto.Image = Properties.Resources.Cooler;

                        Valor_Unitario = 15.00;

                        Nome_Produto = "Cooler";
                        
						break;
					case "12":

                    //Roteador
                    Pic_Produto.Image = Properties.Resources.Roteador;
                        Valor_Unitario = 47.00;

                        Nome_Produto = "Roteador";
                        
						break;
					case "13":

                    //Cabo HDMI
                    Pic_Produto.Image = Properties.Resources.HDMI;

                        Valor_Unitario = 27.00;


                        Nome_Produto = "Cabo HDMI";
                        
						break;
					case "14":

                    //GPS
                    Pic_Produto.Image = Properties.Resources.GPS;

                        Valor_Unitario = 200.00;

                        Nome_Produto = "GPS";
                        
						break;
					case "15":

                    //Software
                    Pic_Produto.Image = Properties.Resources.Software;

                        Valor_Unitario = 230.00;

                        Nome_Produto = "Software";
                        
						break;
					default:
                    //Verificador = false;

                    Lbl_NomeProd.Text = "Produto não encontrado";
                    Lbl_ValorUni.Text = "0,00";

                        Verificador = false;
						break;
			}
			
		}
		
		#endregion
		
		#region Data, Hora & Exit 
		
		void Frm_PrincipalFormClosing(object sender, FormClosingEventArgs e)
		{	
			//Evento de fechar a a aplicação.
			
			Application.Exit();
		}
		
		
		void Frm_PrincipalLoad(object sender, EventArgs e)
		{
			//Carregamento do formulario.
			
			Lbl_Data.Text = DateTime.Now.ToShortDateString();
			
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//Timer
			
			Lbl_Hora.Text = DateTime.Now.ToShortTimeString();
			
		}
		
		#endregion
		
		#region Key Presss e Calculo do Troco
		
		
		
		
		void Frm_PrincipalKeyPress(object sender, KeyPressEventArgs e)
		{
			//Evento botão do Formulario.
			
			if(e.KeyChar == 13)
			{
				Calcular();
				
				
			}
			
		}
		
		
		void Txt_CodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			//Evento Txt_código do Formulario.
			
				if(e.KeyChar == 13) // 13 == enter
				{
					Calcular();				
			
				}
				else if(e.KeyChar == 27) // 27 == Esc
				{
					Frm_Principal principal = new Frm_Principal();
					
					principal.Show();
					
					this.Dispose();
				}
			}
		
		
		void Txt_QuantidadeKeyPress(object sender, KeyPressEventArgs e)
		{
			
					
		//Evento Txt_Qunatidade do Formulario.
			
			if(e.KeyChar == 13)//Enter == 13
			{
				
				Calcular();

			}
			
		}
		
		
		void Txt_ValorPagoKeyPress(object sender, KeyPressEventArgs e)
		{
			
			//Abrir menu ajuda do troco	
			//Calculo de Troco
			
			if(e.KeyChar == 13) //Enter
			{
				Valor_Pago = Double.Parse(Txt_ValorPago.Text);
				
				Troco = Valor_Pago - Valor_Total;
				
				Lbl_Troco.Text = Troco.ToString();
				
			}
			else if(e.KeyChar == 27) // 27 == Esc
			{
				
			

				Frm_Troco Frm_TrocoN = new Frm_Troco();
				
				Frm_TrocoN.Show();
				
				
			}
			
			
			
		}
		void Txt_ValorPagoClick(object sender, EventArgs e)
		{
			Txt_ValorPago.Clear();
		}
		
		#endregion
	}
}
 