
namespace WinBTC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Arq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArq = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtC_V = new System.Windows.Forms.TextBox();
            this.txtBtc_Conv = new System.Windows.Forms.TextBox();
            this.txtSaldoUini = new System.Windows.Forms.TextBox();
            this.txtSaldoBTCini = new System.Windows.Forms.TextBox();
            this.txtBTC_Cota = new System.Windows.Forms.TextBox();
            this.txtSaldoSoma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Arq
            // 
            this.Btn_Arq.Location = new System.Drawing.Point(15, 30);
            this.Btn_Arq.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Arq.Name = "Btn_Arq";
            this.Btn_Arq.Size = new System.Drawing.Size(61, 30);
            this.Btn_Arq.TabIndex = 0;
            this.Btn_Arq.Text = "Arquivo";
            this.Btn_Arq.UseVisualStyleBackColor = true;
            this.Btn_Arq.Click += new System.EventHandler(this.Btn_Arq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuffer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArq);
            this.groupBox1.Controls.Add(this.Btn_Arq);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(702, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração :";
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(664, 35);
            this.txtBuffer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(26, 25);
            this.txtBuffer.TabIndex = 5;
            this.txtBuffer.Text = "5";
            this.txtBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuffer.TextChanged += new System.EventHandler(this.txtBuffer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qtd Buffer :";
            // 
            // txtArq
            // 
            this.txtArq.Location = new System.Drawing.Point(81, 24);
            this.txtArq.Margin = new System.Windows.Forms.Padding(2);
            this.txtArq.Name = "txtArq";
            this.txtArq.Size = new System.Drawing.Size(495, 48);
            this.txtArq.TabIndex = 1;
            this.txtArq.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldoSoma);
            this.groupBox2.Controls.Add(this.txtBTC_Cota);
            this.groupBox2.Controls.Add(this.txtSaldoBTCini);
            this.groupBox2.Controls.Add(this.txtSaldoUini);
            this.groupBox2.Controls.Add(this.txtBtc_Conv);
            this.groupBox2.Controls.Add(this.txtC_V);
            this.groupBox2.Controls.Add(this.txtCotacao);
            this.groupBox2.Controls.Add(this.txtLinha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(9, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(827, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros iniciais :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "btc comp/venda :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "BTC Conv. U$ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cotação :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(715, 35);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(91, 38);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Teste";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Saldo U$ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saldo BTC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo BTC (cotação) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saldo Soma BTC + U$ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Linha :";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(15, 44);
            this.txtLinha.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(26, 25);
            this.txtLinha.TabIndex = 6;
            this.txtLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(63, 44);
            this.txtCotacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(66, 25);
            this.txtCotacao.TabIndex = 19;
            this.txtCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtC_V
            // 
            this.txtC_V.Location = new System.Drawing.Point(186, 44);
            this.txtC_V.Margin = new System.Windows.Forms.Padding(2);
            this.txtC_V.Name = "txtC_V";
            this.txtC_V.Size = new System.Drawing.Size(62, 25);
            this.txtC_V.TabIndex = 20;
            this.txtC_V.Text = "0,001";
            this.txtC_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBtc_Conv
            // 
            this.txtBtc_Conv.BackColor = System.Drawing.Color.Aqua;
            this.txtBtc_Conv.Location = new System.Drawing.Point(285, 44);
            this.txtBtc_Conv.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtc_Conv.Name = "txtBtc_Conv";
            this.txtBtc_Conv.Size = new System.Drawing.Size(66, 25);
            this.txtBtc_Conv.TabIndex = 21;
            this.txtBtc_Conv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoUini
            // 
            this.txtSaldoUini.Location = new System.Drawing.Point(365, 44);
            this.txtSaldoUini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoUini.Name = "txtSaldoUini";
            this.txtSaldoUini.Size = new System.Drawing.Size(62, 25);
            this.txtSaldoUini.TabIndex = 22;
            this.txtSaldoUini.Text = "2000,00";
            this.txtSaldoUini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoBTCini
            // 
            this.txtSaldoBTCini.Location = new System.Drawing.Point(450, 44);
            this.txtSaldoBTCini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoBTCini.Name = "txtSaldoBTCini";
            this.txtSaldoBTCini.Size = new System.Drawing.Size(62, 25);
            this.txtSaldoBTCini.TabIndex = 23;
            this.txtSaldoBTCini.Text = "0,04";
            this.txtSaldoBTCini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBTC_Cota
            // 
            this.txtBTC_Cota.BackColor = System.Drawing.Color.Aqua;
            this.txtBTC_Cota.Location = new System.Drawing.Point(531, 44);
            this.txtBTC_Cota.Margin = new System.Windows.Forms.Padding(2);
            this.txtBTC_Cota.Name = "txtBTC_Cota";
            this.txtBTC_Cota.Size = new System.Drawing.Size(115, 25);
            this.txtBTC_Cota.TabIndex = 24;
            this.txtBTC_Cota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoSoma
            // 
            this.txtSaldoSoma.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldoSoma.Location = new System.Drawing.Point(682, 44);
            this.txtSaldoSoma.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoSoma.Name = "txtSaldoSoma";
            this.txtSaldoSoma.Size = new System.Drawing.Size(115, 25);
            this.txtSaldoSoma.TabIndex = 25;
            this.txtSaldoSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(847, 540);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTC- Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Arq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtArq;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldoSoma;
        private System.Windows.Forms.TextBox txtBTC_Cota;
        private System.Windows.Forms.TextBox txtSaldoBTCini;
        private System.Windows.Forms.TextBox txtSaldoUini;
        private System.Windows.Forms.TextBox txtBtc_Conv;
        private System.Windows.Forms.TextBox txtC_V;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label label6;
    }
}

