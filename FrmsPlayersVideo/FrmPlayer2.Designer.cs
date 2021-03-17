namespace SecurityCameraViewer
{
    partial class FrmPlayer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayer2));
            this.mediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAddLoja = new System.Windows.Forms.Button();
            this.btnPause1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRealTime1 = new System.Windows.Forms.Label();
            this.btnAddCaixa = new System.Windows.Forms.Button();
            this.btnAvX1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeAtual1 = new System.Windows.Forms.Label();
            this.btnRetroX1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.lblTimeTotal1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer2)).BeginInit();
            this.gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPlayer1
            // 
            this.mediaPlayer1.Enabled = true;
            this.mediaPlayer1.Location = new System.Drawing.Point(2, 2);
            this.mediaPlayer1.Name = "mediaPlayer1";
            this.mediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer1.OcxState")));
            this.mediaPlayer1.Size = new System.Drawing.Size(637, 640);
            this.mediaPlayer1.TabIndex = 125;
            this.mediaPlayer1.MouseUpEvent += new AxWMPLib._WMPOCXEvents_MouseUpEventHandler(this.MediaPlayer1_MouseUpEvent);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 707);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(637, 82);
            this.listBox1.TabIndex = 124;
            // 
            // mediaPlayer2
            // 
            this.mediaPlayer2.Enabled = true;
            this.mediaPlayer2.Location = new System.Drawing.Point(645, 2);
            this.mediaPlayer2.Name = "mediaPlayer2";
            this.mediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer2.OcxState")));
            this.mediaPlayer2.Size = new System.Drawing.Size(637, 640);
            this.mediaPlayer2.TabIndex = 127;
            this.mediaPlayer2.MouseUpEvent += new AxWMPLib._WMPOCXEvents_MouseUpEventHandler(this.MediaPlayer2_MouseUpEvent);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(644, 707);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(637, 82);
            this.listBox2.TabIndex = 126;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(3, 632);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 143;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // btnAddLoja
            // 
            this.btnAddLoja.Location = new System.Drawing.Point(64, 677);
            this.btnAddLoja.Name = "btnAddLoja";
            this.btnAddLoja.Size = new System.Drawing.Size(56, 22);
            this.btnAddLoja.TabIndex = 142;
            this.btnAddLoja.Text = "Loja";
            this.btnAddLoja.UseVisualStyleBackColor = true;
            this.btnAddLoja.Click += new System.EventHandler(this.btnAddLoja_Click);
            // 
            // btnPause1
            // 
            this.btnPause1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause1.Location = new System.Drawing.Point(498, 677);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(72, 22);
            this.btnPause1.TabIndex = 141;
            this.btnPause1.Text = "Pause";
            this.btnPause1.UseVisualStyleBackColor = true;
            this.btnPause1.Click += new System.EventHandler(this.btnPause1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop1.Location = new System.Drawing.Point(576, 677);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(72, 22);
            this.btnStop1.TabIndex = 140;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Visible = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 648);
            this.progressBar1.MarqueeAnimationSpeed = 9000000;
            this.progressBar1.Maximum = 1800;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1279, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 135;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseLeave += new System.EventHandler(this.progressBar1_MouseLeave);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // lblRealTime1
            // 
            this.lblRealTime1.AutoSize = true;
            this.lblRealTime1.ForeColor = System.Drawing.Color.White;
            this.lblRealTime1.Location = new System.Drawing.Point(829, 682);
            this.lblRealTime1.Name = "lblRealTime1";
            this.lblRealTime1.Size = new System.Drawing.Size(21, 13);
            this.lblRealTime1.TabIndex = 134;
            this.lblRealTime1.Text = "1 x";
            // 
            // btnAddCaixa
            // 
            this.btnAddCaixa.Location = new System.Drawing.Point(4, 677);
            this.btnAddCaixa.Name = "btnAddCaixa";
            this.btnAddCaixa.Size = new System.Drawing.Size(56, 22);
            this.btnAddCaixa.TabIndex = 129;
            this.btnAddCaixa.Text = "Caixa";
            this.btnAddCaixa.UseVisualStyleBackColor = true;
            this.btnAddCaixa.Click += new System.EventHandler(this.btnAddCaixa_Click);
            // 
            // btnAvX1
            // 
            this.btnAvX1.Location = new System.Drawing.Point(40, 9);
            this.btnAvX1.Name = "btnAvX1";
            this.btnAvX1.Size = new System.Drawing.Size(29, 22);
            this.btnAvX1.TabIndex = 133;
            this.btnAvX1.Text = ">>";
            this.btnAvX1.UseVisualStyleBackColor = true;
            this.btnAvX1.Click += new System.EventHandler(this.btnAvX1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay1.Location = new System.Drawing.Point(420, 677);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(72, 22);
            this.btnPlay1.TabIndex = 139;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1214, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "/";
            // 
            // lblTimeAtual1
            // 
            this.lblTimeAtual1.AutoSize = true;
            this.lblTimeAtual1.ForeColor = System.Drawing.Color.White;
            this.lblTimeAtual1.Location = new System.Drawing.Point(1159, 664);
            this.lblTimeAtual1.Name = "lblTimeAtual1";
            this.lblTimeAtual1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeAtual1.TabIndex = 130;
            this.lblTimeAtual1.Text = "00:00:00";
            // 
            // btnRetroX1
            // 
            this.btnRetroX1.Location = new System.Drawing.Point(5, 9);
            this.btnRetroX1.Name = "btnRetroX1";
            this.btnRetroX1.Size = new System.Drawing.Size(29, 22);
            this.btnRetroX1.TabIndex = 132;
            this.btnRetroX1.Text = "<<";
            this.btnRetroX1.UseVisualStyleBackColor = true;
            this.btnRetroX1.Click += new System.EventHandler(this.btnRetroX1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(785, 677);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(29, 22);
            this.btnNext1.TabIndex = 138;
            this.btnNext1.Text = ">>|";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.Location = new System.Drawing.Point(662, 677);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(29, 22);
            this.btnPrev1.TabIndex = 137;
            this.btnPrev1.Text = "|<<";
            this.btnPrev1.UseVisualStyleBackColor = true;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // lblTimeTotal1
            // 
            this.lblTimeTotal1.AutoSize = true;
            this.lblTimeTotal1.ForeColor = System.Drawing.Color.White;
            this.lblTimeTotal1.Location = new System.Drawing.Point(1232, 664);
            this.lblTimeTotal1.Name = "lblTimeTotal1";
            this.lblTimeTotal1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeTotal1.TabIndex = 131;
            this.lblTimeTotal1.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gp
            // 
            this.gp.Controls.Add(this.btnAvX1);
            this.gp.Controls.Add(this.btnRetroX1);
            this.gp.Location = new System.Drawing.Point(700, 666);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(77, 36);
            this.gp.TabIndex = 144;
            this.gp.TabStop = false;
            // 
            // FrmPlayer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 707);
            this.Controls.Add(this.gp);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAddLoja);
            this.Controls.Add(this.btnPause1);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblRealTime1);
            this.Controls.Add(this.btnAddCaixa);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeAtual1);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.btnPrev1);
            this.Controls.Add(this.lblTimeTotal1);
            this.Controls.Add(this.mediaPlayer2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.mediaPlayer1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "FrmPlayer2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmPlayer2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer2)).EndInit();
            this.gp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAddLoja;
        private System.Windows.Forms.Button btnPause1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblRealTime1;
        private System.Windows.Forms.Button btnAddCaixa;
        private System.Windows.Forms.Button btnAvX1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeAtual1;
        private System.Windows.Forms.Button btnRetroX1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Label lblTimeTotal1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gp;
    }
}