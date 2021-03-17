using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityCameraViewer
{
    public partial class FrmPlayer2 : Form
    {
        int hora = 3600;
        int meiaHora = 1800;
        string[] conteudo;
        int valor1;
        int realTime1 = 1;
        string tipoCamera = null;
        double tempoFullScreem = 0;
        bool full = false;


       
        public FrmPlayer2()
        {
            InitializeComponent();
            gp.Enabled = false;
        }


        private void FrmPlayer2_Load(object sender, EventArgs e)
        {
            EnterForm();
        }

        void EnterForm()
        {
            try
            {
                mediaPlayer1.uiMode = "none";
                mediaPlayer2.uiMode = "none";
            }
            catch
            {

            }
          
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                conteudo = File.ReadAllLines(path);
            }
            catch
            {
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                    File.Delete(path);
                }
                catch
                {

                }
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                    StreamWriter streamWriter = File.CreateText(path);
                    streamWriter.WriteLine();

                    streamWriter.WriteLine(1);


                    streamWriter.Close();
                }
                catch
                {

                }
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                    conteudo = File.ReadAllLines(path);
                }
                catch
                {

                }
            }
        }

        //tela 1
        void Start1()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[1]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer1.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer1.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer1.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer1.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }


            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[1]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer1.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer1.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer1.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer1.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play1()
        {
            try
            {
                if (mediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer1.URL = file.Path;
                        mediaPlayer1.Ctlcontrols.play();
                        mediaPlayer1.stretchToFit = true;
                        Start1();

                    }
                }
                else
                {
                    mediaPlayer1.Ctlcontrols.play();

                }
            }
            catch { }
        }
        void Pause1()
        {
            mediaPlayer1.Ctlcontrols.pause();
        }
        void Stop1()
        {
            try
            {
                mediaPlayer1.Ctlcontrols.stop();
                progressBar1.Value = 0;
                realTime1 = 1;
                lblTimeAtual1.Text = "00:00:00";
                lblTimeTotal1.Text = "00:00:00";
                lblRealTime1.Text = string.Empty;
               
            }
            catch { }
        }
        void Next1()
        {
            try
            {
                int quant = listBox1.Items.Count;
                int index = listBox1.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox1.SelectedIndex = index;
                    MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer1.URL = file.Path;
                        mediaPlayer1.Ctlcontrols.play();
                        Start1();

                    }
                }
            }
            catch { }



        }
        void Prev1()
        {

            try
            {
                int quant = listBox1.Items.Count;
                int index = listBox1.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox1.SelectedIndex = index;
                }
                MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer1.URL = file.Path;
                    mediaPlayer1.Ctlcontrols.play();
                    Start1();

                }
            }
            catch { }

        }

        //tela 2
        void Start2()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[2]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer2.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer2.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer2.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer2.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[2]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer2.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer2.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer2.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer2.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play2()
        {
            try
            {
                if (mediaPlayer2.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer2.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox2.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer2.URL = file.Path;
                        mediaPlayer2.Ctlcontrols.play();
                        mediaPlayer2.stretchToFit = true;
                        Start2();

                    }
                }
                else
                {
                    mediaPlayer2.Ctlcontrols.play();

                }
            }
            catch { }
        }
        void Pause2()
        {
            mediaPlayer2.Ctlcontrols.pause();
        }
        void Stop2()
        {
            try
            {
                mediaPlayer2.Ctlcontrols.stop();
                //progressBar1.Value = 0;
                //realTime1 = 1;
                //lblTimeAtual1.Text = "00:00:00";
                //lblTimeTotal1.Text = "00:00:00";
                //lblRealTime1.Text = string.Empty;

            }
            catch { }
        }
        void Next2()
        {
            try
            {
                int quant = listBox2.Items.Count;
                int index = listBox2.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox2.SelectedIndex = index;
                    MediaPlayerList file = listBox2.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer2.URL = file.Path;
                        mediaPlayer2.Ctlcontrols.play();
                        Start2();

                    }
                }
            }
            catch { }



        }
        void Prev2()
        {

            try
            {
                int quant = listBox2.Items.Count;
                int index = listBox2.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox2.SelectedIndex = index;
                }
                MediaPlayerList file = listBox2.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer2.URL = file.Path;
                    mediaPlayer2.Ctlcontrols.play();
                    Start2();

                }
            }
            catch { }

        }



        private void btnPlay1_Click(object sender, EventArgs e)
        {
            if (full==false)
            {
                Play1();
                Play2();
            }
           
            if (mediaPlayer1.Size.Width!=637)
            {
                Play1();
            }
            if (mediaPlayer2.Size.Width != 637)
            {
                Play2();
            }
        }
        private void btnPause1_Click(object sender, EventArgs e)
        {
            Pause1();
            Pause2();
        }
        private void btnStop1_Click(object sender, EventArgs e)
        {
            Stop1();
            Stop2();
        }
        private void btnPrev1_Click(object sender, EventArgs e)
        {
            Prev1();
            Prev2();
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            Next1();
            Next2();
        }
        private void btnAvX1_Click(object sender, EventArgs e)
        {
            if (realTime1 < 128)
            {
                realTime1 *= 2;
            }
        }
        private void btnRetroX1_Click(object sender, EventArgs e)
        {
            if (realTime1 > 1)
            {
                realTime1 /= 2;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            #region Telas
            try
            {
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    #region FuncaoAvanco
                    if (realTime1 > 1)
                    {
                        lblRealTime1.Visible = true;
                    }
                    else
                    {
                        lblRealTime1.Visible = false;
                    }
                    if (realTime1 == 2)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 0.2f;
                    }
                    if (realTime1 == 4)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                    }
                    if (realTime1 == 8)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                    }
                    if (realTime1 == 16)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                    }
                    if (realTime1 == 32)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                    }
                    if (realTime1 == 64)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                    }
                    if (realTime1 == 128)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                    }
                    #endregion
                    lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) % 60);
                    lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer1.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer1.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer1.currentMedia.duration + valor1) % 60);
                    lblRealTime1.Text = realTime1.ToString() + "x";
                    progressBar1.Value = (int)mediaPlayer1.Ctlcontrols.currentPosition;
                    if (progressBar1.Value > 1798)
                    {
                        Next1();
                        Next2();
                    }
                }
                else
                {
                    if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        #region FuncaoAvanco
                        if (realTime1 > 1)
                        {
                            lblRealTime1.Visible = true;
                        }
                        else
                        {
                            lblRealTime1.Visible = false;
                        }
                        if (realTime1 == 2)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 0.2f;
                        }
                        if (realTime1 == 4)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                        }
                        if (realTime1 == 8)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                        }
                        if (realTime1 == 16)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                        }
                        if (realTime1 == 32)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                        }
                        if (realTime1 == 64)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                        }
                        if (realTime1 == 128)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                        }
                        #endregion
                        lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer2.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer2.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer2.Ctlcontrols.currentPosition + valor1) % 60);
                        lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer2.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer2.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer2.currentMedia.duration + valor1) % 60);
                        lblRealTime1.Text = realTime1.ToString() + "x";
                        progressBar1.Value = (int)mediaPlayer2.Ctlcontrols.currentPosition;
                        if (progressBar1.Value > 1798)
                        {
                            Next1();
                            Next2();
                        }
                    }
                }
               
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    realTime1 = 1;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;

                }
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsUndefined)
                {
                    realTime1 = 1;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;
                }
             
                
                
                
                
                //fullScreem
                if (!mediaPlayer1.fullScreen)
                {
                    mediaPlayer1.uiMode = "none";
                }
                if (!mediaPlayer2.fullScreen)
                {
                    mediaPlayer2.uiMode = "none";
                }
            }
            catch { }
            #endregion
        }
        
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar1.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = progressBar1.Width / (float)progressBar1.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //



            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = Convert.ToInt32(relativeMouse);
                mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
            }
            else
            {
                if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    progressBar1.Value = Convert.ToInt32(relativeMouse);
                    mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                }
            }
        }
        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar1.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = progressBar1.Width / (float)progressBar1.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //
            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl1.Visible = true;
                lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
            }
            else
            {
                if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    lbl1.Visible = true;
                    lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                    lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                }
            }
           
        }
        private void progressBar1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.Visible = false;
        }
  
        
        
        private void btnAddCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    List<MediaPlayerList> arquivos1 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos2 = new List<MediaPlayerList>();
                    string[] files = Directory.GetFiles(folder.SelectedPath);

                    foreach (string nomeString in files)
                    {
                        FileInfo fi = new FileInfo(nomeString);

                        //tela 1
                        if (int.Parse(conteudo[1]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[1]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[1] + "_"))
                                {
                                    arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[1]))
                                {
                                    arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[1]))
                            {
                                arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 2
                        if (int.Parse(conteudo[2]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[2]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[2] + "_"))
                                {
                                    arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[2]))
                                {
                                    arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[2]))
                            {
                                arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                    }

                    tipoCamera = "caixa";

                    listBox1.DataSource = arquivos1;
                    listBox1.ValueMember = "Path";
                    listBox1.DisplayMember = "FileName";

                    listBox2.DataSource = arquivos2;
                    listBox2.ValueMember = "Path";
                    listBox2.DisplayMember = "FileName";
                }
            }
            catch
            {

            }
        }
        private void btnAddLoja_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    List<MediaPlayerList> arquivos1 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos2 = new List<MediaPlayerList>();
                    string[] files = Directory.GetFiles(folder.SelectedPath);

                    foreach (string nomeString in files)
                    {
                        FileInfo fi = new FileInfo(nomeString);

                        //tela 1
                        if (int.Parse(conteudo[1]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[1]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[1] + "_"))
                                {
                                    arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[1]))
                                {
                                    arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[1]))
                            {
                                arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 2
                        if (int.Parse(conteudo[2]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[2]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[2] + "_"))
                                {
                                    arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[2]))
                                {
                                    arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[2]))
                            {
                                arquivos2.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }




                    }
                    tipoCamera = "loja";

                    listBox1.DataSource = arquivos1;
                    listBox1.ValueMember = "Path";
                    listBox1.DisplayMember = "FileName";

                    listBox2.DataSource = arquivos2;
                    listBox2.ValueMember = "Path";
                    listBox2.DisplayMember = "FileName";
                }
            }
            catch
            {

            }
        }
     
        






      

        #region Fullscreem
        private void MediaPlayer1_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            int tamanhox = mediaPlayer1.Size.Width;
            int tamanhoy = mediaPlayer1.Size.Height;

            if (tamanhox == 637)
            {
                mediaPlayer1.Size = new Size(1274, mediaPlayer1.Size.Height);
                mediaPlayer2.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause2();
              
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer1.Ctlcontrols.currentPosition;
                mediaPlayer1.Size = new Size(637, mediaPlayer1.Size.Height);
                mediaPlayer2.Visible = true;
                gp.Enabled = false;
                full = false;
                Play2();
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                }
            }
        }
        private void MediaPlayer2_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            int tamanhox = mediaPlayer2.Size.Width;
            int tamanhoy = mediaPlayer2.Size.Height;

            if (tamanhox == 637)
            {
                mediaPlayer2.Size = new Size(1274, mediaPlayer1.Size.Height);
                mediaPlayer2.Location = new Point(2, 2);
                mediaPlayer1.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer2.Ctlcontrols.currentPosition;
                mediaPlayer2.Size = new Size(637, mediaPlayer2.Size.Height);
                mediaPlayer2.Location = new Point(645, 2);
                mediaPlayer1.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                }

            }
        }
        #endregion

       
    }
}
