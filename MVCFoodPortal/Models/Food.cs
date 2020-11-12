using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFoodPortal.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string OrderName { get; set; }

        public float Price { get; set; }
    }
}