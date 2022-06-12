using System.Reflection.Metadata.Ecma335;
using ATHHRS.API.Data;
using ATHHRS.API.Entities;

namespace ATHHRS.API.Seeders
{
    public class HostelSeeder
    {
        private readonly ATHHRSDbContext _dbContext;

        public HostelSeeder(ATHHRSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
                if (!_dbContext.Hostels.Any())
                {
                    var hostels = GetHostels();
                    _dbContext.Hostels.AddRange(hostels);
                    _dbContext.SaveChanges();
                }
        }

        private IEnumerable<Hostel> GetHostels()
        {
            var hostels = new List<Hostel>
            {
                new()
                {
                    Name = "Hostel Adam",
                    Description = "Mały cichy hostel.",
                    ContactEmail = "contact@hadam.com",
                    ContactNumber = "111 222 333",
                    ImageUrl ="images/hostels/1.jpg",
                    Address = new Address
                    {
                        City = "Hel",
                        Street = "Morska 22A",
                        PostalCode = "66-236"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "A1",
                            Description = "Ładny, duży",
                            ImageUrl = "none",
                            Price = 70,
                            Beds = 3
                        },
                        new()
                        {
                            Name = "A2",
                            Description = "Ładny, średni",
                            ImageUrl = "none",
                            Price = 50,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "A3",
                            Description = "Ładny, mały",
                            ImageUrl = "none",
                            Price = 30,
                            Beds = 1
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Róża",
                    Description = "Blisko do plaży!",
                    ContactEmail = "contact@roza.com",
                    ContactNumber = "111 222 333",
                    ImageUrl ="images/hostels/2.jpg",
                    Address = new Address
                    {
                        City = "Świnoujście",
                        Street = "Żaglowa 12",
                        PostalCode = "22-136"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Miłek",
                            Description = "Dla zakochanych.",
                            ImageUrl = "none",
                            Price = 170,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "Family",
                            Description = "Dla dużych rodzin",
                            ImageUrl = "none",
                            Price = 190,
                            Beds = 4
                        },
                        new()
                        {
                            Name = "Zacisze",
                            Description = "Dla lubiących samotność.",
                            ImageUrl = "none",
                            Price = 100,
                            Beds = 1
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Poznań",
                    Description = "Tani hostel z dobrym jedzeniem",
                    ContactEmail = "contact@poznan.com",
                    ContactNumber = "111 212 233",
                    ImageUrl ="images/hostels/3.jpg",
                    Address = new Address
                    {
                        City = "Poznań",
                        Street = "Wielka 12",
                        PostalCode = "12-332"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Witek",
                            Description = "Nowoczesny",
                            ImageUrl = "none",
                            Price = 170,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "Antek",
                            Description = "Stary",
                            ImageUrl = "none",
                            Price = 190,
                            Beds = 4
                        },
                        new()
                        {
                            Name = "Grażyna",
                            Description = "W sam raz",
                            ImageUrl = "none",
                            Price = 100,
                            Beds = 2
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Lampionik",
                    Description = "Z jednej strony jezioro, z drugiej las.",
                    ContactEmail = "contact@lampionik.com",
                    ContactNumber = "122 322 422",
                    ImageUrl ="images/hostels/4.jpg",
                    Address = new Address
                    {
                        City = "Dąbrowa Górnicza",
                        Street = "Poznańska 223",
                        PostalCode = "21-236"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Jedynka",
                            Description = "Bliżej wody.",
                            ImageUrl = "none",
                            Price = 70,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "Dwójka",
                            Description = "W sam raz po środku.",
                            ImageUrl = "none",
                            Price = 90,
                            Beds = 4
                        },
                        new()
                        {
                            Name = "Trójka",
                            Description = "Bliżej lasu.",
                            ImageUrl = "none",
                            Price = 50,
                            Beds = 1
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Roger",
                    Description = "Najlepsza jakość w przystępnej cenie.",
                    ContactEmail = "contact@roger.com",
                    ContactNumber = "997 112 221",
                    ImageUrl ="images/hostels/5.jpg",
                    Address = new Address
                    {
                        City = "Bielsko-Biała",
                        Street = "Willowa 1A",
                        PostalCode = "43-550"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Złoty",
                            Description = "Dla najbardziej wymagających.",
                            ImageUrl = "none",
                            Price = 770,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "Srebrny",
                            Description = "Dla tych, którzy wiedzą co dobre.",
                            ImageUrl = "none",
                            Price = 590,
                            Beds = 4
                        },
                        new()
                        {
                            Name = "Brązowy",
                            Description = "Tańszy nie znaczy gorszy.",
                            ImageUrl = "none",
                            Price = 300,
                            Beds = 1
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Widlak",
                    Description = "Dla amatorów wózków widłowych.",
                    ContactEmail = "contact@widlak.com",
                    ContactNumber = "221 294 372",
                    ImageUrl ="images/hostels/6.jpg",
                    Address = new Address
                    {
                        City = "Sanok",
                        Street = "Węglowa 122",
                        PostalCode = "12-321"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "A11",
                            Description = "Duża przestrzeń dla dużej rodziny.",
                            ImageUrl = "none",
                            Price = 270,
                            Beds = 5
                        },
                        new()
                        {
                            Name = "A12",
                            Description = "Mały pełen koloru.",
                            ImageUrl = "none",
                            Price = 190,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "A13",
                            Description = "Dla samotnych.",
                            ImageUrl = "none",
                            Price = 100,
                            Beds = 1
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Kartkowy",
                    Description = "Wszystko z papieru, nawet ściany.",
                    ContactEmail = "contact@kartkowy.com",
                    ContactNumber = "453 443 554",
                    ImageUrl ="images/hostels/7.jpg",
                    Address = new Address
                    {
                        City = "Kraków",
                        Street = "Mariacka 122",
                        PostalCode = "22-221"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "A5",
                            Description = "Najmniejszy pokój w ofercie.",
                            ImageUrl = "none",
                            Price = 120,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "A4",
                            Description = "Przestronny jak umowa najmu.",
                            ImageUrl = "none",
                            Price = 220,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "A3",
                            Description = "Wielki format wypoczynku.",
                            ImageUrl = "none",
                            Price = 320,
                            Beds = 3
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Róża",
                    Description = "Niemal w centrum Katowic.",
                    ContactEmail = "contact@rozaKatowice.com",
                    ContactNumber = "223 227 654",
                    ImageUrl ="images/hostels/8.jpg",
                    Address = new Address
                    {
                        City = "Katowice",
                        Street = "Mariacka 44B",
                        PostalCode = "67-665"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "S1",
                            Description = "Widok na spodek.",
                            ImageUrl = "none",
                            Price = 130,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "S2",
                            Description = "Z balkonem oraz grillem.",
                            ImageUrl = "none",
                            Price = 390,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "S3",
                            Description = "Posiada mikrofalówke.",
                            ImageUrl = "none",
                            Price = 600,
                            Beds = 2
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Skowronek",
                    Description = "Jedyny hostel w rezerwacie skowronków.",
                    ContactEmail = "contact@skowronek.com",
                    ContactNumber = "444 555 666",
                    ImageUrl ="images/hostels/9.jpg",
                    Address = new Address
                    {
                        City = "Białowieża",
                        Street = "Żubrowa 44B",
                        PostalCode = "55-555"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Skowronek",
                            Description = "Standardami dorównuje apartamentowi prezydenta.",
                            ImageUrl = "none",
                            Price = 770,
                            Beds = 2
                        },
                        new()
                        {
                            Name = "Imprezowy",
                            Description = "Grubsze ściany dla komfortu imprezowiczów.",
                            ImageUrl = "none",
                            Price = 690,
                            Beds = 4
                        },
                        new()
                        {
                            Name = "Pniaczek",
                            Description = "Cały drewniany.",
                            ImageUrl = "none",
                            Price = 150,
                            Beds = 2
                        },
                    }
                },
                new()
                {
                    Name = "Hostel Supreme",
                    Description = "Jedyny taki w Polsce.",
                    ContactEmail = "contact@supremeHostel.com",
                    ContactNumber = "777 777 777",
                    ImageUrl ="images/hostels/10.jpg",
                    Address = new Address
                    {
                        City = "Warszawa",
                        Street = "Wiejska 11",
                        PostalCode = "77-656"
                    },
                    Rooms = new List<Room>
                    {
                        new()
                        {
                            Name = "Grand Supreme",
                            Description = "Wart swojej ceny.",
                            ImageUrl = "none",
                            Price = 2700,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "Medium Rare",
                            Description = "Mały ale z grilem.",
                            ImageUrl = "none",
                            Price = 1500,
                            Beds = 1
                        },
                        new()
                        {
                            Name = "Swagger",
                            Description = "Instagram go nienawidzi, nasi klienci kochają.",
                            ImageUrl = "none",
                            Price = 2000,
                            Beds = 1
                        },
                    }
                }
            };
            return hostels;
        }
    }

    
}
