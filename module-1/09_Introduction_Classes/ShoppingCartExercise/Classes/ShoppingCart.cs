using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#### **Shopping Cart**

//** Class Properties**

//| Property Name      | Data Type | Get | Set | Description                                                                              |
//| ------------------ | --------- | --- | --- | ---------------------------------------------------------------------------------------- |
//| TotalNumberOfItems | int       | X   |     | The number of items in the shopping cart. ** All shopping carts have 0 items by default** |
//| TotalAmountOwed    | decimal   | X   |     | The total for the shopping cart. ** All shopping carts have 0.0 owed by default**         |

//** Methods**

//| Method Name                                       | Return Type | Description                                                                                      |
//| ------------------------------------------------- | ----------- | ------------------------------------------------------------------------------------------------ |
//| GetAveragePricePerItem()                          | decimal     | Returns the `TotalAmountOwed / TotalNumberOfItems`.                                              |
//| AddItems(int numberOfItems, decimal pricePerItem) | void        | Updates `TotalNumberOfItems` and increases `TotalAmountOwed` by `(pricePerItem* numberOfItems)` |
//| Empty()                                           | void        | Resets `TotalNumberOfItems` and `TotalAmountOwed` to 0.                                          |


namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int TotalNumberOfItems { get; private set; }
        public decimal TotalAmountOwed { get; private set; }

        public ShoppingCart()
        {
            TotalAmountOwed = 0.00M;
            TotalNumberOfItems = 0;
        }

        public decimal GetAveragePricePerItem()
        {
            if (TotalNumberOfItems == 0)
            {
                return 0.00M;
            }
            else
            {
                return (TotalAmountOwed / (decimal)TotalNumberOfItems);
            }
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems += numberOfItems;
            TotalAmountOwed += pricePerItem * (decimal)numberOfItems;
        }

        public void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0.00M;
        }
       
    }
}
