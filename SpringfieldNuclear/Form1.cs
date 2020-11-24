using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Reactor1StateLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            outputLabel.Text = "WE ARE ALL GOING TO DIE!!!";

            reactor2StateLabel.BackColor = Color.Red; 
            reactor1StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);
           

            reactor2StateLabel.BackColor = Color.White;
            reactor1StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Red;
            reactor1StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.White;
            reactor1StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(500);
          
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
