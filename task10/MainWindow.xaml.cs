using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace task10
{
    public partial class MainWindow : Window
    {

        DispatcherTimer timer2 = new DispatcherTimer();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer3 = new DispatcherTimer();
        int b1=0,b2=0,b3=0,b4=0,b5=0,b6=0,b7=0,b8=0,b9=0,b10=0,b11=0,b12=0;
        int score = 0,f1=0,f2=0,f3=0,f4=0,f5=0,f6=0;

        int final = 0;
        int inc = 0;
        int inc2 = 0;
        int min = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void StartClock()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        public void question_clock()
        {
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer2.Tick += tickevent1;
            timer2.Start();
        }

        public void check()
        {
            if (b1 == 1 && b11 == 1)
            {
                eleven.IsEnabled = false;
                one.IsEnabled = false;
                score += 50;
                b1 = 0; b11 = 0;
                scorebox.Text = Convert.ToString(score);
                final++;f1 = 1;
            }
            else if (b2 == 1 && b12 == 1)
            {
                two.IsEnabled = false;
                twelve.IsEnabled = false;
                score += 50;
                scorebox.Text = Convert.ToString(score);
                b2 = 0; b12 = 0;
                final++;f2 = 1;
            }
            else if (b3 == 1 && b7 == 1)
            {
                seven.IsEnabled = false;
                three.IsEnabled = false;
                score += 50;
                scorebox.Text = Convert.ToString(score);
                b3 = 0; b7 = 0;
                final++; f3 = 1;
            }
            else if (b4 == 1 && b5 == 1)
            {
                four.IsEnabled = false;
                five.IsEnabled = false;
                score += 50;
                scorebox.Text = Convert.ToString(score);
                b4 = 0; b5 = 0;
                final++; f4 = 1;
            }
            else if (b6 == 1 && b8 == 1)
            {
                six.IsEnabled = false;
                eight.IsEnabled = false;
                score += 50;
                scorebox.Text = Convert.ToString(score);
                b6 = 0; b8 = 0;
                final++; f5 = 1;
            }
            else if (b9 == 1 && b10 == 1)
            {
                nine.IsEnabled = false;
                ten.IsEnabled = false;
                score += 50;
                scorebox.Text = Convert.ToString(score);
                b9 = 0; b10 = 0;
                final++; f6 = 1;
            }
            if (final == 6)
            {
                timer.Stop();
                timer2.Stop();
                result.Text += min +":"+inc;
                result.Visibility=System.Windows.Visibility.Visible;
            }
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\one.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            oneimg.Source = bitmap;
            bitmap.EndInit();
            b1 = 1;
            check();
        }
        private void two_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\three.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            twoimg.Source = bitmap;
            bitmap.EndInit();
            b2 = 1;
            check();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\two.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            threeimg.Source = bitmap;
            bitmap.EndInit();
            b3 = 1;
            check();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\six.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            fourimg.Source = bitmap;
            bitmap.EndInit();
            b4 = 1;
            check();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\five.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            siximg.Source = bitmap;
            bitmap.EndInit();
            b6 = 1;
            check();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\two.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            sevenimg.Source = bitmap;
            bitmap.EndInit();
            b7 = 1;
            check();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\five.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            eightimg.Source = bitmap;
            bitmap.EndInit();
            b8 = 1;
            check();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\four.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            nineimg.Source = bitmap;
            bitmap.EndInit();
            b9 = 1;
            check();
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\four.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            tenimg.Source = bitmap;
            bitmap.EndInit();
            b10 = 1;
            check();
        }

        private void eleven_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\one.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            elevenimg.Source = bitmap;
            bitmap.EndInit();
            b11 = 1;
            check();
        }

        private void twelve_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\three.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            twelveimg.Source = bitmap;
            bitmap.EndInit();
            b12 = 1;
            check();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\six.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            fiveimg.Source = bitmap;
            bitmap.EndInit();
            b5 = 1;
            check();
        }


        private void tickevent1(object sender, EventArgs e)
        {
            inc2++;
            int pr = 7;
            progress.Value += pr;
            if (inc2 % 5 == 0)
            {
                progress.Value = 0;
                rotateimg();
                inc2 = 0;
                if (f1 != 1)
                {
                    one.IsEnabled = true;
                    eleven.IsEnabled = true;
                }
                if (f2 != 1)
                {
                    twelve.IsEnabled = true;
                    two.IsEnabled = true;
                }
                if (f3 != 1)
                {
                    three.IsEnabled = true;
                    seven.IsEnabled = true;
                }
                if (f4 != 1)
                {
                    four.IsEnabled = true;
                    five.IsEnabled = true;
                }
                if (f5 != 1)
                {
                    six.IsEnabled = true;
                    eight.IsEnabled = true;
                }
                if (f6 != 1)
                {
                    nine.IsEnabled = true;
                    ten.IsEnabled = true;
                }

            }
            else
            {
                int check = 0;
                check = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11 + b12;
                if (check >= 2)
                {
                    one.IsEnabled = false;
                    two.IsEnabled = false;
                    three.IsEnabled = false;
                    four.IsEnabled = false;
                    five.IsEnabled = false;
                    six.IsEnabled = false;
                    seven.IsEnabled = false;
                    eight.IsEnabled = false;
                    nine.IsEnabled = false;
                    ten.IsEnabled = false;
                    eleven.IsEnabled = false;
                    twelve.IsEnabled = false;
                }
            }
        }
        void rotateimg()
        {
            string file = "D:\\My\\PUCIT\\semester 7\\EAD\\Assignments\\assignment 1\\task10\\question.png";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(file);
            if (b1 == 1)
            {
                oneimg.Source = bitmap;
                b1 = 0;
            }
            if (b2 == 1)
            {
                twoimg.Source = bitmap;
                b2 = 0;
            }
            if (b3 == 1)
            {
                threeimg.Source = bitmap;
                b3 = 0;
            }
            if (b4 == 1)
            {
                fourimg.Source = bitmap;
                b4 = 0;
            }
            if (b5 == 1)
            {
                fiveimg.Source = bitmap;
                b5 = 0;
            }
            if (b6 == 1)
            {
                siximg.Source = bitmap;
                b6 = 0;
            }
            if (b7 == 1)
            {
                sevenimg.Source = bitmap;
                b7 = 0;
            }
            if (b8 == 1)
            {
                eightimg.Source = bitmap;
                b8 = 0;
            }
            if (b9 == 1)
            {
                nineimg.Source = bitmap;
                b9 = 0;
            }
            if (b10 == 1)
            {
                tenimg.Source = bitmap;
                b10 = 0;
            }
            if (b11 == 1)
            {
                elevenimg.Source = bitmap;
                b11 = 0;
            }
            if (b12 == 1)
            {
                twelveimg.Source = bitmap;
                b12 = 0;
            }
            bitmap.EndInit();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartClock();
            question_clock();
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = true;
            nine.IsEnabled = true;
            ten.IsEnabled = true;
            eleven.IsEnabled = true;
            twelve.IsEnabled = true;
            button.IsEnabled = false;
        }

        private void tickevent(object sender, EventArgs e)
        {
            inc++;
            if (inc % 60 == 0)
            {
                inc = 0;
                min++;
            }
            time.Content = min + ":"+ inc.ToString();            
        }
    }
}
