using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;

namespace WinBTC
{
    public partial class Form1 : Form
    {

        // Variaveis globais
        int T_buffer;
        //int[] array1 = new int[5];
        double[] V_buffer = new double[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T_buffer = Convert.ToInt32(txtBuffer.Text);
            
           
        }

        private void Btn_Arq_Click(object sender, EventArgs e)
        {
            //var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "xlsx files (*.*) | *.csv";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                }
            }

            txtArq.Text = filePath;
            Le_linha(1);
            Atualiza();
        }
        private void Atualiza()
        {
            double d2 = Convert.ToDouble(txtC_V.Text);
            double c2 = Convert.ToDouble(txtCotacao.Text);
            double g2 = Convert.ToDouble(txtSaldoBTCini.Text);
            double h2 = g2 * c2;
            double f2 = Convert.ToDouble(txtSaldoUini.Text);
            double i2 = h2 + f2;
            txtBtc_Conv.Text = (c2 * d2).ToString();
            txtBTC_Cota.Text = (h2).ToString();
            
            txtSaldoSoma.Text = (i2).ToString();
        }


        private double C_Media(double[] V_buffer_c)
        {
            double soma = 0;
            
            for (int a = 1; a <= T_buffer; a++)
            {
                soma = soma + V_buffer_c[a];
                //txtMedia.Text = txtMedia.Text + soma + "\n";
            }
            double media = (soma / T_buffer);
            return media;
        }
        private void Calculos(double media_loc)
        {
            //double lucroAtual = 0;
            //double SaldoBTC = Convert.ToDouble(txtSaldoAtual.Text);
            
            //double ValorAtual = Convert.ToDouble(txtLinhaAtual.Text);
            //double mxCompra = Convert.ToDouble(txtMxCompra.Text);
            //double mxVenda = Convert.ToDouble(txtMxVenda.Text);

            //if (ValorAtual < media_loc)
            //{
            //    //Compra xx BTC por cotação atual de U$
            //    SaldoBTC = SaldoBTC - mxCompra;
            //}
            //if (ValorAtual > media_loc)
            //{
            //    //Vende xx BTC por cotação atual de U$
            //    SaldoBTC = SaldoBTC + mxVenda;
            //}

            //txtSaldoAtual.Text = SaldoBTC.ToString();
            
        }


        private void LerArquivo()
        {
            int i = 0; // controle do buffer
            int l = 0; // controle linha
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };

            using var streamReader = File.OpenText(txtArq.Text);
           
            using var csvReader = new CsvReader(streamReader, csvConfig);

            while (csvReader.Read())
            {
                var v_open = csvReader.GetField(1);
                i++;
                l++;
                txtLinha.Text = l.ToString();
                
                V_buffer[i] = Convert.ToDouble(v_open);
                
                if (i >= T_buffer)
                {
                    i = 0;
                }
                
                Calculos(C_Media(V_buffer));

            }
        }

        private void Le_linha(int l1)
        {
          
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };

            using var streamReader = File.OpenText(txtArq.Text);

            using var csvReader = new CsvReader(streamReader, csvConfig);
            while (csvReader.Read())
            {
                var v_open = csvReader.GetField(1);
                txtCotacao.Text = v_open.ToString();
                txtLinha.Text = l1.ToString();

                break;              

            }


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }

        private void txtBuffer_TextChanged(object sender, EventArgs e)
        {
            T_buffer = Convert.ToInt32(txtBuffer.Text);
        }
    }
}
