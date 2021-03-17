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
    public partial class FrmPlayer16 : Form
    {
        int tamanhox = 320;
        int tamanhoy = 150;
        int hora = 3600;
        int meiaHora = 1800;
        string[] conteudo;
        int valor1;
        int realTime1 = 1;
        string tipoCamera = null;
        double tempoFullScreem = 0;
        bool full = false;

        public FrmPlayer16()
        {
            InitializeComponent();
        }
        private void FrmPlayer16_Load(object sender, EventArgs e)
        {
            EnterForm();
            gp.Enabled = false;
        }







        #region Form Events
        void EnterForm()
        {
            try
            {
                mediaPlayer1.uiMode = "none";
                mediaPlayer2.uiMode = "none";
                mediaPlayer3.uiMode = "none";
                mediaPlayer4.uiMode = "none";
                mediaPlayer5.uiMode = "none";
                mediaPlayer6.uiMode = "none";
                mediaPlayer7.uiMode = "none";
                mediaPlayer8.uiMode = "none";
                mediaPlayer9.uiMode = "none";
                mediaPlayer10.uiMode = "none";
                mediaPlayer11.uiMode = "none";
                mediaPlayer12.uiMode = "none";
                mediaPlayer13.uiMode = "none";
                mediaPlayer14.uiMode = "none";
                mediaPlayer15.uiMode = "none";
                mediaPlayer16.uiMode = "none";
            }
            catch
            {

            }
          

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                conteudo = File.ReadAllLines(path);
            }
            catch
            {
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                    File.Delete(path);
                }
                catch
                {

                }
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
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
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                    conteudo = File.ReadAllLines(path);
                }
                catch
                {

                }
            }
        }

        //tela 1//ok
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

        //tela 2//ok
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

        //tela 3//ok
        void Start3()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[3]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer3.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer3.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer3.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer3.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[3]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer3.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer3.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer3.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer3.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play3()
        {
            try
            {
                if (mediaPlayer3.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer3.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox3.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer3.URL = file.Path;
                        mediaPlayer3.Ctlcontrols.play();
                        mediaPlayer3.stretchToFit = true;
                        Start3();

                    }
                }
                else
                {
                    mediaPlayer3.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause3()
        {
            mediaPlayer3.Ctlcontrols.pause();
        }
        void Stop3()
        {
            try
            {
                mediaPlayer3.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next3()
        {
            try
            {
                int quant = listBox3.Items.Count;
                int index = listBox3.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox3.SelectedIndex = index;
                    MediaPlayerList file = listBox3.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer3.URL = file.Path;
                        mediaPlayer3.Ctlcontrols.play();
                        Start3();

                    }
                }
            }
            catch { }



        }
        void Prev3()
        {

            try
            {
                int quant = listBox3.Items.Count;
                int index = listBox3.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox3.SelectedIndex = index;
                }
                MediaPlayerList file = listBox3.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer3.URL = file.Path;
                    mediaPlayer3.Ctlcontrols.play();
                    Start3();

                }
            }
            catch { }

        }

        //tela 4//ok
        void Start4()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[4]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer4.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer4.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer4.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer4.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[4]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer4.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer4.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer4.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer4.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play4()
        {
            try
            {
                if (mediaPlayer4.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer4.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox4.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer4.URL = file.Path;
                        mediaPlayer4.Ctlcontrols.play();
                        mediaPlayer4.stretchToFit = true;
                        Start4();

                    }
                }
                else
                {
                    mediaPlayer4.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause4()
        {
            mediaPlayer4.Ctlcontrols.pause();
        }
        void Stop4()
        {
            try
            {
                mediaPlayer4.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next4()
        {
            try
            {
                int quant = listBox4.Items.Count;
                int index = listBox4.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox4.SelectedIndex = index;
                    MediaPlayerList file = listBox4.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer4.URL = file.Path;
                        mediaPlayer4.Ctlcontrols.play();
                        Start4();

                    }
                }
            }
            catch { }



        }
        void Prev4()
        {

            try
            {
                int quant = listBox4.Items.Count;
                int index = listBox4.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox4.SelectedIndex = index;
                }
                MediaPlayerList file = listBox4.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer4.URL = file.Path;
                    mediaPlayer4.Ctlcontrols.play();
                    Start4();

                }
            }
            catch { }

        }

        //tela 5//ok
        void Start5()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[5]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer5.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer5.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer5.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer5.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }


            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[5]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer5.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer5.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer5.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer5.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play5()
        {
            try
            {
                if (mediaPlayer5.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer5.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox5.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer5.URL = file.Path;
                        mediaPlayer5.Ctlcontrols.play();
                        mediaPlayer5.stretchToFit = true;
                        Start5();

                    }
                }
                else
                {
                    mediaPlayer5.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause5()
        {
            mediaPlayer5.Ctlcontrols.pause();
        }
        void Stop5()
        {
            try
            {
                mediaPlayer5.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next5()
        {
            try
            {
                int quant = listBox5.Items.Count;
                int index = listBox5.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox5.SelectedIndex = index;
                    MediaPlayerList file = listBox5.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer5.URL = file.Path;
                        mediaPlayer5.Ctlcontrols.play();
                        Start5();

                    }
                }
            }
            catch { }



        }
        void Prev5()
        {

            try
            {
                int quant = listBox5.Items.Count;
                int index = listBox5.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox5.SelectedIndex = index;
                }
                MediaPlayerList file = listBox5.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer5.URL = file.Path;
                    mediaPlayer5.Ctlcontrols.play();
                    Start5();

                }
            }
            catch { }

        }

        //tela 6//ok
        void Start6()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[6]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer6.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer6.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer6.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer6.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[6]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer6.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer6.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer6.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer6.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play6()
        {
            try
            {
                if (mediaPlayer6.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer6.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox6.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer6.URL = file.Path;
                        mediaPlayer6.Ctlcontrols.play();
                        mediaPlayer6.stretchToFit = true;
                        Start6();

                    }
                }
                else
                {
                    mediaPlayer6.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause6()
        {
            mediaPlayer6.Ctlcontrols.pause();
        }
        void Stop6()
        {
            try
            {
                mediaPlayer6.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next6()
        {
            try
            {
                int quant = listBox6.Items.Count;
                int index = listBox6.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox6.SelectedIndex = index;
                    MediaPlayerList file = listBox6.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer6.URL = file.Path;
                        mediaPlayer6.Ctlcontrols.play();
                        Start6();

                    }
                }
            }
            catch { }



        }
        void Prev6()
        {

            try
            {
                int quant = listBox6.Items.Count;
                int index = listBox6.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox6.SelectedIndex = index;
                }
                MediaPlayerList file = listBox6.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer6.URL = file.Path;
                    mediaPlayer6.Ctlcontrols.play();
                    Start6();

                }
            }
            catch { }

        }

        //tela 7//ok
        void Start7()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[7]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer7.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer7.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer7.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer7.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[7]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer7.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer7.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer7.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer7.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play7()
        {
            try
            {
                if (mediaPlayer7.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer7.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox7.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer7.URL = file.Path;
                        mediaPlayer7.Ctlcontrols.play();
                        mediaPlayer7.stretchToFit = true;
                        Start7();

                    }
                }
                else
                {
                    mediaPlayer7.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause7()
        {
            mediaPlayer7.Ctlcontrols.pause();
        }
        void Stop7()
        {
            try
            {
                mediaPlayer7.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next7()
        {
            try
            {
                int quant = listBox7.Items.Count;
                int index = listBox7.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox7.SelectedIndex = index;
                    MediaPlayerList file = listBox7.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer7.URL = file.Path;
                        mediaPlayer7.Ctlcontrols.play();
                        Start7();

                    }
                }
            }
            catch { }



        }
        void Prev7()
        {

            try
            {
                int quant = listBox7.Items.Count;
                int index = listBox7.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox7.SelectedIndex = index;
                }
                MediaPlayerList file = listBox7.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer7.URL = file.Path;
                    mediaPlayer7.Ctlcontrols.play();
                    Start7();

                }
            }
            catch { }

        }

        //tela 8
        void Start8()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[8]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer8.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer8.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer8.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer8.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[8]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer8.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer8.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer8.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer8.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play8()
        {
            try
            {
                if (mediaPlayer8.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer8.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox8.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer8.URL = file.Path;
                        mediaPlayer8.Ctlcontrols.play();
                        mediaPlayer8.stretchToFit = true;
                        Start8();

                    }
                }
                else
                {
                    mediaPlayer8.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause8()
        {
            mediaPlayer8.Ctlcontrols.pause();
        }
        void Stop8()
        {
            try
            {
                mediaPlayer8.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next8()
        {
            try
            {
                int quant = listBox8.Items.Count;
                int index = listBox8.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox8.SelectedIndex = index;
                    MediaPlayerList file = listBox8.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer8.URL = file.Path;
                        mediaPlayer8.Ctlcontrols.play();
                        Start8();

                    }
                }
            }
            catch { }



        }
        void Prev8()
        {

            try
            {
                int quant = listBox8.Items.Count;
                int index = listBox8.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox8.SelectedIndex = index;
                }
                MediaPlayerList file = listBox8.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer8.URL = file.Path;
                    mediaPlayer8.Ctlcontrols.play();
                    Start8();

                }
            }
            catch { }

        }

        //tela 9//ok
        void Start9()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[9]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer9.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer9.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer9.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer9.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }


            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[9]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer9.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer9.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer9.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer9.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play9()
        {
            try
            {
                if (mediaPlayer9.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer9.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox9.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer9.URL = file.Path;
                        mediaPlayer9.Ctlcontrols.play();
                        mediaPlayer9.stretchToFit = true;
                        Start9();

                    }
                }
                else
                {
                    mediaPlayer9.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause9()
        {
            mediaPlayer9.Ctlcontrols.pause();
        }
        void Stop9()
        {
            try
            {
                mediaPlayer1.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next9()
        {
            try
            {
                int quant = listBox9.Items.Count;
                int index = listBox9.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox9.SelectedIndex = index;
                    MediaPlayerList file = listBox9.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer9.URL = file.Path;
                        mediaPlayer9.Ctlcontrols.play();
                        Start9();

                    }
                }
            }
            catch { }



        }
        void Prev9()
        {

            try
            {
                int quant = listBox9.Items.Count;
                int index = listBox9.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox9.SelectedIndex = index;
                }
                MediaPlayerList file = listBox9.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer9.URL = file.Path;
                    mediaPlayer9.Ctlcontrols.play();
                    Start9();

                }
            }
            catch { }

        }

        //tela 10//ok
        void Start10()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[10]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer10.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer10.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer10.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer10.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[10]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer10.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer10.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer10.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer10.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play10()
        {
            try
            {
                if (mediaPlayer10.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer10.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox10.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer10.URL = file.Path;
                        mediaPlayer10.Ctlcontrols.play();
                        mediaPlayer10.stretchToFit = true;
                        Start10();

                    }
                }
                else
                {
                    mediaPlayer10.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause10()
        {
            mediaPlayer10.Ctlcontrols.pause();
        }
        void Stop10()
        {
            try
            {
                mediaPlayer10.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next10()
        {
            try
            {
                int quant = listBox10.Items.Count;
                int index = listBox10.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox10.SelectedIndex = index;
                    MediaPlayerList file = listBox10.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer10.URL = file.Path;
                        mediaPlayer10.Ctlcontrols.play();
                        Start10();

                    }
                }
            }
            catch { }



        }
        void Prev10()
        {

            try
            {
                int quant = listBox10.Items.Count;
                int index = listBox10.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox10.SelectedIndex = index;
                }
                MediaPlayerList file = listBox10.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer10.URL = file.Path;
                    mediaPlayer10.Ctlcontrols.play();
                    Start10();

                }
            }
            catch { }

        }

        //tela 11//ok
        void Start11()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[11]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer11.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer11.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer11.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer11.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[11]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer11.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer11.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer11.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer11.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play11()
        {
            try
            {
                if (mediaPlayer11.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer11.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox11.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer11.URL = file.Path;
                        mediaPlayer11.Ctlcontrols.play();
                        mediaPlayer11.stretchToFit = true;
                        Start11();

                    }
                }
                else
                {
                    mediaPlayer11.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause11()
        {
            mediaPlayer11.Ctlcontrols.pause();
        }
        void Stop11()
        {
            try
            {
                mediaPlayer11.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next11()
        {
            try
            {
                int quant = listBox11.Items.Count;
                int index = listBox11.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox11.SelectedIndex = index;
                    MediaPlayerList file = listBox11.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer11.URL = file.Path;
                        mediaPlayer11.Ctlcontrols.play();
                        Start11();

                    }
                }
            }
            catch { }



        }
        void Prev11()
        {

            try
            {
                int quant = listBox11.Items.Count;
                int index = listBox11.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox11.SelectedIndex = index;
                }
                MediaPlayerList file = listBox11.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer11.URL = file.Path;
                    mediaPlayer11.Ctlcontrols.play();
                    Start11();

                }
            }
            catch { }

        }

        //tela 12//ok
        void Start12()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[12]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer12.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer12.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer12.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer12.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[12]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer12.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer12.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer12.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer12.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play12()
        {
            try
            {
                if (mediaPlayer12.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer12.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox12.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer12.URL = file.Path;
                        mediaPlayer12.Ctlcontrols.play();
                        mediaPlayer12.stretchToFit = true;
                        Start12();

                    }
                }
                else
                {
                    mediaPlayer12.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause12()
        {
            mediaPlayer12.Ctlcontrols.pause();
        }
        void Stop12()
        {
            try
            {
                mediaPlayer12.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next12()
        {
            try
            {
                int quant = listBox12.Items.Count;
                int index = listBox12.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox12.SelectedIndex = index;
                    MediaPlayerList file = listBox12.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer12.URL = file.Path;
                        mediaPlayer12.Ctlcontrols.play();
                        Start12();

                    }
                }
            }
            catch { }



        }
        void Prev12()
        {

            try
            {
                int quant = listBox12.Items.Count;
                int index = listBox12.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox12.SelectedIndex = index;
                }
                MediaPlayerList file = listBox12.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer12.URL = file.Path;
                    mediaPlayer12.Ctlcontrols.play();
                    Start12();

                }
            }
            catch { }

        }

        //tela 13//ok
        void Start13()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[13]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer13.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer13.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer13.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer13.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }


            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[13]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer13.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer13.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer13.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer13.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play13()
        {
            try
            {
                if (mediaPlayer13.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer13.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox13.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer13.URL = file.Path;
                        mediaPlayer13.Ctlcontrols.play();
                        mediaPlayer13.stretchToFit = true;
                        Start13();

                    }
                }
                else
                {
                    mediaPlayer13.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause13()
        {
            mediaPlayer13.Ctlcontrols.pause();
        }
        void Stop13()
        {
            try
            {
                mediaPlayer13.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next13()
        {
            try
            {
                int quant = listBox13.Items.Count;
                int index = listBox13.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox13.SelectedIndex = index;
                    MediaPlayerList file = listBox13.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer13.URL = file.Path;
                        mediaPlayer13.Ctlcontrols.play();
                        Start13();

                    }
                }
            }
            catch { }



        }
        void Prev13()
        {

            try
            {
                int quant = listBox13.Items.Count;
                int index = listBox13.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox13.SelectedIndex = index;
                }
                MediaPlayerList file = listBox13.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer13.URL = file.Path;
                    mediaPlayer13.Ctlcontrols.play();
                    Start13();

                }
            }
            catch { }

        }

        //tela 14//ok
        void Start14()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[14]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer14.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer14.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer14.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer14.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[14]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer14.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer14.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer14.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer14.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play14()
        {
            try
            {
                if (mediaPlayer14.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer14.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox14.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer14.URL = file.Path;
                        mediaPlayer14.Ctlcontrols.play();
                        mediaPlayer14.stretchToFit = true;
                        Start14();

                    }
                }
                else
                {
                    mediaPlayer14.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause14()
        {
            mediaPlayer14.Ctlcontrols.pause();
        }
        void Stop14()
        {
            try
            {
                mediaPlayer14.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next14()
        {
            try
            {
                int quant = listBox14.Items.Count;
                int index = listBox14.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox14.SelectedIndex = index;
                    MediaPlayerList file = listBox14.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer14.URL = file.Path;
                        mediaPlayer14.Ctlcontrols.play();
                        Start14();

                    }
                }
            }
            catch { }



        }
        void Prev14()
        {

            try
            {
                int quant = listBox14.Items.Count;
                int index = listBox14.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox14.SelectedIndex = index;
                }
                MediaPlayerList file = listBox14.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer14.URL = file.Path;
                    mediaPlayer14.Ctlcontrols.play();
                    Start14();

                }
            }
            catch { }

        }

        //tela 15//ok
        void Start15()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[15]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer15.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer15.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer15.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer15.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[15]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer15.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer15.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer15.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer15.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play15()
        {
            try
            {
                if (mediaPlayer15.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer15.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox15.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer15.URL = file.Path;
                        mediaPlayer15.Ctlcontrols.play();
                        mediaPlayer15.stretchToFit = true;
                        Start15();

                    }
                }
                else
                {
                    mediaPlayer15.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause15()
        {
            mediaPlayer15.Ctlcontrols.pause();
        }
        void Stop15()
        {
            try
            {
                mediaPlayer15.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next15()
        {
            try
            {
                int quant = listBox15.Items.Count;
                int index = listBox15.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox15.SelectedIndex = index;
                    MediaPlayerList file = listBox15.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer15.URL = file.Path;
                        mediaPlayer15.Ctlcontrols.play();
                        Start15();

                    }
                }
            }
            catch { }



        }
        void Prev15()
        {

            try
            {
                int quant = listBox15.Items.Count;
                int index = listBox15.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox15.SelectedIndex = index;
                }
                MediaPlayerList file = listBox15.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer15.URL = file.Path;
                    mediaPlayer15.Ctlcontrols.play();
                    Start15();

                }
            }
            catch { }

        }

        //tela 16
        void Start16()
        {
            if (tipoCamera.Equals("caixa"))
            {
                if (int.Parse(conteudo[16]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer16.currentMedia.name.Substring(22, 2)) * hora;
                    if (mediaPlayer16.currentMedia.name.Substring(24, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer16.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer16.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
            if (tipoCamera.Equals("loja"))
            {
                if (int.Parse(conteudo[16]) < 10)
                {
                    valor1 = int.Parse(mediaPlayer16.currentMedia.name.Substring(23, 2)) * hora;
                    if (mediaPlayer16.currentMedia.name.Substring(25, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
                else
                {
                    valor1 = int.Parse(mediaPlayer16.currentMedia.name.Substring(24, 2)) * hora;
                    if (mediaPlayer16.currentMedia.name.Substring(26, 2).Equals("30"))
                    {
                        valor1 += meiaHora;
                    }
                }
            }
        }
        void Play16()
        {
            try
            {
                if (mediaPlayer16.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer16.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox16.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer16.URL = file.Path;
                        mediaPlayer16.Ctlcontrols.play();
                        mediaPlayer16.stretchToFit = true;
                        Start16();

                    }
                }
                else
                {
                    mediaPlayer16.Ctlcontrols.play();

                }

            }
            catch { }
        }
        void Pause16()
        {
            mediaPlayer16.Ctlcontrols.pause();
        }
        void Stop16()
        {
            try
            {
                mediaPlayer16.Ctlcontrols.stop();
            }
            catch { }
        }
        void Next16()
        {
            try
            {
                int quant = listBox16.Items.Count;
                int index = listBox16.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox16.SelectedIndex = index;
                    MediaPlayerList file = listBox16.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer16.URL = file.Path;
                        mediaPlayer16.Ctlcontrols.play();
                        Start16();

                    }
                }
            }
            catch { }



        }
        void Prev16()  //ok
        {

            try
            {
                int quant = listBox16.Items.Count;
                int index = listBox16.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox16.SelectedIndex = index;
                }
                MediaPlayerList file = listBox16.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer16.URL = file.Path;
                    mediaPlayer16.Ctlcontrols.play();
                    Start16();

                }
            }
            catch { }

        }

        #endregion

        #region Btns
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            if (full==false)
            {
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
            }
            if (mediaPlayer1.Size.Width != tamanhox)
            {
                Play1();
            }
            if (mediaPlayer2.Size.Width != tamanhox)
            {
                Play2();
            }
            if (mediaPlayer3.Size.Width != tamanhox)
            {
                Play3();
            }
            if (mediaPlayer4.Size.Width != tamanhox)
            {
                Play4();
            }
            if (mediaPlayer5.Size.Width != tamanhox)
            {
                Play5();
            }
            if (mediaPlayer6.Size.Width != tamanhox)
            {
                Play6();
            }
            if (mediaPlayer7.Size.Width != tamanhox)
            {
                Play7();
            }
            if (mediaPlayer8.Size.Width != tamanhox)
            {
                Play8();
            }
            if (mediaPlayer9.Size.Width != tamanhox)
            {
                Play9();
            }
            if (mediaPlayer10.Size.Width != tamanhox)
            {
                Play10();
            }
            if (mediaPlayer11.Size.Width != tamanhox)
            {
                Play11();
            }
            if (mediaPlayer12.Size.Width != tamanhox)
            {
                Play12();
            }
            if (mediaPlayer13.Size.Width != tamanhox)
            {
                Play13();
            }
            if (mediaPlayer14.Size.Width != tamanhox)
            {
                Play14();
            }
            if (mediaPlayer15.Size.Width != tamanhox)
            {
                Play15();
            }
            if (mediaPlayer16.Size.Width != tamanhox)
            {
                Play16();
            }


        }
        private void btnPause1_Click(object sender, EventArgs e)
        {
            Pause1();
            Pause2();
            Pause3();
            Pause4();
            Pause5();
            Pause6();
            Pause7();
            Pause8();
            Pause9();
            Pause10();
            Pause11();
            Pause12();
            Pause13();
            Pause14();
            Pause15();
            Pause16();


        }
        private void btnStop1_Click(object sender, EventArgs e)
        {
            Stop1();
            Stop2();
            Stop3();
            Stop4();
            Stop5();
            Stop6();
            Stop7();
            Stop8();
            Stop9();
            Stop10();
            Stop11();
            Stop12();
            Stop13();
            Stop14();
            Stop15();
            Stop16();
        }
        private void btnPrev1_Click(object sender, EventArgs e)
        {
            Prev1();
            Prev2();
            Prev3();
            Prev4();
            Prev5();
            Prev6();
            Prev7();
            Prev8();
            Prev9();
            Prev10();
            Prev11();
            Prev12();
            Prev13();
            Prev14();
            Prev15();
            Prev16();
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            Next1();
            Next2();
            Next3();
            Next4();
            Next5();
            Next6();
            Next7();
            Next8();
            Next9();
            Next10();
            Next11();
            Next12();
            Next13();
            Next14();
            Next15();
            Next16();
        }
        private void btnAvX1_Click(object sender, EventArgs e)
        {
            if (realTime1 < 128)
            {
                realTime1 *= 2;
            }
        }//ok
        private void btnRetroX1_Click(object sender, EventArgs e)
        {
            if (realTime1 > 1)
            {
                realTime1 /= 2;
            }
        }//ok


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
                        mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                    }
                    if (realTime1 == 4)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                    }
                    if (realTime1 == 8)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                    }
                    if (realTime1 == 16)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                    }
                    if (realTime1 == 32)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                    }
                    if (realTime1 == 64)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                    }
                    if (realTime1 == 128)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                        mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
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
                        Next3();
                        Next4();
                        Next5();
                        Next6();
                        Next7();
                        Next8();
                        Next9();
                        Next10();
                        Next11();
                        Next12();
                        Next13();
                        Next14();
                        Next15();
                        Next16();
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
                            mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                        }
                        if (realTime1 == 4)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                        }
                        if (realTime1 == 8)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                        }
                        if (realTime1 == 16)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                        }
                        if (realTime1 == 32)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                        }
                        if (realTime1 == 64)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                        }
                        if (realTime1 == 128)
                        {
                            mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                            mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
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
                            Next3();
                            Next4();
                            Next5();
                            Next6();
                            Next7();
                            Next8();
                            Next9();
                            Next10();
                            Next11();
                            Next12();
                            Next13();
                            Next14();
                            Next15();
                            Next16();
                        }
                    }
                    else
                    {
                        if (mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                            }
                            if (realTime1 == 4)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                            }
                            if (realTime1 == 8)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                            }
                            if (realTime1 == 16)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                            }
                            if (realTime1 == 32)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                            }
                            if (realTime1 == 64)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                            }
                            if (realTime1 == 128)
                            {
                                mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                            }
                            #endregion
                            lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer3.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer3.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer3.Ctlcontrols.currentPosition + valor1) % 60);
                            lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer3.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer3.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer3.currentMedia.duration + valor1) % 60);
                            lblRealTime1.Text = realTime1.ToString() + "x";
                            progressBar1.Value = (int)mediaPlayer3.Ctlcontrols.currentPosition;
                            if (progressBar1.Value > 1798)
                            {
                                Next1();
                                Next2();
                                Next3();
                                Next4();
                                Next5();
                                Next6();
                                Next7();
                                Next8();
                                Next9();
                                Next10();
                                Next11();
                                Next12();
                                Next13();
                                Next14();
                                Next15();
                                Next16();
                            }
                        }
                        else
                        {
                            if (mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                }
                                if (realTime1 == 4)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                }
                                if (realTime1 == 8)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                }
                                if (realTime1 == 16)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                }
                                if (realTime1 == 32)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                }
                                if (realTime1 == 64)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                }
                                if (realTime1 == 128)
                                {
                                    mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                    mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                }
                                #endregion
                                lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer4.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer4.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer4.Ctlcontrols.currentPosition + valor1) % 60);
                                lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer4.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer4.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer4.currentMedia.duration + valor1) % 60);
                                lblRealTime1.Text = realTime1.ToString() + "x";
                                progressBar1.Value = (int)mediaPlayer4.Ctlcontrols.currentPosition;
                                if (progressBar1.Value > 1798)
                                {
                                    Next1();
                                    Next2();
                                    Next3();
                                    Next4();
                                    Next5();
                                    Next6();
                                    Next7();
                                    Next8();
                                    Next9();
                                    Next10();
                                    Next11();
                                    Next12();
                                    Next13();
                                    Next14();
                                    Next15();
                                    Next16();
                                }
                            }
                            else
                            {
                                if (mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                    }
                                    if (realTime1 == 4)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                    }
                                    if (realTime1 == 8)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                    }
                                    if (realTime1 == 16)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                    }
                                    if (realTime1 == 32)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                    }
                                    if (realTime1 == 64)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                    }
                                    if (realTime1 == 128)
                                    {
                                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                        mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                    }
                                    #endregion
                                    lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer5.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer5.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer5.Ctlcontrols.currentPosition + valor1) % 60);
                                    lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer5.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer5.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer5.currentMedia.duration + valor1) % 60);
                                    lblRealTime1.Text = realTime1.ToString() + "x";
                                    progressBar1.Value = (int)mediaPlayer5.Ctlcontrols.currentPosition;
                                    if (progressBar1.Value > 1798)
                                    {
                                        Next1();
                                        Next2();
                                        Next3();
                                        Next4();
                                        Next5();
                                        Next6();
                                        Next7();
                                        Next8();
                                        Next9();
                                        Next10();
                                        Next11();
                                        Next12();
                                        Next13();
                                        Next14();
                                        Next15();
                                        Next16();
                                    }
                                }
                                else
                                {
                                    if (mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                        }
                                        if (realTime1 == 4)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                        }
                                        if (realTime1 == 8)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                        }
                                        if (realTime1 == 16)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                        }
                                        if (realTime1 == 32)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                        }
                                        if (realTime1 == 64)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                        }
                                        if (realTime1 == 128)
                                        {
                                            mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                            mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                        }
                                        #endregion
                                        lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer6.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer6.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer6.Ctlcontrols.currentPosition + valor1) % 60);
                                        lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer6.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer6.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer6.currentMedia.duration + valor1) % 60);
                                        lblRealTime1.Text = realTime1.ToString() + "x";
                                        progressBar1.Value = (int)mediaPlayer6.Ctlcontrols.currentPosition;
                                        if (progressBar1.Value > 1798)
                                        {
                                            Next1();
                                            Next2();
                                            Next3();
                                            Next4();
                                            Next5();
                                            Next6();
                                            Next7();
                                            Next8();
                                            Next9();
                                            Next10();
                                            Next11();
                                            Next12();
                                            Next13();
                                            Next14();
                                            Next15();
                                            Next16();
                                        }
                                    }
                                    else
                                    {
                                        if (mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                            }
                                            if (realTime1 == 4)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                            }
                                            if (realTime1 == 8)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                            }
                                            if (realTime1 == 16)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                            }
                                            if (realTime1 == 32)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                            }
                                            if (realTime1 == 64)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                            }
                                            if (realTime1 == 128)
                                            {
                                                mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                            }
                                            #endregion
                                            lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer7.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer7.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer7.Ctlcontrols.currentPosition + valor1) % 60);
                                            lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer7.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer7.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer7.currentMedia.duration + valor1) % 60);
                                            lblRealTime1.Text = realTime1.ToString() + "x";
                                            progressBar1.Value = (int)mediaPlayer7.Ctlcontrols.currentPosition;
                                            if (progressBar1.Value > 1798)
                                            {
                                                Next1();
                                                Next2();
                                                Next3();
                                                Next4();
                                                Next5();
                                                Next6();
                                                Next7();
                                                Next8();
                                                Next9();
                                                Next10();
                                                Next11();
                                                Next12();
                                                Next13();
                                                Next14();
                                                Next15();
                                                Next16();
                                            }
                                        }
                                        else
                                        {
                                            if (mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                }
                                                if (realTime1 == 4)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                }
                                                if (realTime1 == 8)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                }
                                                if (realTime1 == 16)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                }
                                                if (realTime1 == 32)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                }
                                                if (realTime1 == 64)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                }
                                                if (realTime1 == 128)
                                                {
                                                    mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                    mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                }
                                                #endregion
                                                lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer8.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer8.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer8.Ctlcontrols.currentPosition + valor1) % 60);
                                                lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer8.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer8.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer8.currentMedia.duration + valor1) % 60);
                                                lblRealTime1.Text = realTime1.ToString() + "x";
                                                progressBar1.Value = (int)mediaPlayer8.Ctlcontrols.currentPosition;
                                                if (progressBar1.Value > 1798)
                                                {
                                                    Next1();
                                                    Next2();
                                                    Next3();
                                                    Next4();
                                                    Next5();
                                                    Next6();
                                                    Next7();
                                                    Next8();
                                                    Next9();
                                                    Next10();
                                                    Next11();
                                                    Next12();
                                                    Next13();
                                                    Next14();
                                                    Next15();
                                                    Next16();
                                                }
                                            }
                                            else
                                            {
                                                if (mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                    }
                                                    if (realTime1 == 4)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                    }
                                                    if (realTime1 == 8)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                    }
                                                    if (realTime1 == 16)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                    }
                                                    if (realTime1 == 32)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                    }
                                                    if (realTime1 == 64)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                    }
                                                    if (realTime1 == 128)
                                                    {
                                                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                        mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                    }
                                                    #endregion
                                                    lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer9.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer9.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer9.Ctlcontrols.currentPosition + valor1) % 60);
                                                    lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer9.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer9.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer9.currentMedia.duration + valor1) % 60);
                                                    lblRealTime1.Text = realTime1.ToString() + "x";
                                                    progressBar1.Value = (int)mediaPlayer9.Ctlcontrols.currentPosition;
                                                    if (progressBar1.Value > 1798)
                                                    {
                                                        Next1();
                                                        Next2();
                                                        Next3();
                                                        Next4();
                                                        Next5();
                                                        Next6();
                                                        Next7();
                                                        Next8();
                                                        Next9();
                                                        Next10();
                                                        Next11();
                                                        Next12();
                                                        Next13();
                                                        Next14();
                                                        Next15();
                                                        Next16();
                                                    }
                                                }
                                                else
                                                {
                                                    if (mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                        }
                                                        if (realTime1 == 4)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                        }
                                                        if (realTime1 == 8)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                        }
                                                        if (realTime1 == 16)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                        }
                                                        if (realTime1 == 32)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                        }
                                                        if (realTime1 == 64)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                        }
                                                        if (realTime1 == 128)
                                                        {
                                                            mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                            mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                        }
                                                        #endregion
                                                        lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer10.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer10.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer10.Ctlcontrols.currentPosition + valor1) % 60);
                                                        lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer10.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer10.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer10.currentMedia.duration + valor1) % 60);
                                                        lblRealTime1.Text = realTime1.ToString() + "x";
                                                        progressBar1.Value = (int)mediaPlayer10.Ctlcontrols.currentPosition;
                                                        if (progressBar1.Value > 1798)
                                                        {
                                                            Next1();
                                                            Next2();
                                                            Next3();
                                                            Next4();
                                                            Next5();
                                                            Next6();
                                                            Next7();
                                                            Next8();
                                                            Next9();
                                                            Next10();
                                                            Next11();
                                                            Next12();
                                                            Next13();
                                                            Next14();
                                                            Next15();
                                                            Next16();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                            }
                                                            if (realTime1 == 4)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                            }
                                                            if (realTime1 == 8)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                            }
                                                            if (realTime1 == 16)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                            }
                                                            if (realTime1 == 32)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                            }
                                                            if (realTime1 == 64)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                            }
                                                            if (realTime1 == 128)
                                                            {
                                                                mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                            }
                                                            #endregion
                                                            lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer11.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer11.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer11.Ctlcontrols.currentPosition + valor1) % 60);
                                                            lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer11.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer11.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer11.currentMedia.duration + valor1) % 60);
                                                            lblRealTime1.Text = realTime1.ToString() + "x";
                                                            progressBar1.Value = (int)mediaPlayer11.Ctlcontrols.currentPosition;
                                                            if (progressBar1.Value > 1798)
                                                            {
                                                                Next1();
                                                                Next2();
                                                                Next3();
                                                                Next4();
                                                                Next5();
                                                                Next6();
                                                                Next7();
                                                                Next8();
                                                                Next9();
                                                                Next10();
                                                                Next11();
                                                                Next12();
                                                                Next13();
                                                                Next14();
                                                                Next15();
                                                                Next16();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                                }
                                                                if (realTime1 == 4)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                                }
                                                                if (realTime1 == 8)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                                }
                                                                if (realTime1 == 16)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                                }
                                                                if (realTime1 == 32)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                                }
                                                                if (realTime1 == 64)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                                }
                                                                if (realTime1 == 128)
                                                                {
                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                                }
                                                                #endregion
                                                                lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer12.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer12.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer12.Ctlcontrols.currentPosition + valor1) % 60);
                                                                lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer12.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer12.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer12.currentMedia.duration + valor1) % 60);
                                                                lblRealTime1.Text = realTime1.ToString() + "x";
                                                                progressBar1.Value = (int)mediaPlayer12.Ctlcontrols.currentPosition;
                                                                if (progressBar1.Value > 1798)
                                                                {
                                                                    Next1();
                                                                    Next2();
                                                                    Next3();
                                                                    Next4();
                                                                    Next5();
                                                                    Next6();
                                                                    Next7();
                                                                    Next8();
                                                                    Next9();
                                                                    Next10();
                                                                    Next11();
                                                                    Next12();
                                                                    Next13();
                                                                    Next14();
                                                                    Next15();
                                                                    Next16();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                                    }
                                                                    if (realTime1 == 4)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                                    }
                                                                    if (realTime1 == 8)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                                    }
                                                                    if (realTime1 == 16)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                                    }
                                                                    if (realTime1 == 32)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                                    }
                                                                    if (realTime1 == 64)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                                    }
                                                                    if (realTime1 == 128)
                                                                    {
                                                                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                                    }
                                                                    #endregion
                                                                    lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer13.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer13.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer13.Ctlcontrols.currentPosition + valor1) % 60);
                                                                    lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer13.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer13.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer13.currentMedia.duration + valor1) % 60);
                                                                    lblRealTime1.Text = realTime1.ToString() + "x";
                                                                    progressBar1.Value = (int)mediaPlayer13.Ctlcontrols.currentPosition;
                                                                    if (progressBar1.Value > 1798)
                                                                    {
                                                                        Next1();
                                                                        Next2();
                                                                        Next3();
                                                                        Next4();
                                                                        Next5();
                                                                        Next6();
                                                                        Next7();
                                                                        Next8();
                                                                        Next9();
                                                                        Next10();
                                                                        Next11();
                                                                        Next12();
                                                                        Next13();
                                                                        Next14();
                                                                        Next15();
                                                                        Next16();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                                        }
                                                                        if (realTime1 == 4)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                                        }
                                                                        if (realTime1 == 8)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                                        }
                                                                        if (realTime1 == 16)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                                        }
                                                                        if (realTime1 == 32)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                                        }
                                                                        if (realTime1 == 64)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                                        }
                                                                        if (realTime1 == 128)
                                                                        {
                                                                            mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                                        }
                                                                        #endregion
                                                                        lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer14.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer14.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer14.Ctlcontrols.currentPosition + valor1) % 60);
                                                                        lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer14.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer14.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer14.currentMedia.duration + valor1) % 60);
                                                                        lblRealTime1.Text = realTime1.ToString() + "x";
                                                                        progressBar1.Value = (int)mediaPlayer14.Ctlcontrols.currentPosition;
                                                                        if (progressBar1.Value > 1798)
                                                                        {
                                                                            Next1();
                                                                            Next2();
                                                                            Next3();
                                                                            Next4();
                                                                            Next5();
                                                                            Next6();
                                                                            Next7();
                                                                            Next8();
                                                                            Next9();
                                                                            Next10();
                                                                            Next11();
                                                                            Next12();
                                                                            Next13();
                                                                            Next14();
                                                                            Next15();
                                                                            Next16();
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                                            }
                                                                            if (realTime1 == 4)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                                            }
                                                                            if (realTime1 == 8)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                                            }
                                                                            if (realTime1 == 16)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                                            }
                                                                            if (realTime1 == 32)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                                            }
                                                                            if (realTime1 == 64)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                                            }
                                                                            if (realTime1 == 128)
                                                                            {
                                                                                mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                                mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                                            }
                                                                            #endregion
                                                                            lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer15.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer15.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer15.Ctlcontrols.currentPosition + valor1) % 60);
                                                                            lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer15.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer15.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer15.currentMedia.duration + valor1) % 60);
                                                                            lblRealTime1.Text = realTime1.ToString() + "x";
                                                                            progressBar1.Value = (int)mediaPlayer15.Ctlcontrols.currentPosition;
                                                                            if (progressBar1.Value > 1798)
                                                                            {
                                                                                Next1();
                                                                                Next2();
                                                                                Next3();
                                                                                Next4();
                                                                                Next5();
                                                                                Next6();
                                                                                Next7();
                                                                                Next8();
                                                                                Next9();
                                                                                Next10();
                                                                                Next11();
                                                                                Next12();
                                                                                Next13();
                                                                                Next14();
                                                                                Next15();
                                                                                Next16();
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.2f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.2f;
                                                                                }
                                                                                if (realTime1 == 4)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.4f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.4f;
                                                                                }
                                                                                if (realTime1 == 8)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 0.8f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 0.8f;
                                                                                }
                                                                                if (realTime1 == 16)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 1.6f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 1.6f;
                                                                                }
                                                                                if (realTime1 == 32)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 3.2f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 3.2f;
                                                                                }
                                                                                if (realTime1 == 64)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 6.4f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 6.4f;
                                                                                }
                                                                                if (realTime1 == 128)
                                                                                {
                                                                                    mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer2.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer3.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer4.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer5.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer6.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer7.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer8.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer9.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer10.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer11.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer12.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer13.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer14.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer15.Ctlcontrols.currentPosition += 12.8f;
                                                                                    mediaPlayer16.Ctlcontrols.currentPosition += 12.8f;
                                                                                }
                                                                                #endregion
                                                                                lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer16.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer16.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer16.Ctlcontrols.currentPosition + valor1) % 60);
                                                                                lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer16.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer16.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer16.currentMedia.duration + valor1) % 60);
                                                                                lblRealTime1.Text = realTime1.ToString() + "x";
                                                                                progressBar1.Value = (int)mediaPlayer16.Ctlcontrols.currentPosition;
                                                                                if (progressBar1.Value > 1798)
                                                                                {
                                                                                    Next1();
                                                                                    Next2();
                                                                                    Next3();
                                                                                    Next4();
                                                                                    Next5();
                                                                                    Next6();
                                                                                    Next7();
                                                                                    Next8();
                                                                                    Next9();
                                                                                    Next10();
                                                                                    Next11();
                                                                                    Next12();
                                                                                    Next13();
                                                                                    Next14();
                                                                                    Next15();
                                                                                    Next16();
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
               
                
                
                
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    realTime1 = 1;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;

                }
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsUndefined)
                {
                    realTime1 = 1;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;
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
                mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
            }
            else
            {
                if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    progressBar1.Value = Convert.ToInt32(relativeMouse);
                    mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                    mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                }
                else
                {
                    if (mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        progressBar1.Value = Convert.ToInt32(relativeMouse);
                        mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                        mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                    }
                    else
                    {
                        if (mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsPlaying)
                        {
                            progressBar1.Value = Convert.ToInt32(relativeMouse);
                            mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                            mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                        }
                        else
                        {
                            if (mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsPlaying)
                            {
                                progressBar1.Value = Convert.ToInt32(relativeMouse);
                                mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                            }
                            else
                            {
                                if (mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                {
                                    progressBar1.Value = Convert.ToInt32(relativeMouse);
                                    mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                    mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                }
                                else
                                {
                                    if (mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                    {
                                        progressBar1.Value = Convert.ToInt32(relativeMouse);
                                        mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                        mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                    }
                                    else
                                    {
                                        if (mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                        {
                                            progressBar1.Value = Convert.ToInt32(relativeMouse);
                                            mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                            mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                        }
                                        else
                                        {
                                            if (mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                            {
                                                progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                            }
                                            else
                                            {
                                                if (mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                {
                                                    progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                    mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                }
                                                else
                                                {
                                                    if (mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                    {
                                                        progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                        mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                    }
                                                    else
                                                    {
                                                        if (mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                        {
                                                            progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                            mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                        }
                                                        else
                                                        {
                                                            if (mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                            {
                                                                progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                                mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                            }
                                                            else
                                                            {
                                                                if (mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                {
                                                                    progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                                    mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                }
                                                                else
                                                                {
                                                                    if (mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                    {
                                                                        progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                                        mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                        {
                                                                            progressBar1.Value = Convert.ToInt32(relativeMouse);
                                                                            mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer2.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer3.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer4.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer5.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer6.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer7.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer8.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer9.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer10.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer11.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer12.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer13.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer14.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer15.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                            mediaPlayer16.Ctlcontrols.currentPosition = progressBar1.Value;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
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
                else
                {
                    if (mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        lbl1.Visible = true;
                        lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                        lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                    }
                    else
                    {
                        if (mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsPlaying)
                        {
                            lbl1.Visible = true;
                            lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                            lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                        }
                        else
                        {
                            if (mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsPlaying)
                            {
                                lbl1.Visible = true;
                                lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                            }
                            else
                            {
                                if (mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                {
                                    lbl1.Visible = true;
                                    lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                    lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                }
                                else
                                {
                                    if (mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                    {
                                        lbl1.Visible = true;
                                        lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                        lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                    }
                                    else
                                    {
                                        if (mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                        {
                                            lbl1.Visible = true;
                                            lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                            lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                        }
                                        else
                                        {
                                            if (mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                            {
                                                lbl1.Visible = true;
                                                lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                            }
                                            else
                                            {
                                                if (mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                {
                                                    lbl1.Visible = true;
                                                    lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                    lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                }
                                                else
                                                {
                                                    if (mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                    {
                                                        lbl1.Visible = true;
                                                        lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                        lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                    }
                                                    else
                                                    {
                                                        if (mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                        {
                                                            lbl1.Visible = true;
                                                            lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                            lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                        }
                                                        else
                                                        {
                                                            if (mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                            {
                                                                lbl1.Visible = true;
                                                                lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                                lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                            }
                                                            else
                                                            {
                                                                if (mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                {
                                                                    lbl1.Visible = true;
                                                                    lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                                    lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                                }
                                                                else
                                                                {
                                                                    if (mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                    {
                                                                        lbl1.Visible = true;
                                                                        lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                                        lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsPlaying)
                                                                        {
                                                                            lbl1.Visible = true;
                                                                            lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                                                                            lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
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
                    List<MediaPlayerList> arquivos3 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos4 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos5 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos6 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos7 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos8 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos9 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos10 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos11 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos12 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos13 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos14 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos15 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos16 = new List<MediaPlayerList>();

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

                        //tela 3
                        if (int.Parse(conteudo[3]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[3]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[3] + "_"))
                                {
                                    arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[3]))
                                {
                                    arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[3]))
                            {
                                arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 4
                        if (int.Parse(conteudo[4]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[4]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[4] + "_"))
                                {
                                    arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[4]))
                                {
                                    arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[4]))
                            {
                                arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 5
                        if (int.Parse(conteudo[5]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[5]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[5] + "_"))
                                {
                                    arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[5]))
                                {
                                    arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[5]))
                            {
                                arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 6
                        if (int.Parse(conteudo[6]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[6]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[6] + "_"))
                                {
                                    arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[6]))
                                {
                                    arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[6]))
                            {
                                arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 7
                        if (int.Parse(conteudo[7]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[7]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[7] + "_"))
                                {
                                    arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[7]))
                                {
                                    arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[7]))
                            {
                                arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 8
                        if (int.Parse(conteudo[8]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[8]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[8] + "_"))
                                {
                                    arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[8]))
                                {
                                    arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[8]))
                            {
                                arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 9
                        if (int.Parse(conteudo[9]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[9]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[9] + "_"))
                                {
                                    arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[9]))
                                {
                                    arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[9]))
                            {
                                arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 10
                        if (int.Parse(conteudo[10]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[10]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[10] + "_"))
                                {
                                    arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[10]))
                                {
                                    arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[10]))
                            {
                                arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 11
                        if (int.Parse(conteudo[11]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[11]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[11] + "_"))
                                {
                                    arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[11]))
                                {
                                    arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[11]))
                            {
                                arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 12
                        if (int.Parse(conteudo[12]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[12]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[12] + "_"))
                                {
                                    arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[12]))
                                {
                                    arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[12]))
                            {
                                arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 13
                        if (int.Parse(conteudo[13]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[13]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[13] + "_"))
                                {
                                    arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[13]))
                                {
                                    arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[13]))
                            {
                                arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 14
                        if (int.Parse(conteudo[14]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[14]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[14] + "_"))
                                {
                                    arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[14]))
                                {
                                    arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[14]))
                            {
                                arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 15
                        if (int.Parse(conteudo[15]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[15]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[15] + "_"))
                                {
                                    arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[15]))
                                {
                                    arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[15]))
                            {
                                arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                            }
                        }

                        //tela 16
                        if (int.Parse(conteudo[16]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[16]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[16] + "_"))
                                {
                                    arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo[16]))
                                {
                                    arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[16]))
                            {
                                arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
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

                    listBox3.DataSource = arquivos3;
                    listBox3.ValueMember = "Path";
                    listBox3.DisplayMember = "FileName";

                    listBox4.DataSource = arquivos4;
                    listBox4.ValueMember = "Path";
                    listBox4.DisplayMember = "FileName";

                    listBox5.DataSource = arquivos5;
                    listBox5.ValueMember = "Path";
                    listBox5.DisplayMember = "FileName";

                    listBox6.DataSource = arquivos6;
                    listBox6.ValueMember = "Path";
                    listBox6.DisplayMember = "FileName";

                    listBox7.DataSource = arquivos7;
                    listBox7.ValueMember = "Path";
                    listBox7.DisplayMember = "FileName";

                    listBox8.DataSource = arquivos8;
                    listBox8.ValueMember = "Path";
                    listBox8.DisplayMember = "FileName";

                    listBox9.DataSource = arquivos9;
                    listBox9.ValueMember = "Path";
                    listBox9.DisplayMember = "FileName";

                    listBox10.DataSource = arquivos10;
                    listBox10.ValueMember = "Path";
                    listBox10.DisplayMember = "FileName";

                    listBox11.DataSource = arquivos11;
                    listBox11.ValueMember = "Path";
                    listBox11.DisplayMember = "FileName";

                    listBox12.DataSource = arquivos12;
                    listBox12.ValueMember = "Path";
                    listBox12.DisplayMember = "FileName";

                    listBox13.DataSource = arquivos13;
                    listBox13.ValueMember = "Path";
                    listBox13.DisplayMember = "FileName";

                    listBox14.DataSource = arquivos14;
                    listBox14.ValueMember = "Path";
                    listBox14.DisplayMember = "FileName";

                    listBox15.DataSource = arquivos15;
                    listBox15.ValueMember = "Path";
                    listBox15.DisplayMember = "FileName";

                    listBox16.DataSource = arquivos16;
                    listBox16.ValueMember = "Path";
                    listBox16.DisplayMember = "FileName";
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
                    List<MediaPlayerList> arquivos3 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos4 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos5 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos6 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos7 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos8 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos9 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos10 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos11 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos12 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos13 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos14 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos15 = new List<MediaPlayerList>();
                    List<MediaPlayerList> arquivos16 = new List<MediaPlayerList>();

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

                        //tela 3
                        if (int.Parse(conteudo[3]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[3]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[3] + "_"))
                                {
                                    arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[3]))
                                {
                                    arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[3]))
                            {
                                arquivos3.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 4
                        if (int.Parse(conteudo[4]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[4]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[4] + "_"))
                                {
                                    arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[4]))
                                {
                                    arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[4]))
                            {
                                arquivos4.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 5
                        if (int.Parse(conteudo[5]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[5]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[5] + "_"))
                                {
                                    arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[5]))
                                {
                                    arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[5]))
                            {
                                arquivos5.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 6
                        if (int.Parse(conteudo[6]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[6]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[6] + "_"))
                                {
                                    arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[6]))
                                {
                                    arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[6]))
                            {
                                arquivos6.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 7
                        if (int.Parse(conteudo[7]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[7]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[7] + "_"))
                                {
                                    arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[7]))
                                {
                                    arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[7]))
                            {
                                arquivos7.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 8
                        if (int.Parse(conteudo[8]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[8]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[8] + "_"))
                                {
                                    arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[8]))
                                {
                                    arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[8]))
                            {
                                arquivos8.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 9
                        if (int.Parse(conteudo[9]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[9]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[9] + "_"))
                                {
                                    arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[9]))
                                {
                                    arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[9]))
                            {
                                arquivos9.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 10
                        if (int.Parse(conteudo[10]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[10]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[10] + "_"))
                                {
                                    arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[10]))
                                {
                                    arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[10]))
                            {
                                arquivos10.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 11
                        if (int.Parse(conteudo[11]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[11]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[11] + "_"))
                                {
                                    arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[11]))
                                {
                                    arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[11]))
                            {
                                arquivos11.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 12
                        if (int.Parse(conteudo[12]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[12]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[12] + "_"))
                                {
                                    arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[12]))
                                {
                                    arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[12]))
                            {
                                arquivos12.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 13
                        if (int.Parse(conteudo[13]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[13]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[13] + "_"))
                                {
                                    arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[13]))
                                {
                                    arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[13]))
                            {
                                arquivos13.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 14
                        if (int.Parse(conteudo[14]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[6]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[14] + "_"))
                                {
                                    arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[14]))
                                {
                                    arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[14]))
                            {
                                arquivos14.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 15
                        if (int.Parse(conteudo[15]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[7]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[15] + "_"))
                                {
                                    arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[15]))
                                {
                                    arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[15]))
                            {
                                arquivos15.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
                            }
                        }

                        //tela 16
                        if (int.Parse(conteudo[16]) < 10)
                        {
                            //função de igual 1 
                            if (int.Parse(conteudo[8]) == 1)
                            {
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[16] + "_"))
                                {
                                    arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                            else
                            {
                                //função de 1 digito
                                if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals(conteudo[16]))
                                {
                                    arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(23, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(25, 2), Path = fi.FullName });
                                }
                            }
                        }
                        else
                        {
                            //função de 2 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 2).Equals(conteudo[16]))
                            {
                                arquivos16.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(6, 4) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(26, 2), Path = fi.FullName });
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

                    listBox3.DataSource = arquivos3;
                    listBox3.ValueMember = "Path";
                    listBox3.DisplayMember = "FileName";

                    listBox4.DataSource = arquivos4;
                    listBox4.ValueMember = "Path";
                    listBox4.DisplayMember = "FileName";

                    listBox5.DataSource = arquivos5;
                    listBox5.ValueMember = "Path";
                    listBox5.DisplayMember = "FileName";

                    listBox6.DataSource = arquivos6;
                    listBox6.ValueMember = "Path";
                    listBox6.DisplayMember = "FileName";

                    listBox7.DataSource = arquivos7;
                    listBox7.ValueMember = "Path";
                    listBox7.DisplayMember = "FileName";

                    listBox8.DataSource = arquivos8;
                    listBox8.ValueMember = "Path";
                    listBox8.DisplayMember = "FileName";

                    listBox9.DataSource = arquivos9;
                    listBox9.ValueMember = "Path";
                    listBox9.DisplayMember = "FileName";

                    listBox10.DataSource = arquivos10;
                    listBox10.ValueMember = "Path";
                    listBox10.DisplayMember = "FileName";

                    listBox11.DataSource = arquivos11;
                    listBox11.ValueMember = "Path";
                    listBox11.DisplayMember = "FileName";

                    listBox12.DataSource = arquivos12;
                    listBox12.ValueMember = "Path";
                    listBox12.DisplayMember = "FileName";

                    listBox13.DataSource = arquivos13;
                    listBox13.ValueMember = "Path";
                    listBox13.DisplayMember = "FileName";

                    listBox14.DataSource = arquivos14;
                    listBox14.ValueMember = "Path";
                    listBox14.DisplayMember = "FileName";

                    listBox15.DataSource = arquivos15;
                    listBox15.ValueMember = "Path";
                    listBox15.DisplayMember = "FileName";

                    listBox16.DataSource = arquivos16;
                    listBox16.ValueMember = "Path";
                    listBox16.DisplayMember = "FileName";
                }
            }
            catch
            {

            }
        }
       
        
     
        #endregion

        #region FullScreem
        private void MediaPlayer1_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer1.Size.Width == tamanhox)
            {
                mediaPlayer1.Size = new Size(1284, 620);
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer1.Ctlcontrols.currentPosition;
                mediaPlayer1.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer2_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer2.Size.Width == tamanhox)
            {
                mediaPlayer2.Size = new Size(1284, 620);
                mediaPlayer2.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer2.Ctlcontrols.currentPosition;
                mediaPlayer2.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer2.Location = new Point(322, 2);
                mediaPlayer1.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer3_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer3.Size.Width == tamanhox)
            {
                mediaPlayer3.Size = new Size(1284, 620);
                mediaPlayer3.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer3.Ctlcontrols.currentPosition;
                mediaPlayer3.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer3.Location = new Point(644, 2);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer4_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer4.Size.Width == tamanhox)
            {
                mediaPlayer4.Size = new Size(1284, 620);
                mediaPlayer4.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer4.Ctlcontrols.currentPosition;
                mediaPlayer4.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer4.Location = new Point(965, 2);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer5_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer5.Size.Width == tamanhox)
            {
                mediaPlayer5.Size = new Size(1284, 620);
                mediaPlayer5.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer5.Ctlcontrols.currentPosition;
                mediaPlayer5.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer5.Location = new Point(1, 155);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer6_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer6.Size.Width == tamanhox)
            {
                mediaPlayer6.Size = new Size(1284, 620);
                mediaPlayer6.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer6.Ctlcontrols.currentPosition;
                mediaPlayer6.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer6.Location = new Point(322, 155);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer7_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer7.Size.Width == tamanhox)
            {
                mediaPlayer7.Size = new Size(1284, 620);
                mediaPlayer7.Location = new Point(1, 2);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer7.Ctlcontrols.currentPosition;
                mediaPlayer7.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer7.Location = new Point(644, 155);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer8_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer8.Size.Width == tamanhox)
            {
                mediaPlayer8.Size = new Size(1284, 620);
                mediaPlayer8.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer8.Ctlcontrols.currentPosition;
                mediaPlayer8.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer8.Location = new Point(965, 155);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer9_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer9.Size.Width == tamanhox)
            {
                mediaPlayer9.Size = new Size(1284, 620);
                mediaPlayer9.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer9.Ctlcontrols.currentPosition;
                mediaPlayer9.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer9.Location = new Point(1, 309);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer9.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer10_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer10.Size.Width == tamanhox)
            {
                mediaPlayer10.Size = new Size(1284, 620);
                mediaPlayer10.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer10.Ctlcontrols.currentPosition;
                mediaPlayer10.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer10.Location = new Point(322, 309);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer10.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer11_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer11.Size.Width == tamanhox)
            {
                mediaPlayer11.Size = new Size(1284, 620);
                mediaPlayer11.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer11.Ctlcontrols.currentPosition;
                mediaPlayer11.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer11.Location = new Point(644, 309);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play12();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer11.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer12_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer12.Size.Width == tamanhox)
            {
                mediaPlayer12.Size = new Size(1284, 620);
                mediaPlayer12.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause13();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer12.Ctlcontrols.currentPosition;
                mediaPlayer12.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer12.Location = new Point(965, 309);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play13();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer12.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer13_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer13.Size.Width == tamanhox)
            {
                mediaPlayer13.Size = new Size(1284, 620);
                mediaPlayer13.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause14();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer13.Ctlcontrols.currentPosition;
                mediaPlayer13.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer13.Location = new Point(1, 463);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play14();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer13.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer14_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer14.Size.Width == tamanhox)
            {
                mediaPlayer14.Size = new Size(1284, 620);
                mediaPlayer14.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer15.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause15();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer14.Ctlcontrols.currentPosition;
                mediaPlayer14.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer14.Location = new Point(322, 463);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer15.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play15();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer14.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer15_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer15.Size.Width == tamanhox)
            {
                mediaPlayer15.Size = new Size(1284, 620);
                mediaPlayer15.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer16.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause16();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer15.Ctlcontrols.currentPosition;
                mediaPlayer15.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer15.Location = new Point(644, 463);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer16.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play16();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer16.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer15.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }
        private void MediaPlayer16_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer16.Size.Width == tamanhox)
            {
                mediaPlayer16.Size = new Size(1284, 620);
                mediaPlayer16.Location = new Point(1, 2);

                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                mediaPlayer9.Visible = false;
                mediaPlayer10.Visible = false;
                mediaPlayer11.Visible = false;
                mediaPlayer12.Visible = false;
                mediaPlayer13.Visible = false;
                mediaPlayer14.Visible = false;
                mediaPlayer15.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
                Pause9();
                Pause10();
                Pause11();
                Pause12();
                Pause13();
                Pause14();
                Pause15();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer16.Ctlcontrols.currentPosition;
                mediaPlayer16.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer16.Location = new Point(965, 463);

                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                mediaPlayer9.Visible = true;
                mediaPlayer10.Visible = true;
                mediaPlayer11.Visible = true;
                mediaPlayer12.Visible = true;
                mediaPlayer13.Visible = true;
                mediaPlayer14.Visible = true;
                mediaPlayer15.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                Play9();
                Play10();
                Play11();
                Play12();
                Play13();
                Play14();
                Play15();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer9.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer10.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer11.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer12.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer13.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer14.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer15.Ctlcontrols.currentPosition = tempoFullScreem;
                tempoFullScreem = 0;
                if (mediaPlayer16.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    Pause1();
                    Pause2();
                    Pause3();
                    Pause4();
                    Pause5();
                    Pause6();
                    Pause7();
                    Pause8();
                    Pause9();
                    Pause10();
                    Pause11();
                    Pause12();
                    Pause13();
                    Pause14();
                    Pause15();
                    Pause16();
                }
            }
        }



        #endregion

       
    }

}
