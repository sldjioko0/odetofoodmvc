﻿using OdeToFoodData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFoodData.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name = "Scotts Pizza",
                    Cuisine = CuisineType.Italian
                } ,
                new Restaurant()
                {
                    Id = 2,
                    Name = "Terziguels",
                    Cuisine = CuisineType.French
                },
                new Restaurant()
                {
                    Id = 3,
                    Name = "Mango Grove",
                    Cuisine = CuisineType.Indian
                }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(s => s.Name);
        }
    }
}
