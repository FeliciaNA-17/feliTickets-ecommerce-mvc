using feliTickets.Data.Enums;
using feliTickets.Data.Static;
using feliTickets.Models;
using Microsoft.AspNetCore.Identity;

namespace feliTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                    new Cinema()
                        {
                            Name = "Cinema IMAX",
                            Logo = "/img/cinema-1.jpeg",
                            Description = "IMAX is a proprietary system of high-resolution cameras, film formats, film projectors, and theaters known for having very large screens with a tall aspect ratio and steep stadium seating"
                        },

                        new Cinema()
                        {
                            Name = "Cinema HOUSE",
                            Logo = "/img/cinema-2.jpeg",
                            Description = "Cinema that have the sense when u are at home"
                        },
                        new Cinema()
                        {
                            Name = "Cinema VELVET",
                            Logo = "/img/cinema-3.jpeg",
                            Description = "VELVET cinema gives you a recliner to watch your movie on, complete with cushions and blanket."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4Dx",
                            Logo = "/img/cinema-4.jpeg",
                            Description = "It allows films to be augmented with various practical effects, including motion-seats, wind, strobe-lights, simulated-snow, and scents"
                        },
                        new Cinema()
                        {
                            Name = "Cinema SATIN",
                            Logo = "/img/cinema-5.jpeg",
                            Description = "gives you a recliner to watch your movie on"
                        },
                    });
                    context.SaveChanges();


                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "/img/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/img/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/img/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/img/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/img/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();


                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "George R. R. Martin",
                            Bio = "is an American novelist, screenwriter, television producer and short story writer.",
                            ProfilePictureURL = "/img/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "David Benioff",
                            Bio = "is an American writer, director and producer.",
                            ProfilePictureURL = "/img/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Vanessa Taylor",
                            Bio = "an American screenwriter and television producer",
                            ProfilePictureURL = "/img/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "George Vincent Gilligan jr",
                            Bio = "He is known for his television work, specifically as creator, head writer, executive producer, and director of AMC's Breaking Bad and its spin-off prequel series Better Call Saul",
                            ProfilePictureURL = "/img/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Bryan Cranston",
                            Bio = "is an American actor, director, and producer who is best known for portraying Walter White in the AMC crime drama series ",
                            ProfilePictureURL = "/img/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Breaking Bad Season 1",
                            Description = "A chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine with a former student in order to secure his family's future.",
                            Price = 50000,
                            ImageURL = "/img/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Game of Thrones",
                            Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia",
                            Price = 65000,
                            ImageURL = "/img/movie-2.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Avatar: The Way of Water",
                            Description = "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora. Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their home.",
                            Price = 55000,
                            ImageURL = "/img/movie-3.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Interstellar",
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Price = 50000,
                            ImageURL = "/img/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Joker",
                            Description = "The rise of Arthur Fleck, from aspiring stand-up comedian and pariah to Gotham's clown prince and leader of the revolution.",
                            Price = 50000,
                            ImageURL = "/img/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "All Quiet on the Western Front",
                            Description = "A young German soldier's terrifying experiences and distress on the western front during World War I.",
                            Price = 50000,
                            ImageURL = "/img/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Documentary
                        }
                    });
                    context.SaveChanges();


                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                    new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });

                    context.SaveChanges();


                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@felitickets.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }



                string appUserEmail = "user@felitickets.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
