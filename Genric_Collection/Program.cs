namespace genric_collection
{
    public class GenericClass1<T> where T : struct
    {
        public T msg1;

        public void GenericMethod(T value1, T value2)
        {
            Console.WriteLine($"\nMessage: {msg1}");
            Console.WriteLine($"Param1: {value1}");
            Console.WriteLine($"Param2: {value2}\n");
        }
    }

    public class ClsCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    public class GenericClass<T>
    {
        public T Message;

        public void GenericMethod(T Name, T Location)
        {
            Console.WriteLine($"\nMessage: {Message}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}\n");
        }
    }

    public class SomeClass
    {
        public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)
        {
            Console.WriteLine($"Parameter T1 type: {typeof(T1)}: Parameter T2 type: {typeof(T2)}");
            Console.WriteLine($"Parameter 1: {Param1} : Parameter 2: {Param2}");
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Base * Height;
        }
    }

    public class ShapeProcessor<TShape> where TShape : Shape, new()
    {
        public void ProcessShape(double dimension1, double dimension2)
        {
            TShape shape = new TShape();

            if (shape is Rectangle rectangle)
            {
                rectangle.Width = dimension1;
                rectangle.Height = dimension2;
            }
            else if (shape is Triangle triangle)
            {
                triangle.Base = dimension1;
                triangle.Height = dimension2;
            }

            double area = shape.CalculateArea();
            Console.WriteLine($"The area of the shape is: {area}");
        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            ShapeProcessor<Rectangle> rectangleProcessor = new ShapeProcessor<Rectangle>();
            rectangleProcessor.ProcessShape(5, 3);
            ShapeProcessor<Triangle> triangleProcessor = new ShapeProcessor<Triangle>();
            triangleProcessor.ProcessShape(4, 6);
            Console.ReadKey();



            SomeClass s = new SomeClass();
            s.GenericMethod<int, int>(10, 20);
            s.GenericMethod<double, string>(10.5, "Hello");
            s.GenericMethod<string, float>("Hii", 20.5f);
            Console.ReadLine();


            GenericClass<string> myGenericClass = new GenericClass<string>
            {
                Message = "Welcome to India"
            };
            myGenericClass.GenericMethod("Tharun", "India");


            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            bool IsEqual1 = ClsCalculator.AreEqual<string>("Program", "program");
            if (IsEqual1)
            {
                Console.WriteLine("Both are Equal\n");
            }
            else
            {
                Console.WriteLine("Both are Not Equal\n");
            }


            GenericClass1<int> intClass = new GenericClass1<int>();
            intClass.msg1 = 30;
            intClass.GenericMethod(10, 20);
            //GenericClass1<string> stringClass = new GenericClass1<string>();


            List<dynamic> myList = new List<dynamic>();
            Console.WriteLine("Enter a string:");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter an integer:");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Enter a Double:");
            string userInput3 = Console.ReadLine();

            myList.Add(Convert.ChangeType(userInput1, typeof(string)));
            myList.Add(Convert.ChangeType(userInput2, typeof(int)));
            myList.Add(Convert.ChangeType(userInput3, typeof(double)));

            string str1 = myList[0];
            int num = myList[1];
            double date = myList[2];

            Console.WriteLine("String: " + str1);
            Console.WriteLine("Integer: " + num);
            Console.WriteLine("Double: " + date);

            /* //Dictionary
           Dictionary<int, string> GenericDictionary = new Dictionary<int, string>();
           GenericDictionary.Add(1, "Soda");
           GenericDictionary.Add(2, "Burger");
           GenericDictionary.Add(3, "Cola");
           GenericDictionary.Add(4, "Onion Rings");
           foreach (KeyValuePair<int, string> kvp in GenericDictionary)
           {
               Console.WriteLine(kvp.Key + " " + kvp.Value);
           }

           //SortedList
           SortedList<int, string> sortedList = new SortedList<int, string>();
           sortedList.Add(3, "Apple");
           sortedList.Add(1, "Orange");
           sortedList.Add(2, "Banana");
           Console.WriteLine(sortedList[1]);
           sortedList[1] = "Pineapple";
           Console.WriteLine(sortedList[1]);
           sortedList.Remove(2);
           Console.WriteLine(sortedList.ContainsKey(2));
           foreach (KeyValuePair<int, string> pair in sortedList)
           {
               Console.WriteLine(pair.Key + ": " + pair.Value);
           }

           //Stack
           Stack<string> steak = new Stack<string>();
           steak.Push("Rare");
           steak.Push("Medium Rare");
           steak.Push("Medium");
           steak.Push("Well done");
           foreach (string s in steak)
           {
               Console.WriteLine(s);
           }

           //Queue
           Queue<string> Queue = new Queue<string>();
           Queue.Enqueue("Mark");
           Queue.Enqueue("Bill");
           Queue.Enqueue("Xavier");
           Queue.Enqueue("Michael");
           Console.WriteLine(Queue.Peek());
           string firstElement = Queue.Dequeue();
           Console.WriteLine(firstElement);
           foreach (string ss in Queue)
           {
               Console.WriteLine(ss);
           }*/
        }
    }
}