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
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<ResturantReview> Reviews { get; set; }
    }
}