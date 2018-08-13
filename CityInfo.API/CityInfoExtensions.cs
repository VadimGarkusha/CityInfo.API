using CityInfo.API.Entities;
using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
                return;

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest()
                        {
                            Name = "Cental Park",
                            Description = "The most visited park in US"
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A skyscraper located in midtown of Manhattan"
                        }
                    }
                },
                new City()
                {
                    Name = "Toronto",
                    Description = "The one with one of the tallest towers",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest()
                        {
                            Name = "CN Tower",
                            Description = "The highest tower in North America"
                        },
                        new PointOfInterest()
                        {
                            Name = "High Park",
                            Description = "The best park to visit in Toronto"
                        }
                    }
                },
                new City()
                {
                    Name = "Montreal",
                    Description = "The one where everybody speaks French",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest()
                        {
                            Name = "The River",
                            Description = "A well-known river of the city of Montreal"
                        },
                        new PointOfInterest()
                        {
                            Name = "The Castle",
                            Description = "A huge and beatiful castle"
                        }
                    }
                }
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
