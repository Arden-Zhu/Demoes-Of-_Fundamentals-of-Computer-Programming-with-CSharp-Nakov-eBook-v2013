using System;

namespace PriorityQueue_Example
{
    class PriorityQueueExample
    {
        static void Main()
        {
            PriorityQueue<Person> people = new PriorityQueue<Person>();
            people.Enqueue(new Person("Pesho", 11));
            people.Enqueue(new Person("malkiq Goshko", 9));
            people.Enqueue(new Person("Mimeto", 21));
            people.Enqueue(new Person("Baba Mara", 70));
            people.Enqueue(new Person("Bai Ivan", 65));
            people.Enqueue(new Person("Bobi", 15));
            people.Enqueue(new Person("Pena", 45));
            people.Enqueue(new Person("Krasito", 50));
            while (people.Count > 0)
            {
                Console.WriteLine(people.Dequeue());
            }
        }
    }

    class Person :IComparable<Person>
    {
        string Name { get; set; }

        int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Age);
        }
        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
