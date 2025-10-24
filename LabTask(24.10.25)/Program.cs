namespace LabTask_24._10._25_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 5, 12, 3, 9, 21, 7 };
            //int maxn = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxn)
            //    {
            //        maxn = numbers[i];
            //    }

            //}
            //Console.WriteLine(maxn);



            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Array.Reverse(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 2, 7, 4, 9, 6, 3, 8 };
            //int[] cut = new int[0];
            //int counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Array.Resize(ref cut,cut.Length+1 );
            //        cut[cut.Length-1] = i;
            //        counter++;
            //    }
            //}
            //foreach (int i in cut)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine();
            //Console.WriteLine(counter);

            //Shape circle=new Circle(5);
            //Shape rectangle = new Rectangle(4, 5);
            //circle.CalculateArea();
            //rectangle.CalculateArea();

            //Console.WriteLine("Heyvan adi daxil edin");
            //string name= Console.ReadLine();
            //Animal cat= new Cat();
            //Animal dog= new Dog();
            //dog.MakeSound(name);
            Employee manager = new Manager("Ilqar", 2000, 300);
            manager.CalculateSalary();
            manager.ShowInfo();
            Employee developer = new Developer("Kamran", 1500, 100,16);
            developer.CalculateSalary();
            developer.ShowInfo();
        }
    }
}
