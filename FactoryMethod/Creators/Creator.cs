using FactoryMethod.Models;
using FactoryMethod.Utilities;

namespace FactoryMethod.Creators
{
    public class Creator
    {
        public Product Create(string productId)
        {
            return productId switch
            {
                ProductsName.FirstProduct => new FirstProduct(),
                ProductsName.SecondProduct => new SecondProduct(),
                _ => new OtherProduct()
            };
        }
    }
}