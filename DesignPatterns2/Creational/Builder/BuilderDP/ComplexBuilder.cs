namespace BuilderDP.ComplexBuilder
{
    /*
     * Creates PersonBuilder and uses Lives property to to get PersonAddressBuilder object to build address info.
     * After that we just switch to PersonJobBuilder (by Works property) to build job related informations
     * After all by using implicit operator we 'convert' our builder object to Person instance.
     *
     * This solution has one huge DISADVANTAGE. It is not SOLID friendly - base class (PersonBuilder) is aware about all subclasses (JobBuilder and AddressBuilder).
     * If we need to create new builder (ex PersonFamilyBuilder), we will have to break OCP principle and edit PersonBuilder class.
     */

    public class Person
    {
        public string StreetAddress;
        public string PostCode;
        public string City;

        public string CompanyName;
        public string Position;

        public int AnnualIncome;

        public override string ToString()
            => $"{StreetAddress}{PostCode}{City}{CompanyName}{Position}{AnnualIncome}";
    }

    /// <summary>
    /// Complex Person Builder.
    /// </summary>
    public class PersonBuilder
    {
        protected Person person;

        public PersonBuilder() => person = new Person();

        protected PersonBuilder(Person person) => this.person = person;

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb) => pb.person;
    }

    /// <summary>
    /// Job Builder for person
    /// </summary>
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
            : base(person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder As(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int salary)
        {
            person.AnnualIncome = salary;
            return this;
        }
    }

    /// <summary>
    /// Address builder for person
    /// </summary>
    public class PersonAddressBuilder : PersonBuilder
    {
        internal PersonAddressBuilder(Person person)
            : base(person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostCode(string postCode)
        {
            person.PostCode = postCode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }
}