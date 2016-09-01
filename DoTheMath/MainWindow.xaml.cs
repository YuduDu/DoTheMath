using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace DoTheMath
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Exam _CurExam = new Exam();
        private Question _CurQuestion;
        private int _time = 10;
        private int _count = 3;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {

            Timer.Text = _time.ToString();
            if (_time == 0)
            {
                timer.Stop();
                Window resultWindow = new Result(_CurExam);
                resultWindow.Show();
                this.Close();
            }
            _time--;

        }



        private void Submit_OnClick(object sender, RoutedEventArgs e)
        {
            _CurQuestion.subm_answer = userAnswer.Text;
            bool result = _CurQuestion.Judge();
            Question tmp = _CurQuestion.clone();
            _CurExam.ExamContent.Add(tmp);
            if (result)
            {
                textNotify.Text = "Great job!";
                textNotify.Foreground = new SolidColorBrush(Colors.Green);
                newQuestion();
            }
            else
            {
                textNotify.Text = "Oops, try again...";
                textNotify.Foreground = new SolidColorBrush(Colors.Red);
                if (--_count == 0)
                {
                    newQuestion();
                    
                }
                else
                {
                    _CurQuestion.subm_answer = null;
                }
            }
            

        }


        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            newQuestion();

        }

        private void newQuestion()
        {
            _CurQuestion = new Question();
            _CurQuestion.subm_answer = null;
            Page.DataContext = _CurQuestion;
            
        }
    }
}
