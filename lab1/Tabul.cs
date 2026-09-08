namespace lab1
{
    internal class Tabul
    {
        //поле з результуючим масивом(що виводиться?)
        public double[,] xy = new double[1000, 2];
        //реальна кількість елементів в масиів
        public int n = 0;

        //метод для обрахунку ф. (три за варіантом)
        private double f1(double x)
        {
            return Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x;
        }
        private double f2(double x)
        {
            return Math.Exp(-x) + Math.Pow(x, 1.0 / 4.0);
        }
        private double f3(double x)
        {
            return Math.Log((Math.Pow(x, 3) + x * x));
        }

        //метод табулювання(записування в таблицю?) за трьома варіантами
        public void tab(double xn = -1.78, double xk = 11.99, double h = 0.1, double a = 0.5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else { y = f3(x); }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
