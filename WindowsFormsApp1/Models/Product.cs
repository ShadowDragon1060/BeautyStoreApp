using System;
using System.ComponentModel.DataAnnotations;

namespace BeautyStoreApp.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string ImagePath { get; set; }

        public string Shade { get; set; }
    }
}