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
        public Form1()
        {
            InitializeComponent();
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

        private void LerArquivo()
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
                var firstName = csvReader.GetField(0);
                var lastName = csvReader.GetField(1);
                var occupation = csvReader.GetField(2);
                Console.WriteLine("\n************************************");
                Console.WriteLine($"{firstName} {lastName} is {occupation}");
                txtLinhaAtual.Text = firstName;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }
    }
}
