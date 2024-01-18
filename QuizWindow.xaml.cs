using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EnglischQuiz 
{
    public partial class QuizWindow : Window
    {
        EndHighscore temp = new EndHighscore();
        EndWindow gameOverWindow;

        bool antwort1 = false;
        bool antwort2 = false;
        bool antwort3 = false;

        public QuizWindow(){
            InitializeComponent();
            gameOverWindow = new EndWindow(temp);
            auswahl();
        }

        public void auswahl(){
            List<string> frage = ["Wie bildet man das Present Simple?",
                "Wie bildet man das Present Perfekt?",
                "Wie bildet man das Past Simple?",
                "Wie bildet man das Past Perfekt?",
                "Wie bildet man das Present Continuous?",
                "Wie bildet man das Past Continuous?",
                "Wie bildet man das Future Simple?",
                "Wie bildet man das Future Continuous?",
                "Wie bildet man den Present Perfect Continuous?",
                "Wie verwendet man 'going to' für zukünftige Pläne?",
                "Wie bildet man den Past Perfect Continuous?",
                "Wann verwendet man 'used to' und wie bildet man Sätze damit?",
                "Was sind die Modalverben der Möglichkeit?",
                "Was sind Signalwörter fürs das Present Simple?",
                "Was sind Signalwörter fürs das Present Perfekt?",
                "Was sind Signalwörter fürs das Past Simple?"];

            Random rnd = new Random();
            int rndZahl = rnd.Next(frage.Count);

            Sprechblase.Text = frage[rndZahl];

            switch (rndZahl) {
                case 0:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "Verb + ing";
                    button3.Content = "Verb + ed";
                    antwort1 = true;
                    break;

                case 1:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "have/has + Verb + ed";
                    button3.Content = "had + Verb + ed";
                    antwort2 = true;
                    break;

                case 2:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "Verb + ing";
                    button3.Content = "Verb + ed";
                    antwort3 = true;
                    break;

                case 3:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "have/has + Verb + ed";
                    button3.Content = "had + Verb + ed";
                    antwort3 = true;
                    break;

                case 4:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "Form von be + Verb + ing";
                    button3.Content = "Verb + ing";
                    antwort2 = true;
                    break;

                case 5:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "was/were + Verb + ing";
                    button3.Content = "Verb + ing";
                    antwort2 = true;
                    break;

                case 6:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "will + Verb";
                    button3.Content = "will be + Verb";
                    antwort2 = true;
                    break;

                case 7:
                    button1.Content = "Mit der Grundform des Verbs";
                    button2.Content = "will + Verb";
                    button3.Content = "will be + Verb";
                    antwort3 = true;
                    break;

                case 8:
                    button1.Content = "have/has + been + Verb + ing";
                    button2.Content = "will + have + been + Verb + ing";
                    button3.Content = "have/has + Verb + ed";
                    antwort2 = true;
                    break;

                case 9:
                    button1.Content = "Spontane Entscheidungen";
                    button2.Content = "vorher geplante Handlungen.";
                    button3.Content = "vergangene Ereignisse.";
                    antwort2 = true;
                    break;

                case 10:
                    button1.Content = "had + been + Verb + ing";
                    button2.Content = "have/has + been + Verb + ing";
                    button3.Content = "had + Verb + ed";
                    antwort1 = true;
                    break;

                case 11:
                    button1.Content = "Bei vergangenen Gewohnheiten.";
                    button2.Content = "Bei aktuellen Handlungen.";
                    button3.Content = "Für zukünftige Pläne verwendet.";
                    antwort1 = true;
                    break;

                case 12:
                    button1.Content = "can, could, may, might";
                    button2.Content = "will, would, shall, should";
                    button3.Content = "must, have to, need to, ought to";
                    antwort1 = true;
                    break;

                case 13:
                    button1.Content = "every morning, usually, often";
                    button2.Content = "since, for, already, yet";
                    button3.Content = "yesterday, last week, two weeks ago";
                    antwort1 = true;
                    break;

                case 14:
                    button1.Content = "every morning, usually, often";
                    button2.Content = "since, for, already, yet";
                    button3.Content = "yesterday, last week, two weeks ago";
                    antwort2 = true;
                    break;

                case 15:
                    button1.Content = "every morning, usually, often";
                    button2.Content = "since, for, already, yet";
                    button3.Content = "yesterday, last week, two weeks ago";
                    antwort3 = true;
                    break;
            }
        }

        private void antw1_Click(object sender, RoutedEventArgs e) {
            if (antwort1 == true) {
                antwort1 = false;
                highscore.Text = Convert.ToString(temp.Score += 1);
                auswahl();
            } else {
                gameOverWindow.Show();
                this.Close();
            } 
        }

        private void antw2_Click(object sender, RoutedEventArgs e) {
            if (antwort2 == true) {
                antwort2 = false;
                highscore.Text = Convert.ToString(temp.Score += 1);
                auswahl();
            } else {
                gameOverWindow.Show();
                this.Close();
            } 
        }

        private void antw3_Click(object sender, RoutedEventArgs e) {
            if (antwort3 == true) {
                antwort3 = false;
                highscore.Text = Convert.ToString(temp.Score += 1);
                auswahl();
            } else {
                gameOverWindow.Show();
                this.Close();
            }
        }
    }
}
