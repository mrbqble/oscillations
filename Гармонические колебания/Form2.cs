using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гармонические_колебания
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)                      // Нажатие на кнопку1
        {
            double t, N, T, f, w;                                                   // Создание переменных типа double
            if (textBox1.Text == "" || textBox2.Text == "")                         // Условие: если текст компонента textBox1 или textBox2 пусто
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудифайла R
                MessageBox.Show("Введите время и число колебании", "Ошибка");       // Вывод сообщения об ошибке в отдельном окне
                t = 0;                                                              // Переменная t присваивает значение 0
                N = 0;                                                              // Переменная N присваивает значение 0
            }
            else
            {
                t = Convert.ToDouble(textBox1.Text);                                // Переменная t присваивает переведенное в тип double значение текста компонента textBox1
                N = Convert.ToDouble(textBox2.Text);                                // Переменная N присваивает переведенное в тип double значение текста компонента textBox2
            }
            T = t / N;                                                              // Вычисление переменной Т
            f = 1 / T;                                                              // Вычисление переменной f
            w = 2 * Math.PI / T;                                                    // Вычисление переменной w
            textBox6.Text = Convert.ToString(T);                                    // Текст компонента textBox6 присваивает переведенное в тип string значение переменной T
            textBox7.Text = Convert.ToString(f);                                    // Текст компонента textBox7 присваивает переведенное в тип string значение переменной f
            textBox8.Text = Convert.ToString(w);                                    // Текст компонента textBox8 присваивает переведенное в тип string значение переменной w
        }
        private void button2_Click(object sender, EventArgs e)                      // Нажатие на кнопку2
        {
            double Eo, Ek, Ep, g, A, x;                                             // Создание переменных типа double
            g = 9.81;                                                               // Переменная g присваивает значение 9,81
            if (textBox3.Text == "" || textBox9.Text == "")                         // Условие: если текст компонента textBox3 или textBox9 пусто
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Введите амплитуду и вычислите смещение", "Ошибка");// Вывод сообщения об ошибке в отдельном окне
                A = 0;                                                              // Переменная А присваивает значение 0
                x = 0;                                                              // Переменная t присваивает значение 0
            }
            else
            {
                A = Convert.ToDouble(textBox3.Text);                                // Переменная А присваивает переведенное в тип double значение текста компонента textBox3
                x = Convert.ToDouble(textBox9.Text);                                // Переменная х присваивает переведенное в тип double значение текста компонента textBox9
            }
            if (radioButton3.Checked == true)                                       // Условие: если компонент radioButton3 был выбран, то есть поставлен флажок
            {
                double m;                                                           // Создание переменной типа double
                if (textBox5.Text == "")                                            // Условие: если текст компонента textBox5 пусто
                {
                    SoundPlayer R = new SoundPlayer();                              // Создание аудиофайла R
                    R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";       // Местоположение аудиофайла R
                    R.Play();                                                       // Воспроизведение аудиофайла R
                    MessageBox.Show("Введите массу", "Ошибка");                     // Вывод сообщения об ошибке в отдельном окне
                    m = 0;                                                          // Переменная m присваивает значение 0
                }
                else
                {
                    m = Convert.ToDouble(textBox5.Text);                            // Переменная m присваивает переведенное в тип double значение текста компонента textBox5
                }
                Eo = m * g * A;                                                     // Вычисление переменной Eo
                Ep = m * g * Math.Abs(x);                                           // Вычисление переменной Ep
                if (Ep == Eo)                                                       // Условие: если переменная Ep равна переменной Eo
                {
                    Ek = 0;                                                         // Переменная Ek присваивает значение 0
                }
                if (Ep == 0)                                                        // Условие: если переменная Ep равна 0
                {
                    Ek = Eo;                                                        // Переменная Ek присваивает значение переменной Eo
                }
                else
                {
                    Ek = Eo - Ep;                                                   // Переменная Ek присваивает значение разности переменных Eo и Ep
                }
                textBox12.Text = Convert.ToString(Eo);                              // Текст компонента textBox12 присваивает переведенное в тип string значение переменной Eo
                textBox13.Text = Convert.ToString(Ek);                              // Текст компонента textBox13 присваивает переведенное в тип string значение переменной Ek
                textBox14.Text = Convert.ToString(Ep);                              // Текст компонента textBox14 присваивает переведенное в тип string значение переменной Ep
            }
            if (radioButton4.Checked == true)                                       // Условие: если компонент radioButton4 был выбран, то есть поставлен флажок
            {
                double k;                                                           // Создание переменной типа double
                if (textBox5.Text == "")                                            // Условие: если текст компонента textBox5 пусто
                {
                    SoundPlayer R = new SoundPlayer();                              // Создание аудиофайла R
                    R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";       // Местоположение аудиофайла R
                    R.Play();                                                       // Воспроизведение аудиофайла R
                    MessageBox.Show("Введите жесткость пружины", "Ошибка");         // Вывод сообщения об ошибке в отдельном окне
                    k = 0;                                                          // Переменная k присваивает значение 0
                }
                else
                {
                    k = Convert.ToDouble(textBox5.Text);                            // Переменная k присваивает переведенное в тип double значение текста компонента textBox5
                }
                Eo = k * Math.Pow(A, 2) / 2;                                        // Вычисление переменной Eo
                Ep = k * Math.Pow(x, 2) / 2;                                        // Вычисление переменной Ep
                if (Ep == Eo)                                                       // Условие: если переменная Ep равна переменной Eo
                {
                    Ek = 0;                                                         // Переменная Ek присваивает значение 0
                }
                if (Ep == 0)                                                        // Условие: если переменная Ep равна 0
                {
                    Ek = Eo;                                                        // Переменная Ek присваивает значение переменной Eo
                }
                else
                {
                    Ek = Eo - Ep;                                                   // Переменная Ek присваивает значение разности переменных Eo и Ep
                }
                textBox12.Text = Convert.ToString(Eo);                              // Текст компонента textBox12 присваивает переведенное в тип string значение переменной Eo
                textBox13.Text = Convert.ToString(Math.Abs(Ek));                    // Текст компонента textBox13 присваивает переведенное в тип string значение переменной Ek
                textBox14.Text = Convert.ToString(Math.Abs(Ep));                    // Текст компонента textBox14 присваивает переведенное в тип string значение переменной Ep
            }
            else if(radioButton3.Checked == false && radioButton4.Checked == false)
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Выберите вид маятника", "Ошибка");                 // Вывод сообщения об ошибке в отдельном окне
            }
        }
        private void button3_Click(object sender, EventArgs e)                      // Нажатие на кнопку3
        {
            double A, t, x, v, a, w, r;                                             // Создание переменных типа double
            if (textBox3.Text == "" || textBox4.Text == "")                         // Условие: если текст компонента textBox3 или textBox4 пусто
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Введите амплитуду и время и вычислите циклическую частоту", "Ошибка");// Вывод сообщения об ошибке в отдельном окне
                A = 0;                                                              // Переменная A присваивает значение 0
                t = 0;                                                              // Переменная t присваивает значение 0
                w = 0;                                                              // Переменная w присваивает значение 0
            }
            else
            {
                A = Convert.ToDouble(textBox3.Text);                                // Переменная А присваивает переведенное в тип double значение текста компонента textBox3
                t = Convert.ToDouble(textBox4.Text);                                // Переменная t присваивает переведенное в тип double значение текста компонента textBox4
                w = Convert.ToDouble(textBox8.Text);                                // Переменная w присваивает переведенное в тип double значение текста компонента textBox8
            }
            r = w * t;                                                              // Вычисление переменной r
            if (radioButton1.Checked == true)                                       // Условие: если компонент radioButton1 был выбран, то есть поставлен флажок
            {
                for (int i = 1; i <= 100; i++)                                      // Цикл: создание переменной i начальным значением 1, диапозон до 100, с каждым повтором i увеличивается на 1
                {
                    if (Convert.ToSingle(r / i) == Convert.ToSingle(Math.PI))       // Условие: значение r деленое на i, переведенное в тип float, равно значению числу пи, переведенное в тип float 
                    {
                        x = 0;                                                      // Переменная x присваивает значение 0
                        v = A * w * Math.Cos(r);                                    // Вычисление переменной v
                        a = 0;                                                      // Переменная a присваивает значение 0
                        textBox9.Text = Convert.ToString(x);                        // Текст компонента textBox9 присваивает переведенное в тип string значение переменной x
                        textBox10.Text = Convert.ToString(v);                       // Текст компонента textBox10 присваивает переведенное в тип string значение переменной v
                        textBox11.Text = Convert.ToString(a);                       // Текст компонента textBox11 присваивает переведенное в тип string значение переменной a
                        break;                                                      // Выход из цикла
                    }
                    else
                    {
                        x = A * Math.Sin(r);                                        // Вычисление переменной x
                        a = (-x) * Math.Pow(w, 2);                                  // Вычисление переменной a
                        if (x == A || (-x) == A)                                    // Условие: переменная x равна переменной А или обратное значение переменной х равна переменной А
                        {
                            v = 0;                                                  // Переменная v присваивает значение 0
                        }
                        else
                        {
                            v = A * w * Math.Cos(r);                                // Вычисление переменной v
                        }
                        textBox9.Text = Convert.ToString(x);                        // Текст компонента textBox9 присваивает переведенное в тип string значение переменной x
                        textBox10.Text = Convert.ToString(v);                       // Текст компонента textBox10 присваивает переведенное в тип string значение переменной v
                        textBox11.Text = Convert.ToString(a);                       // Текст компонента textBox11 присваивает переведенное в тип string значение переменной a
                    }
                }
            }
            if (radioButton2.Checked == true)                                       // Условие: если компонент radioButton2 был выбран, то есть поставлен флажок
            {
                for (int i = 1; i <= 100; i++)                                      // Цикл: создание переменной i начальным значением 1, диапозон до 100, с каждым повтором i увеличивается на 1
                {
                    if (Convert.ToSingle(r / i) == Convert.ToSingle(Math.PI))       // Условие: значение r деленое на i, переведенное в тип float, равно значению числу пи, переведенное в тип float
                    {
                        x = A * Math.Cos(r);                                        // Вычисление переменной x
                        a = (-x) * Math.Pow(w, 2);                                  // Вычисление переменной a
                        v = 0;                                                      // Переменная v присваивает значение 0
                        textBox9.Text = Convert.ToString(x);                        // Текст компонента textBox9 присваивает переведенное в тип string значение переменной x
                        textBox10.Text = Convert.ToString(v);                       // Текст компонента textBox10 присваивает переведенное в тип string значение переменной v
                        textBox11.Text = Convert.ToString(a);                       // Текст компонента textBox11 присваивает переведенное в тип string значение переменной a
                        break;                                                      // Выход из цикла
                    }
                    if (Convert.ToSingle(r / i) == Convert.ToSingle(Math.PI / 2))   // Условие: значение r деленое на i, переведенное в тип float, равно значению числу пи деленое на 2, переведенное в тип float 
                    {
                        x = 0;                                                      // Переменная x присваивает значение 0
                        v = (-A) * w * Math.Sin(r);                                 // Вычисление переменной v
                        a = 0;                                                      // Переменная a присваивает значение 0
                        textBox9.Text = Convert.ToString(x);                        // Текст компонента textBox9 присваивает переведенное в тип string значение переменной x
                        textBox10.Text = Convert.ToString(v);                       // Текст компонента textBox10 присваивает переведенное в тип string значение переменной v
                        textBox11.Text = Convert.ToString(a);                       // Текст компонента textBox11 присваивает переведенное в тип string значение переменной a
                        break;
                    }
                    else if(Convert.ToSingle(r / i) != Convert.ToSingle(Math.PI) && Convert.ToSingle(r / i) != Convert.ToSingle(Math.PI / 2))// Условие: значение r деленое на i, переведенное в тип float, не равно значению числу пи, переведенное в тип float и значение r деленое на i, переведенное в тип float, не равно значению числу пи деленое на 2, переведенное в тип float
                    {
                        x = A * Math.Cos(r);                                        // Вычисление переменной x
                        a = (-x) * Math.Pow(w, 2);                                  // Вычисление переменной a
                        v = (-A) * w * Math.Sin(r);                                 // Вычисление переменной v
                        textBox9.Text = Convert.ToString(x);                        // Текст компонента textBox9 присваивает переведенное в тип string значение переменной x
                        textBox10.Text = Convert.ToString(v);                       // Текст компонента textBox10 присваивает переведенное в тип string значение переменной v
                        textBox11.Text = Convert.ToString(a);                       // Текст компонента textBox11 присваивает переведенное в тип string значение переменной a
                    }
                }
            }
            else if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Выберите вид графика", "Ошибка");                  // Вывод сообщения об ошибке в отдельном окне
            }
        }
        private void button4_Click(object sender, EventArgs e)                      // Нажатие на кнопку4
        {
            Application.Exit();                                                     // Выход из программы
        }
        private void button5_Click(object sender, EventArgs e)                      // Нажатие на кнопку5
        {
            double A, w, r, T;                                                      // Создание переменных типа double
            if (textBox3.Text == "" || textBox6.Text == "" || textBox8.Text == "")  // Условие: если текст компонента textBox3 или textBox6 или textBox8 пусто
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Введите амплитуду и вычислите период и циклическую частоту", "Ошибка");// Вывод сообщения об ошибке в отдельном окне
                A = 0;                                                              // Переменная A присваивает значение 0
                T = 0;                                                              // Переменная T присваивает значение 0
                w = 0;                                                              // Переменная w присваивает значение 0
            }
            else
            {
                A = Convert.ToDouble(textBox3.Text);                                // Переменная А присваивает переведенное в тип double значение текста компонента textBox3
                T = Convert.ToDouble(textBox6.Text);                                // Переменная T присваивает переведенное в тип double значение текста компонента textBox6
                w = Convert.ToDouble(textBox8.Text);                                // Переменная w присваивает переведенное в тип double значение текста компонента textBox8
            }
            chart1.ChartAreas[0].AxisY.Maximum = A + 1;                             // Значение максимума оси Y присваивает значение суммы переменной А и 1
            chart1.ChartAreas[0].AxisY.Minimum = (-A) - 1;                          // Значение минимума оси Х присваивает значение разности обратного значения переменной А и 1
            if (radioButton1.Checked == true)                                       // Условие: если компонент radioButton1 был выбран, то есть поставлен флажок
            {
                for (int i = 0; i <= 3 * T; i++)                                    // Цикл: создание переменной i начальным значением 0, диапозон до значения произведения переменной T и 3, с каждым повтором i увеличивается на 1
                {
                    r = w * i;                                                      // Вычисление переменной r
                    chart1.Series[0].Points.AddXY(i, Math.Sin(r) * A);              // Рисование графика по множества точек по координатам x = i и y = sin(r) * A
                }
            }
            if (radioButton2.Checked == true)                                       // Условие: если компонент radioButton2 был выбран, то есть поставлен флажок
            {
                for (int i = 0; i <= 3 * T; i++)                                    // Цикл: создание переменной i начальным значением 0, диапозон до значения произведения переменной T и 3, с каждым повтором i увеличивается на 1
                {
                    r = w * i;                                                      // Вычисление переменной r
                    chart1.Series[0].Points.AddXY(i, Math.Cos(r) * A);              // Рисование графика по множества точек по координатам x = i и y = cos(r) * A
                }
            }
            else if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                SoundPlayer R = new SoundPlayer();                                  // Создание аудиофайла R
                R.SoundLocation = "C:\\Windows\\Media\\Windows Ding.wav";           // Местоположение аудиофайла R
                R.Play();                                                           // Воспроизведение аудиофайла R
                MessageBox.Show("Выберите вид графика", "Ошибка");                  // Вывод сообщения об ошибке в отдельном окне
            }
        }
        private void button6_Click(object sender, EventArgs e)                      // Нажатие на кнопку6
        {
            SoundPlayer S = new SoundPlayer();                                      // Создание аудиофайла R
            S.SoundLocation = "C:\\Windows\\Media\\Windows Startup.wav";            // Местоположение аудиофайла R
            S.Play();                                                               // Воспроизведение аудиофайла R
            Form1 Form2 = new Form1();
            Form2.Show();
            this.Hide();                                                            // Переход на форму1
        }
        private void button7_Click(object sender, EventArgs e)                      // Нажатие на кнопку7
        {
            chart1.Series[0].Points.Clear();                                        // Удаление графика
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)        // Выбор компонента radiobutton3
        {
            label17.Text = "Масса / m, кг";                                         // Изменение текста компонента label17
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)        // Выбор компонента radiobutton4
        {
            label17.Text = "Жесткость пружины / k, Н/м";                            // Изменение текста компонента label17
        }
    }
}