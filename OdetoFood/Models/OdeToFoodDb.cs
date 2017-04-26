using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdetoFood.Models
{
    public class OdeToFoodDb:DbContext
    {
        public OdeToFoodDb():base("name=DefaultConnection") //base code can contain connection string
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}