namespace Projeto_SuperHeroi_Vilao
{
    partial class Form1
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
            label8 = new Label();
            dataGridView = new DataGridView();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnVisualizar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(300, 9);
            label8.Name = "label8";
            label8.Size = new Size(215, 29);
            label8.TabIndex = 21;
            label8.Text = "CRUD - Alterações";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(71, 189);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(664, 150);
            dataGridView.TabIndex = 22;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.WhiteSmoke;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Location = new Point(183, 101);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 30);
            btnInserir.TabIndex = 47;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.WhiteSmoke;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Location = new Point(305, 101);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 30);
            btnAtualizar.TabIndex = 48;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.WhiteSmoke;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.Location = new Point(426, 101);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(75, 30);
            btnVisualizar.TabIndex = 49;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.WhiteSmoke;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Location = new Point(548, 101);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 30);
            btnRemover.TabIndex = 50;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnVisualizar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(dataGridView);
            Controls.Add(label8);
            Name = "Form1";
            Text = "Alterações";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dataGridView;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnVisualizar;
        private Button btnRemover;
    }
}