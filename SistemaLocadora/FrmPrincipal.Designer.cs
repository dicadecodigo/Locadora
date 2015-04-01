namespace SistemaLocadora
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcervo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcervoCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcervoPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientesCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClientesPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuAcervo,
            this.mnuClientes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // mnuAcervo
            // 
            this.mnuAcervo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcervoCadastro,
            this.toolStripMenuItem1,
            this.mnuAcervoPesquisa});
            this.mnuAcervo.Name = "mnuAcervo";
            this.mnuAcervo.Size = new System.Drawing.Size(56, 20);
            this.mnuAcervo.Text = "Acervo";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(152, 22);
            this.mnuSair.Text = "Sai&r";
            // 
            // mnuClientes
            // 
            this.mnuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientesCadastro,
            this.toolStripMenuItem2,
            this.mnuClientesPesquisa});
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(61, 20);
            this.mnuClientes.Text = "Clientes";
            // 
            // mnuAcervoCadastro
            // 
            this.mnuAcervoCadastro.Name = "mnuAcervoCadastro";
            this.mnuAcervoCadastro.Size = new System.Drawing.Size(152, 22);
            this.mnuAcervoCadastro.Text = "Cadastro";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuAcervoPesquisa
            // 
            this.mnuAcervoPesquisa.Name = "mnuAcervoPesquisa";
            this.mnuAcervoPesquisa.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuAcervoPesquisa.Size = new System.Drawing.Size(152, 22);
            this.mnuAcervoPesquisa.Text = "Pesquisa";
            // 
            // mnuClientesCadastro
            // 
            this.mnuClientesCadastro.Name = "mnuClientesCadastro";
            this.mnuClientesCadastro.Size = new System.Drawing.Size(152, 22);
            this.mnuClientesCadastro.Text = "Cadastro";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuClientesPesquisa
            // 
            this.mnuClientesPesquisa.Name = "mnuClientesPesquisa";
            this.mnuClientesPesquisa.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuClientesPesquisa.Size = new System.Drawing.Size(152, 22);
            this.mnuClientesPesquisa.Text = "Pesquisa";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Locadora (COMPLETO) :: Dica de Código - www.dicadecodigo.com.br";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAcervo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuAcervoCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuAcervoPesquisa;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuClientesCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuClientesPesquisa;
    }
}

