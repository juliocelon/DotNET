using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetTopics
{
    class CompleteName
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class LINQExercises
    {

        public static void Start()
        {
            var estudiantes = new[]
            {
                new
                {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };


            // Simple Example, using IEnumerable
            IEnumerable<string> StudentsName = estudiantes.Select(e => $"{e.Nombre} {e.ApellidoPaterno}");
            foreach (var item in StudentsName)
            {
                Console.WriteLine(item);
            }

            // Example with explicit object
            IEnumerable<CompleteName> StudentsName2 = estudiantes.Select(e => new CompleteName { Name = e.Nombre, LastName = e.ApellidoPaterno });
            foreach (var item in StudentsName2)
            {
                Console.WriteLine($"{item.Name} {item.LastName}");
            }

            // Example with anonymous object
            var StudentsName3 = estudiantes.Select(e => new { Name = e.Nombre, LastName = e.ApellidoPaterno });
            foreach (var item in StudentsName3)
            {
                Console.WriteLine($"{item.Name} {item.LastName}");
            }

            // Filtering information
            var USAUniversities = universidades
                .Where(u => u.Pais == "Estados Unidos")
                .Select(u => u.Universidad);

            // Getting the name of all the universities ordered alphabetically ascending
            var USAUniversitiesOrdered = universidades
                .OrderBy(u => u.Universidad)
                .Select(u => u.Universidad);

            Console.WriteLine("---USAUniversitiesOrdered Asc---");
            foreach (var item in USAUniversitiesOrdered)
            {
                Console.WriteLine(item);
            }

            // Getting the name of all the universities ordered alphabetically descending
            var USAUniversitiesOrderedDesc = universidades
                .OrderByDescending(u => u.Universidad)
                .Select(u => u.Universidad);

            Console.WriteLine("---USAUniversitiesOrdered Desc---");
            foreach (var item in USAUniversitiesOrderedDesc)
            {
                Console.WriteLine(item);
            }

            // Getting the name of all the universities ordered alphabetically descending with a 2nd order by
            var USAUniversitiesOrderedDesc2 = universidades
                .OrderByDescending(u => u.Universidad)
                .ThenBy(u => u.Pais)
                .Select(u => u.Universidad);

            Console.WriteLine("---USAUniversitiesOrdered Desc---");
            foreach (var item in USAUniversitiesOrderedDesc)
            {
                Console.WriteLine(item);
            }

            // Getting the name of all the universities grouped by Country
            var USAUniversitiesGroupedByCountry = universidades
                .GroupBy(u => u.Pais);

            Console.WriteLine("--- USAUniversitiesGroupedByCountry ---");
            foreach (var group in USAUniversitiesGroupedByCountry)
            {
                Console.WriteLine($"University: {group.Key} - {group.Count()}");
                foreach (var university in group)
                {
                    Console.WriteLine($"{university.Universidad}");
                }
            }

            // Getting number of universities
            var numberOfUniversiticies = universidades.Select(u => u.Universidad).Count();
            Console.WriteLine("Number of Universities = [{0}]", numberOfUniversiticies);

            // Getting number of Countries (without repetition)
            var numberOfCountries = universidades.Select(u => u.Pais).Distinct().Count();
            Console.WriteLine("Number of Countries = [{0}]", numberOfCountries);

            // join
            //var join = estudiantes
            //    .Select( e => new
            //        {
            //            e.Nombre,
            //            e.ApellidoPaterno,
            //            e.Universidad
            //        }
            //    );
        }
    }
}
