using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEmployes.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutSourcedEmployee()
        {
        }
        public OutSourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public sealed override double Payment()
        {
           
            return base.Payment() + AdditionalCharge * 1.10;
        }
    }
}
