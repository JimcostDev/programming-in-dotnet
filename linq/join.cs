namespace curso_dotnet.linq
{
    public static class LinqJoinExample
    {
        private static void JoinDemo()
        {
            Console.WriteLine(":: Ejemplo de LINQ con Join ::");

            // Colección de países
            var countries = new List<Country>
            {
                new Country { Id = 1, Name = "España" },
                new Country { Id = 2, Name = "Francia" },
                new Country { Id = 3, Name = "Italia" }
            };

            // Colección de capitales
            var capitals = new List<Capital>
            {
                new Capital { CountryId = 1, City = "Madrid" },
                new Capital { CountryId = 2, City = "París" },
                new Capital { CountryId = 3, City = "Roma" },
                new Capital { CountryId = 4, City = "Berlín" } // sin país correspondiente
            };

            // 1) Join usando sintaxis de métodos
            var countryCapitals1 = countries
                .Join(
                    capitals,
                    country => country.Id,
                    capital => capital.CountryId,
                    (country, capital) => new
                    {
                        CountryName = country.Name,
                        CapitalCity = capital.City
                    }
                );

            Console.WriteLine("-- Método de extensión Join --");
            foreach (var item in countryCapitals1)
            {
                Console.WriteLine($"{item.CountryName}: {item.CapitalCity}");
            }

            // 2) Join usando sintaxis de consulta
            var countryCapitals2 =
                from country in countries
                join capital in capitals
                    on country.Id equals capital.CountryId
                select new
                {
                    country.Name,
                    capital.City
                };

            Console.WriteLine("\n-- Query syntax Join --");
            foreach (var item in countryCapitals2)
            {
                Console.WriteLine($"{item.Name}: {item.City}");
            }

            Console.WriteLine(new string('-', 30));
        }

        public static void Run()
        {
            JoinDemo();
        }

        private class Country
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        private class Capital
        {
            public int CountryId { get; set; }
            public string City { get; set; } = string.Empty;
        }
    }
}
