﻿using LetsMarket.Entities;
using Sharprompt;

namespace LetsMarket.Validations
{
    public class ProductValidation
    {
        public static decimal ValidateProduct(Product exit, Product closeSale, Product cancelItem, List<Product> products, List<Sale> saleItems, decimal total, Product product)
        {

            if (product != exit && product != closeSale && product != cancelItem)
            {
                var amount = Prompt.Input<int>("Informe a quantidade", defaultValue: 1);
                var item = new Sale
                {
                    ProductCode = product.ProductCode,
                    Description = product.Description,
                    UnitPrice = product.Price,
                    Amount = amount
                };
                saleItems.Add(item);
                total += item.Subtotal;
            }
            return total;
        }
    }
}
