using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {

        public void Create(Product product)
        {
            PRN221_Assignment02Context.Instance.Add(product);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = GetProduct(id);
            PRN221_Assignment02Context.Instance.Remove(product);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return PRN221_Assignment02Context.Instance.Products.ToList().FirstOrDefault(c => c.ProductId == id);
        }

        public List<Product> GetProducts() => PRN221_Assignment02Context.Instance.Products.ToList();

        public void Update()
        {
            PRN221_Assignment02Context.Instance.SaveChanges();
        }
    }
}
