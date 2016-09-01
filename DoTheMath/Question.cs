using System;
using System.ComponentModel;

namespace DoTheMath
{
    public class Question : INotifyPropertyChanged
    {
        //example: (58*7)+23
        public string question { get; set; }
        public int answer { get; set; }
        private string _subm_answer;
        public string subm_answer{
            get { return _subm_answer; }
            set
            {
                _subm_answer = value;
                NotifyPropertyChanged(subm_answer);
            } }

        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public int score { get; set; }

        private string[] OperationList = {null, "×", "÷","+","-" };
        private Random RandomGenerator = new Random();

        public event PropertyChangedEventHandler PropertyChanged;

        public Question()
        {
            GenerateQuestion();
            score = 0;
        }

        public bool Judge()
        {
            if (answer == Int32.Parse(subm_answer))
            {
                score = 1;
                return true;
            }
            else
            {
                score = -1;
                return false;
            }
        }

        public Question clone()
        {
            Question Dup_question = new Question() {question = this.question,answer = this.answer,subm_answer = this.subm_answer,score = this.score};
            return Dup_question;
        }

        private void GenerateQuestion()
        {
            int num1 = 0, num2 = 0, num3 = 0;
            bool simple = false;
            string operation1 = OperationList[RandomGenerator.Next(5)];
            string operation2 = OperationList[RandomGenerator.Next(3, 5)];
            num3 = RandomGenerator.Next(1000);
            switch (operation1)
            {
                case null:
                    num1 = RandomGenerator.Next(1, 100);
                    simple = true;
                    answer = num1;
                    break;
                case "÷":
                    answer = RandomGenerator.Next(1, 100);
                    num2 = RandomGenerator.Next(1, 10);
                    num1 = answer*num2;
                    break;
                default:
                    num1 = RandomGenerator.Next(1, 100);
                    num2 = RandomGenerator.Next(1, 10);
                    switch (operation1)
                    {
                        case "×":
                            answer = num1*num2;
                            break;
                        case "+":
                            answer = num1 + num2;
                            break;
                        case "-":
                            answer = num1 - num2;
                            break;
                    }
                    break;

            }
            switch (operation2)
            {
                case "+":
                    answer += num3;
                    break;

                case "-":
                    answer -= num3;
                    break;
            }

            if (answer >= 0)
            {
                if (simple)
                {
                    question = num1 + operation2 + num3;
                }
                else
                {
                    question = num1 + operation1 + num2 + operation2 + num3;
                }
            }
            else
            {
                if (simple)
                {
                    question = num3 + operation2 + num1;
                }
                else
                {
                    question = num3 + operation2 + "("+num1 + operation1 + num2+")";
                }
                answer = Math.Abs(answer);
            }
            

        }
    }
}
