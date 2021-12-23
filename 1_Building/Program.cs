using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Building
{
    class Program
    {
        /*
         * В блоке ввода данных осуществляется получение пользовательских (User) данных в соответствующие переменные.
         * Создается экземпляр класса Building с параметрами пользовательских данных. Далее осуществляется вывод данных методом Print().
         * Предусмотрена обработка исключений в методе Main где наиболее вероятно их появление из-за некорректности ввода пользовательских
         * параметров.
         * 
         * В классе Building реализован конструктор и аксессоры для каждой переменной, в которых осуществляется проверка на
         * отрицательные значения длины, ширины, высоты дома и в случае подтверждения, происходит вывод соответствующего сообщения
         * и замена на значение по умлочанию 1. Для адреса осуществляется проверка строки с помощью тернарного оператора на пустоту
         * или null, и при подтверждении адресу присваивается значение "Без адреса". Свойства установлены с модификатором private
         * для ограничения доступа к ним только внутри класса.
         * 
         * Класс MultiBuilding наследуется от Building. Входные параметры адрес, длина, ширина передаются в родительский конструктор,
         * этажность обрабатывается в конструкторе MultiBuilding, реализовано автосвойство. В методе Print осуществляется вызов метода
         * Print родительского класса и добавляется новое значение этажности дочернего класса. От класса MultiBuilding унаследоваться
         * нельзя. Применен модификатор sealed.
         */

        static void Main(string[] args)
        {
            try
            {
                #region Ввод данных
                Console.Write("Введите адрес дома: ");
                string adressUser = Console.ReadLine();
                Console.Write("Введите длину дома: ");
                double lenghtUser = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ширину дома: ");
                double widthUser = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту дома: ");
                double heightUser = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите кол-во этажей: ");
                byte floorsUser = Convert.ToByte(Console.ReadLine());
                #endregion
                Building firstHome = new Building(adressUser, lenghtUser, widthUser, heightUser);
                MultiBuilding secondHome = new MultiBuilding(adressUser, lenghtUser, widthUser, heightUser, floorsUser);
                Console.WriteLine("\tРабота класса Building\n"+firstHome.Print());
                Console.WriteLine("\tРабота класса MultiBuilding\n" + secondHome.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
