namespace fgfg
{
    class Employee
    {


        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        #region constructor
        public Employee()
        {
            id = 1;
            age = 1;
            name = string.Empty;
            address = string.Empty;
        }

        public Employee(int id) : this()
        {
            this.id = id;

        }

        public Employee(int id, string name) : this()
        {
            this.id = id;
            this.name = name;
        }
        public Employee(int id, string name, int age) : this()
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Employee(int id, string name, int age, String address)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
        }


        #endregion



        public string getString()
        {
            return $"id = {id} ,name = {name} ,age ={age} ,address ={address}";
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.getString());

            employee.name = "safaa";
            employee.id = 1;
            employee.age = 30;
            employee.address = "benha";

            Console.WriteLine(employee.getString());


            Console.WriteLine("Enter number of Employees");
            int num = int.Parse(Console.ReadLine());

            Employee[] employee1 = new Employee[num];

            for (int i = 0; i < num; i++)
            {
                employee1[i] = new Employee();

                Console.WriteLine($"Enter Id of Emplyee {i + 1}");
                employee1[i].id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Age of Emplyee {i + 1}");
                employee1[i].age = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Name of Emplyee {i + 1}");
                employee1[i].name = Console.ReadLine();

                Console.WriteLine($"Enter Address of Emplyee {i + 1}");
                employee1[i].address = Console.ReadLine();



            }

            for (int i = 0; i < num; i++)
            {

                Console.WriteLine($"Date of Employee {i + 1} = {employee1[i].getString()}");

            }







        }
    }

}