using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace FrostyAI_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List of Questions to be asked by the bot
        string[] arrays = { "What is your name?", "What is your Occupation?", "What is your favourite color?", "What is your favourite food?"};
        //The bot's list of replies for the name question
        string[] imprname = { "That name is lovely", "I love that name", "That name sucks", "What type of name is this?", "I hate that name", "The name is too holy", "Too Boring ", "Cool name dude", "Isn't that a dog name", "Are you Buhari's Brother" };
        //The bot's list of replies for the occupation question
        string[] imprprof = { "Wow!", "Nice! impressive", "Hmmmmmm, kudos", "great", "That job sucks","I really like that Job" };
        //The bot's list of replies for the color question
        string[] imprcolor = { "Blue is still the best", "I hate that Color", "That Color is irritating", "I dislike the color so badly", "I really like that color" };
        //The bot's list of replies for the food question
        string[] imprfood = { "The food is really traditional", "That food sucks", "I hate that food once in Nigeria", "I hate the smell of the food", "What the heck", "Click on the finish button", "Click on the finish button" };

        string text;
        string ansName, ansOccupation, ansColor = "";
        //Initializing speech synthesizer
        SpeechSynthesizer sp = new SpeechSynthesizer();
        Random rand = new Random();
        int i = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Force close program
            Environment.Exit(0);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //if the user types 2

            if (textBox2.Text == "2")
            {
                //the method info() should function
                info();
            }
          
            //Method containing all info about what the button should do
                    Buttoninfo();
                
            
        }
        //a void method
        public void listedinfo()
        {
            textBox1.Text = "1.Chat with me\n2.Get Information about me.";
        }
        public void info()
        {
            
            sp.Speak("I am a voice chat bot. I am developed by Programmer Habeeb. I was developed in c sharp. I was made in October 2018. I have the ability to ask some questions like,");
        }
        public void frstdisp()
        {
             var servertext = "";
           
             
                 servertext = "Hello I am Frosty!. What do you want in the listed Information above";
                
                 sp.Speak(servertext);
                 listedinfo();
                  
           
        }
        public string Default = "What is your ";
        public void name()
        {
            
            string name = Default + "name?";
           
            sp.Speak(name);
        }

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Method to initialized if the program is run
            frstdisp();
        }
        public void insertion()
        {
            
                if (i == 1)
                {
                    ansName = text;

                    textBox2.Text = "";

                }
                if (i == 2)
                {
                    ansOccupation = text;

                    textBox2.Text = "";
                }
                if (i == 3)
                {
                    ansColor = text;
                    textBox2.Text = "";

                }
            
            
            
            
        }
        public void information()
        {
            string u = "Now I know some information about you ";
            string name = "Your name is ";
            string Profession = "Your Occupation or Profession is ";
            string color = "Your favourite color is ";
            string food = " Your favourite food is ";
            string ansFood = textBox2.Text;
            textBox2.Text = "";
            string[] inform = {ansName, ansOccupation,ansColor,ansFood };
            sp.Speak(u + name + ansName);
            sp.Speak(Profession + ansOccupation);
            sp.Speak(color + ansColor);
            sp.Speak(food + ansFood);
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //if button 3 is clicked
           
            information();
            
            i = 0;
            button3.Visibility = System.Windows.Visibility.Hidden;
            button2.Visibility = System.Windows.Visibility.Visible;
            listedinfo();
            
        }
        public void Buttoninfo()
        {

            if (i < 4)
            {
                if (i == 1)
                {

                    var ran = rand.Next(imprname.Length);
                    sp.Speak(imprname[ran]);
                }
                else if (i == 2)
                {
                    var ran = rand.Next(imprprof.Length);
                    sp.Speak(imprprof[ran]);

                }
                else if (i == 3)
                {
                    var ran = rand.Next(imprcolor.Length);
                    sp.Speak(imprcolor[ran]);

                }
                else if (i == 4)
                {
                    var ran = rand.Next(imprfood.Length);
                    sp.Speak(imprfood[ran]);
                }

                sp.Speak(arrays[i]);


                textBox1.Text = arrays[i];
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
                {
                    text = textBox2.Text;
                }





                insertion();


            }
            else if (i == 4)
            {

                button2.Visibility = System.Windows.Visibility.Hidden;
                button3.Visibility = System.Windows.Visibility.Visible;

            }


            i++;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            frost_abt_us frst = new frost_abt_us();
            frst.Show();
        }

        
       //end of code
    }
}
