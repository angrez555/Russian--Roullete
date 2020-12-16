using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;


namespace Russian_Roullete
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        gun gungame = new gun();
        Random random = new Random();

        private void Loadbt_Click(object sender, EventArgs e)
        {
            buttonspin.Enabled = true;
            Loadbt.Enabled = false;
            //  pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\Desktop\game\Res\load.gif");
            // below code helps to show the picbox
            Assembly myasses = Assembly.GetExecutingAssembly();
            Stream myst = myasses.GetManifestResourceStream("Russian_Roullete.Resources.load.gif");
            //Bitmap bmp = new Bitmap(mystream);
            //var bmp1 = new Bitmap(Russian_Roullete.properties.Resources.load);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.load;
            //Image.FormFile(Russian_Roulette.Resource.load);


            //pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\source\repos\Russian Roullete\Resources\load.gif");

        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            gungame.lodedgunspin = random.Next(1, 6);
           buttonshhot .Enabled = true;
            buttonspin .Enabled = false;
            //  pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\Desktop\game\Res\spin.gif");
            // below code helps to show the picbox
            Assembly myasses = Assembly.GetExecutingAssembly();
            Stream myst = myasses.GetManifestResourceStream("Russian_Roullete.Resources.spin.gif");
            //Bitmap bmp = new Bitmap(mystream);
            //var bmp1 = new Bitmap(Russian_Roullete.properties.Resources.spin);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.spin;
            //Image.FormFile(Russian_Roulette.Resource.spin);
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\source\repos\Russian Roullete\Russian Roullete\Resources\spin.gif");

        }

        private void buttonshhot_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Dell\source\repos\Russian Roullete\Russian Roullete\Resources\spin.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.shoot1);
            player.Play();


            //  pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\Desktop\game\Res\shoot.gif");
            // below code helps to show the picbox
            Assembly myasses = Assembly.GetExecutingAssembly();
            Stream myst = myasses.GetManifestResourceStream("Russian_Roullete.Resources.shoot.gif");
            //Bitmap bmp = new Bitmap(mystream);
            //var bmp1 = new Bitmap(Russian_Roullete.properties.Resources.shoot);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;
            //Image.FormFile(Russian_Roulette.Resource.shoot);
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\source\repos\Russian Roullete\Russian Roullete\Resources\shoot.gif");
            int shootaway = gungame.Shootbullete();
            if (shootaway == 1)
            {
                MessageBox.Show("you loose");
                buttonshhot .Enabled = false;
                Shootawaybt.Enabled = false;
                buttonspin .Enabled = false;
               Loadbt .Enabled = false;

            }
            if (shootaway == 2)
            {


                gungame.shotsremain = gungame.shotsremain - 1;
                gungame.lodedgunspin = gungame.bulletechange(gungame.lodedgunspin);
                MessageBox.Show("missed");
            }


        }

        private void Shootawaybt_Click(object sender, EventArgs e)
        {
          


            int winloss = gungame.Shootaway();
            if (winloss == 10)
            {

                MessageBox.Show("100 you win");
                buttonshhot.Enabled = false;
                Shootawaybt.Enabled = false;
                buttonspin.Enabled = false;
                Loadbt.Enabled = false;

            }
            if (winloss == 5)
            {
                MessageBox.Show("50 you win");
                buttonshhot.Enabled = false;
                Shootawaybt.Enabled = false;
                buttonspin.Enabled = false;
                Loadbt.Enabled = false;
            }
            if (winloss == 0)
            {

                MessageBox.Show("miss");
            }
            if (gungame.shotsremain == 0)
            {

                MessageBox.Show("no chances left");
                Shootawaybt.Enabled = false;


            }

        }

        private void playagain_Click(object sender, EventArgs e)
        {
            (new game()).Show();
            this.Hide();
        }
    }
}
