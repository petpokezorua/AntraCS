using System;
using System.Collections.Generic;

namespace GenericRepositoryDemo
{
    // Base Entity class 
    public class Entity
    {
        public int Id { get; set; }
    }

    // IRepository<T> interface
    public interface IRepository<T> where T : Entity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    // GenericRepository<T> class implementing IRepository<T>
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _dataStore; 

        public GenericRepository()
        {
            _dataStore = new List<T>();
        }

        // 1. 
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            _dataStore.Add(item);
        }

        // 2.
        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            _dataStore.Remove(item);
        }

        // 3.
        public void Save()
        {
            Console.WriteLine("Changes saved to the data source.");
        }

        // 4.
        public IEnumerable<T> GetAll()
        {
            return _dataStore;
        }

        // 5.
        public T GetById(int id)
        {
            return _dataStore.FirstOrDefault(item => item.Id == id);
        }
    }

    // Example entity class
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var productRepository = new GenericRepository<Product>();

            productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            productRepository.Add(new Product { Id = 2, Name = "Smartphone", Price = 500 });

            Console.WriteLine("All Products:");
            foreach (var product in productRepository.GetAll())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            var productById = productRepository.GetById(1);
            Console.WriteLine($"\nProduct with Id 1: Name: {productById.Name}, Price: {productById.Price}");

            productRepository.Remove(productById);
            Console.WriteLine("\nAfter removing product with Id 1:");
            foreach (var product in productRepository.GetAll())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            productRepository.Save();
        }
    }
}