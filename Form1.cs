using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thats_enoug_for_quiz
{
    public partial class Form1 : Form
    {
        int CorrectAnswer;
        int questionNumber = 1;
        int score;        
        int totalquestions;
        int incorrect;
        int falsescore;

        

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);


            totalquestions=5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
           
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == CorrectAnswer)
            {
                score++;
               
            }
            if (buttonTag==incorrect)
            {
                falsescore++;
            }
            questionNumber++;


            if (questionNumber==totalquestions)

            {


                MessageBox.Show(
                    "Quiz is End" + Environment.NewLine+
                    "Well Done" + Environment.NewLine+
                    "Your Score  "+score+ " at 4 qua");



                score = 0;
                
                questionNumber = 0;
                askQuestion(questionNumber);

            }


            askQuestion(questionNumber);


        }



        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.quiz_start_picture;

                    lblqua.Text = "what is the color of sky";

                    button1.Text = "Blue";
                    button2.Text = "Red";
                    button3.Text = "Purple";
                    button4.Text = "Yellow";

                    CorrectAnswer = 1;
                    

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.fight_club;

                    lblqua.Text = "what is the name of the main caracter from Fight Club";

                    button1.Text = "Angela Thorman";
                    button2.Text = "Brad Pitt";
                    button3.Text = "Tony Stark";
                    button4.Text = "Tony Stald";

                    CorrectAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.ınterstaller;

                    lblqua.Text = "What is the name of this movie?";

                    button1.Text = "Interstaller";
                    button2.Text = "Stranger Things";
                    button3.Text = "Cobra Kai";
                    button4.Text = "Enola Holmes";

                    CorrectAnswer = 1;
                    


                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.stranger_things;

                    lblqua.Text = "What is the name of this movie";

                    button1.Text = "Brooklyn 99";
                    button2.Text = "Bojack Horseman";
                    button3.Text = "Game of Thrones";
                    button4.Text = "Stranger Things";

                    CorrectAnswer = 4;
                    


                    break;












            }

        }






    }
}
