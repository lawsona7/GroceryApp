using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroceryApp.Models
{
    public class Grocery
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public DateTime SellBy { get; set; }

        [Required]
        public string Done { get; set; }

        [Required]
        public string Repeating { get; set; }

        [Required]
        public string StoreName { get; set; }

        public string Address { get; set; }

        public string ProductStatus()
        {
            string used = Done;
            double expired = (SellBy - DateTime.Now).TotalDays;
            if(expired >= 0)
            {
                return "Good";
            }
            else if (expired <= 0 || used == "Yes")
            {
                return "Bad";
            }
            else
            {
                return "Good";
            }
        }

        public object DaysToExpiration()
        {
            DateTime today = DateTime.Now;
            DateTime expire = SellBy;
            double days=(expire - today).TotalDays;
            if(days >= 0)
            {
                return days;
            }
            else
            {
                return "bad";
            }
        }
        

    }
}