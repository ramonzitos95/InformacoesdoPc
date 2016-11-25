namespace Macoratti.TesteEmail
{
    partial class frmTesteEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteEmail));
            this.grbDePara = new System.Windows.Forms.GroupBox();
            this.txtAssuntoTitulo = new System.Windows.Forms.TextBox();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.grpAnexos = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtAnexos = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.grbDePara.SuspendLayout();
            this.grpMensagem.SuspendLayout();
            this.grpAnexos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDePara
            // 
            this.grbDePara.Controls.Add(this.txtAssuntoTitulo);
            this.grbDePara.Controls.Add(this.txtEnviadoPor);
            this.grbDePara.Controls.Add(this.txtEnviarPara);
            this.grbDePara.Controls.Add(this.lblSubjectLine);
            this.grbDePara.Controls.Add(this.lblRemetente);
            this.grbDePara.Controls.Add(this.lblDestinatario);
            this.grbDePara.Location = new System.Drawing.Point(13, 13);
            this.grbDePara.Name = "grbDePara";
            this.grbDePara.Size = new System.Drawing.Size(485, 100);
            this.grbDePara.TabIndex = 0;
            this.grbDePara.TabStop = false;
            this.grbDePara.Text = "De: Para";
            // 
            // txtAssuntoTitulo
            // 
            this.txtAssuntoTitulo.Location = new System.Drawing.Point(70, 70);
            this.txtAssuntoTitulo.Name = "txtAssuntoTitulo";
            this.txtAssuntoTitulo.Size = new System.Drawing.Size(399, 20);
            this.txtAssuntoTitulo.TabIndex = 5;
            this.txtAssuntoTitulo.Text = "teset";
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Location = new System.Drawing.Point(70, 46);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(399, 20);
            this.txtEnviadoPor.TabIndex = 4;
            this.txtEnviadoPor.Text = "macoratte@gmail.com";
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Location = new System.Drawing.Point(70, 22);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(399, 20);
            this.txtEnviarPara.TabIndex = 3;
            this.txtEnviarPara.Text = "macoratti@ig.com.br";
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(11, 74);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 2;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(35, 50);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(24, 13);
            this.lblRemetente.TabIndex = 1;
            this.lblRemetente.Text = "De:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(28, 25);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Para:";
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.Location = new System.Drawing.Point(13, 120);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(485, 204);
            this.grpMensagem.TabIndex = 1;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(25, 20);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(444, 167);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "teste de envio de email";
            // 
            // grpAnexos
            // 
            this.grpAnexos.Controls.Add(this.btnIncluir);
            this.grpAnexos.Controls.Add(this.txtAnexos);
            this.grpAnexos.Location = new System.Drawing.Point(13, 330);
            this.grpAnexos.Name = "grpAnexos";
            this.grpAnexos.Size = new System.Drawing.Size(485, 63);
            this.grpAnexos.TabIndex = 2;
            this.grpAnexos.TabStop = false;
            this.grpAnexos.Text = "Anexos";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(394, 26);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtAnexos
            // 
            this.txtAnexos.Location = new System.Drawing.Point(25, 28);
            this.txtAnexos.Name = "txtAnexos";
            this.txtAnexos.Size = new System.Drawing.Size(363, 20);
            this.txtAnexos.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(407, 399);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Add Attachment";
            // 
            // frmTesteEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(509, 431);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpAnexos);
            this.Controls.Add(this.grpMensagem);
            this.Controls.Add(this.grbDePara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviando Emails";
            this.grbDePara.ResumeLayout(false);
            this.grbDePara.PerformLayout();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.grpAnexos.ResumeLayout(false);
            this.grpAnexos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDePara;
        private System.Windows.Forms.TextBox txtAssuntoTitulo;
        private System.Windows.Forms.TextBox txtEnviadoPor;
        private System.Windows.Forms.TextBox txtEnviarPara;
        private System.Windows.Forms.Label lblSubjectLine;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.GroupBox grpMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.GroupBox grpAnexos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtAnexos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}

