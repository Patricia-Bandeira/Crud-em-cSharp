
namespace teste2021
{
    partial class cadastroG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroG));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lbConsultaF = new System.Windows.Forms.Label();
            this.dataGridViewGeral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 107);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(12, 447);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 32);
            this.btnVoltar.TabIndex = 46;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lbConsultaF
            // 
            this.lbConsultaF.AutoSize = true;
            this.lbConsultaF.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultaF.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaF.Location = new System.Drawing.Point(112, 26);
            this.lbConsultaF.Name = "lbConsultaF";
            this.lbConsultaF.Size = new System.Drawing.Size(485, 57);
            this.lbConsultaF.TabIndex = 45;
            this.lbConsultaF.Text = "Cadastro Geral";
            // 
            // dataGridViewGeral
            // 
            this.dataGridViewGeral.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeral.Location = new System.Drawing.Point(40, 114);
            this.dataGridViewGeral.Name = "dataGridViewGeral";
            this.dataGridViewGeral.Size = new System.Drawing.Size(643, 327);
            this.dataGridViewGeral.TabIndex = 44;
            // 
            // cadastroG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbConsultaF);
            this.Controls.Add(this.dataGridViewGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastroG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroG";
            this.Load += new System.EventHandler(this.cadastroG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbConsultaF;
        private System.Windows.Forms.DataGridView dataGridViewGeral;
    }
}