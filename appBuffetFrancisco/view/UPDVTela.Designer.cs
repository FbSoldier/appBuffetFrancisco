namespace appBuffetFrancisco.view
{
    partial class UPDVTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPDVTela));
            label1 = new Label();
            label2 = new Label();
            btn_coxinha = new Button();
            btn_esfiha = new Button();
            btn_pastel = new Button();
            btn_bolin = new Button();
            btn_suco = new Button();
            btn_cafe = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_refri = new Button();
            btn_cancelar = new Button();
            btn_receber = new Button();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Unitario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_adicionar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(306, 12);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 0;
            label1.Text = "Buffet Francisco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(172, 251);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Pedidos";
            // 
            // btn_coxinha
            // 
            btn_coxinha.Image = (Image)resources.GetObject("btn_coxinha.Image");
            btn_coxinha.ImageAlign = ContentAlignment.BottomCenter;
            btn_coxinha.Location = new Point(17, 32);
            btn_coxinha.Name = "btn_coxinha";
            btn_coxinha.Size = new Size(75, 65);
            btn_coxinha.TabIndex = 2;
            btn_coxinha.UseVisualStyleBackColor = true;
            // 
            // btn_esfiha
            // 
            btn_esfiha.Image = (Image)resources.GetObject("btn_esfiha.Image");
            btn_esfiha.Location = new Point(17, 114);
            btn_esfiha.Name = "btn_esfiha";
            btn_esfiha.Size = new Size(75, 65);
            btn_esfiha.TabIndex = 3;
            btn_esfiha.TextAlign = ContentAlignment.BottomCenter;
            btn_esfiha.UseVisualStyleBackColor = true;
            // 
            // btn_pastel
            // 
            btn_pastel.Image = (Image)resources.GetObject("btn_pastel.Image");
            btn_pastel.Location = new Point(172, 32);
            btn_pastel.Name = "btn_pastel";
            btn_pastel.Size = new Size(75, 65);
            btn_pastel.TabIndex = 4;
            btn_pastel.UseVisualStyleBackColor = true;
            // 
            // btn_bolin
            // 
            btn_bolin.Image = (Image)resources.GetObject("btn_bolin.Image");
            btn_bolin.Location = new Point(172, 114);
            btn_bolin.Name = "btn_bolin";
            btn_bolin.Size = new Size(75, 65);
            btn_bolin.TabIndex = 5;
            btn_bolin.UseVisualStyleBackColor = true;
            // 
            // btn_suco
            // 
            btn_suco.Image = (Image)resources.GetObject("btn_suco.Image");
            btn_suco.ImageAlign = ContentAlignment.BottomCenter;
            btn_suco.Location = new Point(17, 52);
            btn_suco.Name = "btn_suco";
            btn_suco.Size = new Size(85, 70);
            btn_suco.TabIndex = 6;
            btn_suco.UseVisualStyleBackColor = true;
            // 
            // btn_cafe
            // 
            btn_cafe.Image = (Image)resources.GetObject("btn_cafe.Image");
            btn_cafe.ImageAlign = ContentAlignment.BottomCenter;
            btn_cafe.Location = new Point(191, 58);
            btn_cafe.Name = "btn_cafe";
            btn_cafe.Size = new Size(86, 64);
            btn_cafe.TabIndex = 7;
            btn_cafe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_coxinha);
            groupBox1.Controls.Add(btn_esfiha);
            groupBox1.Controls.Add(btn_pastel);
            groupBox1.Controls.Add(btn_bolin);
            groupBox1.Location = new Point(49, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 185);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_refri);
            groupBox2.Controls.Add(btn_suco);
            groupBox2.Controls.Add(btn_cafe);
            groupBox2.Location = new Point(49, 471);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 161);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            // 
            // btn_refri
            // 
            btn_refri.Image = (Image)resources.GetObject("btn_refri.Image");
            btn_refri.Location = new Point(346, 58);
            btn_refri.Name = "btn_refri";
            btn_refri.Size = new Size(75, 64);
            btn_refri.TabIndex = 8;
            btn_refri.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(837, 589);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(129, 32);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_receber
            // 
            btn_receber.Location = new Point(995, 589);
            btn_receber.Name = "btn_receber";
            btn_receber.Size = new Size(129, 32);
            btn_receber.TabIndex = 11;
            btn_receber.Text = "Receber e finalizar";
            btn_receber.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(874, 211);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(879, 193);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 14;
            label3.Text = "Qtd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(699, 193);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 15;
            label4.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(837, 529);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 17;
            label5.Text = "Valor Total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(687, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(837, 560);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            textBox2.Text = "R$ 0,00";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Produto, Qtd, Unitario, Total });
            dataGridView1.Location = new Point(686, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(403, 235);
            dataGridView1.TabIndex = 21;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Qtd";
            Qtd.Name = "Qtd";
            // 
            // Unitario
            // 
            Unitario.HeaderText = "Unitário";
            Unitario.Name = "Unitario";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(995, 211);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 22;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // UPDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1168, 652);
            Controls.Add(btn_adicionar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(btn_receber);
            Controls.Add(btn_cancelar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UPDVTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de PDV Buffet Francisco";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_coxinha;
        private Button btn_esfiha;
        private Button btn_pastel;
        private Button btn_bolin;
        private Button btn_suco;
        private Button btn_cafe;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_refri;
        private Button btn_cancelar;
        private Button btn_receber;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Unitario;
        private DataGridViewTextBoxColumn Total;
        private Button btn_adicionar;
    }
}