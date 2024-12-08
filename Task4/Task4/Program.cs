namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры символ. Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо, влево
            //в зависимости от введенного символа (W, S, A, D). Вывести результат решения на экран.
            //В случае отсутствия необходимости перемещения вывести соответствующее сообщение.
            Console.WriteLine("Программа перемещает @ в одно из направлений. Исходное состояние: \n\n\t@\n");
            Console.WriteLine("Для перемещения фигуры введите:\nВверх - W;\nВниз - S;\nВраво - D;\nВлево - A.");
            var move = Console.ReadLine().ToUpper();
            switch (move)
            {
                case "W":
                    Console.WriteLine("Фигура премещается вверх: \n\t@\n");
                    break;
                case "S":
                    Console.WriteLine("Фигура премещается вниз: \n\n\n\t@\n");
                    break;
                case "A":
                    Console.WriteLine("Фигура премещается влево: \n\n@\n");
                    break;
                case "D":
                    Console.WriteLine("Фигура премещается вправо: \n\n\t\t@\n");
                    break;
                default:
                    Console.WriteLine("Фигура не перемещается: \n\n\t@\n");
                    break;

            }

        }
    }
}
