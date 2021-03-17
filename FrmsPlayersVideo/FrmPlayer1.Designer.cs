namespace SecurityCameraViewer
{
    partial class FrmPlayer1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayer1));
            this.btnPause1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRealTime1 = new System.Windows.Forms.Label();
            this.btnAvX1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeAtual1 = new System.Windows.Forms.Label();
            this.btnRetroX1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.lblTimeTotal1 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.mediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnAddLoja = new System.Windows.Forms.Button();
            this.btnAddCaixas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause1
            // 
            this.btnPause1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause1.Location = new System.Drawing.Point(529, 674);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(72, 22);
            this.btnPause1.TabIndex = 120;
            this.btnPause1.Text = "Pause";
            this.btnPause1.UseVisualStyleBackColor = true;
            this.btnPause1.Click += new System.EventHandler(this.btnPause1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1343, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 693);
            this.listBox1.TabIndex = 107;
            // 
            // btnStop1
            // 
            this.btnStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop1.Location = new System.Drawing.Point(607, 674);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(72, 22);
            this.btnStop1.TabIndex = 119;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Visible = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 644);
            this.progressBar1.MarqueeAnimationSpeed = 9000000;
            this.progressBar1.Maximum = 1800;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1285, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 114;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseLeave += new System.EventHandler(this.progressBar1_MouseLeave);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // lblRealTime1
            // 
            this.lblRealTime1.AutoSize = true;
            this.lblRealTime1.ForeColor = System.Drawing.Color.White;
            this.lblRealTime1.Location = new System.Drawing.Point(842, 679);
            this.lblRealTime1.Name = "lblRealTime1";
            this.lblRealTime1.Size = new System.Drawing.Size(21, 13);
            this.lblRealTime1.TabIndex = 113;
            this.lblRealTime1.Text = "1 x";
            // 
            // btnAvX1
            // 
            this.btnAvX1.Location = new System.Drawing.Point(763, 674);
            this.btnAvX1.Name = "btnAvX1";
            this.btnAvX1.Size = new System.Drawing.Size(29, 22);
            this.btnAvX1.TabIndex = 112;
            this.btnAvX1.Text = ">>";
            this.btnAvX1.UseVisualStyleBackColor = true;
            this.btnAvX1.Click += new System.EventHandler(this.btnAvX1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay1.Location = new System.Drawing.Point(451, 674);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(72, 22);
            this.btnPlay1.TabIndex = 118;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1209, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "/";
            // 
            // lblTimeAtual1
            // 
            this.lblTimeAtual1.AutoSize = true;
            this.lblTimeAtual1.ForeColor = System.Drawing.Color.White;
            this.lblTimeAtual1.Location = new System.Drawing.Point(1154, 666);
            this.lblTimeAtual1.Name = "lblTimeAtual1";
            this.lblTimeAtual1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeAtual1.TabIndex = 109;
            this.lblTimeAtual1.Text = "00:00:00";
            // 
            // btnRetroX1
            // 
            this.btnRetroX1.Location = new System.Drawing.Point(728, 674);
            this.btnRetroX1.Name = "btnRetroX1";
            this.btnRetroX1.Size = new System.Drawing.Size(29, 22);
            this.btnRetroX1.TabIndex = 111;
            this.btnRetroX1.Text = "<<";
            this.btnRetroX1.UseVisualStyleBackColor = true;
            this.btnRetroX1.Click += new System.EventHandler(this.btnRetroX1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(798, 674);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(29, 22);
            this.btnNext1.TabIndex = 117;
            this.btnNext1.Text = ">>|";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.Location = new System.Drawing.Point(693, 674);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(29, 22);
            this.btnPrev1.TabIndex = 116;
            this.btnPrev1.Text = "|<<";
            this.btnPrev1.UseVisualStyleBackColor = true;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // lblTimeTotal1
            // 
            this.lblTimeTotal1.AutoSize = true;
            this.lblTimeTotal1.ForeColor = System.Drawing.Color.White;
            this.lblTimeTotal1.Location = new System.Drawing.Point(1227, 666);
            this.lblTimeTotal1.Name = "lblTimeTotal1";
            this.lblTimeTotal1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeTotal1.TabIndex = 110;
            this.lblTimeTotal1.Text = "00:00:00";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(1, 697);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo1.TabIndex = 105;
            this.lblTitulo1.Text = "Titulo";
            // 
            // mediaPlayer1
            // 
            this.mediaPlayer1.Enabled = true;
            this.mediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.mediaPlayer1.Name = "mediaPlayer1";
            this.mediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer1.OcxState")));
            this.mediaPlayer1.Size = new System.Drawing.Size(1285, 644);
            this.mediaPlayer1.TabIndex = 123;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(-1, 631);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 126;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnAddLoja
            // 
            this.btnAddLoja.Location = new System.Drawing.Point(64, 665);
            this.btnAddLoja.Name = "btnAddLoja";
            this.btnAddLoja.Size = new System.Drawing.Size(56, 22);
            this.btnAddLoja.TabIndex = 127;
            this.btnAddLoja.Text = "Loja";
            this.btnAddLoja.UseVisualStyleBackColor = true;
            this.btnAddLoja.Click += new System.EventHandler(this.btnAddLoja_Click);
            // 
            // btnAddCaixas
            // 
            this.btnAddCaixas.Location = new System.Drawing.Point(2, 665);
            this.btnAddCaixas.Name = "btnAddCaixas";
            this.btnAddCaixas.Size = new System.Drawing.Size(56, 22);
            this.btnAddCaixas.TabIndex = 128;
            this.btnAddCaixas.Text = "Caixas";
            this.btnAddCaixas.UseVisualStyleBackColor = true;
            this.btnAddCaixas.Click += new System.EventHandler(this.btnAddCaixas_Click);
            // 
            // FrmPlayer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 711);
            this.Controls.Add(this.btnAddCaixas);
            this.Controls.Add(this.btnAddLoja);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.mediaPlayer1);
            this.Controls.Add(this.btnPause1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblRealTime1);
            this.Controls.Add(this.btnAvX1);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeAtual1);
            this.Controls.Add(this.btnRetroX1);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.btnPrev1);
            this.Controls.Add(this.lblTimeTotal1);
            this.Controls.Add(this.lblTitulo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPlayer1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1 Tela";
            this.Load += new System.EventHandler(this.FrmPlayer1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPause1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblRealTime1;
        private System.Windows.Forms.Button btnAvX1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeAtual1;
        private System.Windows.Forms.Button btnRetroX1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Label lblTimeTotal1;
        private System.Windows.Forms.Label lblTitulo1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnAddLoja;
        private System.Windows.Forms.Button btnAddCaixas;
    }
}