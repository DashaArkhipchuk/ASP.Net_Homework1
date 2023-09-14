using DataClasses;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Task5.Pages
{
    public class CountriesModel : PageModel
    {
        public List<Country> Countries { get; private set; }

        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country
                {
                    Name = "Ukraine",
                    Population = 44000000,
                    Capital = "Kyiv",
                    Language = "Ukrainian",
                    Attractions = new List<string>
                    {
                        "Saint Sophia's Cathedral",
                        "Chernobyl Exclusion Zone",
                        "Carpathian Mountains",
                    }
                },
                new Country
                {
                    Name = "United States",
                    Population = 331000000,
                    Capital = "Washington, D.C.",
                    Language = "English",
                    Attractions = new List<string>
                    {
                        "Statue of Liberty",
                        "Grand Canyon",
                        "Disney World",
                    }
                },
                new Country
                {
                    Name = "United Kingdom",
                    Population = 66400000,
                    Capital = "London",
                    Language = "English",
                    Attractions = new List<string>
                    {
                        "Big Ben",
                        "Tower of London",
                        "Stonehenge",
                    }
                },
                new Country
                {
                    Name = "Canada",
                    Population = 37590000,
                    Capital = "Ottawa",
                    Language = "English and French",
                    Attractions = new List<string>
                    {
                        "Banff National Park",
                        "Niagara Falls",
                        "CN Tower",
                    }
                },
                new Country
                {
                    Name = "Germany",
                    Population = 83020000,
                    Capital = "Berlin",
                    Language = "German",
                    Attractions = new List<string>
                    {
                        "Brandenburg Gate",
                        "Neuschwanstein Castle",
                        "Berlin Wall",
                    }
                },
                new Country
                {
                    Name = "France",
                    Population = 67013000,
                    Capital = "Paris",
                    Language = "French",
                    Attractions = new List<string>
                    {
                        "Eiffel Tower",
                        "Louvre Museum",
                        "Versailles Palace",
                    }
                },
                new Country
                {
                    Name = "Australia",
                    Population = 25670000,
                    Capital = "Canberra",
                    Language = "English",
                    Attractions = new List<string>
                    {
                        "Sydney Opera House",
                        "Great Barrier Reef",
                        "Uluru (Ayers Rock)",
                    }
                },
                new Country
                {
                    Name = "Brazil",
                    Population = 211000000,
                    Capital = "Brasília",
                    Language = "Portuguese",
                    Attractions = new List<string>
                    {
                        "Christ the Redeemer",
                        "Amazon Rainforest",
                        "Carnival in Rio de Janeiro",
                    }
                },
                new Country
                {
                    Name = "India",
                    Population = 1380000000,
                    Capital = "New Delhi",
                    Language = "Hindi and English",
                    Attractions = new List<string>
                    {
                        "Taj Mahal",
                        "Varanasi",
                        "Jaipur's Palaces and Forts",
                    }
                },
                new Country
                {
                    Name = "China",
                    Population = 1444000000,
                    Capital = "Beijing",
                    Language = "Mandarin",
                    Attractions = new List<string>
                    {
                        "Great Wall of China",
                        "Forbidden City",
                        "Terracotta Army",
                    }
                },
                new Country
                {
                    Name = "Japan",
                    Population = 126300000,
                    Capital = "Tokyo",
                    Language = "Japanese",
                    Attractions = new List<string>
                    {
                        "Mount Fuji",
                        "Kyoto Temples",
                        "Tokyo Disneyland",
                    }
                },
                new Country
                {
                    Name = "South Korea",
                    Population = 51780579,
                    Capital = "Seoul",
                    Language = "Korean",
                    Attractions = new List<string>
                    {
                        "Gyeongbokgung Palace",
                        "Jeju Island",
                        "DMZ (Demilitarized Zone)",
                    }
                },
                new Country
                {
                    Name = "Mexico",
                    Population = 126200000,
                    Capital = "Mexico City",
                    Language = "Spanish",
                    Attractions = new List<string>
                    {
                        "Chichen Itza",
                        "Cancun's Beaches",
                        "Teotihuacan Pyramids",
                    }
                },
                new Country
                {
                    Name = "South Africa",
                    Population = 57725600,
                    Capital = "Pretoria",
                    Language = "11 Official Languages",
                    Attractions = new List<string>
                    {
                        "Table Mountain",
                        "Kruger National Park",
                        "Robben Island",
                    }
                },
                new Country
                {
                    Name = "New Zealand",
                    Population = 5000000,
                    Capital = "Wellington",
                    Language = "English and Māori",
                    Attractions = new List<string>
                    {
                        "Milford Sound",
                        "Rotorua Geothermal Area",
                        "Tongariro Alpine Crossing",
                    }
                }
            };

        }
    }
}
