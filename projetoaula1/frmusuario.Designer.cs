namespace projetoaula1
{
    partial class frmusuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Nome = new TextBox();
            email = new TextBox();
            senha = new TextBox();
            cadastrar = new Button();
            Dados_usuario = new DataGridView();
            editar = new Button();
            excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)Dados_usuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 57);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 170);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "senha";
            // 
            // Nome
            // 
            Nome.Location = new Point(154, 58);
            Nome.Name = "Nome";
            Nome.Size = new Size(125, 27);
            Nome.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(154, 108);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 4;
            // 
            // senha
            // 
            senha.Location = new Point(154, 167);
            senha.Name = "senha";
            senha.Size = new Size(125, 27);
            senha.TabIndex = 5;
            senha.TextChanged += senha_TextChanged;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(364, 58);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(94, 29);
            cadastrar.TabIndex = 6;
            cadastrar.Text = "cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // Dados_usuario
            // 
            Dados_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dados_usuario.Location = new Point(67, 226);
            Dados_usuario.Name = "Dados_usuario";
            Dados_usuario.RowHeadersWidth = 51;
            Dados_usuario.Size = new Size(391, 188);
            Dados_usuario.TabIndex = 7;
            // 
            // editar
            // 
            editar.Location = new Point(364, 108);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 8;
            editar.Text = "editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            excluir.Location = new Point(364, 161);
            excluir.Name = "excluir";
            excluir.Size = new Size(94, 29);
            excluir.TabIndex = 9;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            // 
            // frmusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 460);
            Controls.Add(excluir);
            Controls.Add(editar);
            Controls.Add(Dados_usuario);
            Controls.Add(cadastrar);
            Controls.Add(senha);
            Controls.Add(email);
            Controls.Add(Nome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmusuario";
            Text = "frmusuario";
            Load += frmusuario_Load;
            ((System.ComponentModel.ISupportInitialize)Dados_usuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nome;
        private TextBox email;
        private TextBox senha;
        private Button cadastrar;
        private DataGridView Dados_usuario;
        private Button editar;
        private Button excluir;
    }
}