
using System;
using System.Collections.Generic;
using System.Collections;

namespace _3._6AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Cat> cats = new LinkedList<Cat>();
            LinkedList<Dog> dogs = new LinkedList<Dog>();
            int order = 0;
            CreateMainList(cats, dogs, order);
            WriteCatlist(cats);
            WriteDoglist(dogs);
            order = dogs.Count + cats.Count;

            //Enqueue
            /*Cat addLastCat = new Cat() { Name = "Catt", Order = order + 2 };
            Dog addLastDog = new Dog() { Name = "Dogg", Order = order + 1 };
            Enqueue(addLastCat, cats, dogs);
            Enqueue(addLastDog, cats, dogs);
            */

            //Dequeue
            //DequeueAny(cats,dogs);



            Console.WriteLine("New Lists");
            WriteCatlist(cats);
            WriteDoglist(dogs);


        }

        public static void CreateMainList(LinkedList<Cat> cats, LinkedList<Dog> dogs, int order)
        {

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if (random.Next(0, 2) % 2 == 0)
                {
                    order++;
                    Cat cat = new Cat();
                    cat.Name = "Cat" + i;
                    cat.Order = order;
                    cats.AddLast(cat);
                }
                else
                {
                    order++;
                    Dog dog = new Dog();
                    dog.Name = "Dog" + i;
                    dog.Order = order;
                    dogs.AddLast(dog);
                }
            }

        }

        public static void DequeueAny(LinkedList<Cat> cats, LinkedList<Dog> dogs)
        {
            if (cats.First.Value.Order < dogs.First.Value.Order||dogs.Count==0) cats.RemoveFirst();
            else dogs.RemoveFirst();
        }


        public static void Enqueue(Animal animal, LinkedList<Cat> cats, LinkedList<Dog> dogs)
        {
            if (animal is Dog)
            {
                Dog lastDog = new Dog();
                lastDog.Name = animal.Name;
                lastDog.Order = animal.Order;
                dogs.AddLast(lastDog);
            }
            else if (animal is Cat)
            {
                Cat lastCat = new Cat();
                lastCat.Name = animal.Name;
                lastCat.Order = animal.Order;
                cats.AddLast(lastCat);
            }
        }

        public static void WriteDoglist(LinkedList<Dog> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Name : " + item.Name + " Order : " + item.Order);
            }
            Console.WriteLine();
        }
        public static void WriteCatlist(LinkedList<Cat> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Name : " + item.Name + " Order : " + item.Order);
            }
            Console.WriteLine();
        }


    }
}



