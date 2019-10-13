using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCursos.Interfaces;
using WebApiCursos.Models;

namespace WebApiCursos.Providers
{
    public class FakeCoursesProvider : ICoursesProvider
    {
        private readonly List<Course> repo = new List<Course>();

        public FakeCoursesProvider()
        {
            repo.Add(new Course()
            {
                Id = 1,
                Name = "Programando en Blazor - ASP.NET Core 3",
                Author = "Felipe Gavilán",
                Description = "Crea aplicaciones web interactivas con C#",
                Uri = "https://i.udemycdn.com/course/480x270/2551555_fe21_3.jpg"
            });
            repo.Add(new Course()
            {
                Id = 2,
                Name = "Master en JavaScript: Aprender JS, jQuery, Angular 8, NodeJS",
                Author = "Víctor Robles",
                Description = "Aprende a programar desde cero y desarrollo web con JavaScript, jQuery, JSON, TypeScript, Angular, Node, MEAN, +30 horas",
                Uri = "https://i.udemycdn.com/course/240x135/1337000_0d99.jpg"
            });
            repo.Add(new Course()
            {
                Id = 3,
                Name = "Diseño Web Desde Cero a Avanzado 45h Curso COMPLETO",
                Author = "Javier Villena",
                Description = "Aprende a Diseñar Páginas Web Responsive Design, atractivas, de forma profesional y sin dificultad con HTML5 y CSS3",
                Uri = "https://i.udemycdn.com/course/240x135/809410_4666_6.jpg"
            });
            repo.Add(new Course()
            {
                Id = 4,
                Name = "Diseño Web Profesional El Curso Completo, Práctico y desde 0",
                Author = "Arturo Esparza",
                Description = "HTML5, CSS3, Responsive Design, Adobe XD, SASS, JavaScript, jQuery, Bootstrap 4, WordPress, Git, GitHub",
                Uri = "https://i.udemycdn.com/course/240x135/782428_b5cf_3.jpg"
            });
            repo.Add(new Course()
            {
                Id = 5,
                Name = "Curso de Desarrollo Web Completo 2.0",
                Author = "Rob Percival",
                Description = "¡Aprende haciendo! HTML5, CSS3, Javascript, jQuery, Bootstrap 4, WordPress, PHP, MySQL, APIs, apps móviles y Python",
                Uri = "https://i.udemycdn.com/course/240x135/834866_4564_2.jpg"
            });
            repo.Add(new Course()
            {
                Id = 6,
                Name = "React JS + Redux + ES6. Completo ¡De 0 a experto! (español)",
                Author = "Emiliano Ocariz",
                Description = "El curso de React en español más elegido. Desarrollo en forma práctica, ejemplos, fundamentos y herramientas útiles",
                Uri = "https://i.udemycdn.com/course/240x135/1374394_f1a8_2.jpg"
            });
            repo.Add(new Course()
            {
                Id = 7,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            //---

            repo.Add(new Course()
            {
                Id = 8,
                Name = "Crea sistemas POS Inventarios y ventas con PHP 7 y AdminLTE",
                Author = "Juan Fernando Urrego",
                Description = "Aprende a crear sistemas para puntos de venta con manejo de inventarios y facturación utilizando PHP 7 y AdminLTE",
                Uri = "https://i.udemycdn.com/course/240x135/1467412_94b5_11.jpg"
            });
            repo.Add(new Course()
            {
                Id = 9,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            repo.Add(new Course()
            {
                Id = 10,
                Name = "Desarrollo Web con Spring Boot - De Cero a Ninja",
                Author = "Miguel A. M.",
                Description = "El curso definitivo de Spring Framework 4.3 desde cero: Spring Boot + Rest + MVC + Security + Data JPA + Thymeleaf",
                Uri = "https://i.udemycdn.com/course/240x135/984636_5a01_8.jpg"
            });
            repo.Add(new Course()
            {
                Id = 11,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            repo.Add(new Course()
            {
                Id = 12,
                Name = "Bootstrap 4: El Curso Completo, Práctico y Desde Cero",
                Author = "Carlos Arturo Esparza",
                Description = "Aprende a crear cualquier sitio web adaptable a dispositivos móviles con Boostrap 4, el mejor framework de diseño web",
                Uri = "https://i.udemycdn.com/course/240x135/1245130_efdb_5.jpg"
            });
             repo.Add(new Course()
            {
                Id = 1,
                Name = "Programando en Blazor - ASP.NET Core 3",
                Author = "Felipe Gavilán",
                Description = "Crea aplicaciones web interactivas con C#",
                Uri = "https://i.udemycdn.com/course/480x270/2551555_fe21_3.jpg"
            });
            repo.Add(new Course()
            {
                Id = 2,
                Name = "Master en JavaScript: Aprender JS, jQuery, Angular 8, NodeJS",
                Author = "Víctor Robles",
                Description = "Aprende a programar desde cero y desarrollo web con JavaScript, jQuery, JSON, TypeScript, Angular, Node, MEAN, +30 horas",
                Uri = "https://i.udemycdn.com/course/240x135/1337000_0d99.jpg"
            });
            repo.Add(new Course()
            {
                Id = 3,
                Name = "Diseño Web Desde Cero a Avanzado 45h Curso COMPLETO",
                Author = "Javier Villena",
                Description = "Aprende a Diseñar Páginas Web Responsive Design, atractivas, de forma profesional y sin dificultad con HTML5 y CSS3",
                Uri = "https://i.udemycdn.com/course/240x135/809410_4666_6.jpg"
            });
            repo.Add(new Course()
            {
                Id = 4,
                Name = "Diseño Web Profesional El Curso Completo, Práctico y desde 0",
                Author = "Arturo Esparza",
                Description = "HTML5, CSS3, Responsive Design, Adobe XD, SASS, JavaScript, jQuery, Bootstrap 4, WordPress, Git, GitHub",
                Uri = "https://i.udemycdn.com/course/240x135/782428_b5cf_3.jpg"
            });
            repo.Add(new Course()
            {
                Id = 5,
                Name = "Curso de Desarrollo Web Completo 2.0",
                Author = "Rob Percival",
                Description = "¡Aprende haciendo! HTML5, CSS3, Javascript, jQuery, Bootstrap 4, WordPress, PHP, MySQL, APIs, apps móviles y Python",
                Uri = "https://i.udemycdn.com/course/240x135/834866_4564_2.jpg"
            });
            repo.Add(new Course()
            {
                Id = 6,
                Name = "React JS + Redux + ES6. Completo ¡De 0 a experto! (español)",
                Author = "Emiliano Ocariz",
                Description = "El curso de React en español más elegido. Desarrollo en forma práctica, ejemplos, fundamentos y herramientas útiles",
                Uri = "https://i.udemycdn.com/course/240x135/1374394_f1a8_2.jpg"
            });
            repo.Add(new Course()
            {
                Id = 7,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            //---

            repo.Add(new Course()
            {
                Id = 8,
                Name = "Crea sistemas POS Inventarios y ventas con PHP 7 y AdminLTE",
                Author = "Juan Fernando Urrego",
                Description = "Aprende a crear sistemas para puntos de venta con manejo de inventarios y facturación utilizando PHP 7 y AdminLTE",
                Uri = "https://i.udemycdn.com/course/240x135/1467412_94b5_11.jpg"
            });
            repo.Add(new Course()
            {
                Id = 9,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            repo.Add(new Course()
            {
                Id = 10,
                Name = "Desarrollo Web con Spring Boot - De Cero a Ninja",
                Author = "Miguel A. M.",
                Description = "El curso definitivo de Spring Framework 4.3 desde cero: Spring Boot + Rest + MVC + Security + Data JPA + Thymeleaf",
                Uri = "https://i.udemycdn.com/course/240x135/984636_5a01_8.jpg"
            });
            repo.Add(new Course()
            {
                Id = 11,
                Name = "Curso de TypeScript - El lenguaje utilizado por Angular 2",
                Author = "Víctor Robles",
                Description = "Aprende JavaScript orientado a objetos con TypeScript el lenguaje usado en Angular 2 (nuevo y mejorado AngularJS)",
                Uri = "https://i.udemycdn.com/course/240x135/914024_9850.jpg"
            });
            repo.Add(new Course()
            {
                Id = 12,
                Name = "Bootstrap 4: El Curso Completo, Práctico y Desde Cero",
                Author = "Carlos Arturo Esparza",
                Description = "Aprende a crear cualquier sitio web adaptable a dispositivos móviles con Boostrap 4, el mejor framework de diseño web",
                Uri = "https://i.udemycdn.com/course/240x135/1245130_efdb_5.jpg"
            });
        }

        public Task<(bool IsSuccess, int? Id)> AddAsync(Course course)
        {
            course.Id = repo.Max(c => c.Id) + 1;
            repo.Add(course);
            return Task.FromResult((true, (int?)course.Id));
        }

        public Task<ICollection<Course>> GetAllAsync()
        {
            return Task.FromResult((ICollection<Course>)repo.ToList());
        }

        public Task<Course> GetAsync(int id)
        {
            return Task.FromResult(repo.FirstOrDefault(c => c.Id == id));
        }

        public Task<ICollection<Course>> SearchAsync(string search)
        {
            return Task.FromResult((ICollection<Course>)repo.Where(c => c.Name.ToLowerInvariant().Contains(search.ToLowerInvariant())).ToList());
        }

        public Task<bool> UpdateAsync(int id, Course course)
        {
            var courseToUpdate = repo.FirstOrDefault(c => c.Id == id);
            if (courseToUpdate != null)
            {
                courseToUpdate.Name = course.Name;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Author = course.Author;
                courseToUpdate.Uri = course.Uri;

                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
