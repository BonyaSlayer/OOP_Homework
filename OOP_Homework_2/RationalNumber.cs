namespace OOP_Homework
{
    public class RationalNumber
    {
        private int numerator;
        private int denominator;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <exception cref="DivideByZeroException"></exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Вызов первого конструктора со знаменателем равным 1
        public RationalNumber(int number)
            : this(number, 1)
        { }

        // Перегрузка оператора "Равенство" для двух дробей
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            Object aAsObj = a as Object;
            Object bAsObj = b as Object;
            if (aAsObj == null || bAsObj == null)
            {
                return aAsObj == bAsObj;
            }
            return a.Equals(b);
        }

        // Перегрузка оператора "Равенство" для дроби и числа
        public static bool operator ==(RationalNumber a, int b)
        {
            return a == new RationalNumber(b);
        }

        // Перегрузка оператора "Равенство" для числа и дроби
        public static bool operator ==(int a, RationalNumber b)
        {
            return new RationalNumber(a) == b;
        }

        // Перегрузка оператора "Неравенство" для двух дробей
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        // Перегрузка оператора "Неравенство" для дроби и числа
        public static bool operator !=(RationalNumber a, int b)
        {
            return a != new RationalNumber(b);
        }

        // Перегрузка оператора "Неравенство" для числа и дроби
        public static bool operator !=(int a, RationalNumber b)
        {
            return new RationalNumber(a) != b;
        }

        // Equals()
        public override bool Equals(object obj)
        {
            if (obj is not RationalNumber number)
            {
                return false;
            }

            return numerator == number.numerator &&
                   denominator == number.denominator;
        }

        // Пара методу Equals() - GetHashCode
        public override int GetHashCode()
        {
            return numerator * numerator + denominator * denominator;
        }

        /// <summary>
        /// Возвращает наибольший общий делитель
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Возвращает сокращенную дробь
        /// </summary>
        /// <returns></returns>
        public RationalNumber Reduce()
        {
            RationalNumber result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(numerator, denominator);
            result.numerator /= greatestCommonDivisor;
            result.denominator /= greatestCommonDivisor;
            return result;
        }

        // Метод сравнения двух дробей
        // Возвращает	 0, если дроби равны
        //				 1, если this больше that
        //				-1, если this меньше that
        private int CompareTo(RationalNumber that)
        {
            if (Equals(that))
            {
                return 0;
            }
            RationalNumber a = this.Reduce();
            RationalNumber b = that.Reduce();
            if (a.numerator * b.denominator > b.numerator * a.denominator)
            {
                return 1;
            }
            return -1;
        }

        // Перегрузка оператора ">" для двух дробей
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) > 0;
        }
        // Перегрузка оператора ">" для дроби и числа
        public static bool operator >(RationalNumber a, int b)
        {
            return a > new RationalNumber(b);
        }
        // Перегрузка оператора ">" для числа и дроби
        public static bool operator >(int a, RationalNumber b)
        {
            return new RationalNumber(a) > b;
        }
        // Перегрузка оператора "<" для двух дробей
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) < 0;
        }
        // Перегрузка оператора "<" для дроби и числа
        public static bool operator <(RationalNumber a, int b)
        {
            return a < new RationalNumber(b);
        }
        // Перегрузка оператора "<" для числа и дроби
        public static bool operator <(int a, RationalNumber b)
        {
            return new RationalNumber(a) < b;
        }
        // Перегрузка оператора ">=" для двух дробей
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) >= 0;
        }
        // Перегрузка оператора ">=" для дроби и числа
        public static bool operator >=(RationalNumber a, int b)
        {
            return a >= new RationalNumber(b);
        }
        // Перегрузка оператора ">=" для числа и дроби
        public static bool operator >=(int a, RationalNumber b)
        {
            return new RationalNumber(a) >= b;
        }
        // Перегрузка оператора "<=" для двух дробей
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) <= 0;
        }
        // Перегрузка оператора "<=" для дроби и числа
        public static bool operator <=(RationalNumber a, int b)
        {
            return a <= new RationalNumber(b);
        }
        // Перегрузка оператора "<=" для числа и дроби
        public static bool operator <=(int a, RationalNumber b)
        {
            return new RationalNumber(a) <= b;
        }

        // Возвращает наименьшее общее кратное
        private static int getLeastCommonMultiple(int a, int b)
        {
            return a * b / getGreatestCommonDivisor(a, b);
        }

        /// <summary>
        /// Метод создан для устранения повторяющегося кода в методах сложения и вычитания дробей.
        /// Возвращает дробь, которая является результатом сложения или вычитания дробей a и b,
        /// В зависимости от того, какая операция передана в параметр operation.
        /// P.S. использовать только для сложения и вычитания
        /// </summary>
        /// <param name="a">дробь1</param>
        /// <param name="b">дробь2</param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static RationalNumber performOperation(RationalNumber a, RationalNumber b, Func<int, int, int> operation)
        {
            // Наименьшее общее кратное знаменателей
            int leastCommonMultiple = getLeastCommonMultiple(a.denominator, b.denominator);
            // Дополнительный множитель к первой дроби
            int additionalMultiplierFirst = leastCommonMultiple / a.denominator;
            // Дополнительный множитель ко второй дроби
            int additionalMultiplierSecond = leastCommonMultiple / b.denominator;
            // Результат операции
            int operationResult = operation(a.numerator * additionalMultiplierFirst,
            b.numerator * additionalMultiplierSecond);
            return new RationalNumber(operationResult, a.denominator * additionalMultiplierFirst);
        }

        // Перегрузка оператора "+" для случая сложения двух дробей
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return performOperation(a, b, (int x, int y) => x + y);
        }
        // Перегрузка оператора "+" для случая сложения дроби с числом
        public static RationalNumber operator +(RationalNumber a, int b)
        {
            return a + new RationalNumber(b);
        }
        // Перегрузка оператора "+" для случая сложения числа с дробью
        public static RationalNumber operator +(int a, RationalNumber b)
        {
            return b + a;
        }

        // Перегрузка оператора "++"
        public static RationalNumber operator ++(RationalNumber a)
        {
            return a + 1;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return $"{numerator }/{denominator}";
        }
    }
}
