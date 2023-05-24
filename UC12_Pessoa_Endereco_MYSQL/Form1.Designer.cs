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
            this.dateTimePicker_DATA_NASC = new System.Windows.Forms.DateTimePicker();
            this.label_NOME = new System.Windows.Forms.Label();
            this.label_SOBRENOME = new System.Windows.Forms.Label();
            this.label_NOME_SOCIAL = new System.Windows.Forms.Label();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_ETINIA = new System.Windows.Forms.Label();
            this.label_DATA_NASC = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_CADASTRAR = new System.Windows.Forms.Button();
            this.radioButton_GENERO1 = new System.Windows.Forms.RadioButton();
            this.radioButton_GENERO2 = new System.Windows.Forms.RadioButton();
            this.radioButton_GENERO3 = new System.Windows.Forms.RadioButton();
            this.groupBox_GENERO = new System.Windows.Forms.GroupBox();
            this.dataGridView_CADASTRO = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBox_GENERO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CADASTRO)).BeginInit();
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
            this.textBox_RG.Location = new System.Drawing.Point(54, 240);
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(168, 20);
            this.textBox_RG.TabIndex = 3;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(54, 266);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(168, 20);
            this.textBox_CPF.TabIndex = 4;
            // 
            // comboBox_ETNIA
            // 
            this.comboBox_ETNIA.FormattingEnabled = true;
            this.comboBox_ETNIA.Items.AddRange(new object[] {
            "Branco(a)",
            "Negro(a)",
            "Indígena",
            "Pardo(a)",
            "Mulato(a)",
            "Cabloco",
            "Cafuzos"});
            this.comboBox_ETNIA.Location = new System.Drawing.Point(11, 154);
            this.comboBox_ETNIA.Name = "comboBox_ETNIA";
            this.comboBox_ETNIA.Size = new System.Drawing.Size(211, 21);
            this.comboBox_ETNIA.TabIndex = 5;
            // 
            // dateTimePicker_DATA_NASC
            // 
            this.dateTimePicker_DATA_NASC.Location = new System.Drawing.Point(12, 203);
            this.dateTimePicker_DATA_NASC.Name = "dateTimePicker_DATA_NASC";
            this.dateTimePicker_DATA_NASC.Size = new System.Drawing.Size(210, 20);
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
            this.label_RG.Location = new System.Drawing.Point(13, 243);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(23, 13);
            this.label_RG.TabIndex = 13;
            this.label_RG.Text = "RG";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(13, 269);
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
            this.label_DATA_NASC.Location = new System.Drawing.Point(11, 187);
            this.label_DATA_NASC.Name = "label_DATA_NASC";
            this.label_DATA_NASC.Size = new System.Drawing.Size(104, 13);
            this.label_DATA_NASC.TabIndex = 16;
            this.label_DATA_NASC.Text = "Data de Nascimento";
            // 
            // textBox_LOGRADOURO
            // 
            this.textBox_LOGRADOURO.Location = new System.Drawing.Point(25, 36);
            this.textBox_LOGRADOURO.Name = "textBox_LOGRADOURO";
            this.textBox_LOGRADOURO.Size = new System.Drawing.Size(201, 20);
            this.textBox_LOGRADOURO.TabIndex = 19;
            // 
            // textBox_BAIRRO
            // 
            this.textBox_BAIRRO.Location = new System.Drawing.Point(25, 79);
            this.textBox_BAIRRO.Name = "textBox_BAIRRO";
            this.textBox_BAIRRO.Size = new System.Drawing.Size(201, 20);
            this.textBox_BAIRRO.TabIndex = 20;
            // 
            // comboBox_UF
            // 
            this.comboBox_UF.FormattingEnabled = true;
            this.comboBox_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox_UF.Location = new System.Drawing.Point(25, 211);
            this.comboBox_UF.Name = "comboBox_UF";
            this.comboBox_UF.Size = new System.Drawing.Size(201, 21);
            this.comboBox_UF.TabIndex = 21;
            // 
            // comboBox_ESTADO
            // 
            this.comboBox_ESTADO.FormattingEnabled = true;
            this.comboBox_ESTADO.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe ",
            "Tocantins"});
            this.comboBox_ESTADO.Location = new System.Drawing.Point(25, 169);
            this.comboBox_ESTADO.Name = "comboBox_ESTADO";
            this.comboBox_ESTADO.Size = new System.Drawing.Size(201, 21);
            this.comboBox_ESTADO.TabIndex = 22;
            // 
            // label_LOGRADOURO
            // 
            this.label_LOGRADOURO.AutoSize = true;
            this.label_LOGRADOURO.Location = new System.Drawing.Point(94, 20);
            this.label_LOGRADOURO.Name = "label_LOGRADOURO";
            this.label_LOGRADOURO.Size = new System.Drawing.Size(61, 13);
            this.label_LOGRADOURO.TabIndex = 23;
            this.label_LOGRADOURO.Text = "Logradouro";
            // 
            // label_BAIRRO
            // 
            this.label_BAIRRO.AutoSize = true;
            this.label_BAIRRO.Location = new System.Drawing.Point(105, 59);
            this.label_BAIRRO.Name = "label_BAIRRO";
            this.label_BAIRRO.Size = new System.Drawing.Size(34, 13);
            this.label_BAIRRO.TabIndex = 24;
            this.label_BAIRRO.Text = "Bairro";
            // 
            // label_CIDADE
            // 
            this.label_CIDADE.AutoSize = true;
            this.label_CIDADE.Location = new System.Drawing.Point(105, 102);
            this.label_CIDADE.Name = "label_CIDADE";
            this.label_CIDADE.Size = new System.Drawing.Size(40, 13);
            this.label_CIDADE.TabIndex = 25;
            this.label_CIDADE.Text = "Cidade";
            // 
            // label_ESTADO
            // 
            this.label_ESTADO.AutoSize = true;
            this.label_ESTADO.Location = new System.Drawing.Point(105, 153);
            this.label_ESTADO.Name = "label_ESTADO";
            this.label_ESTADO.Size = new System.Drawing.Size(40, 13);
            this.label_ESTADO.TabIndex = 26;
            this.label_ESTADO.Text = "Estado";
            this.label_ESTADO.Click += new System.EventHandler(this.label_ESTADO_Click);
            // 
            // textBox_CIDADE
            // 
            this.textBox_CIDADE.Location = new System.Drawing.Point(25, 118);
            this.textBox_CIDADE.Name = "textBox_CIDADE";
            this.textBox_CIDADE.Size = new System.Drawing.Size(201, 20);
            this.textBox_CIDADE.TabIndex = 27;
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(115, 193);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(21, 13);
            this.label_UF.TabIndex = 28;
            this.label_UF.Text = "UF";
            this.label_UF.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox_CIDADE);
            this.panel2.Controls.Add(this.label_UF);
            this.panel2.Controls.Add(this.label_ESTADO);
            this.panel2.Controls.Add(this.label_CIDADE);
            this.panel2.Controls.Add(this.comboBox_ESTADO);
            this.panel2.Controls.Add(this.label_BAIRRO);
            this.panel2.Controls.Add(this.comboBox_UF);
            this.panel2.Controls.Add(this.label_LOGRADOURO);
            this.panel2.Controls.Add(this.textBox_LOGRADOURO);
            this.panel2.Controls.Add(this.textBox_BAIRRO);
            this.panel2.Location = new System.Drawing.Point(249, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 256);
            this.panel2.TabIndex = 18;
            // 
            // button_CADASTRAR
            // 
            this.button_CADASTRAR.Location = new System.Drawing.Point(16, 415);
            this.button_CADASTRAR.Name = "button_CADASTRAR";
            this.button_CADASTRAR.Size = new System.Drawing.Size(841, 23);
            this.button_CADASTRAR.TabIndex = 19;
            this.button_CADASTRAR.Text = "Cadastrar";
            this.button_CADASTRAR.UseVisualStyleBackColor = true;
            this.button_CADASTRAR.Click += new System.EventHandler(this.button_CADASTRAR_Click);
            // 
            // radioButton_GENERO1
            // 
            this.radioButton_GENERO1.AutoSize = true;
            this.radioButton_GENERO1.Location = new System.Drawing.Point(72, 19);
            this.radioButton_GENERO1.Name = "radioButton_GENERO1";
            this.radioButton_GENERO1.Size = new System.Drawing.Size(73, 17);
            this.radioButton_GENERO1.TabIndex = 6;
            this.radioButton_GENERO1.TabStop = true;
            this.radioButton_GENERO1.Text = "Masculino";
            this.radioButton_GENERO1.UseVisualStyleBackColor = true;
            this.radioButton_GENERO1.Click += new System.EventHandler(this.radioButton_GENERO1_Click);
            // 
            // radioButton_GENERO2
            // 
            this.radioButton_GENERO2.AutoSize = true;
            this.radioButton_GENERO2.Location = new System.Drawing.Point(73, 42);
            this.radioButton_GENERO2.Name = "radioButton_GENERO2";
            this.radioButton_GENERO2.Size = new System.Drawing.Size(67, 17);
            this.radioButton_GENERO2.TabIndex = 7;
            this.radioButton_GENERO2.TabStop = true;
            this.radioButton_GENERO2.Text = "Feminino";
            this.radioButton_GENERO2.UseVisualStyleBackColor = true;
            this.radioButton_GENERO2.CheckedChanged += new System.EventHandler(this.radioButton_GENERO2_CheckedChanged);
            // 
            // radioButton_GENERO3
            // 
            this.radioButton_GENERO3.AutoSize = true;
            this.radioButton_GENERO3.Location = new System.Drawing.Point(73, 65);
            this.radioButton_GENERO3.Name = "radioButton_GENERO3";
            this.radioButton_GENERO3.Size = new System.Drawing.Size(64, 17);
            this.radioButton_GENERO3.TabIndex = 8;
            this.radioButton_GENERO3.TabStop = true;
            this.radioButton_GENERO3.Text = "OUTRO";
            this.radioButton_GENERO3.UseVisualStyleBackColor = true;
            this.radioButton_GENERO3.CheckedChanged += new System.EventHandler(this.radioButton_GENERO3_CheckedChanged);
            // 
            // groupBox_GENERO
            // 
            this.groupBox_GENERO.BackColor = System.Drawing.Color.LightGray;
            this.groupBox_GENERO.Controls.Add(this.radioButton_GENERO2);
            this.groupBox_GENERO.Controls.Add(this.radioButton_GENERO3);
            this.groupBox_GENERO.Controls.Add(this.radioButton_GENERO1);
            this.groupBox_GENERO.Location = new System.Drawing.Point(16, 308);
            this.groupBox_GENERO.Name = "groupBox_GENERO";
            this.groupBox_GENERO.Size = new System.Drawing.Size(223, 98);
            this.groupBox_GENERO.TabIndex = 20;
            this.groupBox_GENERO.TabStop = false;
            this.groupBox_GENERO.Text = "Genero";
            // 
            // dataGridView_CADASTRO
            // 
            this.dataGridView_CADASTRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CADASTRO.Location = new System.Drawing.Point(524, 30);
            this.dataGridView_CADASTRO.Name = "dataGridView_CADASTRO";
            this.dataGridView_CADASTRO.Size = new System.Drawing.Size(333, 360);
            this.dataGridView_CADASTRO.TabIndex = 21;
            this.dataGridView_CADASTRO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CADASTRO_CellEndEdit);
            this.dataGridView_CADASTRO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_CADASTRO_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 442);
            this.Controls.Add(this.dataGridView_CADASTRO);
            this.Controls.Add(this.groupBox_GENERO);
            this.Controls.Add(this.button_CADASTRAR);
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
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_GENERO.ResumeLayout(false);
            this.groupBox_GENERO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CADASTRO)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATA_NASC;
        private System.Windows.Forms.Label label_NOME;
        private System.Windows.Forms.Label label_SOBRENOME;
        private System.Windows.Forms.Label label_NOME_SOCIAL;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_ETINIA;
        private System.Windows.Forms.Label label_DATA_NASC;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_GENERO3;
        private System.Windows.Forms.RadioButton radioButton_GENERO2;
        private System.Windows.Forms.RadioButton radioButton_GENERO1;
        private System.Windows.Forms.Button button_CADASTRAR;
        private System.Windows.Forms.GroupBox groupBox_GENERO;
        private System.Windows.Forms.DataGridView dataGridView_CADASTRO;
    }
}

