﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnglischQuiz {
 
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e) {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.Show();
            this.Close();
        }
    }
}