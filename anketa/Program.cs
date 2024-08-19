namespace anketa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string secname, string login, bool pet, int age, string[] favcolor, int loglegth) anketa;

            for (int k = 0; k < 3; k++) 
            {
                Console.Write("Имя пользователя: ");
                anketa.name = Console.ReadLine();

                Console.Write("Введите возраст с цифрами: ");
                anketa.age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите фамилию: ");
                anketa.secname = Console.ReadLine();

                Console.WriteLine("Придумайте логин: ");
                anketa.login = Console.ReadLine();

                Console.WriteLine("Есть ли у вас домашнгие дживотные? да или нет: ");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    anketa.pet = true;
                }
                {
                    anketa.pet = false;
                }

                anketa.loglegth = anketa.login.Length;

                anketa.favcolor = new string[3];
                Console.WriteLine("назовите 3 любимых цвета");
                for (int i = 0; i < anketa.favcolor.Length; i++)
                {
                    anketa.favcolor[i] = Console.ReadLine();
                }

                Console.WriteLine("Ваше имя: {0}", anketa.name);
                Console.WriteLine("Ваш возраст: {0}", anketa.age);
                Console.WriteLine("длинна логина {0}", anketa.loglegth);
                Console.WriteLine("наличие домашних животных {0}", anketa.pet);
                Console.WriteLine("Фамилия: {0}", anketa.secname);
                Console.WriteLine("логин: {0}", anketa.login);
                Console.WriteLine("Любимый цвет/цвета: {0} ", anketa.favcolor);
                Console.ReadKey();

            }
        }
    }
}
