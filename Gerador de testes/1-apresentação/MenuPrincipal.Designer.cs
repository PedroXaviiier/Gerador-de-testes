namespace Gerador_de_testes
{
    partial class MenuPrincipal
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
            this.BtnTelaMaterias = new System.Windows.Forms.Button();
            this.BtnTelaQuestoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxDiciplinas = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSeries = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNquestoes = new System.Windows.Forms.TextBox();
            this.labelNquestoes = new System.Windows.Forms.Label();
            this.btnGerarTeste = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabControlMaterias = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBoxMatematica = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBoxLinguagens = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBoxCH = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBoxCN = new System.Windows.Forms.CheckedListBox();
            this.tabControlMaterias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTelaMaterias
            // 
            this.BtnTelaMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTelaMaterias.Location = new System.Drawing.Point(228, 59);
            this.BtnTelaMaterias.Name = "BtnTelaMaterias";
            this.BtnTelaMaterias.Size = new System.Drawing.Size(165, 45);
            this.BtnTelaMaterias.TabIndex = 1;
            this.BtnTelaMaterias.Text = "Matérias";
            this.BtnTelaMaterias.UseVisualStyleBackColor = true;
            this.BtnTelaMaterias.Click += new System.EventHandler(this.BtnTelaMaterias_Click);
            // 
            // BtnTelaQuestoes
            // 
            this.BtnTelaQuestoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTelaQuestoes.Location = new System.Drawing.Point(440, 59);
            this.BtnTelaQuestoes.Name = "BtnTelaQuestoes";
            this.BtnTelaQuestoes.Size = new System.Drawing.Size(165, 45);
            this.BtnTelaQuestoes.TabIndex = 2;
            this.BtnTelaQuestoes.Text = "Questões";
            this.BtnTelaQuestoes.UseVisualStyleBackColor = true;
            this.BtnTelaQuestoes.Click += new System.EventHandler(this.BtnTelaQuestoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Diciplina";
            // 
            // checkedListBoxDiciplinas
            // 
            this.checkedListBoxDiciplinas.FormattingEnabled = true;
            this.checkedListBoxDiciplinas.Items.AddRange(new object[] {
            "Matematica",
            "Linguagens",
            "Ciências Da natureza",
            "Ciências Humanas"});
            this.checkedListBoxDiciplinas.Location = new System.Drawing.Point(173, 195);
            this.checkedListBoxDiciplinas.Name = "checkedListBoxDiciplinas";
            this.checkedListBoxDiciplinas.Size = new System.Drawing.Size(120, 112);
            this.checkedListBoxDiciplinas.TabIndex = 8;
            // 
            // checkedListBoxSeries
            // 
            this.checkedListBoxSeries.FormattingEnabled = true;
            this.checkedListBoxSeries.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º"});
            this.checkedListBoxSeries.Location = new System.Drawing.Point(122, 195);
            this.checkedListBoxSeries.Name = "checkedListBoxSeries";
            this.checkedListBoxSeries.Size = new System.Drawing.Size(45, 112);
            this.checkedListBoxSeries.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(122, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(331, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matéria";
            // 
            // textBoxNquestoes
            // 
            this.textBoxNquestoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNquestoes.Location = new System.Drawing.Point(577, 195);
            this.textBoxNquestoes.Name = "textBoxNquestoes";
            this.textBoxNquestoes.Size = new System.Drawing.Size(116, 29);
            this.textBoxNquestoes.TabIndex = 14;
            // 
            // labelNquestoes
            // 
            this.labelNquestoes.AutoSize = true;
            this.labelNquestoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNquestoes.Location = new System.Drawing.Point(577, 165);
            this.labelNquestoes.Name = "labelNquestoes";
            this.labelNquestoes.Size = new System.Drawing.Size(116, 21);
            this.labelNquestoes.TabIndex = 15;
            this.labelNquestoes.Text = "Nº de questões";
            // 
            // btnGerarTeste
            // 
            this.btnGerarTeste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarTeste.Location = new System.Drawing.Point(577, 234);
            this.btnGerarTeste.Name = "btnGerarTeste";
            this.btnGerarTeste.Size = new System.Drawing.Size(116, 37);
            this.btnGerarTeste.TabIndex = 16;
            this.btnGerarTeste.Text = "Gerar Teste";
            this.btnGerarTeste.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(356, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(116, 15);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "GERADOR DE TESTES";
            // 
            // tabControlMaterias
            // 
            this.tabControlMaterias.Controls.Add(this.tabPage1);
            this.tabControlMaterias.Controls.Add(this.tabPage2);
            this.tabControlMaterias.Controls.Add(this.tabPage3);
            this.tabControlMaterias.Controls.Add(this.tabPage4);
            this.tabControlMaterias.Location = new System.Drawing.Point(299, 195);
            this.tabControlMaterias.Name = "tabControlMaterias";
            this.tabControlMaterias.SelectedIndex = 0;
            this.tabControlMaterias.Size = new System.Drawing.Size(272, 211);
            this.tabControlMaterias.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBoxMatematica);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matematica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMatematica
            // 
            this.checkedListBoxMatematica.FormattingEnabled = true;
            this.checkedListBoxMatematica.Location = new System.Drawing.Point(0, -1);
            this.checkedListBoxMatematica.Name = "checkedListBoxMatematica";
            this.checkedListBoxMatematica.Size = new System.Drawing.Size(264, 184);
            this.checkedListBoxMatematica.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBoxLinguagens);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(264, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linguagens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxLinguagens
            // 
            this.checkedListBoxLinguagens.FormattingEnabled = true;
            this.checkedListBoxLinguagens.Location = new System.Drawing.Point(0, -1);
            this.checkedListBoxLinguagens.Name = "checkedListBoxLinguagens";
            this.checkedListBoxLinguagens.Size = new System.Drawing.Size(264, 184);
            this.checkedListBoxLinguagens.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListBoxCH);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(264, 183);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CIencias Humanas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCH
            // 
            this.checkedListBoxCH.FormattingEnabled = true;
            this.checkedListBoxCH.Location = new System.Drawing.Point(0, -1);
            this.checkedListBoxCH.Name = "checkedListBoxCH";
            this.checkedListBoxCH.Size = new System.Drawing.Size(264, 184);
            this.checkedListBoxCH.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBoxCN);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(264, 183);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ciencia da Natureza";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCN
            // 
            this.checkedListBoxCN.FormattingEnabled = true;
            this.checkedListBoxCN.Location = new System.Drawing.Point(0, -1);
            this.checkedListBoxCN.Name = "checkedListBoxCN";
            this.checkedListBoxCN.Size = new System.Drawing.Size(264, 184);
            this.checkedListBoxCN.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 442);
            this.Controls.Add(this.tabControlMaterias);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnGerarTeste);
            this.Controls.Add(this.labelNquestoes);
            this.Controls.Add(this.textBoxNquestoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxSeries);
            this.Controls.Add(this.checkedListBoxDiciplinas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTelaQuestoes);
            this.Controls.Add(this.BtnTelaMaterias);
            this.Name = "MenuPrincipal";
            this.Text = "Bem vindo!";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.tabControlMaterias.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTelaMaterias;
        private System.Windows.Forms.Button BtnTelaQuestoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxDiciplinas;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNquestoes;
        private System.Windows.Forms.Label labelNquestoes;
        private System.Windows.Forms.Button btnGerarTeste;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TabControl tabControlMaterias;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBoxMatematica;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBoxLinguagens;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox checkedListBoxCH;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox checkedListBoxCN;
    }
}
