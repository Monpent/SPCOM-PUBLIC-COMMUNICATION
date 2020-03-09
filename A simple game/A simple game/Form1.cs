using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_simple_game
{
    public partial class Form1 : Form
    {
        public int clickCount = 0;
        public int UserScore = 5;
        public int CompScore = 5;
        public bool tricked = false;
        public bool insert = false;
        public bool notInsert = false;
        public int indicator = 0;
        public bool copy = false;
        public bool lastTime = true;
        public int questionNum = 0;
        public string fPath = null;
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;
            CompThinking.Visible = false;
            scoreComp.Visible = false;
            scoreUser.Visible = false;
            largePB.Visible = false;
            loc101.Enabled = false;
            loc101.Visible = false;
            loc102.Enabled = false;
            loc102.Visible = false;
            loc103.Enabled = false;
            loc103.Visible = false;
            loc201.Enabled = false;
            loc201.Visible = false;
            loc202.Enabled = false;
            loc202.Visible = false;
            loc203.Enabled = false;
            loc203.Visible = false;
            loc204.Enabled = false;
            loc204.Visible = false;
            bobPB.Visible = false;
            bobPB2.Visible = false;
            alicePB1.Visible = false;
            alicePB2.Visible = false;

            MessageBox.Show("Please select any file in the 'resources' folder");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            var filePath = ofd.FileName;
            fPath = filePath.ToString();
            int index = fPath.LastIndexOf(@"\");
            fPath = fPath.Remove(index);

            loadMachine();
            loadLeftArrow();
            loadRightArrow();
            loadSimpleStreet();
            loadHardStreet();
            loadBob();
            loadAlice();
        }
        private Bitmap machine;
        private Bitmap leftArrow;
        private Bitmap rightArrow;
        private Bitmap alice;
        private Bitmap bob;
        private Bitmap simpleStreet;
        private Bitmap hardStreet;
        public void loadBob()
        {
            // Sets up an image object to be displayed.
            if (bob != null)
            {
                bob.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            bobPB.SizeMode = PictureBoxSizeMode.StretchImage;
            bob = new Bitmap(fPath+"\\bob.jpg");
            bobPB.Image = (Image)bob;
            bobPB.Visible = false;

            bobPB2.SizeMode = PictureBoxSizeMode.StretchImage;
            bobPB2.Image = (Image)bob;
            bobPB2.Visible = false;
        }
        public void loadAlice()
        {
            // Sets up an image object to be displayed.
            if (alice != null)
            {
                alice.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            alicePB1.SizeMode = PictureBoxSizeMode.StretchImage;
            alice = new Bitmap(fPath + "\\alice.jpg");
            alicePB1.Image = (Image)alice;
            alicePB1.Visible = false;

            alicePB2.SizeMode = PictureBoxSizeMode.StretchImage;
            alicePB2.Image = (Image)alice;
            alicePB2.Visible = false;
        }
        public void loadSimpleStreet()
        {
            // Sets up an image object to be displayed.
            if (simpleStreet != null)
            {
                simpleStreet.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            street1.SizeMode = PictureBoxSizeMode.StretchImage;
            simpleStreet = new Bitmap(fPath + "\\street1.jpg");
            street1.Image = (Image)simpleStreet;
            street1.Visible = false;
        }
        public void loadHardStreet()
        {
            // Sets up an image object to be displayed.
            if (hardStreet != null)
            {
                hardStreet.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            street2.SizeMode = PictureBoxSizeMode.StretchImage;
            hardStreet = new Bitmap(fPath + "\\street2.jpg");
            street2.Image = (Image)hardStreet;
            street2.Visible = false;
        }
        public void loadMachine()
        {
            // Sets up an image object to be displayed.
            if (machine != null)
            {
                machine.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            largePB.SizeMode = PictureBoxSizeMode.StretchImage;
            machine = new Bitmap(fPath + "\\machine.jpg");
            largePB.Image = (Image)machine;
        }
        public void loadLeftArrow()
        {
            // Sets up an image object to be displayed.
            if (leftArrow != null)
            {
                leftArrow.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            leftPB.SizeMode = PictureBoxSizeMode.StretchImage;
            leftArrow = new Bitmap(fPath + "\\arrowLeft.jpg");
            leftPB.Image = (Image)leftArrow;
        }
        public void loadRightArrow()
        {
            // Sets up an image object to be displayed.
            if (rightArrow != null)
            {
                rightArrow.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            rightPB.SizeMode = PictureBoxSizeMode.StretchImage;
            rightArrow = new Bitmap(fPath + "\\arrowLeft.jpg");
            rightArrow.RotateFlip(RotateFlipType.Rotate180FlipY);
            rightPB.Image = (Image)rightArrow;
        }
        private void clicked(object sender, EventArgs e)
        {
            clickCount = clickCount + 1;
            if (clickCount == 1)
            {
                mainTextBox.Text = "This is a problem worth a Nobel prize.";
            }
            else if (clickCount == 2)
            {
                mainTextBox.Text = "Here is the machine we are gonging to use today. " + Environment.NewLine +
                    "A small machine with some small rules.";
            }
            else if (clickCount == 3)
            {
                mainTextBox.Text = "Suppose we have a machine like this" + Environment.NewLine
                    + "You can insert a coin here";
                largePB.Visible = true;
                leftPB.Visible = true;
            }
            else if (clickCount == 4)
            {
                mainTextBox.Text = "The other person can insert the coin here";
                leftPB.Visible = false;
                rightPB.Visible = true;
            }
            else if (clickCount == 5)
            {
                mainTextBox.Text = "Here is the trick. If both of you insert the coin, both of you will get two coins." + Environment.NewLine +
                    "However, if there is only one person insert the coin, then the person inserted the coin will lose the coin and the other person will get the coin. " + Environment.NewLine
                    + "If both of you don’t insert the coin, then both of you will not gain nor lose the coin. ";
                rightPB.Visible = false;
            }
            else if (clickCount == 6)
            {
                mainTextBox.Text = "Let’s give it a try. You will play with the other person for as many trails as you want";
            }
            else if (clickCount == 7)
            {
                mainTextBox.Text = "What will you do?" + Environment.NewLine
                    + "Click this text to end the game";
                CompThinking.Visible = true;
                scoreComp.Visible = true;
                scoreUser.Visible = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button2.Visible = true;
                button3.Visible = true;
                update(5);
            }
            else if (clickCount == 8)
            {
                mainTextBox.Text = "Let's try to play with another person" + Environment.NewLine
                    + "Click this text to end the game";
                UserScore = 5;
                CompScore = 5;
                copy = true;
                update(5);
            }
            else if (clickCount == 9)
            {
                mainTextBox.Text = "Do you notice the difference?" + Environment.NewLine
                    + "The first person uses different strategy compare to the second person. " + Environment.NewLine
                    + "If you are working with one of the people in the future, which person will you pick?";
                button2.Visible = false;
                button3.Visible = false;
                CompThinking.Visible = false;
                scoreComp.Visible = false;
                scoreUser.Visible = false;
                largePB.Visible = false;
                mainTextBox.Height = 720;
            }
            else if (clickCount == 10)
            {
                mainTextBox.Text = "The game that you played is a little branch called the ‘Game Theory’. John Von Neuman, the physicist and mathematician who built the framework of quantum mechanism, was also the first to build the field of the game theory. Later, the game theory was developed by John Nash, which won him a Nobel Memorial Prize in Economic Sciences in 1994. ";
            }
            else if (clickCount == 11)
            {
                mainTextBox.Text = "Nash won the Nobel Prize for his discovery called Nash equilibrium.";
            }
            else if (clickCount == 12)
            {
                mainTextBox.Text = "What is Nash equilibrium? Think of the competition between a restaurant Alice and a restaurant Bob.";
            }
            else if (clickCount == 13)
            {
                mainTextBox.Text = "There is a street without any restaurants. Alice thought it will be a nice idea to build a restaurant in the middle of the street. Like this: Where would you put Alice restaurant?";
                street1.Visible = true;
                mainTextBox.Height = 400;
            }
            else if (clickCount == 14)
            {
                mainTextBox.Text = "Where would you put Alice restaurant?";
                street1.Visible = true;
                loc101.Visible = true;
                loc102.Visible = true;
                loc103.Visible = true;
                loc101.Enabled = true;
                loc102.Enabled = true;
                loc103.Enabled = true;
                loc101.BringToFront();
                loc102.BringToFront();
                loc103.BringToFront();
            }
            else if (clickCount == 15)
            {
                mainTextBox.Text = "However, in real life, the street doesn’t have only one crossing. It may look like this:";
                street1.Visible = false;
                loc101.Visible = false;
                loc102.Visible = false;
                loc103.Visible = false;
                loc101.Enabled = false;
                loc102.Enabled = false;
                loc103.Enabled = false;
                street2.Visible = true;
            }
            else if (clickCount == 16)
            {
                mainTextBox.Text = "Where would you put Alice restaurant?";
                loc201.Enabled = true;
                loc201.Visible = true;
                loc201.BringToFront();
                loc202.Enabled = true;
                loc202.Visible = true;
                loc202.BringToFront();
                loc203.Enabled = true;
                loc203.Visible = true;
                loc203.BringToFront();
                loc204.Enabled = true;
                loc204.Visible = true;
                loc204.BringToFront();
                questionNum = 1;
            }
            else if (clickCount == 17)
            {
                mainTextBox.Text = "Then, Bob also thought it is a wonderful idea to put a restaurant in the same street. If Bob placed his restaurant here, where do you think Alice should place her restaurant?";
                loc203.Enabled = false;
                loc203.Visible = false;
                bobPB.Visible = true;
                bobPB.BringToFront();
                questionNum = 2;
            }
            else if (clickCount == 18)
            {
                mainTextBox.Text = "What if Bob place his restaurant here?";
                loc203.Enabled = true;
                loc203.Visible = true;
                loc204.Enabled = false;
                loc204.Visible = false;
                bobPB.Visible = false;
                bobPB2.Visible = true;
                bobPB2.BringToFront();
                loc203.BringToFront();
                questionNum = 3;
            }
            else if (clickCount == 19)
            {
                mainTextBox.Text = "When Alice is building the restaurant, she will think of her competitor Bob in mind. Bob, like Alice, would also think of his competitor in mind. Therefore, they will have their restaurant in a specific palce.";
                loc201.Enabled = false;
                loc201.Visible = false;
                loc202.Enabled = false;
                loc202.Visible = false;
                loc203.Enabled = false;
                loc203.Visible = false;
                loc204.Enabled = false;
                loc204.Visible = false;
                bobPB.BringToFront();
                bobPB2.Visible = false;
                alicePB2.Visible = true;
                bobPB.Visible = true;
                alicePB2.BringToFront();
            }
            else if (clickCount == 20)
            {
                mainTextBox.Text = "If Alice moves her restaurant, Bob will move his restaurant too.";

            }
            else if (clickCount == 21)
            {
                mainTextBox.Text = "Eventually, they will reach the agreement without the best location but with the easiest to compete with others.";
                mainTextBox.Height = 520;
                bobPB.Visible = false;
                alicePB1.Visible = false;
                bobPB2.Visible = false;
                alicePB2.Visible = false;
                street2.Visible = false;
            }
            else if (clickCount == 22)
            {
                mainTextBox.Text = "The agreement is called Nash equilibrium.";
            }
            else if (clickCount == 23)
            {
                mainTextBox.Text = "In this scenario, Alice and Bob also consider each other as competitor without chance of cooperating. This is called the zero-sum or non-zero-sum game.Another this type of cooperating is the Prisoner’s Dilemma.";
            }
            else if (clickCount == 24)
            {
                mainTextBox.Text = "Alice and Bob were arrested for bank robbery and placed in separate isolation cells. The police approach one of them and said: “you can remain silence or chose to confess. If you both confess, both of you will have two years of sentence. If both of you remain silence, the charge will be dropped, and you can go home tomorrow. However, take in mind that if you confess and your partner remain silence, you will have one year of sentence, but your partner will have five years of sentences. Your partner also has a chance of betraying you. Will you confess?”";
            }
            else if (clickCount == 25)
            {
                mainTextBox.Text = "Prisoner’s Dilemma explains why two completely rational people may not make the most rational decision. Hence, game theory plays a very important roles in our life.";
            }
            else if (clickCount == 26)
            {
                mainTextBox.Text = "Prisoner’s Dilemma explains why two completely rational people may not make the most rational decision. Hence, game theory plays a very important roles in our life.";
            }
            else if (clickCount == 27)
            {
                mainTextBox.Text = "There are choices we must make in life that are like the game theory questions. They are also happening in stock market, schools and any other workplaces. That why the game theory is valuable to us.  Hope you learned something throughout this game. Thank you for playing. :)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (copy == false)
            {
                if (tricked == false)
                {
                    UserScore = UserScore + 2;
                    CompScore = CompScore + 2;
                    indicator = 1;
                }
                else
                {
                    UserScore = UserScore - 1;
                    CompScore = CompScore + 1;
                    indicator = 2;
                }
            }
            else
            {
                if (lastTime == true)
                {
                    UserScore = UserScore + 2;
                    CompScore = CompScore + 2;
                    indicator = 1;
                }
                else
                {
                    UserScore = UserScore - 1;
                    CompScore = CompScore + 1;
                    indicator = 2;
                }
            }
            lastTime = true;
            CompThinking.Text = "I am thinking";
            update(indicator);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (copy == false)
            {
                if (tricked == false)
                {
                    CompScore = CompScore - 1;
                    UserScore = UserScore + 1;
                    tricked = true;
                    indicator = 3;
                }
                else
                {
                    indicator = 4;
                }
            }
            else
            {
                if (lastTime == true)
                {
                    UserScore = UserScore + 1;
                    CompScore = CompScore - 1;
                    indicator = 1;
                }
                else
                {
                    indicator = 2;
                }
            }
            lastTime = false;
            CompThinking.Text = "I am thinking";
            update(indicator);
        }
        
        private void update(int i)
        {
            System.Threading.Thread.Sleep(500);
            if (i == 1 || i ==3)
            {
                CompThinking.Text = "I will insert the coin";
            }
            else if(i == 2 || i==4)
            {
                CompThinking.Text = "I will not insert the coin";
            }
            else if (i == 5)
            {
                CompThinking.Text = "intialized";
            }
            scoreUser.Text = "Your Score is " + UserScore.ToString();
            scoreComp.Text = "The Computer score is " + CompScore.ToString();
        }

        private void loc102_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good choice!");
        }

        private void loc101_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rethink about the location. \n Where is the shortest distance from both end of the street?");
        }

        private void loc103_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rethink about the location. \n Where is the shortest distance from both end of the street?");
        }

        private void loc201_Click(object sender, EventArgs e)
        {           
            if(questionNum == 1)
            {
                MessageBox.Show("This location is a bit far for the people travelling from East");
            }
            else if (questionNum == 2)
            {
                MessageBox.Show("This location is a bit far for the people travelling from East");
            }
            else if (questionNum == 3)
            {
                MessageBox.Show("Nice choice. Then what will happen if Bob moves a block to the West?");
            }
        }

        private void loc202_Click(object sender, EventArgs e)
        {
            if (questionNum == 1)
            {
                MessageBox.Show("Good Choice");
            }
            else if (questionNum == 2)
            {
                MessageBox.Show("Good Choice");
            }
            else if (questionNum == 3)
            {
                MessageBox.Show("Good Choice");
            }
        }

        private void loc203_Click(object sender, EventArgs e)
        {
            if (questionNum == 1)
            {
                MessageBox.Show("Good Choice");
            }
            else if (questionNum == 2)
            {
                MessageBox.Show("Good Choice");
            }
            else if (questionNum == 3)
            {
                MessageBox.Show("Good Choice");
            }
        }

        private void loc204_Click(object sender, EventArgs e)
        {
            if (questionNum == 1)
            {
                MessageBox.Show("This location is a bit far for the people travelling from West");
            }
            else if (questionNum == 2)
            {
                MessageBox.Show("This location is a bit far for the people travelling from West");
            }
            else if (questionNum == 3)
            {
                MessageBox.Show("Good Choice. Then, what will happen if Bob moves a block to the West?");
            }
        }
    }
}
