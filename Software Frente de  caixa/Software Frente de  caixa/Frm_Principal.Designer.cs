/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 16/04/2015
 * Hora: 16:34
 * 
 */
namespace Software_Frente_de__caixa
{
	partial class Frm_Principal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox Pic_Produto;
		private System.Windows.Forms.ToolStripStatusLabel Lbl_Data;
		private System.Windows.Forms.ToolStripStatusLabel Lbl_Hora;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label Lbl_Total;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Lbl_ValorUni;
		private System.Windows.Forms.Label Lbl_Troco;
		private System.Windows.Forms.TextBox Txt_Codigo;
		private System.Windows.Forms.TextBox Txt_Quantidade;
		private System.Windows.Forms.TextBox Txt_NotaFiscal;
		private System.Windows.Forms.TextBox Txt_ValorPago;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label Lbl_NomeProd;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
			this.Pic_Produto = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Lbl_Total = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Lbl_ValorUni = new System.Windows.Forms.Label();
			this.Lbl_Troco = new System.Windows.Forms.Label();
			this.Txt_NotaFiscal = new System.Windows.Forms.TextBox();
			this.Txt_Codigo = new System.Windows.Forms.TextBox();
			this.Txt_Quantidade = new System.Windows.Forms.TextBox();
			this.Txt_ValorPago = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Lbl_NomeProd = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Lbl_Data = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.Lbl_Hora = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Produto)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pic_Produto
			// 
			this.Pic_Produto.BackColor = System.Drawing.Color.Transparent;
			this.Pic_Produto.Location = new System.Drawing.Point(604, 206);
			this.Pic_Produto.Name = "Pic_Produto";
			this.Pic_Produto.Size = new System.Drawing.Size(214, 212);
			this.Pic_Produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Produto.TabIndex = 0;
			this.Pic_Produto.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 60;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// Lbl_Total
			// 
			this.Lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Total.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Total.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Total.Location = new System.Drawing.Point(99, 553);
			this.Lbl_Total.Name = "Lbl_Total";
			this.Lbl_Total.Size = new System.Drawing.Size(266, 61);
			this.Lbl_Total.TabIndex = 3;
			this.Lbl_Total.Text = "0,00";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 553);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 61);
			this.label1.TabIndex = 4;
			this.label1.Text = "R$";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(637, 470);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "R$";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(666, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "R$";
			// 
			// Lbl_ValorUni
			// 
			this.Lbl_ValorUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_ValorUni.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_ValorUni.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
			this.Lbl_ValorUni.ForeColor = System.Drawing.Color.Gray;
			this.Lbl_ValorUni.Location = new System.Drawing.Point(702, 91);
			this.Lbl_ValorUni.Name = "Lbl_ValorUni";
			this.Lbl_ValorUni.Size = new System.Drawing.Size(111, 23);
			this.Lbl_ValorUni.TabIndex = 8;
			this.Lbl_ValorUni.Text = "0,00";
			// 
			// Lbl_Troco
			// 
			this.Lbl_Troco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Troco.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Troco.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
			this.Lbl_Troco.Location = new System.Drawing.Point(673, 470);
			this.Lbl_Troco.Name = "Lbl_Troco";
			this.Lbl_Troco.Size = new System.Drawing.Size(111, 25);
			this.Lbl_Troco.TabIndex = 10;
			this.Lbl_Troco.Text = "0,00";
			// 
			// Txt_NotaFiscal
			// 
			this.Txt_NotaFiscal.BackColor = System.Drawing.Color.White;
			this.Txt_NotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Txt_NotaFiscal.Enabled = false;
			this.Txt_NotaFiscal.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_NotaFiscal.Location = new System.Drawing.Point(28, 177);
			this.Txt_NotaFiscal.Multiline = true;
			this.Txt_NotaFiscal.Name = "Txt_NotaFiscal";
			this.Txt_NotaFiscal.Size = new System.Drawing.Size(336, 333);
			this.Txt_NotaFiscal.TabIndex = 13;
			this.Txt_NotaFiscal.Text = "________________________________________________________\r\n\r\n                     " +
	"               ** Nota Fiscal **\r\n______________________________________________" +
	"__________";
			// 
			// Txt_Codigo
			// 
			this.Txt_Codigo.BackColor = System.Drawing.SystemColors.Menu;
			this.Txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Txt_Codigo.Font = new System.Drawing.Font("Arial", 10.25F);
			this.Txt_Codigo.Location = new System.Drawing.Point(398, 244);
			this.Txt_Codigo.MaxLength = 13;
			this.Txt_Codigo.Name = "Txt_Codigo";
			this.Txt_Codigo.Size = new System.Drawing.Size(163, 16);
			this.Txt_Codigo.TabIndex = 11;
			this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CodigoKeyPress);
			// 
			// Txt_Quantidade
			// 
			this.Txt_Quantidade.BackColor = System.Drawing.SystemColors.Menu;
			this.Txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Txt_Quantidade.Font = new System.Drawing.Font("Arial", 10.25F);
			this.Txt_Quantidade.Location = new System.Drawing.Point(398, 325);
			this.Txt_Quantidade.Name = "Txt_Quantidade";
			this.Txt_Quantidade.Size = new System.Drawing.Size(163, 16);
			this.Txt_Quantidade.TabIndex = 12;
			this.Txt_Quantidade.Text = "1";
			this.Txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_QuantidadeKeyPress);
			// 
			// Txt_ValorPago
			// 
			this.Txt_ValorPago.BackColor = System.Drawing.SystemColors.Menu;
			this.Txt_ValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Txt_ValorPago.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_ValorPago.Location = new System.Drawing.Point(428, 395);
			this.Txt_ValorPago.Name = "Txt_ValorPago";
			this.Txt_ValorPago.Size = new System.Drawing.Size(133, 22);
			this.Txt_ValorPago.TabIndex = 16;
			this.Txt_ValorPago.Text = "0,00";
			this.Txt_ValorPago.Click += new System.EventHandler(this.Txt_ValorPagoClick);
			this.Txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorPagoKeyPress);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(386, 395);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "R$";
			// 
			// Lbl_NomeProd
			// 
			this.Lbl_NomeProd.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_NomeProd.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold);
			this.Lbl_NomeProd.ForeColor = System.Drawing.Color.Gray;
			this.Lbl_NomeProd.Location = new System.Drawing.Point(33, 33);
			this.Lbl_NomeProd.Name = "Lbl_NomeProd";
			this.Lbl_NomeProd.Size = new System.Drawing.Size(715, 58);
			this.Lbl_NomeProd.TabIndex = 18;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Lbl_Data,
			this.toolStripStatusLabel1,
			this.Lbl_Hora});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(849, 22);
			this.statusStrip1.TabIndex = 19;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Lbl_Data
			// 
			this.Lbl_Data.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Data.Name = "Lbl_Data";
			this.Lbl_Data.Size = new System.Drawing.Size(51, 17);
			this.Lbl_Data.Text = "00/00/0000";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel1.Text = "|";
			// 
			// Lbl_Hora
			// 
			this.Lbl_Hora.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Hora.Name = "Lbl_Hora";
			this.Lbl_Hora.Size = new System.Drawing.Size(28, 17);
			this.Lbl_Hora.Text = "00:00";
			// 
			// Frm_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(849, 655);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.Lbl_NomeProd);
			this.Controls.Add(this.Txt_ValorPago);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Txt_Codigo);
			this.Controls.Add(this.Txt_Quantidade);
			this.Controls.Add(this.Txt_NotaFiscal);
			this.Controls.Add(this.Lbl_Troco);
			this.Controls.Add(this.Lbl_ValorUni);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Lbl_Total);
			this.Controls.Add(this.Pic_Produto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frente de Caixa";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_PrincipalFormClosing);
			this.Load += new System.EventHandler(this.Frm_PrincipalLoad);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_PrincipalKeyPress);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Produto)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
