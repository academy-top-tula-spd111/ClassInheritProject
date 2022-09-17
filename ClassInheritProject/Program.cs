namespace ClassInheritProject
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            //Console.WriteLine("Person construct");
            Name = name;
            Age = age;
        }

        public Person() : this("Anonim", 0) { }

        public void Print()
        {
            Console.Write($"{Name} <{Age}>");
        }
        public virtual void Show()
        {
            Console.Write($"{Name} <{Age}>");
        }

        public override string ToString()
        {
            return $"{Name} <{Age}>";
        }

        public override bool Equals(object? obj)
        {
            return (this.Name == (obj as Person).Name) 
                && (this.Age == (obj as Person).Age);
        }
    }

    class User : Person
    {
        public string Login { set; get; }
        public User(string name, int age, string login = "aaaaa") : base(name, age)
        {
            //Console.WriteLine("User construct");
            Login = login;
        }   

        public User() : base() 
        {
            Login = "member";
        }

        public new void Print()
        {
            base.Print();
            Console.Write($" ({Login})");
        }

        public override void Show()
        {
            base.Show();
            Console.Write($" ({Login})");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({Login})";
        }
    }

    class Employe : Person
    {
        public int Id { set; get; }
        public Employe(string name, int age, int id = 0) : base(name, age)
        {
            //Console.WriteLine("User construct");
            Id = id;
        }

        public Employe() : base()
        {
            Id = 0;
        }

        public new void Print()
        {
            base.Print();
            Console.Write($" ({Id})");
        }

        public override void Show()
        {
            base.Show();
            Console.Write($" ({Id})");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({Id})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bob", 24);
            User user = new User("Joe", 31, "joelim");
            Employe employe = new Employe("Tim", 22, 123);

            Person man = person;
            man.Show();
            Console.WriteLine();

            man = user;
            man.Show();
            Console.WriteLine();

            man = employe;
            man.Show();
            Console.WriteLine();

            person = new User();

            //(person as User).Show();
            //Console.WriteLine();

            float x = 10.5f;
            int n = (int)x;

            if (person is User)
            {
                user = person as User;
                user.Show();
            }
            else
                Console.WriteLine("Not User!!!");
            
            Console.WriteLine();

            //Console.WriteLine(person);
            //Console.WriteLine(user);

            //person.Print();
            //Console.WriteLine();
            //user.Print();
            //Console.WriteLine();

            ////person = user;

            //Person user2 = new User("Tim", 17);
            //user2.Print();
            //Console.WriteLine();

            //Console.WriteLine("-------- Show --------\n");

            //person.Show();
            //Console.WriteLine();

            //user.Show();
            //Console.WriteLine();

            //user2.Show();
            //Console.WriteLine();
        }
    }
}