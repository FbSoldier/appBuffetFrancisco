namespace appBuffetFrancisco.view
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_usuario = new TextBox();
            txb_senha = new TextBox();
            btn_acessar = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btn_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Buffet Francisco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 120);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 240);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // txb_usuario
            // 
            txb_usuario.Location = new Point(135, 125);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(180, 23);
            txb_usuario.TabIndex = 3;
            txb_usuario.Text = "admin";
            // 
            // txb_senha
            // 
            txb_senha.Location = new Point(135, 242);
            txb_senha.Name = "txb_senha";
            txb_senha.PasswordChar = '*';
            txb_senha.Size = new Size(180, 23);
            txb_senha.TabIndex = 4;
            txb_senha.Text = "123";
            // 
            // btn_acessar
            // 
            btn_acessar.Location = new Point(161, 290);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(134, 23);
            btn_acessar.TabIndex = 5;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = true;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(21, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 248);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image;
            pictureBox1.Location = new Point(518, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(713, 311);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // LoginTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 346);
            Controls.Add(btn_sair);
            Controls.Add(pictureBox1);
            Controls.Add(btn_acessar);
            Controls.Add(txb_senha);
            Controls.Add(txb_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginTela";
            Text = "Sistema PDV Buffet francisco";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_usuario;
        private TextBox txb_senha;
        private Button btn_acessar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btn_sair;
    }
}