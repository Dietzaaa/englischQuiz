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

namespace EnglischQuiz {

    public partial class EndWindow : Window {
        EndHighscore highscore;
        
        public EndWindow(EndHighscore temp) {
            highscore = temp;
            InitializeComponent();
        }

        private void WeiterButton_Click(object sender, RoutedEventArgs e) {
            MainWindow startWindow = new MainWindow();
            startWindow.Show();
            this.Close();
        }

        public new void Show() {
            endHighscore.Text = Convert.ToString(highscore.Score);
            base.Show();
        }
    }
}
