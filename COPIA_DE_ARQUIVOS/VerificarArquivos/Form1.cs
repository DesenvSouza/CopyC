using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VerificarArquivos
{
    public partial class Form1 : Form
    {
        string strCheckBox = "[ ]";
        string strCaminhoArquivo = "Caminho do Arquivo";
        string strNomeArquivo = "Nome do Arquivo";
        string strDataCriacao = "Data de Criação";
        string strStatus = "Status";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarCaminhoOrigem_Click(object sender, EventArgs e)
        {
            try
            {
                fbdCaminho1.ShowDialog();
                txtCaminhoOrigem.Text = fbdCaminho1.SelectedPath.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSelecionarCaminhoDestino_Click(object sender, EventArgs e)
        {
            try
            {
                fdbCaminho2.ShowDialog();
                txtCaminhoDestino.Text = fdbCaminho2.SelectedPath.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCaminhoOrigem.Text != string.Empty && txtCaminhoDestino.Text != string.Empty)
                {
                    DirectoryInfo Pasta1 = new DirectoryInfo(txtCaminhoOrigem.Text);
                    DirectoryInfo Pasta2 = new DirectoryInfo(txtCaminhoDestino.Text);
                    var ArquivosPasta1 = Pasta1.GetFiles("*", SearchOption.AllDirectories);
                    var ArquivosPasta2 = Pasta2.GetFiles("*", SearchOption.AllDirectories);
                    //ArrayList arlListaArquivos = new ArrayList();
                    DataTable dtbTabelaTemporaria = new DataTable();
                    dtbTabelaTemporaria.Columns.Add(strCheckBox, typeof(bool));
                    dtbTabelaTemporaria.Columns.Add(strCaminhoArquivo, typeof(string));
                    dtbTabelaTemporaria.Columns.Add(strNomeArquivo, typeof(string));
                    dtbTabelaTemporaria.Columns.Add(strDataCriacao, typeof(DateTime));
                    dtbTabelaTemporaria.Columns.Add(strStatus, typeof(Image));

                    foreach (var Arquivo in ArquivosPasta1)
                    {
                        var existe = ArquivosPasta2.FirstOrDefault(x => x.Name.Equals(Arquivo.Name));
                        if (existe == null)
                        {
                            DataRow dtrLinha = dtbTabelaTemporaria.NewRow();
                           

                            dtrLinha[strCheckBox] = true;
                            dtrLinha[strCaminhoArquivo] = Arquivo.DirectoryName;
                            dtrLinha[strNomeArquivo] = Arquivo.Name;
                            dtrLinha[strDataCriacao] = Arquivo.CreationTime;
                            dtrLinha[strStatus] = ;


                            dtbTabelaTemporaria.Rows.Add(dtrLinha);
                        }
                    }

                    this.dtgArquivos.DataSource = dtbTabelaTemporaria;

                    this.dtgArquivos.Columns[strCheckBox].Width = 27;
                    this.dtgArquivos.Columns[strCaminhoArquivo].Width = 260;
                    this.dtgArquivos.Columns[strCaminhoArquivo].ReadOnly = true;
                    this.dtgArquivos.Columns[strNomeArquivo].Width = 255;
                    this.dtgArquivos.Columns[strNomeArquivo].ReadOnly = true;
                    this.dtgArquivos.Columns[strDataCriacao].Width = 113;
                    this.dtgArquivos.Columns[strDataCriacao].ReadOnly = true;


                    MessageBox.Show(ArquivosPasta1.Length + " Arquivos Divergentes, Relatório \"VerificarArquivos.txt\" gerado em C:\\");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
