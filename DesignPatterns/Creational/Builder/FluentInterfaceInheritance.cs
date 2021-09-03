namespace DesignPatterns.Creational.Builder.FluentInterfaceInheritance
{
    public class Person
    {
        public string Name;
        public string Position;
        public string City;

        public override string ToString()
            => $"{Name}{Position}{City}";
    }

    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }

    /*
     * This is wrong, because return this returns reference to PersonInfoBuilder so it won't work for 'WorksAs' method
     * Need to come up with generics (check below)
     *
    public class PersonInfoBuilder : PersonBuilder
    {
        public PersonInfoBuilder SetName(string name)
        {
            person.Name = name;
            return this;
        }
    }

    public class PersonJobBuilder : PersonInfoBuilder
    {
        public PersonJobBuilder WorksAs(string posiiton)
        {
            person.Position = posiiton;
            return this;
        }
    }
    */

    public class PersonInfoBuilder<T> : PersonBuilder
        where T : PersonInfoBuilder<T>
    {
        public T SetName(string name)
        {
            person.Name = name;
            return (T)this;
        }
    }

    /*
     * Now we can add new builders
     */

    public class PersonJobBuilder<T> : PersonInfoBuilder<T>
        where T : PersonJobBuilder<T>
    {
        public T WorkAs(string position)
        {
            person.Position = position;
            return (T)this;
        }
    }

    public class PersonAddressBuilder<T> : PersonJobBuilder<T>
        where T : PersonAddressBuilder<T>
    {
        public T SetCity(string city)
        {
            person.City = city;
            return (T)this;
        }
    }

    public class BuilderDirector : PersonAddressBuilder<BuilderDirector>
    {
        public static BuilderDirector New => new BuilderDirector();
    }
}