﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class Medicines
    {
        [Key]
        public string MedicineID { get; set; }
        public string Name { get; set; }
        public string AdminID { get; set; }
        public string Manufacturer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ImageUrl { get; set; }
        public int status { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
