namespace VerificarArquivos
{
    partial class Form1
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.fbdCaminho1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fdbCaminho2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbCamposDestino = new System.Windows.Forms.GroupBox();
            this.txtCaminhoDestino = new System.Windows.Forms.TextBox();
            this.btnSelecionarCaminhoDestino = new System.Windows.Forms.Button();
            this.grbCamposOrigem = new System.Windows.Forms.GroupBox();
            this.txtCaminhoOrigem = new System.Windows.Forms.TextBox();
            this.btnSelecionarCaminhoOrigem = new System.Windows.Forms.Button();
            this.grbListaArquivos = new System.Windows.Forms.GroupBox();
            this.dtgArquivos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbCamposDestino.SuspendLayout();
            this.grbCamposOrigem.SuspendLayout();
            this.grbListaArquivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(311, 457);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbListaArquivos);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.grbCamposDestino);
            this.panel1.Controls.Add(this.grbCamposOrigem);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 490);
            this.panel1.TabIndex = 9;
            // 
            // grbCamposDestino
            // 
            this.grbCamposDestino.Controls.Add(this.txtCaminhoDestino);
            this.grbCamposDestino.Controls.Add(this.btnSelecionarCaminhoDestino);
            this.grbCamposDestino.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCamposDestino.Location = new System.Drawing.Point(0, 50);
            this.grbCamposDestino.Name = "grbCamposDestino";
            this.grbCamposDestino.Size = new System.Drawing.Size(704, 50);
            this.grbCamposDestino.TabIndex = 13;
            this.grbCamposDestino.TabStop = false;
            this.grbCamposDestino.Text = "Destino:";
            // 
            // txtCaminhoDestino
            // 
            this.txtCaminhoDestino.Location = new System.Drawing.Point(12, 19);
            this.txtCaminhoDestino.Name = "txtCaminhoDestino";
            this.txtCaminhoDestino.Size = new System.Drawing.Size(633, 20);
            this.txtCaminhoDestino.TabIndex = 1;
            // 
            // btnSelecionarCaminhoDestino
            // 
            this.btnSelecionarCaminhoDestino.Location = new System.Drawing.Point(651, 17);
            this.btnSelecionarCaminhoDestino.Name = "btnSelecionarCaminhoDestino";
            this.btnSelecionarCaminhoDestino.Size = new System.Drawing.Size(35, 23);
            this.btnSelecionarCaminhoDestino.TabIndex = 5;
            this.btnSelecionarCaminhoDestino.Text = "...";
            this.btnSelecionarCaminhoDestino.UseVisualStyleBackColor = true;
            this.btnSelecionarCaminhoDestino.Click += new System.EventHandler(this.btnSelecionarCaminhoDestino_Click);
            // 
            // grbCamposOrigem
            // 
            this.grbCamposOrigem.Controls.Add(this.txtCaminhoOrigem);
            this.grbCamposOrigem.Controls.Add(this.btnSelecionarCaminhoOrigem);
            this.grbCamposOrigem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCamposOrigem.Location = new System.Drawing.Point(0, 0);
            this.grbCamposOrigem.Name = "grbCamposOrigem";
            this.grbCamposOrigem.Size = new System.Drawing.Size(704, 50);
            this.grbCamposOrigem.TabIndex = 12;
            this.grbCamposOrigem.TabStop = false;
            this.grbCamposOrigem.Text = "Origem:";
            // 
            // txtCaminhoOrigem
            // 
            this.txtCaminhoOrigem.Location = new System.Drawing.Point(12, 19);
            this.txtCaminhoOrigem.Name = "txtCaminhoOrigem";
            this.txtCaminhoOrigem.Size = new System.Drawing.Size(633, 20);
            this.txtCaminhoOrigem.TabIndex = 0;
            // 
            // btnSelecionarCaminhoOrigem
            // 
            this.btnSelecionarCaminhoOrigem.Location = new System.Drawing.Point(651, 17);
            this.btnSelecionarCaminhoOrigem.Name = "btnSelecionarCaminhoOrigem";
            this.btnSelecionarCaminhoOrigem.Size = new System.Drawing.Size(35, 23);
            this.btnSelecionarCaminhoOrigem.TabIndex = 4;
            this.btnSelecionarCaminhoOrigem.Text = "...";
            this.btnSelecionarCaminhoOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionarCaminhoOrigem.Click += new System.EventHandler(this.btnSelecionarCaminhoOrigem_Click);
            // 
            // grbListaArquivos
            // 
            this.grbListaArquivos.Controls.Add(this.dtgArquivos);
            this.grbListaArquivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbListaArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbListaArquivos.Location = new System.Drawing.Point(0, 100);
            this.grbListaArquivos.Name = "grbListaArquivos";
            this.grbListaArquivos.Size = new System.Drawing.Size(704, 351);
            this.grbListaArquivos.TabIndex = 14;
            this.grbListaArquivos.TabStop = false;
            this.grbListaArquivos.Text = "Lista de Arquivos";
            // 
            // dtgArquivos
            // 
            this.dtgArquivos.AllowUserToAddRows = false;
            this.dtgArquivos.AllowUserToDeleteRows = false;
            this.dtgArquivos.AllowUserToOrderColumns = true;
            this.dtgArquivos.AllowUserToResizeColumns = false;
            this.dtgArquivos.AllowUserToResizeRows = false;
            this.dtgArquivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgArquivos.Location = new System.Drawing.Point(3, 16);
            this.dtgArquivos.MultiSelect = false;
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.Size = new System.Drawing.Size(698, 332);
            this.dtgArquivos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 514);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.grbCamposDestino.ResumeLayout(false);
            this.grbCamposDestino.PerformLayout();
            this.grbCamposOrigem.ResumeLayout(false);
            this.grbCamposOrigem.PerformLayout();
            this.grbListaArquivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminho1;
        private System.Windows.Forms.FolderBrowserDialog fdbCaminho2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbCamposDestino;
        private System.Windows.Forms.TextBox txtCaminhoDestino;
        private System.Windows.Forms.Button btnSelecionarCaminhoDestino;
        private System.Windows.Forms.GroupBox grbCamposOrigem;
        private System.Windows.Forms.Button btnSelecionarCaminhoOrigem;
        private System.Windows.Forms.TextBox txtCaminhoOrigem;
        private System.Windows.Forms.GroupBox grbListaArquivos;
        private System.Windows.Forms.DataGridView dtgArquivos;
    }
}

