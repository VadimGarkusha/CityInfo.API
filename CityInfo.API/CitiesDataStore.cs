using System;
using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Cental Park",
                            Description = "The most visited park in US"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A skyscraper located in midtown of Manhattan"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Toronto",
                    Description = "The one with one of the tallest towers",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "CN Tower",
                            Description = "The highest tower in North America"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "High Park",
                            Description = "The best park to visit in Toronto"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Montreal",
                    Description = "The one where everybody speaks French",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "The River",
                            Description = "A well-known river of the city of Montreal"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Castle",
                            Description = "A huge and beatiful castle"
                        }
                    }
                }
            };
        }
    }
}
