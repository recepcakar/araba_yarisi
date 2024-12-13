using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace araba_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        int kazanlian_puan = 0;
        int yol_hizi = 5;
        int araba_hizi = 15; //benim araba hizi

        bool sol_yon=false;
        bool sag_yon = false;
        
        int diger_araba_hizi = 5;

        Random rdr=new Random();
        
         
   
        public void oyunubaslat()
        {
            
            sesac();
            btn_oyunubaslat.Enabled = false;
            carpma.Visible = false;

            // arabanın koordinatı kendi arabam

            lbl_yuksekskor.Text = Settings1.Default.yuksekskor; 

            bizimaraba.Left = 160;
            bizimaraba.Top = 300;

            araba1.Left = 30; // diğğer arabaların başlangıc koordinatşarı
            araba1.Top = 50;

            araba2.Left = 320;
            araba2.Top = 50;

            sol_yon = false;
            sag_yon = false;

            carpma.Left = 195;
            carpma.Top = 294;

            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanlian_puan ++;
            lbl_puan.Text = kazanlian_puan.ToString();
            if (kazanlian_puan == 1000)
            {
                araba3.Visible = true;
                araba3.Enabled = true;
             
            }
            if (kazanlian_puan == 2000)
            {


            }
            yol.Top += yol_hizi;
            if (yol.Top >= 400)
            {
                yol.Top = -100;
            }

            if (sol_yon )
            {
                bizimaraba.Left -= araba_hizi;
            }
            if (sag_yon)
            {
                bizimaraba.Left += araba_hizi;
            }
            if (bizimaraba.Left < 1) {  sol_yon = false;}
            else if(bizimaraba.Left + bizimaraba.Width > 510) {  sag_yon=false;}

            araba1.Top += diger_araba_hizi;
            araba2.Top += diger_araba_hizi;
            if (araba3.Enabled == true)
            {
                araba3.Top += diger_araba_hizi;
                if (araba3.Top > panel1.Height)
                {
                    araba3degistir();
                    araba3.Left = rdr.Next(160, 250);
                    araba3.Top = rdr.Next(150, 250) * -1;
                }
            }

            if (araba1.Top > panel1.Height) 
            {
                araba1degistir();
                araba1.Left= rdr.Next(20,50);
                araba1.Top= rdr.Next(40,140)*-1;
            }
            if (araba2.Top > panel1.Height)
            { if(araba3.Enabled)
                araba2degistir();
                araba2.Left = rdr.Next(90, 250 );
                araba2.Top = rdr.Next(40, 140) * -1;
            }
            if (bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds) || bizimaraba.Bounds.IntersectsWith(araba3.Bounds))
            {
                oyunbitti();
            }

          
        }
        private void araba1degistir()
        {
            int sıra=rdr.Next(1,8);
            switch (sıra) 
            {
                case 1: araba1.Image = Properties.Resources.araba2; break;
                case 2: araba1.Image = Properties.Resources.araba3; break;
                case 3: araba1.Image = Properties.Resources.araba4; break;
                case 4: araba1.Image = Properties.Resources.araba5; break;
                case 5: araba1.Image = Properties.Resources.araba6; break;
                case 6: araba1.Image = Properties.Resources.araba7; break;
                case 7: araba1.Image = Properties.Resources.araba8; break;

            }

        }
        private void araba2degistir()
        {
            int sıra = rdr.Next(1, 8);
            switch (sıra)
            {
                case 1: araba2.Image = Properties.Resources.araba2; break;
                case 2: araba2.Image = Properties.Resources.araba3; break;
                case 3: araba2.Image = Properties.Resources.araba4; break;
                case 4: araba2.Image = Properties.Resources.araba5; break;
                case 5: araba2.Image = Properties.Resources.araba6; break;
                case 6: araba2.Image = Properties.Resources.araba7; break;
                case 7: araba2.Image = Properties.Resources.araba8; break;

            }
        }
        private void araba3degistir()
        {

            {
                int sıra = rdr.Next(1, 8);
                switch (sıra)
                {
                    case 1: araba3.Image = Properties.Resources.araba2; break;
                    case 2: araba3.Image = Properties.Resources.araba3; break;
                    case 3: araba3.Image = Properties.Resources.araba4; break;
                    case 4: araba3.Image = Properties.Resources.araba5; break;
                    case 5: araba3.Image = Properties.Resources.araba6; break;
                    case 6: araba3.Image = Properties.Resources.araba7; break;
                    case 7: araba3.Image = Properties.Resources.araba8; break;

                }
            }
        }
        private void oyunbitti() 
        { 
            timer1.Stop();
            if (Convert.ToInt32(lbl_puan.Text) > Convert.ToInt32( Settings1.Default.yuksekskor))
            {
                Settings1.Default.yuksekskor = lbl_puan.Text;
                
            }
            btn_oyunubaslat.Enabled = true;
            carpma.Visible = true;
            bizimaraba.Controls.Add(carpma);
            carpma.Location = new Point(-10,-5);
           
            carpma.BringToFront();
            carpma.BackColor = Color.Transparent;
            seskapa();
            MessageBox.Show("KAZANALIAN PUAN : "+lbl_puan.Text,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btn_oyunubaslat.Enabled =true ;
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            araba3.Visible = false;
            araba3.Enabled = false;
            oyunubaslat();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && bizimaraba.Left > 0) { sol_yon = true; }
            if (e.KeyCode == Keys.Right && bizimaraba.Left + bizimaraba.Width < panel1.Width) { sag_yon = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { sol_yon = false; }
            if (e.KeyCode == Keys.Right) { sag_yon = false; }

        }

        private void btn_oyunubaslat_Click(object sender, EventArgs e)
        {
            oyunubaslat();
            
        }
        private void sesac()
        {
            SoundPlayer ses =new SoundPlayer();
            string sesyol = Application.StartupPath + "//Muzik.wav";
            ses.SoundLocation=sesyol;
            ses.Play(); 
        }
        private void seskapa()
        {
            SoundPlayer seskapa = new SoundPlayer();
            seskapa.Stop();
        }

      
    }
}
