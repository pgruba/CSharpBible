using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Extended
{
    /*
     * Example comes from https://dofactory.com/net/builder-design-pattern
     * Builder  (VehicleBuilder)
     *    -specifies an abstract interface for creating parts of a Product object
     * ConcreteBuilder  (MotorCycleBuilder, CarBuilder, ScooterBuilder)
     *    -constructs and assembles parts of the product by implementing the Builder interface
     *    -defines and keeps track of the representation it creates
     *    -provides an interface for retrieving the product
     * Director  (Shop)
     *    -constructs an object using the Builder interface
     * Product  (Vehicle)
     *    -represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
     *    -includes classes that define the constituent parts, including interfaces for assembling the parts into the final result
     */

    public class Vehicle
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string Show() => string.Join(',', _parts);
    }

    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle = new Vehicle();

        public abstract void BuildChassis();

        public abstract void BuildBody();

        public Vehicle GetVehicle() => Vehicle;
    }

    public class CarBuilder : VehicleBuilder
    {
        public override void BuildBody()
        {
            Vehicle.Add("Van");
        }

        public override void BuildChassis()
        {
            Vehicle.Add("2WD");
        }
    }

    public class MotorbikeBuilder : VehicleBuilder
    {
        public override void BuildBody()
        {
            Vehicle.Add("Choper");
        }

        public override void BuildChassis()
        {
            Vehicle.Add("RearDrive");
        }
    }

    public class Director
    {
        public void Contruct(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();
        }
    }
}