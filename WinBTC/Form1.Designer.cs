
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
            this.txtCotacaoIni = new System.Windows.Forms.TextBox();
            this.txtCaixaInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArq = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSaldoUSD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMxVenda = new System.Windows.Forms.TextBox();
            this.txtMxCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoAtual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLinhaAtual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBtcInicial = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtBtcInicial);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBuffer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCotacaoIni);
            this.groupBox1.Controls.Add(this.txtCaixaInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtArq);
            this.groupBox1.Controls.Add(this.Btn_Arq);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(431, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração :";
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(99, 140);
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
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qtd Buffer :";
            // 
            // txtCotacaoIni
            // 
            this.txtCotacaoIni.Location = new System.Drawing.Point(284, 140);
            this.txtCotacaoIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotacaoIni.Name = "txtCotacaoIni";
            this.txtCotacaoIni.Size = new System.Drawing.Size(57, 25);
            this.txtCotacaoIni.TabIndex = 3;
            this.txtCotacaoIni.Text = "40000";
            this.txtCotacaoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaixaInicial
            // 
            this.txtCaixaInicial.BackColor = System.Drawing.Color.White;
            this.txtCaixaInicial.Location = new System.Drawing.Point(127, 94);
            this.txtCaixaInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaixaInicial.Name = "txtCaixaInicial";
            this.txtCaixaInicial.Size = new System.Drawing.Size(57, 25);
            this.txtCaixaInicial.TabIndex = 3;
            this.txtCaixaInicial.Text = "2000,00";
            this.txtCaixaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cotação Base Inicial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixa Inicial U$ :";
            // 
            // txtArq
            // 
            this.txtArq.Location = new System.Drawing.Point(81, 24);
            this.txtArq.Margin = new System.Windows.Forms.Padding(2);
            this.txtArq.Name = "txtArq";
            this.txtArq.Size = new System.Drawing.Size(332, 48);
            this.txtArq.TabIndex = 1;
            this.txtArq.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtSaldoUSD);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMxVenda);
            this.groupBox2.Controls.Add(this.txtMxCompra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSaldoAtual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLucro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(459, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(307, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "USD :";
            // 
            // txtSaldoUSD
            // 
            this.txtSaldoUSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSaldoUSD.Location = new System.Drawing.Point(224, 50);
            this.txtSaldoUSD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoUSD.Name = "txtSaldoUSD";
            this.txtSaldoUSD.ReadOnly = true;
            this.txtSaldoUSD.Size = new System.Drawing.Size(57, 25);
            this.txtSaldoUSD.TabIndex = 6;
            this.txtSaldoUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Moeda :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "BTC :";
            // 
            // txtMxVenda
            // 
            this.txtMxVenda.Location = new System.Drawing.Point(142, 116);
            this.txtMxVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtMxVenda.Name = "txtMxVenda";
            this.txtMxVenda.Size = new System.Drawing.Size(57, 25);
            this.txtMxVenda.TabIndex = 9;
            this.txtMxVenda.Text = "0,001";
            this.txtMxVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMxCompra
            // 
            this.txtMxCompra.Location = new System.Drawing.Point(142, 82);
            this.txtMxCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMxCompra.Name = "txtMxCompra";
            this.txtMxCompra.Size = new System.Drawing.Size(57, 25);
            this.txtMxCompra.TabIndex = 9;
            this.txtMxCompra.Text = "0,001";
            this.txtMxCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Max Venda :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Max Compra :";
            // 
            // txtSaldoAtual
            // 
            this.txtSaldoAtual.Location = new System.Drawing.Point(142, 50);
            this.txtSaldoAtual.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoAtual.Name = "txtSaldoAtual";
            this.txtSaldoAtual.Size = new System.Drawing.Size(57, 25);
            this.txtSaldoAtual.TabIndex = 7;
            this.txtSaldoAtual.Text = "0";
            this.txtSaldoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Saldo Atual :";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(142, 149);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(57, 25);
            this.txtLucro.TabIndex = 6;
            this.txtLucro.Text = "0";
            this.txtLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lucro Atual :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(32, 234);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(61, 26);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(435, 231);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(104, 25);
            this.txtMedia.TabIndex = 4;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cotação Atual :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Média Atual :";
            // 
            // txtLinhaAtual
            // 
            this.txtLinhaAtual.Location = new System.Drawing.Point(213, 231);
            this.txtLinhaAtual.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinhaAtual.Name = "txtLinhaAtual";
            this.txtLinhaAtual.Size = new System.Drawing.Size(104, 25);
            this.txtLinhaAtual.TabIndex = 9;
            this.txtLinhaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 97);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Caixa Inicial  BTC :";
            // 
            // txtBtcInicial
            // 
            this.txtBtcInicial.Location = new System.Drawing.Point(324, 94);
            this.txtBtcInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtcInicial.Name = "txtBtcInicial";
            this.txtBtcInicial.Size = new System.Drawing.Size(57, 25);
            this.txtBtcInicial.TabIndex = 14;
            this.txtBtcInicial.Text = "0,01";
            this.txtBtcInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLinhaAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedia);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Arq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtArq;
        private System.Windows.Forms.TextBox txtCaixaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCotacaoIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoAtual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMxCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMxVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLinhaAtual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSaldoUSD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBtcInicial;
        private System.Windows.Forms.Label label13;
    }
}

