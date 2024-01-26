using System;
// ReSharper disable InvalidXmlDocComment

namespace Sample
{
    public static class LessonConstructions
    {
        // Максимальное количество баллов = 10

        ///Пример: Найти число корней квадратного уравнения ax^2 + bx + c = 0
        public static int QuadraticRootNumber(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c);

            if (discriminant > 0)
            {
                return 2;
            }

            if (discriminant == 0)
            {
                return 1;
            }

            return 0;
        }
        
        public static double Discriminant(double a, double b, double c) => Sqr(b) - 4 * a * c;
        public static double Sqr(double x) => x * x;

        ///Пример: Получить строковую нотацию для оценки по пятибалльной системе
        public static string GradeNotation(int grade)
        {
            return grade switch
            {
                5 => "отлично",
                4 => "хорошо",
                3 => "удовлетворительно",
                2 => "неудовлетворительно",
                _ => "несуществующая оценка $grade",
            };
        }

        ///Пример: Вычисление факториала 
        public static double Factorial(int n)
        {
            double result = 1.0;
            
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        
        /**
         * Тривиальная (1 балл)
         *
         * Мой возраст. Для заданного 0 < n < 200, рассматриваемого как возраст человека,
         * вернуть строку вида: «21 год», «32 года», «12 лет».
         */
        public static string AgeDescription(int age)
        {
            switch (age) {
                case 1:
                case 21:
                case 31:
                case 41:
                case 51:
                case 61:
                case 71:
                case 81:
                case 91:
                case 101:
                case 121:
                case 131:
                case 141:
                case 151:
                case 161:
                case 171:
                case 181:
                case 191: 
                    return $"{age} год";
                case 2:
                case 3:
                case 4:
                case 22:
                case 23:
                case 24:
                case 32:
                case 33:
                case 34:
                case 42:
                case 43:
                case 44:
                case 52:
                case 53:
                case 54:
                case 62:
                case 63:
                case 64:
                case 72:
                case 73:
                case 74:
                case 82:
                case 83:
                case 84:
                case 92:
                case 93:
                case 94:
                case 102:
                case 103:
                case 104:
                case 122:
                case 123:
                case 124:
                case 132:
                case 133:
                case 134:
                case 142:
                case 143:
                case 144:
                case 152:
                case 153:
                case 154:
                case 162:
                case 163:
                case 164:
                case 172:
                case 173:
                case 174:
                case 182:
                case 183:
                case 184:
                case 192:
                case 193:
                case 194:
                    return $"{age} года";
                default:
                    return $"{age} лет";
            }
            // throw new NotImplementedException();
        }

        /**
         * Простая (2 балла)
         *
         * Нa шахматной доске стоят черный король и две белые ладьи (ладья бьет по горизонтали и вертикали).
         * Определить, не находится ли король под боем, а если есть угроза, то от кого именно.
         * Вернуть 0, если угрозы нет, 1, если угроза только от первой ладьи, 2, если только от второй ладьи,
         * и 3, если угроза от обеих ладей.
         * Считать, что ладьи не могут загораживать друг друга
         */
        public static int WhichRookThreatens(
            int kingX, int kingY,
            int rookX1, int rookY1,
            int rookX2, int rookY2
        )
        {
            if (kingX == rookX1 || kingY == rookY1) {
                if (kingX == rookX2 || kingY == rookY2) {
                    return 3;
                } else {
                    return 1;
                }
            } else if (kingX == rookX2 || kingY == rookY2) {
                return 2;
            } else {
                return 0;
            }
            // throw new NotImplementedException();
        }

        /**
         * Средняя (2 балла)
         *
         * Треугольник задан длинами своих сторон a, b, c.
         * Проверить, является ли данный треугольник остроугольным (вернуть 0),
         * прямоугольным (вернуть 1) или тупоугольным (вернуть 2).
         * Если такой треугольник не существует, вернуть -1.
         */
        public static int TriangleKind(double a, double b, double c)
        {   
            double maxNum = 0;
            double sumNum = 0;
            if (a > b && a > c) {
                maxNum = Math.Pow(a,2);
                sumNum = Math.Pow(b,2) + Math.Pow(c,2);
            } else if (b > a && b > c) {
                maxNum = Math.Pow(b,2);
                sumNum = Math.Pow(a,2) + Math.Pow(c,2);
            } else {
                maxNum = Math.Pow(c,2);
                sumNum = Math.Pow(a,2) + Math.Pow(b,2);
            }
            if (maxNum < sumNum) {
                return 0;
            } else if (maxNum == sumNum) {
                return 1;
            } else if (maxNum > sumNum) {
                return 2;
            } else {
                return -1;
            }
            // throw new NotImplementedException();
        }

        /**
         * Тривиальная (1 балла)
         *
         * Найти число Фибоначчи из ряда 1, 1, 2, 3, 5, 8, 13, 21, ... с номером n.
         * Ряд Фибоначчи определён следующим образом: fib(1) = 1, fib(2) = 1, fib(n+2) = fib(n) + fib(n+1)
         */
        public static int Fibonacci(int n)
        {
            int a1 = 0;
            int a2 = 1;
            int sum = 1;
            for (int i = 1; i < n; i++) {
                sum = a1 + a2;
                a1 = a2;
                a2 = sum;
                
            } return sum;
            // throw new NotImplementedException();
        }

        /**
         * Простая (2 балла)
         *
         * Для заданного числа n > 1 найти минимальный делитель, превышающий 1
         */
        public static int MinDivisor(int n)
        {
            int number = 0;
            for (int i = 2; i <= n; i++) {
                if (n % i == 0) {
                    number = i;
                    return number;
                    }
            } return number;
            // throw new NotImplementedException();
        }

        /**
         * Средняя (2 балла)
         *
         * Поменять порядок цифр заданного числа n на обратный: 13478 -> 87431.
         *
         * Использовать операции со строками в этой задаче запрещается!
         */
        public static int Revert(int n)
        {
            int result = 0;
            while (n > 0) {
                result = result * 10 + n % 10;
                n /= 10;
            }
            return result;
        }
    }
}