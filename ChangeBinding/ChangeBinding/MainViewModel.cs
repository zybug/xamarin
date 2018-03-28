using System;
using System.Collections.ObjectModel;

namespace ChangeBinding
{
    public class MainViewModel
    {
        public ObservableCollection<Person> People { private set; get; } = new ObservableCollection<Person>();

        public MainViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person("zhangyi");
                People.Add(person);
            }
        }

        public void ChangeModelType(int i)
        {
            People.Clear();
            if (i == 0) 
            {
                for (int j = 0; j < 10; j++)
                {
                    Person person = new Person("zhangyi");
                    People.Add(person);
                }
            }

            if (i == 1)
            {
                for (int j = 0; j < 10; j++)
                {
                    Person person = new Person("zhanger");
                    People.Add(person);
                }
            }

            if (i == 2)
            {
                for (int j = 0; j < 10; j++)
                {
                    Person person = new Person("zhangsan");
                    People.Add(person);
                }
            }

            if (i == 3)
            {
                for (int j = 0; j < 10; j++)
                {
                    Person person = new Person("zhangsi");
                    People.Add(person);
                }
            }
        }
    }

    public class Person
    {
        public string Name { set; get; }

        public Person(string name)
        {
            Name = name;
        }

    }
}
