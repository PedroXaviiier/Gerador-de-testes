namespace Gerador_de_testes._1_apresentação.Questões
{
    partial class TelaQuestoes
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.tabControlDiciplinas = new System.Windows.Forms.TabControl();
            this.tabPageMatematica = new System.Windows.Forms.TabPage();
            this.tabPageLinguagens = new System.Windows.Forms.TabPage();
            this.tabPageCH = new System.Windows.Forms.TabPage();
            this.tabPageCN = new System.Windows.Forms.TabPage();
            this.tabControlDiciplinas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(477, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAtualizar.Location = new System.Drawing.Point(210, 17);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(164, 43);
            this.buttonAtualizar.TabIndex = 9;
            this.buttonAtualizar.Text = "atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExcluir.Location = new System.Drawing.Point(404, 17);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(164, 43);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(12, 17);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(164, 43);
            this.buttonInserir.TabIndex = 7;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // tabControlDiciplinas
            // 
            this.tabControlDiciplinas.Controls.Add(this.tabPageMatematica);
            this.tabControlDiciplinas.Controls.Add(this.tabPageLinguagens);
            this.tabControlDiciplinas.Controls.Add(this.tabPageCH);
            this.tabControlDiciplinas.Controls.Add(this.tabPageCN);
            this.tabControlDiciplinas.Location = new System.Drawing.Point(12, 66);
            this.tabControlDiciplinas.Name = "tabControlDiciplinas";
            this.tabControlDiciplinas.SelectedIndex = 0;
            this.tabControlDiciplinas.Size = new System.Drawing.Size(556, 233);
            this.tabControlDiciplinas.TabIndex = 11;
            // 
            // tabPageMatematica
            // 
            this.tabPageMatematica.Location = new System.Drawing.Point(4, 24);
            this.tabPageMatematica.Name = "tabPageMatematica";
            this.tabPageMatematica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatematica.Size = new System.Drawing.Size(548, 205);
            this.tabPageMatematica.TabIndex = 0;
            this.tabPageMatematica.Text = "Matematica";
            this.tabPageMatematica.UseVisualStyleBackColor = true;
            // 
            // tabPageLinguagens
            // 
            this.tabPageLinguagens.Location = new System.Drawing.Point(4, 24);
            this.tabPageLinguagens.Name = "tabPageLinguagens";
            this.tabPageLinguagens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLinguagens.Size = new System.Drawing.Size(548, 205);
            this.tabPageLinguagens.TabIndex = 1;
            this.tabPageLinguagens.Text = "Linguagens";
            this.tabPageLinguagens.UseVisualStyleBackColor = true;
            // 
            // tabPageCH
            // 
            this.tabPageCH.Location = new System.Drawing.Point(4, 24);
            this.tabPageCH.Name = "tabPageCH";
            this.tabPageCH.Size = new System.Drawing.Size(548, 205);
            this.tabPageCH.TabIndex = 2;
            this.tabPageCH.Text = "Ciencias Humanas";
            this.tabPageCH.UseVisualStyleBackColor = true;
            // 
            // tabPageCN
            // 
            this.tabPageCN.Location = new System.Drawing.Point(4, 24);
            this.tabPageCN.Name = "tabPageCN";
            this.tabPageCN.Size = new System.Drawing.Size(548, 205);
            this.tabPageCN.TabIndex = 3;
            this.tabPageCN.Text = "Ciencias da Natureza";
            this.tabPageCN.UseVisualStyleBackColor = true;
            // 
            // TelaQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 352);
            this.Controls.Add(this.tabControlDiciplinas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Name = "TelaQuestoes";
            this.Text = "TelaQuestões";
            this.Load += new System.EventHandler(this.TelaQuestões_Load_1);
            this.tabControlDiciplinas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TabControl tabControlDiciplinas;
        private System.Windows.Forms.TabPage tabPageMatematica;
        private System.Windows.Forms.TabPage tabPageLinguagens;
        private System.Windows.Forms.TabPage tabPageCH;
        private System.Windows.Forms.TabPage tabPageCN;
    }
}