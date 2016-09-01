using System;
using System.Windows;

namespace DoTheMath
{
    /// <summary>
    /// Result.xaml 的交互逻辑
    /// </summary>
    public partial class Result : Window
    {
        public Exam CurExam;
        public Result(Exam exam )
        {
            InitializeComponent();
            CurExam = exam;
        }

        private void Result_OnLoaded(object sender, RoutedEventArgs e)
        {
            textResult.Text = CurExam.Score().ToString();
            listExam.ItemsSource = CurExam.ExamContent;
        }

        private void NewGame_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow NewGameWindow = new MainWindow();
            NewGameWindow.Show();
            this.Close();
        }

        private void Quit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Result_OnClosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
