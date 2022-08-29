namespace teste2021
{
    partial class consultaC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaC));
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbConsultaF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(130, 109);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(445, 331);
            this.dataGridViewCliente.TabIndex = 1;
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.BackColor = System.Drawing.Color.Black;
            this.btnVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar2.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar2.Location = new System.Drawing.Point(12, 455);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(111, 31);
            this.btnVoltar2.TabIndex = 2;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 100);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lbConsultaF
            // 
            this.lbConsultaF.AutoSize = true;
            this.lbConsultaF.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultaF.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaF.Location = new System.Drawing.Point(146, 34);
            this.lbConsultaF.Name = "lbConsultaF";
            this.lbConsultaF.Size = new System.Drawing.Size(507, 57);
            this.lbConsultaF.TabIndex = 44;
            this.lbConsultaF.Text = "Tabela de Cursos";
            // 
            // consultaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(691, 498);
            this.Controls.Add(this.lbConsultaF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.dataGridViewCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultaC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultaC";
            this.Load += new System.EventHandler(this.consultaC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbConsultaF;
    }
}