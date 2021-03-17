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
    public partial class FrmConfig : Form
    {
        int telas = 16;

        public FrmConfig()
        {
            InitializeComponent();
        }

        void Exibir16()
        {
            txt1.Enabled = true;
            txt1.Visible = true;

            txt2.Enabled = true;
            txt2.Visible = true;

            txt3.Enabled = true;
            txt3.Visible = true;

            txt4.Enabled = true;
            txt4.Visible = true;

            txt5.Enabled = true;
            txt5.Visible = true;

            txt6.Enabled = true;
            txt6.Visible = true;

            txt7.Enabled = true;
            txt7.Visible = true;

            txt8.Enabled = true;
            txt8.Visible = true;

            txt9.Enabled = true;
            txt9.Visible = true;

            txt10.Enabled = true;
            txt10.Visible = true;

            txt11.Enabled = true;
            txt11.Visible = true;

            txt12.Enabled = true;
            txt12.Visible = true;

            txt13.Enabled = true;
            txt13.Visible = true;

            txt14.Enabled = true;
            txt14.Visible = true;

            txt15.Enabled = true;
            txt15.Visible = true;

            txt16.Enabled = true;
            txt16.Visible = true;

        }
        void Exibir8()
        {
            txt1.Enabled = true;
            txt1.Visible = true;

            txt2.Enabled = true;
            txt2.Visible = true;

            txt3.Enabled = true;
            txt3.Visible = true;

            txt4.Enabled = true;
            txt4.Visible = true;

            txt5.Enabled = true;
            txt5.Visible = true;

            txt6.Enabled = true;
            txt6.Visible = true;

            txt7.Enabled = true;
            txt7.Visible = true;

            txt8.Enabled = true;
            txt8.Visible = true;

            txt9.Enabled = false;
            txt9.Visible = false;

            txt10.Enabled = false;
            txt10.Visible = false;

            txt11.Enabled = false;
            txt11.Visible = false;

            txt12.Enabled = false;
            txt12.Visible = false;

            txt13.Enabled = false;
            txt13.Visible = false;

            txt14.Enabled = false;
            txt14.Visible = false;

            txt15.Enabled = false;
            txt15.Visible = false;

            txt16.Enabled = false;
            txt16.Visible = false;
        }
        void Exibir4()
        {
            txt1.Enabled = true;
            txt1.Visible = true;

            txt2.Enabled = true;
            txt2.Visible = true;

            txt3.Enabled = true;
            txt3.Visible = true;

            txt4.Enabled = true;
            txt4.Visible = true;

            txt5.Enabled = false;
            txt5.Visible = false;

            txt6.Enabled = false;
            txt6.Visible = false;

            txt7.Enabled = false;
            txt7.Visible = false;

            txt8.Enabled = false;
            txt8.Visible = false;

            txt9.Enabled = false;
            txt9.Visible = false;

            txt10.Enabled = false;
            txt10.Visible = false;

            txt11.Enabled = false;
            txt11.Visible = false;

            txt12.Enabled = false;
            txt12.Visible = false;

            txt13.Enabled = false;
            txt13.Visible = false;

            txt14.Enabled = false;
            txt14.Visible = false;

            txt15.Enabled = false;
            txt15.Visible = false;

            txt16.Enabled = false;
            txt16.Visible = false;
        }
        void Exibir2()
        {
            txt1.Enabled = true;
            txt1.Visible = true;

            txt2.Enabled = true;
            txt2.Visible = true;

            txt3.Enabled = false;
            txt3.Visible = false;

            txt4.Enabled = false;
            txt4.Visible = false;

            txt5.Enabled = false;
            txt5.Visible = false;

            txt6.Enabled = false;
            txt6.Visible = false;

            txt7.Enabled = false;
            txt7.Visible = false;

            txt8.Enabled = false;
            txt8.Visible = false;

            txt9.Enabled = false;
            txt9.Visible = false;

            txt10.Enabled = false;
            txt10.Visible = false;

            txt11.Enabled = false;
            txt11.Visible = false;

            txt12.Enabled = false;
            txt12.Visible = false;

            txt13.Enabled = false;
            txt13.Visible = false;

            txt14.Enabled = false;
            txt14.Visible = false;

            txt15.Enabled = false;
            txt15.Visible = false;

            txt16.Enabled = false;
            txt16.Visible = false;
        }
        void Exibir1()
        {
            txt1.Enabled = true;
            txt1.Visible = true;

            txt2.Enabled = false;
            txt2.Visible = false;

            txt3.Enabled = false;
            txt3.Visible = false;

            txt4.Enabled = false;
            txt4.Visible = false;

            txt5.Enabled = false;
            txt5.Visible = false;

            txt6.Enabled = false;
            txt6.Visible = false;

            txt7.Enabled = false;
            txt7.Visible = false;

            txt8.Enabled = false;
            txt8.Visible = false;

            txt9.Enabled = false;
            txt9.Visible = false;

            txt10.Enabled = false;
            txt10.Visible = false;

            txt11.Enabled = false;
            txt11.Visible = false;

            txt12.Enabled = false;
            txt12.Visible = false;

            txt13.Enabled = false;
            txt13.Visible = false;

            txt14.Enabled = false;
            txt14.Visible = false;

            txt15.Enabled = false;
            txt15.Visible = false;

            txt16.Enabled = false;
            txt16.Visible = false;
        }





        //16 telas
        void Limpar16()
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txt6.Text = string.Empty;
            txt7.Text = string.Empty;
            txt8.Text = string.Empty;
            txt9.Text = string.Empty;
            txt10.Text = string.Empty;
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;
            txt13.Text = string.Empty;
            txt14.Text = string.Empty;
            txt15.Text = string.Empty;
            txt16.Text = string.Empty;
        }
        void Apagar16()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                File.Delete(path);
            }
            catch
            {

            }
        }
        void CriarPerfil16()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(txt1.Text);
                streamWriter.WriteLine(txt2.Text);
                streamWriter.WriteLine(txt3.Text);
                streamWriter.WriteLine(txt4.Text);
                streamWriter.WriteLine(txt5.Text);
                streamWriter.WriteLine(txt6.Text);
                streamWriter.WriteLine(txt7.Text);
                streamWriter.WriteLine(txt8.Text);
                streamWriter.WriteLine(txt9.Text);
                streamWriter.WriteLine(txt10.Text);
                streamWriter.WriteLine(txt11.Text);
                streamWriter.WriteLine(txt12.Text);
                streamWriter.WriteLine(txt13.Text);
                streamWriter.WriteLine(txt14.Text);
                streamWriter.WriteLine(txt15.Text);
                streamWriter.WriteLine(txt16.Text);

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void Reset16()
        {

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(1);
                streamWriter.WriteLine(2);
                streamWriter.WriteLine(3);
                streamWriter.WriteLine(4);
                streamWriter.WriteLine(5);
                streamWriter.WriteLine(6);
                streamWriter.WriteLine(7);
                streamWriter.WriteLine(8);
                streamWriter.WriteLine(9);
                streamWriter.WriteLine(10);
                streamWriter.WriteLine(11);
                streamWriter.WriteLine(12);
                streamWriter.WriteLine(13);
                streamWriter.WriteLine(14);
                streamWriter.WriteLine(15);
                streamWriter.WriteLine(16);

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void ExibirForm16()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\16.txt";
            string[] conteudo = File.ReadAllLines(path);

            txt1.Text = conteudo[1];
            txt2.Text = conteudo[2];
            txt3.Text = conteudo[3];
            txt4.Text = conteudo[4];
            txt5.Text = conteudo[5];
            txt6.Text = conteudo[6];
            txt7.Text = conteudo[7];
            txt8.Text = conteudo[8];
            txt9.Text = conteudo[9];
            txt10.Text = conteudo[10];
            txt11.Text = conteudo[11];
            txt12.Text = conteudo[12];
            txt13.Text = conteudo[13];
            txt14.Text = conteudo[14];
            txt15.Text = conteudo[15];
            txt16.Text = conteudo[16];

        }
        bool liberadoSalvar16()
        {
            try
            {
                int a = 0;
                int count = 0;

                a = int.Parse(txt1.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt2.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt3.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt4.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt5.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt6.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt7.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt8.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt9.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt10.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt11.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt12.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt13.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt14.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt15.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt16.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                if (count == 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }


        }


        //8 telas
        void Limpar8()
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txt6.Text = string.Empty;
            txt7.Text = string.Empty;
            txt8.Text = string.Empty;
          
        }
        void Apagar8()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
                File.Delete(path);
            }
            catch
            {

            }
        }
        void CriarPerfil8()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(txt1.Text);
                streamWriter.WriteLine(txt2.Text);
                streamWriter.WriteLine(txt3.Text);
                streamWriter.WriteLine(txt4.Text);
                streamWriter.WriteLine(txt5.Text);
                streamWriter.WriteLine(txt6.Text);
                streamWriter.WriteLine(txt7.Text);
                streamWriter.WriteLine(txt8.Text);
              

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void Reset8()
        {

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(1);
                streamWriter.WriteLine(2);
                streamWriter.WriteLine(3);
                streamWriter.WriteLine(4);
                streamWriter.WriteLine(5);
                streamWriter.WriteLine(6);
                streamWriter.WriteLine(7);
                streamWriter.WriteLine(8);
              
                streamWriter.Close();
            }
            catch
            {

            }
        }
        void ExibirForm8()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\8.txt";
            string[] conteudo = File.ReadAllLines(path);

            txt1.Text = conteudo[1];
            txt2.Text = conteudo[2];
            txt3.Text = conteudo[3];
            txt4.Text = conteudo[4];
            txt5.Text = conteudo[5];
            txt6.Text = conteudo[6];
            txt7.Text = conteudo[7];
            txt8.Text = conteudo[8];
           

        }
        bool liberadoSalvar8()
        {
            try
            {
                int a = 0;
                int count = 0;

                a = int.Parse(txt1.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt2.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt3.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt4.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt5.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt6.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt7.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt8.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
               
                if (count == 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }


        }


        //4 telas
        void Limpar4()
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txt4.Text = string.Empty;
          
        }
        void Apagar4()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\4.txt";
                File.Delete(path);
            }
            catch
            {

            }
        }
        void CriarPerfil4()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\4.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(txt1.Text);
                streamWriter.WriteLine(txt2.Text);
                streamWriter.WriteLine(txt3.Text);
                streamWriter.WriteLine(txt4.Text);
               
                streamWriter.Close();
            }
            catch
            {

            }
        }
        void Reset4()
        {

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\4.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(1);
                streamWriter.WriteLine(2);
                streamWriter.WriteLine(3);
                streamWriter.WriteLine(4);
               

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void ExibirForm4()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\4.txt";
            string[] conteudo = File.ReadAllLines(path);

            txt1.Text = conteudo[1];
            txt2.Text = conteudo[2];
            txt3.Text = conteudo[3];
            txt4.Text = conteudo[4];
           

        }
        bool liberadoSalvar4()
        {
            try
            {
                int a = 0;
                int count = 0;

                a = int.Parse(txt1.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt2.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt3.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt4.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
              
                if (count == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }


        }



        //2 telas
        void Limpar2()
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
           
        }
        void Apagar2()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                File.Delete(path);
            }
            catch
            {

            }
        }
        void CriarPerfil2()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(txt1.Text);
                streamWriter.WriteLine(txt2.Text);
               

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void Reset2()
        {

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(1);
                streamWriter.WriteLine(2);
               

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void ExibirForm2()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\2.txt";
            string[] conteudo = File.ReadAllLines(path);

            txt1.Text = conteudo[1];
            txt2.Text = conteudo[2];
           

        }
        bool liberadoSalvar2()
        {
            try
            {
                int a = 0;
                int count = 0;

                a = int.Parse(txt1.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
                a = int.Parse(txt2.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
              
                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }


        }



        //1 tela
        void Limpar1()
        {
            txt1.Text = string.Empty;
           
        }
        void Apagar1()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\1.txt";
                File.Delete(path);
            }
            catch
            {

            }
        }
        void CriarPerfil1()
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\1.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(txt1.Text);
               

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void Reset1()
        {

            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\1.txt";
                StreamWriter streamWriter = File.CreateText(path);
                streamWriter.WriteLine();

                streamWriter.WriteLine(1);
               

                streamWriter.Close();
            }
            catch
            {

            }
        }
        void ExibirForm1()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\1.txt";
            string[] conteudo = File.ReadAllLines(path);

            txt1.Text = conteudo[1];
           

        }
        bool liberadoSalvar1()
        {
            try
            {
                int a = 0;
                int count = 0;

                a = int.Parse(txt1.Text.Trim());
                if (a > 0 && a < 17)
                {
                    count++;
                }
              
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }


        }



        private void rb16_CheckedChanged(object sender, EventArgs e)
        {
            if (rb16.Checked)
            {
                telas = 16;
                Exibir16();
                try
                {
                    ExibirForm16();
                }
                catch
                {
                    Apagar16();
                    Reset16();
                    ExibirForm16();

                }
            }
        }
        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rb8.Checked)
            {
                telas = 8;
                Exibir8();
                try
                {
                    ExibirForm8();
                }
                catch
                {
                    Apagar8();
                    Reset8();
                    ExibirForm8();

                }
            }
        }
        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked)
            {
                telas = 4;
                Exibir4();
                try
                {
                    ExibirForm4();
                }
                catch
                {
                    Apagar4();
                    Reset4();
                    ExibirForm4();

                }
            }
        }
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                telas = 2;
                Exibir2();
                if (telas == 2)
                {
                    try
                    {
                        ExibirForm2();
                    }
                    catch
                    {
                        Apagar2();
                        Reset2();
                        ExibirForm2();

                    }
                }
            }
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                telas = 1;
                Exibir1();
                try
                {
                    ExibirForm1();
                }
                catch
                {
                    Apagar1();
                    Reset1();
                    ExibirForm1();

                }
            }
        }







        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (telas==16)
            {
                if (liberadoSalvar16())
                {
                    Apagar16();
                    CriarPerfil16();
                }
                else
                {
                    MessageBox.Show("Valores Permitidos: 1-16","Erro");
                }
            }
            if (telas == 8)
            {
                if (liberadoSalvar8())
                {
                    Apagar8();
                    CriarPerfil8();
                }
                else
                {
                    MessageBox.Show("Valores Permitidos: 1-16", "Erro");
                }
            }
            if (telas == 4)
            {
                if (liberadoSalvar4())
                {
                    Apagar4();
                    CriarPerfil4();
                }
                else
                {
                    MessageBox.Show("Valores Permitidos: 1-16", "Erro");
                }
            }
            if (telas == 2)
            {
                if (liberadoSalvar2())
                {
                    Apagar2();
                    CriarPerfil2();
                }
                else
                {
                    MessageBox.Show("Valores Permitidos: 1-16", "Erro");
                }
            }
            if (telas == 1)
            {
                if (liberadoSalvar1())
                {
                    Apagar1();
                    CriarPerfil1();
                }
                else
                {
                    MessageBox.Show("Valores Permitidos: 1-16", "Erro");
                }
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (telas == 16)
            {
                try
                {
                    ExibirForm16();
                }
                catch
                {
                    Apagar16();
                    Reset16();
                    ExibirForm16();

                }
            }
            if (telas == 8)
            {
                try
                {
                    ExibirForm8();
                }
                catch
                {
                    Apagar8();
                    Reset8();
                    ExibirForm8();

                }
            }
            if (telas == 4)
            {
                try
                {
                    ExibirForm4();
                }
                catch
                {
                    Apagar4();
                    Reset4();
                    ExibirForm4();

                }
            }
            if (telas == 2)
            {
                try
                {
                    ExibirForm2();
                }
                catch
                {
                    Apagar2();
                    Reset2();
                    ExibirForm2();

                }
            }
            if (telas == 1)
            {
                try
                {
                    ExibirForm1();
                }
                catch
                {
                    Apagar1();
                    Reset1();
                    ExibirForm1();

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (telas == 16)
            {
                Limpar16();
            }
            if (telas == 8)
            {
                Limpar8();
            }
            if (telas == 4)
            {
                Limpar4();
            }
            if (telas == 2)
            {
                Limpar2();
            }
            if (telas == 1)
            {
                Limpar1();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (telas == 16)
            {
                Apagar16();
                Reset16();
                ExibirForm16();
            }
            if (telas == 8)
            {
                Apagar8();
                Reset8();
                ExibirForm8();
            }
            if (telas == 4)
            {
                Apagar4();
                Reset4();
                ExibirForm4();
            }
            if (telas == 2)
            {
                Apagar2();
                Reset2();
                ExibirForm2();
            }
            if (telas == 1)
            {
                Apagar1();
                Reset1();
                ExibirForm1();
            }
        }











        private void FrmConfig_Load(object sender, EventArgs e)
        {
            //1
            try
            {
                ExibirForm1();
            }
            catch
            {
                Apagar1();
                Reset1();
                ExibirForm1();

            }
            //2
            try
            {
                ExibirForm2();
            }
            catch
            {
                Apagar2();
                Reset2();
                ExibirForm2();

            }
            //4
            try
            {
                ExibirForm4();
            }
            catch
            {
                Apagar4();
                Reset4();
                ExibirForm4();

            }
            //8
            try
            {
                ExibirForm8();
            }
            catch
            {
                Apagar8();
                Reset8();
                ExibirForm8();

            }
            //16
            try
            {
                ExibirForm16();
            }
            catch
            {
                Apagar16();
                Reset16();
                ExibirForm16();

            }
        }

    }
}
