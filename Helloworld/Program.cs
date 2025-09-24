namespace Helloworld
{
    class Program
    {
        static void Main()
        {
            /*Data type
            int myNum = 5;
            double myDoubleNum = 5.990;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            int? myNewVar = null;
            var Name = "Maribel";*/

            /*Console.WriteLine($"Hello World {Name}");
            Console.WriteLine($"Thanks for comming {myNewVar}");
            Console.WriteLine();*/

            DateOnly dateConverted = new DateOnly();
            string nameIn;
            string birthdayIn;
            Console.WriteLine("Bienvenido al calculador de años");
            Console.WriteLine("Escriba su nombre");
            nameIn = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameIn}");
            Console.WriteLine("¿Cual es tu fecha de nacimiento de nacimiento en formato dd/mm/yy?");
            birthdayIn = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayIn, out dateConverted);
            if(isDateValid==false) Console.WriteLine($"La fecha es erronea {birthdayIn}");
            var person = new Person
            {
                Name = nameIn,
                Birthday = dateConverted,
                Age = System.DateTime.Now.Year - dateConverted.Year

            };
            Console.WriteLine($"Nombre: {person.Name}");
            Console.WriteLine($"Nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad: {person.Age} años");


            Console.WriteLine();

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
