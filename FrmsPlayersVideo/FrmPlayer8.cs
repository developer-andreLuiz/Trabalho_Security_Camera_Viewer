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
    public partial class FrmPlayer8 : Form
    {
        int tamanhox = 315;
        int tamanhoy = 320;
        int hora = 3600;
        int meiaHora = 1800;
        string[] conteudo;
        int valor1;
        int realTime1 = 1;
        string tipoCamera = null;
        double tempoFullScreem = 0;
        bool full = false;

        public FrmPlayer8()
        {
            InitializeComponent();
            gp.Enabled = false;
        }
        private void FrmPlayer8_Load(object sender, EventArgs e)
        {
            EnterForm();
        }

        #region Form Events
        //ok
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
            }
            catch
            {

            }

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
                conteudo = File.ReadAllLines(path);
            }
            catch
            {
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
                    File.Delete(path);
                }
                catch
                {

                }
                try
                {
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
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
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
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
        #endregion

        #region btns
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            if (full == false)
            {
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
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
                        mediaPlayer3.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer4.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer5.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer6.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer7.Ctlcontrols.currentPosition += 0.2f;
                        mediaPlayer8.Ctlcontrols.currentPosition += 0.2f;
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
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }





                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsStopped && mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    realTime1 = 1;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;

                }
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer2.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer3.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer4.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer5.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer6.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer7.playState == WMPLib.WMPPlayState.wmppsUndefined && mediaPlayer8.playState == WMPLib.WMPPlayState.wmppsUndefined)
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
                if (!mediaPlayer3.fullScreen)
                {
                    mediaPlayer3.uiMode = "none";
                }
                if (!mediaPlayer4.fullScreen)
                {
                    mediaPlayer4.uiMode = "none";
                }
                if (!mediaPlayer5.fullScreen)
                {
                    mediaPlayer5.uiMode = "none";
                }
                if (!mediaPlayer6.fullScreen)
                {
                    mediaPlayer6.uiMode = "none";
                }
                if (!mediaPlayer7.fullScreen)
                {
                    mediaPlayer7.uiMode = "none";
                }
                if (!mediaPlayer8.fullScreen)
                {
                    mediaPlayer8.uiMode = "none";
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
                mediaPlayer1.Size = new Size(1275, 648);
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();

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
                gp.Enabled = false;
                full = false;
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer2_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer2.Size.Width == tamanhox)
            {
                mediaPlayer2.Size = new Size(1275, 648);
                mediaPlayer2.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer2.Ctlcontrols.currentPosition;
                mediaPlayer2.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer2.Location = new Point(327, 3);
                mediaPlayer1.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer3_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer3.Size.Width == tamanhox)
            {
                mediaPlayer3.Size = new Size(1275, 648);
                mediaPlayer3.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer3.Ctlcontrols.currentPosition;
                mediaPlayer3.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer3.Location = new Point(645, 3);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play4();
                Play5();
                Play6();
                Play7();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer4_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer4.Size.Width == tamanhox)
            {
                mediaPlayer4.Size = new Size(1275, 648);
                mediaPlayer4.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause5();
                Pause6();
                Pause7();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer4.Ctlcontrols.currentPosition;
                mediaPlayer4.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer4.Location = new Point(966, 3);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play5();
                Play6();
                Play7();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer5_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer5.Size.Width == tamanhox)
            {
                mediaPlayer5.Size = new Size(1275, 648);
                mediaPlayer5.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause6();
                Pause7();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer5.Ctlcontrols.currentPosition;
                mediaPlayer5.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer5.Location = new Point(7, 326);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play6();
                Play7();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer6_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer6.Size.Width == tamanhox)
            {
                mediaPlayer6.Size = new Size(1275, 648);
                mediaPlayer6.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer7.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause7();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer6.Ctlcontrols.currentPosition;
                mediaPlayer6.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer6.Location = new Point(327, 326);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer7.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play7();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer7_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer7.Size.Width == tamanhox)
            {
                mediaPlayer7.Size = new Size(1275, 648);
                mediaPlayer7.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer8.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause8();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer7.Ctlcontrols.currentPosition;
                mediaPlayer7.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer7.Location = new Point(645, 326);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer8.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play8();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer8.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }
        private void MediaPlayer8_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            if (mediaPlayer8.Size.Width == tamanhox)
            {
                mediaPlayer8.Size = new Size(1275, 648);
                mediaPlayer8.Location = new Point(6, 3);
                mediaPlayer1.Visible = false;
                mediaPlayer2.Visible = false;
                mediaPlayer3.Visible = false;
                mediaPlayer4.Visible = false;
                mediaPlayer5.Visible = false;
                mediaPlayer6.Visible = false;
                mediaPlayer7.Visible = false;
                gp.Enabled = true;
                full = true;
                Pause1();
                Pause2();
                Pause3();
                Pause4();
                Pause5();
                Pause6();
                Pause7();
            }
            else
            {
                realTime1 = 1;
                tempoFullScreem = mediaPlayer8.Ctlcontrols.currentPosition;
                mediaPlayer8.Size = new Size(tamanhox, tamanhoy);
                mediaPlayer8.Location = new Point(966, 326);
                mediaPlayer1.Visible = true;
                mediaPlayer2.Visible = true;
                mediaPlayer3.Visible = true;
                mediaPlayer4.Visible = true;
                mediaPlayer5.Visible = true;
                mediaPlayer6.Visible = true;
                mediaPlayer7.Visible = true;
                gp.Enabled = false;
                full = false;
                Play1();
                Play2();
                Play3();
                Play4();
                Play5();
                Play6();
                Play7();
                mediaPlayer1.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer2.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer3.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer4.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer5.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer6.Ctlcontrols.currentPosition = tempoFullScreem;
                mediaPlayer7.Ctlcontrols.currentPosition = tempoFullScreem;
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
                }
            }
        }

        #endregion


    }
}
