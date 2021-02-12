namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSonuc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.arizali = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.lblUzaklik = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(129, 12);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(75, 23);
            this.btnBaglan.TabIndex = 1;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(210, 12);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 23);
            this.btnKes.TabIndex = 2;
            this.btnKes.Text = "Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSonuc,
            this.toolStripStatusLabel1,
            this.arizali});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(295, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSonuc
            // 
            this.lblSonuc.ForeColor = System.Drawing.Color.Red;
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(63, 17);
            this.lblSonuc.Text = "Bağlı Değil";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // arizali
            // 
            this.arizali.ForeColor = System.Drawing.Color.Red;
            this.arizali.Name = "arizali";
            this.arizali.Size = new System.Drawing.Size(0, 17);
            // 
            // txtPort
            // 
            this.txtPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Items.AddRange(new object[] {
            "COM3",
            "COM6",
            "COM4"});
            this.txtPort.Location = new System.Drawing.Point(12, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(111, 21);
            this.txtPort.TabIndex = 14;
            // 
            // lblUzaklik
            // 
            this.lblUzaklik.AutoSize = true;
            this.lblUzaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzaklik.Location = new System.Drawing.Point(83, 113);
            this.lblUzaklik.Name = "lblUzaklik";
            this.lblUzaklik.Size = new System.Drawing.Size(121, 73);
            this.lblUzaklik.TabIndex = 91;
            this.lblUzaklik.Text = "45 ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 241);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 10);
            this.progressBar1.TabIndex = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 470);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblUzaklik);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSonuc;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel arizali;
        private System.Windows.Forms.Label lblUzaklik;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

