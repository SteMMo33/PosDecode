namespace PosDecode
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReqDecode = new System.Windows.Forms.Button();
            this.btnResDecode = new System.Windows.Forms.Button();
            this.tbRichiesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRisposta = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnReqDecode
            // 
            this.btnReqDecode.Location = new System.Drawing.Point(340, 12);
            this.btnReqDecode.Name = "btnReqDecode";
            this.btnReqDecode.Size = new System.Drawing.Size(72, 27);
            this.btnReqDecode.TabIndex = 1;
            this.btnReqDecode.Text = "Decodifica";
            this.btnReqDecode.UseVisualStyleBackColor = true;
            this.btnReqDecode.Click += new System.EventHandler(this.btnReqDecode_Click);
            // 
            // btnResDecode
            // 
            this.btnResDecode.Location = new System.Drawing.Point(340, 45);
            this.btnResDecode.Name = "btnResDecode";
            this.btnResDecode.Size = new System.Drawing.Size(72, 27);
            this.btnResDecode.TabIndex = 2;
            this.btnResDecode.Text = "Decodifica";
            this.btnResDecode.UseVisualStyleBackColor = true;
            this.btnResDecode.Click += new System.EventHandler(this.btnResDecode_Click);
            // 
            // tbRichiesta
            // 
            this.tbRichiesta.Location = new System.Drawing.Point(72, 16);
            this.tbRichiesta.Name = "tbRichiesta";
            this.tbRichiesta.Size = new System.Drawing.Size(262, 20);
            this.tbRichiesta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Richiesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Risposta:";
            // 
            // tbRisposta
            // 
            this.tbRisposta.Location = new System.Drawing.Point(72, 49);
            this.tbRisposta.Name = "tbRisposta";
            this.tbRisposta.Size = new System.Drawing.Size(262, 20);
            this.tbRisposta.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 344);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(400, 32);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Esporta dati ..";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvData
            // 
            this.lvData.Location = new System.Drawing.Point(12, 75);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(400, 263);
            this.lvData.TabIndex = 8;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 388);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRisposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRichiesta);
            this.Controls.Add(this.btnResDecode);
            this.Controls.Add(this.btnReqDecode);
            this.Name = "MainForm";
            this.Text = "INGENICO POS decoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReqDecode;
        private System.Windows.Forms.Button btnResDecode;
        private System.Windows.Forms.TextBox tbRichiesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRisposta;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListView lvData;
    }
}

