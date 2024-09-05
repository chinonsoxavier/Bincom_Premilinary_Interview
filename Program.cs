using System;
namespace Bincom_Premilinary_Interview {
    class MyProgram {
        static void Task1(){
       string name = "John Doe";
        Console.WriteLine(name);

        int age = 25;
        Console.WriteLine(age);

        bool isAdmin = true;
        Console.WriteLine(isAdmin);
        }

        
        static void Task2() {
           Console.WriteLine("Enter your age:");
            int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0) {
                    Console.WriteLine("Even.");
                } else {
                    Console.WriteLine("Odd.");
                }
        }

        static void Task3(){
            for(int i = 0; i <=10;i++){
                Console.WriteLine("Task 3 " + i);
            }
        }

        static void Task4(){
            int[] myArray = [2, 4, 6, 8,10];
            int sum = 0;
            for(int i = 0;i < myArray.Length;i++){
                sum += myArray[i];
            }
            Console.WriteLine("Task 4 Sum :" + sum);
            foreach (var item in myArray)
            {
                Console.WriteLine("Task 4:"+ item);
            }

        }

        static void Greet(string name){
                Console.WriteLine("Hello, " + name + "!");
        }
        static void Main(string[] args)
        {
            // Task 1;
            Task1();
           //   Task2;
            Task2();
            // Task 3;
            Task3();
            // Task 4;
            Task4();
            // Task 5
            Greet("Alice");
        }
    }
}