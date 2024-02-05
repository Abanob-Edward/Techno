using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Appliaction.Contract;
using System.Xml.Linq;
namespace Appliaction.Services
{
    ///IG_Services to 


    public class ProductService : IProductService
    {
        //private readonly IG_Repo<Product, int> _productRepository;
        private readonly IProudectRepository _productRepository;

        public ProductService(IProudectRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Addtech(Product entity)
        {
            _productRepository.add(entity);


        }

        public void Deletetech(int id)
        {
            _productRepository.delete(id);
        }

        public IQueryable<Product> GetAlltech()
        {
            return _productRepository.getAll();
        }

        public IQueryable<Product> GetByName(string? Name)
        {
            
            return _productRepository.SearchByName(Name);
        }

        public Product? GettechById(int id)
        {
            return _productRepository.getByID(id);
        }

        public Product Updatetech(Product entity)
        {
            return _productRepository.update(entity);
        }
        public List<Product> GetAllPagination(int skipCount, int takeCount, string? searchtxt)
        {
            var products = _productRepository.getAll().Where(x=>x.Name.Contains(searchtxt) || x.Name ==null|| x.Name == "").Skip(skipCount).Take(takeCount).ToList();
            return products;
        }
    }



}


