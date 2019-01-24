using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#### **Product**

//** Class Properties**

//| Property Name  | Data Type | Get | Set | Description                                  |
//| -------------- | --------- | --- | --- | -------------------------------------------- |
//| Name           | string    | X   | X   | Holds the name of the product.               |
//| Price          | decimal   | X   | X   | Holds the price of the product.              |
//| WeightInOunces | double    | X   | X   | Holds the weight (in ounces) of the product. |


namespace TechElevator.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public double WeightInOunces { get; set; }
    }
}
