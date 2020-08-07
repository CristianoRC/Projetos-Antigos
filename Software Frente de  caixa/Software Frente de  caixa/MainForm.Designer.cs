/*
 * Criado por SharpDevelop.
 * Usuário: Cristiano Raffi Cunha
 * Data: 16/04/2015
 * Hora: 16:23
 * 
 */
namespace Software_Frente_de__caixa
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel Lbl_Login;
		private System.Windows.Forms.TextBox Txt_Login;
		private System.Windows.Forms.TextBox Txt_Senha;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Lbl_Login = new System.Windows.Forms.ToolStripStatusLabel();
			this.Txt_Login = new System.Windows.Forms.TextBox();
			this.Txt_Senha = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(60, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Logar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(202, 148);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "Sair";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Lbl_Login});
			this.statusStrip1.Location = new System.Drawing.Point(0, 229);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(473, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Lbl_Login
			// 
			this.Lbl_Login.ForeColor = System.Drawing.Color.Maroon;
			this.Lbl_Login.Name = "Lbl_Login";
			this.Lbl_Login.Size = new System.Drawing.Size(63, 17);
			this.Lbl_Login.Text = "Deslogado";
			// 
			// Txt_Login
			// 
			this.Txt_Login.Location = new System.Drawing.Point(60, 50);
			this.Txt_Login.Name = "Txt_Login";
			this.Txt_Login.Size = new System.Drawing.Size(216, 20);
			this.Txt_Login.TabIndex = 0;
			this.Txt_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LoginKeyPress);
			// 
			// Txt_Senha
			// 
			this.Txt_Senha.Location = new System.Drawing.Point(60, 93);
			this.Txt_Senha.Name = "Txt_Senha";
			this.Txt_Senha.Size = new System.Drawing.Size(216, 20);
			this.Txt_Senha.TabIndex = 1;
			this.Txt_Senha.UseSystemPasswordChar = true;
			this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SenhaKeyPress);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(311, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(138, 129);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 251);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Txt_Senha);
			this.Controls.Add(this.Txt_Login);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Software Frente de  caixa";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
