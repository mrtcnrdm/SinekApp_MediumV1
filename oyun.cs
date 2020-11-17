using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinekApp
{
    public partial class oyun : Form
    {
        public oyun()
        {
            InitializeComponent();
        }
        Random rdm = new Random();
        static int butontutamac = 1;
        static Button[] buttonArray = new Button[100];
        static SoundPlayer sesefekti = new SoundPlayer();
        static int sayac = 0;
        static int butonsil = 0;
        static int toplam;
        static int sure = 3;
        private void oyun_Load(object sender, EventArgs e)
        {
            SesEfekti();
            timer1.Start();
            timer2.Start();            
        }
        void SesEfekti()
        {
            DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory());         
            sesefekti = new SoundPlayer();
            string info2 = info.Parent.Parent.FullName + "\\sounds\\sineksesi.wav";
            sesefekti.SoundLocation = info2;            
            sesefekti.PlayLooping();
        }
       
        void ButonUret()
        {
            sayac++;
            buttonArray[butontutamac] = new Button();
            buttonArray[butontutamac].Size = new Size(100, 100);
            buttonArray[butontutamac].Location = new Point(rdm.Next(1, this.ClientSize.Width - panel1.Width - buttonArray[butontutamac].Width),
                rdm.Next(1, this.ClientSize.Height - buttonArray[butontutamac].Height));
            buttonArray[butontutamac].Text = rdm.Next(1, 10).ToString();
            buttonArray[butontutamac].BackColor = Color.Transparent;
            buttonArray[butontutamac].FlatStyle = FlatStyle.Flat;
            buttonArray[butontutamac].FlatAppearance.BorderSize = 0;
            buttonArray[butontutamac].FlatAppearance.BorderColor = TransparencyKey;
            buttonArray[butontutamac].FlatAppearance.MouseDownBackColor = Color.Red;
            buttonArray[butontutamac].FlatAppearance.MouseOverBackColor = Color.Blue;
            buttonArray[butontutamac].BackgroundImage = imageList1.Images[0];
            buttonArray[butontutamac].BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(buttonArray[butontutamac]);
            buttonArray[butontutamac].Click += new EventHandler(this.btnClick);
            butontutamac++;
            if (sayac % 3 == 0)
            {
                try
                {
                    butonsil++;
                    this.Controls.Remove(buttonArray[butonsil]);
                    if (buttonArray[butonsil].IsDisposed == true)
                    {
                        butonsil += 3;
                        if (butonsil == 90)
                        {
                            butonsil -= 3;
                            this.Controls.Remove(buttonArray[butonsil]);
                        }
                        else
                        {
                            this.Controls.Remove(buttonArray[butonsil]);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    butonsil += 7;
                    this.Controls.Remove(buttonArray[butonsil]);
                    butonsil += 7;
                    if (butonsil == 90)
                    {
                        butonsil -= 3;
                        this.Controls.Remove(buttonArray[butonsil]);
                    }
                    else
                    {
                        this.Controls.Remove(buttonArray[butonsil]);
                    }
                }
            }
        }        
        private void btnClick(object sender, EventArgs e)
        {
            buttonArray[butontutamac] = (Button)sender;
            buttonArray[butontutamac].Dispose();
            string hafiza = buttonArray[butontutamac].Text;
            toplam += int.Parse(hafiza);
            label_skoryazdir.Text = toplam.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ButonUret();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            sure--;
            label_sure.Text = sure.ToString() + " saniye";
            if (sure == 0)
            {
                OyunuBitir();
            }
        }
        void OyunuBitir()
        {
            sesefekti.Stop();
            timer1.Stop();
            timer2.Stop();            
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show($"Oyun Bitti! \nSkorunuz: {label_skoryazdir.Text} Puan\n" +
                "Yeniden Oynamak İster Misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Oyun Kapatılıyor!", "Shotdown");
                Application.Exit();
            }
        }
    }
}
