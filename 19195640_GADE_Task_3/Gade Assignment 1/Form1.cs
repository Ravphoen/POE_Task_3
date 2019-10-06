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
using System.Runtime.Serialization.Formatters.Binary;

namespace Gade_Assignment_1
{
    public partial class BattleForm : Form
    {
        public int mapsize;
        public int numberofunits;
        public int numberofbuildings;
        public BattleForm()
        {
            InitializeComponent();
        }
        Map map = new Map();
        GameEngine gameengine = new GameEngine();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MapTextBox.Text = gameengine.Updatedisplay();//updating map
            lblRound.Text = "Round:"+gameengine.RoundsCompleted.ToString();//changing round text
            lblResources.Text = "Resources:"+gameengine.Resources.ToString();//Displaying resources
            textDisplayBox.Text = gameengine.Updateunit();//unit info
            textDisplayBox.Text = gameengine.Updatebuilding();//building info
            gameengine.startround();//calling start round method
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = true;

                        
            if (cb10.Checked)
            {
                mapsize = 10;
                numberofunits = 6;
                numberofbuildings = 3;
                
            }
            if (cb15.Checked)
            {
                mapsize = 15;
                numberofunits = 8;
                numberofbuildings = 6;
               
            }
            if (cb20.Checked)
            {
                mapsize = 20;
                numberofunits = 10;
                numberofbuildings = 9;
                
            }
            else
            {
                mapsize = 10;
                MessageBox.Show("An error occured. A 10x10 map has been set as default.");
                
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("MapInfo.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            
            try
            {
                using (FS)
                {
                    BF.Serialize(FS, map);
                    MessageBox.Show("File Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
          
        }

        private void MapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRound_Click(object sender, EventArgs e)
        {

        }

       
    }
}
