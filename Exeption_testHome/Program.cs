using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_testHome
{
    class Program
    {
        class BooleanExpression
        {
            private string[] str;

            public BooleanExpression()
            {
                str = null;
            }
            public bool Input()
            {
                bool answer;
                Console.Write("Введите ваше варажение -> ");
                string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                int[] numbers = new int[str.Length - 1];
                int j = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    bool index = char.IsLetter(str[i], i);
                    if (index == true)
                        throw new Exception("!!!Некорректный ввод выражения, вы ввели букву!!!");

                    if (str[i] == ">" || str[i] == "<" || str[i] == ">=" || str[i] == "<=" || str[i] == "==" || str[i] == "!=")
                    {
                    }
                    else
                    {
                        numbers[j] = Convert.ToInt32(str[i]);
                        j++;
                    }
                }
                try
                {

                    if (numbers[0] < numbers[1] && str[1] == "<") return NewMethod(out answer);

                    if (numbers[0] > numbers[1] && str[1] == ">") return NewMethod(out answer);

                    if (numbers[0] <= numbers[1] && str[1] == "<=") return NewMethod(out answer);

                    if (numbers[0] >= numbers[1] && str[1] == ">=") return NewMethod(out answer);

                    if (numbers[0] == numbers[1] && str[1] == "==") return NewMethod(out answer);

                    if (numbers[0] != numbers[1] && str[1] == "!=") return NewMethod(out answer);

                    return answer = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }

            private static bool NewMethod(out bool answer)
            {
                return answer = true;
            }
        }

        class Passport
        {
            private string name;
            private string numberPassport;
            private int day;
            private int month;
            private int year;
            public Passport()
            {
                name = null;
                numberPassport = null;
                day = 0;
                month = 0;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string NumberPassport
            {
                get => numberPassport;
                set => numberPassport = value;
            }
            public int Day
            {
                get => day;
                set => day = value;
            }
            public int Month
            {
                get => month;
                set => month = value;
            }
            public int Year
            {
                get => year;
                set => year = value;
            }
            public void Input()
            {
                try
                {
                    Console.Write("Введите номер паспорта: ");
                    numberPassport = Console.ReadLine();
                    char[] num = numberPassport.ToCharArray();
                    if (num.Length != 8)
                        throw new Exception("!!!Неправильный номер паспорта!!!");
                    for (int i = 0; i < num.Length; i++)
                    {
                        bool index = char.IsLetter(numberPassport, i);
                        if (index == true && (i != 0 && i != 1))
                            throw new Exception("!!!Некорректный ввод номера паспорта, вы ввели букву, вместо цифры!!!");
                        if (index == false && (i == 0 || i == 1))
                            throw new Exception("!!!Некорректный ввод номера паспорта, вы ввели цифру, вместо буквы!!!");
                    }

                    Console.Write("Введите ФИО: ");
                    name = Console.ReadLine();

                    Console.Write("Введите дату выдачи карты \nДень: ");
                    day = Convert.ToInt32(Console.ReadLine());
                    if (day > 31 || day < 1)
                        throw new Exception("!!!Некорректный ввод дня!!!");

                    Console.Write("Месяц: ");
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month > 12 || month < 1)
                        throw new Exception("!!!Некорректный ввод месяца!!!");

                    Console.Write("Год: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    if (year > 2027 || year < 2022)
                        throw new Exception("!!!некорректный ввод года!!!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public override string ToString()
            {
                return $"Номер паспорта: {numberPassport}\nФИО: {name}\nДата выдачи паспорта: {day}/{month}/{year}";
            }
        }
        static void Main(string[] args)
        {
            //Passport passport = new Passport();
            //passport.Input();
            //passport.ToString();

            BooleanExpression booleanExpression = new BooleanExpression();
            Console.WriteLine(booleanExpression.Input());
        }

    }
}
