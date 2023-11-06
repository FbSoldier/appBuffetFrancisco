namespace appBuffetFrancisco.view
{
    partial class TelaFechar
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
            lbl_data = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_TotalFinal = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Francisco Eventos Ltda.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 50);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 1;
            label2.Text = "Rua da Alegria, 171 - SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 93);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 2;
            label3.Text = "CNPJ: 12.321.958/0001 - 00";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Location = new Point(242, 117);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(65, 15);
            lbl_data.TabIndex = 3;
            lbl_data.Text = "00/00/0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 117);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "235959";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 117);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "CCF 0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 117);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "COD: 0001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 158);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 7;
            label8.Text = "Total:";
            // 
            // lbl_TotalFinal
            // 
            lbl_TotalFinal.AutoSize = true;
            lbl_TotalFinal.Location = new Point(404, 158);
            lbl_TotalFinal.Name = "lbl_TotalFinal";
            lbl_TotalFinal.Size = new Size(50, 15);
            lbl_TotalFinal.TabIndex = 8;
            lbl_TotalFinal.Text = "R$ 00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(308, 198);
            label10.Name = "label10";
            label10.Size = new Size(134, 15);
            label10.TabIndex = 9;
            label10.Text = "PAGAMENTO RECEBIDO";
            // 
            // TelaFechar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(lbl_TotalFinal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaFechar";
            Text = "TelaFechar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_data;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbl_TotalFinal;
        private Label label10;
    }
}