using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int CurrentIndex = 0;
        private string CurrentQuery = string.Empty;
        private int CorrectCount = 0;

        private readonly string[] Questions = new string[]
        {
            "Какой тип данных используется для хранения целых чисел без знака в C#?",
            "Что такое метод в C#?",
            "Что такое оператор \"if\" в C#?",
            "Как объявить массив в C#?",
            "Что такое конструктор в C#?",
            "Какой модификатор доступа используется для членов класса, доступных только внутри класса?",
            "Что такое интерфейс в C#?",
            "Какой оператор используется для управления потоком выполнения в C#?"
        };

        private readonly string[][] Options = new string[][]
        {
            new string[] { "int", "unit", "short" },
            new string[] { "Блок кода, выполняющий определенную задачу", "Класс для хранения данных", "Интерфейс для работы с файлами" },
            new string[] { "Оператор для циклического повторения кода", "Оператор для принятия решений на основе условий", "Оператор для выполнения математических операций" },
            new string[] { "int[] arr = new int[];", "int[] arr = new int[10];", "int[] arr = {1, 2, 3};" },
            new string[] { "Метод для сортировки данных в массиве", "Специальный метод для инициализации объекта", "Оператор для создания новых файлов" },
            new string[] { "private", "public", "protected" },
            new string[] { "Специальный класс для работы с базами данных", "Спецификация методов, которые должен реализовать класс", "Оператор для объединения нескольких условий" },
            new string[] { "for", "switch", "break" }
        };

        private readonly int[] CorrectAnswers = new int[]
        {
            1, // Правильный ответ для первого вопроса
            0, // Правильный ответ для второго вопроса
            1, // Правильный ответ для третьего вопроса
            1, // Правильный ответ для четвертого вопроса
            1, // Правильный ответ для пятого вопроса
            0, // Правильный ответ для шестого вопроса
            1, // Правильный ответ для седьмого вопроса
            2  // Правильный ответ для восьмого вопроса
        };

        public Form1()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (CurrentIndex < Questions.Length)
            {
                CurrentQuery = Questions[CurrentIndex];
                label1.Text = CurrentQuery;

                radioButton1.Text = Options[CurrentIndex][0];
                radioButton2.Text = Options[CurrentIndex][1];
                radioButton3.Text = Options[CurrentIndex][2];
            }
            else
            {
                MessageBox.Show($"Тест завершен! Правильных ответов: {CorrectCount} из {Questions.Length}");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < Questions.Length)
            {
                int selectedAnswer = -1;

                if (radioButton1.Checked)
                {
                    selectedAnswer = 0;
                }
                else if (radioButton2.Checked)
                {
                    selectedAnswer = 1;
                }
                else if (radioButton3.Checked)
                {
                    selectedAnswer = 2;
                }

                if (selectedAnswer == CorrectAnswers[CurrentIndex])
                {
                    CorrectCount++;
                    MessageBox.Show("Правильный ответ!");
                }
                else
                {
                    MessageBox.Show("Неправильный ответ.");
                }

                CurrentIndex++;
                DisplayQuestion();
            }
        }
    }
}
