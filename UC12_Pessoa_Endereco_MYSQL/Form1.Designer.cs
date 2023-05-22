namespace UC12_Pessoa_Endereco_MYSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_NOME = new System.Windows.Forms.TextBox();
            this.textBox_SOBRENOME = new System.Windows.Forms.TextBox();
            this.textBox_NOME_SOCIAL = new System.Windows.Forms.TextBox();
            this.textBox_RG = new System.Windows.Forms.TextBox();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.comboBox_ETNIA = new System.Windows.Forms.ComboBox();
            this.radioButton_GENERO1 = new System.Windows.Forms.RadioButton();
            this.radioButton_GENERO2 = new System.Windows.Forms.RadioButton();
            this.radioButton_GENERO3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_DATA_NASC = new System.Windows.Forms.DateTimePicker();
            this.label_NOME = new System.Windows.Forms.Label();
            this.label_SOBRENOME = new System.Windows.Forms.Label();
            this.label_NOME_SOCIAL = new System.Windows.Forms.Label();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_ETINIA = new System.Windows.Forms.Label();
            this.label_DATA_NASC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_GENERO = new System.Windows.Forms.Label();
            this.textBox_LOGRADOURO = new System.Windows.Forms.TextBox();
            this.textBox_BAIRRO = new System.Windows.Forms.TextBox();
            this.comboBox_UF = new System.Windows.Forms.ComboBox();
            this.comboBox_ESTADO = new System.Windows.Forms.ComboBox();
            this.label_LOGRADOURO = new System.Windows.Forms.Label();
            this.label_BAIRRO = new System.Windows.Forms.Label();
            this.label_CIDADE = new System.Windows.Forms.Label();
            this.label_ESTADO = new System.Windows.Forms.Label();
            this.textBox_CIDADE = new System.Windows.Forms.TextBox();
            this.label_UF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_NOME
            // 
            this.textBox_NOME.Location = new System.Drawing.Point(12, 30);
            this.textBox_NOME.Name = "textBox_NOME";
            this.textBox_NOME.Size = new System.Drawing.Size(211, 20);
            this.textBox_NOME.TabIndex = 0;
            // 
            // textBox_SOBRENOME
            // 
            this.textBox_SOBRENOME.Location = new System.Drawing.Point(12, 112);
            this.textBox_SOBRENOME.Name = "textBox_SOBRENOME";
            this.textBox_SOBRENOME.Size = new System.Drawing.Size(211, 20);
            this.textBox_SOBRENOME.TabIndex = 1;
            // 
            // textBox_NOME_SOCIAL
            // 
            this.textBox_NOME_SOCIAL.Location = new System.Drawing.Point(12, 73);
            this.textBox_NOME_SOCIAL.Name = "textBox_NOME_SOCIAL";
            this.textBox_NOME_SOCIAL.Size = new System.Drawing.Size(211, 20);
            this.textBox_NOME_SOCIAL.TabIndex = 2;
            // 
            // textBox_RG
            // 
            this.textBox_RG.Location = new System.Drawing.Point(63, 196);
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(100, 20);
            this.textBox_RG.TabIndex = 3;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(63, 222);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPF.TabIndex = 4;
            // 
            // comboBox_ETNIA
            // 
            this.comboBox_ETNIA.FormattingEnabled = true;
            this.comboBox_ETNIA.Location = new System.Drawing.Point(11, 154);
            this.comboBox_ETNIA.Name = "comboBox_ETNIA";
            this.comboBox_ETNIA.Size = new System.Drawing.Size(211, 21);
            this.comboBox_ETNIA.TabIndex = 5;
            // 
            // radioButton_GENERO1
            // 
            this.radioButton_GENERO1.AutoSize = true;
            this.radioButton_GENERO1.Location = new System.Drawing.Point(61, 11);
            this.radioButton_GENERO1.Name = "radioButton_GENERO1";
            this.radioButton_GENERO1.Size = new System.Drawing.Size(73, 17);
            this.radioButton_GENERO1.TabIndex = 6;
            this.radioButton_GENERO1.TabStop = true;
            this.radioButton_GENERO1.Text = "Masculino";
            this.radioButton_GENERO1.UseVisualStyleBackColor = true;
            // 
            // radioButton_GENERO2
            // 
            this.radioButton_GENERO2.AutoSize = true;
            this.radioButton_GENERO2.Location = new System.Drawing.Point(62, 34);
            this.radioButton_GENERO2.Name = "radioButton_GENERO2";
            this.radioButton_GENERO2.Size = new System.Drawing.Size(67, 17);
            this.radioButton_GENERO2.TabIndex = 7;
            this.radioButton_GENERO2.TabStop = true;
            this.radioButton_GENERO2.Text = "Feminino";
            this.radioButton_GENERO2.UseVisualStyleBackColor = true;
            // 
            // radioButton_GENERO3
            // 
            this.radioButton_GENERO3.AutoSize = true;
            this.radioButton_GENERO3.Location = new System.Drawing.Point(62, 57);
            this.radioButton_GENERO3.Name = "radioButton_GENERO3";
            this.radioButton_GENERO3.Size = new System.Drawing.Size(64, 17);
            this.radioButton_GENERO3.TabIndex = 8;
            this.radioButton_GENERO3.TabStop = true;
            this.radioButton_GENERO3.Text = "OUTRO";
            this.radioButton_GENERO3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DATA_NASC
            // 
            this.dateTimePicker_DATA_NASC.Location = new System.Drawing.Point(20, 394);
            this.dateTimePicker_DATA_NASC.Name = "dateTimePicker_DATA_NASC";
            this.dateTimePicker_DATA_NASC.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DATA_NASC.TabIndex = 9;
            // 
            // label_NOME
            // 
            this.label_NOME.AutoSize = true;
            this.label_NOME.Location = new System.Drawing.Point(11, 14);
            this.label_NOME.Name = "label_NOME";
            this.label_NOME.Size = new System.Drawing.Size(35, 13);
            this.label_NOME.TabIndex = 10;
            this.label_NOME.Text = "Nome";
            // 
            // label_SOBRENOME
            // 
            this.label_SOBRENOME.AutoSize = true;
            this.label_SOBRENOME.Location = new System.Drawing.Point(9, 96);
            this.label_SOBRENOME.Name = "label_SOBRENOME";
            this.label_SOBRENOME.Size = new System.Drawing.Size(61, 13);
            this.label_SOBRENOME.TabIndex = 11;
            this.label_SOBRENOME.Text = "Sobrenome";
            // 
            // label_NOME_SOCIAL
            // 
            this.label_NOME_SOCIAL.AutoSize = true;
            this.label_NOME_SOCIAL.Location = new System.Drawing.Point(9, 57);
            this.label_NOME_SOCIAL.Name = "label_NOME_SOCIAL";
            this.label_NOME_SOCIAL.Size = new System.Drawing.Size(67, 13);
            this.label_NOME_SOCIAL.TabIndex = 12;
            this.label_NOME_SOCIAL.Text = "Nome Social";
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Location = new System.Drawing.Point(22, 199);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(23, 13);
            this.label_RG.TabIndex = 13;
            this.label_RG.Text = "RG";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(22, 225);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(27, 13);
            this.label_CPF.TabIndex = 14;
            this.label_CPF.Text = "CPF";
            // 
            // label_ETINIA
            // 
            this.label_ETINIA.AutoSize = true;
            this.label_ETINIA.Location = new System.Drawing.Point(11, 138);
            this.label_ETINIA.Name = "label_ETINIA";
            this.label_ETINIA.Size = new System.Drawing.Size(31, 13);
            this.label_ETINIA.TabIndex = 15;
            this.label_ETINIA.Text = "Etnia";
            // 
            // label_DATA_NASC
            // 
            this.label_DATA_NASC.AutoSize = true;
            this.label_DATA_NASC.Location = new System.Drawing.Point(59, 378);
            this.label_DATA_NASC.Name = "label_DATA_NASC";
            this.label_DATA_NASC.Size = new System.Drawing.Size(104, 13);
            this.label_DATA_NASC.TabIndex = 16;
            this.label_DATA_NASC.Text = "Data de Nascimento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton_GENERO3);
            this.panel1.Controls.Add(this.radioButton_GENERO2);
            this.panel1.Controls.Add(this.radioButton_GENERO1);
            this.panel1.Location = new System.Drawing.Point(10, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 87);
            this.panel1.TabIndex = 17;
            // 
            // label_GENERO
            // 
            this.label_GENERO.AutoSize = true;
            this.label_GENERO.Location = new System.Drawing.Point(8, 256);
            this.label_GENERO.Name = "label_GENERO";
            this.label_GENERO.Size = new System.Drawing.Size(42, 13);
            this.label_GENERO.TabIndex = 18;
            this.label_GENERO.Text = "Genero";
            // 
            // textBox_LOGRADOURO
            // 
            this.textBox_LOGRADOURO.Location = new System.Drawing.Point(417, 30);
            this.textBox_LOGRADOURO.Name = "textBox_LOGRADOURO";
            this.textBox_LOGRADOURO.Size = new System.Drawing.Size(211, 20);
            this.textBox_LOGRADOURO.TabIndex = 19;
            // 
            // textBox_BAIRRO
            // 
            this.textBox_BAIRRO.Location = new System.Drawing.Point(417, 73);
            this.textBox_BAIRRO.Name = "textBox_BAIRRO";
            this.textBox_BAIRRO.Size = new System.Drawing.Size(211, 20);
            this.textBox_BAIRRO.TabIndex = 20;
            // 
            // comboBox_UF
            // 
            this.comboBox_UF.FormattingEnabled = true;
            this.comboBox_UF.Location = new System.Drawing.Point(455, 225);
            this.comboBox_UF.Name = "comboBox_UF";
            this.comboBox_UF.Size = new System.Drawing.Size(121, 21);
            this.comboBox_UF.TabIndex = 21;
            // 
            // comboBox_ESTADO
            // 
            this.comboBox_ESTADO.FormattingEnabled = true;
            this.comboBox_ESTADO.Location = new System.Drawing.Point(455, 178);
            this.comboBox_ESTADO.Name = "comboBox_ESTADO";
            this.comboBox_ESTADO.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ESTADO.TabIndex = 22;
            // 
            // label_LOGRADOURO
            // 
            this.label_LOGRADOURO.AutoSize = true;
            this.label_LOGRADOURO.Location = new System.Drawing.Point(414, 14);
            this.label_LOGRADOURO.Name = "label_LOGRADOURO";
            this.label_LOGRADOURO.Size = new System.Drawing.Size(61, 13);
            this.label_LOGRADOURO.TabIndex = 23;
            this.label_LOGRADOURO.Text = "Logradouro";
            // 
            // label_BAIRRO
            // 
            this.label_BAIRRO.AutoSize = true;
            this.label_BAIRRO.Location = new System.Drawing.Point(414, 57);
            this.label_BAIRRO.Name = "label_BAIRRO";
            this.label_BAIRRO.Size = new System.Drawing.Size(34, 13);
            this.label_BAIRRO.TabIndex = 24;
            this.label_BAIRRO.Text = "Bairro";
            // 
            // label_CIDADE
            // 
            this.label_CIDADE.AutoSize = true;
            this.label_CIDADE.Location = new System.Drawing.Point(414, 96);
            this.label_CIDADE.Name = "label_CIDADE";
            this.label_CIDADE.Size = new System.Drawing.Size(40, 13);
            this.label_CIDADE.TabIndex = 25;
            this.label_CIDADE.Text = "Cidade";
            // 
            // label_ESTADO
            // 
            this.label_ESTADO.AutoSize = true;
            this.label_ESTADO.Location = new System.Drawing.Point(495, 162);
            this.label_ESTADO.Name = "label_ESTADO";
            this.label_ESTADO.Size = new System.Drawing.Size(40, 13);
            this.label_ESTADO.TabIndex = 26;
            this.label_ESTADO.Text = "Estado";
            // 
            // textBox_CIDADE
            // 
            this.textBox_CIDADE.Location = new System.Drawing.Point(417, 112);
            this.textBox_CIDADE.Name = "textBox_CIDADE";
            this.textBox_CIDADE.Size = new System.Drawing.Size(211, 20);
            this.textBox_CIDADE.TabIndex = 27;
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(505, 209);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(21, 13);
            this.label_UF.TabIndex = 28;
            this.label_UF.Text = "UF";
            this.label_UF.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_UF);
            this.Controls.Add(this.textBox_CIDADE);
            this.Controls.Add(this.label_ESTADO);
            this.Controls.Add(this.label_CIDADE);
            this.Controls.Add(this.label_BAIRRO);
            this.Controls.Add(this.label_LOGRADOURO);
            this.Controls.Add(this.comboBox_ESTADO);
            this.Controls.Add(this.comboBox_UF);
            this.Controls.Add(this.textBox_BAIRRO);
            this.Controls.Add(this.textBox_LOGRADOURO);
            this.Controls.Add(this.label_GENERO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_DATA_NASC);
            this.Controls.Add(this.label_ETINIA);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_NOME_SOCIAL);
            this.Controls.Add(this.comboBox_ETNIA);
            this.Controls.Add(this.label_SOBRENOME);
            this.Controls.Add(this.label_NOME);
            this.Controls.Add(this.dateTimePicker_DATA_NASC);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_RG);
            this.Controls.Add(this.textBox_NOME_SOCIAL);
            this.Controls.Add(this.textBox_SOBRENOME);
            this.Controls.Add(this.textBox_NOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NOME;
        private System.Windows.Forms.TextBox textBox_SOBRENOME;
        private System.Windows.Forms.TextBox textBox_NOME_SOCIAL;
        private System.Windows.Forms.TextBox textBox_RG;
        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.ComboBox comboBox_ETNIA;
        private System.Windows.Forms.RadioButton radioButton_GENERO1;
        private System.Windows.Forms.RadioButton radioButton_GENERO2;
        private System.Windows.Forms.RadioButton radioButton_GENERO3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATA_NASC;
        private System.Windows.Forms.Label label_NOME;
        private System.Windows.Forms.Label label_SOBRENOME;
        private System.Windows.Forms.Label label_NOME_SOCIAL;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_ETINIA;
        private System.Windows.Forms.Label label_DATA_NASC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_GENERO;
        private System.Windows.Forms.TextBox textBox_LOGRADOURO;
        private System.Windows.Forms.TextBox textBox_BAIRRO;
        private System.Windows.Forms.ComboBox comboBox_UF;
        private System.Windows.Forms.ComboBox comboBox_ESTADO;
        private System.Windows.Forms.Label label_LOGRADOURO;
        private System.Windows.Forms.Label label_BAIRRO;
        private System.Windows.Forms.Label label_CIDADE;
        private System.Windows.Forms.Label label_ESTADO;
        private System.Windows.Forms.TextBox textBox_CIDADE;
        private System.Windows.Forms.Label label_UF;
    }
}

