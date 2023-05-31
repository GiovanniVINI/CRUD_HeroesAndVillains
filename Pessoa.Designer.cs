namespace Projeto_SuperHeroi_Vilao
{
    partial class Pessoa
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
            label8 = new Label();
            label1 = new Label();
            btnLimpar1 = new Button();
            label2 = new Label();
            txtNomePessoa = new TextBox();
            txtIdadePessoa = new TextBox();
            label3 = new Label();
            txtNascPessoa = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btnProx1 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(206, 9);
            label8.Name = "label8";
            label8.Size = new Size(398, 29);
            label8.TabIndex = 24;
            label8.Text = "CRUD - Heróis e Vilões - Marvel/DC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(302, 51);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(207, 24);
            label1.TabIndex = 25;
            label1.Text = "Informações do usuário";
            label1.Click += label1_Click;
            // 
            // btnLimpar1
            // 
            btnLimpar1.BackColor = Color.WhiteSmoke;
            btnLimpar1.FlatAppearance.BorderSize = 0;
            btnLimpar1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLimpar1.FlatStyle = FlatStyle.Flat;
            btnLimpar1.Location = new Point(206, 318);
            btnLimpar1.Name = "btnLimpar1";
            btnLimpar1.Size = new Size(75, 30);
            btnLimpar1.TabIndex = 26;
            btnLimpar1.Text = "Limpar";
            btnLimpar1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(280, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 28;
            label2.Text = "Nome";
            // 
            // txtNomePessoa
            // 
            txtNomePessoa.Location = new Point(382, 112);
            txtNomePessoa.Name = "txtNomePessoa";
            txtNomePessoa.Size = new Size(165, 21);
            txtNomePessoa.TabIndex = 29;
            // 
            // txtIdadePessoa
            // 
            txtIdadePessoa.Location = new Point(382, 151);
            txtIdadePessoa.Name = "txtIdadePessoa";
            txtIdadePessoa.Size = new Size(165, 21);
            txtIdadePessoa.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(280, 151);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 30;
            label3.Text = "Idade";
            // 
            // txtNascPessoa
            // 
            txtNascPessoa.Location = new Point(382, 193);
            txtNascPessoa.Name = "txtNascPessoa";
            txtNascPessoa.Size = new Size(165, 21);
            txtNascPessoa.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(222, 193);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 32;
            label4.Text = "Data de Nascimento";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(382, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 21);
            txtEmail.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(280, 236);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 34;
            label5.Text = "E-mail";
            // 
            // btnProx1
            // 
            btnProx1.BackColor = Color.WhiteSmoke;
            btnProx1.FlatAppearance.BorderSize = 0;
            btnProx1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnProx1.FlatStyle = FlatStyle.Flat;
            btnProx1.Location = new Point(529, 318);
            btnProx1.Name = "btnProx1";
            btnProx1.Size = new Size(75, 30);
            btnProx1.TabIndex = 36;
            btnProx1.Text = "Próximo";
            btnProx1.UseVisualStyleBackColor = false;
            // 
            // Pessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnProx1);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtNascPessoa);
            Controls.Add(label4);
            Controls.Add(txtIdadePessoa);
            Controls.Add(label3);
            Controls.Add(txtNomePessoa);
            Controls.Add(label2);
            Controls.Add(btnLimpar1);
            Controls.Add(label1);
            Controls.Add(label8);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Pessoa";
            Text = "Cadastro";
            Load += Pessoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private Button btnLimpar1;
        private Label label2;
        private TextBox txtNomePessoa;
        private TextBox txtIdadePessoa;
        private Label label3;
        private TextBox txtNascPessoa;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Button btnProx1;
    }
}