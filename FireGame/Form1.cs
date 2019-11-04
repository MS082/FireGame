using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame
{
    public partial class Form1 : Form
    {
        //global varaible to get the name of the player who want to play the game
        String playerName = "";
        
        
        //integer array that is used to generate the random no to fire 
        int fire = 0;
        int gunFire= 0,chance=0,rslt=0,shoot=0;
        //object of the global class to fire the randomly 
        Random instance = new Random();
        Connection obj=new Connection();
        //constructor method that is used to load the game in the screen and get the name of the player and set everything 
        public Form1()
        {
            InitializeComponent();
            //show the default image of empty bullet
            pictureBox.ImageLocation = "pics/Empty.jpg";
            //generate the random no to store in the array
            fire = instance.Next(1, 6);
            
            //hidden the game area until the player enter his name 
            groupBox2.Visible = false;
            button1.Visible = false;
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            //get  the Name of the Player until he does not fill  the name he doesn't play the game 
            if (!Player_Name.Text.ToString().Equals(""))
            { 
                //pass the name of the player from text box to global variable to later task
                playerName = Player_Name.Text.ToString();
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                button1.Visible = true;
                Player_Name.Text = "";
                pictureBox.ImageLocation = "pics/Empty.jpg";
            }
            else {
                //if he does not enter  the Name and clck on the button then he will get the error Massage like this 
                MessageBox.Show("Enter the Name of the Player First ");
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            //this is used to load the bullet forfire by calling the rray index;
            pictureBox.ImageLocation = "pics/two.jpg";
        }

        private void Spinner_Click(object sender, EventArgs e)
        {
            //this is used to load the bullet forfire by calling the rray index;
            pictureBox.ImageLocation = "pics/loaded.jpg";
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            //this is the play again method that is used to start the game again so the user can work properly
            groupBox1.Visible = true;
            PlayAgain.Visible = false;
            chance = 0;
            gunFire = 0;
            rslt = 0;

            shoot = 0;

            fire= instance.Next(1,6);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this method is used to trigger the button 2 times in  singe one session 
            // it is just depend upon random is it generate the sound or not 
            shoot++;
            //compare the click to the random no to generate the sound of trigger
            if (shoot== instance.Next(1,3)) {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("pics/fire.wav");
                player.Play();
            }

            //when 2 clicks are over then the game is also over 
            if (shoot==2) {
                MessageBox.Show("Game is over You have to restart the game again");
                //Hide the trigger so the user can't be trigger more
                button1.Visible = false;
                groupBox2.Visible = false;
                PlayAgain.Visible = true;
            }
        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            gunFire++;
            //compare the shoot with the no from array to generate the sound effect
            if (gunFire<=6) {
                if (gunFire == fire) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("pics/fire.wav");
                    player.Play();
                    chance++;
                    result(chance);

                }
            }
            if (gunFire==6) {
                MessageBox.Show("Bullets are finished now this is the your last chance to shoot ");
                fire = instance.Next(1, 6);
                gunFire = 0;

            }
            

            //closing the game with generating the message 
            if (chance==2 && rslt<1){
                MessageBox.Show(playerName + " your Game is over now ");
                
                //PlayAgain.Visible = true;
                chance = 0;
                gunFire = 0;
            }
        }
        //this method is used to decalre the result if he is wiiner then this method will be execute otherwise the loser mssg will be generated 
        public void result(int y) {
            Random random_Object = new Random();
            int z = random_Object.Next(1,5);
            //compare the no once with the random clk 
            if (y==z) {
                rslt++;
                //MessageBox.Show(playerName + " Congrats you won the game");
                groupBox2.Visible =true;
                button1.Visible = true;
                //exit the app if u won the game 
                //System.Windows.Forms.Application.Exit();
                PlayAgain.Visible = true;
            }

        }


    }
}
