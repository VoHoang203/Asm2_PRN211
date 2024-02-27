using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        void Update();

        void Create(Product product);

        void Delete(int id);

        Product GetProduct(int id);
    }

}
