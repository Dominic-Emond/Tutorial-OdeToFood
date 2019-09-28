using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name="The Alley", Location="Montreal", Cuisine=CuisineType.None},
                new Restaurant {Id = 2, Name="Biiru", Location="Montreal", Cuisine=CuisineType.Japanese},
                new Restaurant {Id = 3, Name="Yokato Yokabai", Location="Montreal", Cuisine=CuisineType.Japanese},
                new Restaurant {Id = 4, Name="Tapeo", Location="Montreal", Cuisine=CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }

}
