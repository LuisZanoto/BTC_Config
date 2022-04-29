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
            //Negocio.ClassGlobal.ArqRede = filePath;
        }
        private String Calculos(double[] V_buffer_c)
        {
            double soma = 0;
            
            for (int a = 1; a <= T_buffer; a++)
            {
                soma = soma + V_buffer_c[a];
                //txtMedia.Text = txtMedia.Text + soma + "\n";
            }
            double media = (soma / T_buffer);            
            return media.ToString();
        }

        private void LerArquivo()
        {
            int i = 0; // controle do buffer
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
                
                txtLinhaAtual.Text = txtLinhaAtual.Text + v_open.ToString() + "\n";
                i++;
                V_buffer[i] = Convert.ToDouble(v_open);
                
                if (i >= T_buffer)
                {
                    i = 0;
                }

                txtMedia.Text  = Calculos(V_buffer);

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
