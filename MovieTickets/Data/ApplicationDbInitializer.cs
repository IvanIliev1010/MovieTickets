using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Adding Data
                /*For the cinema*/
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Palace Veliko Tarnovo",
                            Logo = "https://veliko-tarnovo.net/tarnovo/wp-content/uploads/2016/12/IMG_0486.jpg",
                            Description = "This Movie theather finds itself in Mall Veliko Tarnovo"

                        },

                         new Cinema()
                        {
                            Name = "Iskra Movie Theater",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fkino.novo5.com%2Fa%2Fkinopolis-iskra-veliko-trnovo&psig=AOvVaw2hEpKGMV6ll677B7JwOoV_&ust=1642940606242000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJCe4uusxfUCFQAAAAAdAAAAABAG",
                           Description = "placed in the central part  of the city this Movie theater has the newest Dolby Surround system and modern furniture, adding a fresh look of the historical Building "

                        },
                          new Cinema()
                        {
                            Name = "Iskra  Summer Theater",
                            Logo = "https://www.oblastvt.com/admin/uploads/img_1591773446_big.JPG",
                            Description = "Watching a movie under the stars in  a hot summer night"

                        },
                    });
                    context.SaveChanges();
                }
                /*For the Actors*/
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        FullName = "Arnold Schwarzenegger",
                        Biograhpy = "Born in the austrian alps with little to nothing, this man became an icon in the Bodyduilding sport and the best paid actor in all times",
                        ProfilePictureURL = "https://images.news18.com/ibnlive/uploads/2022/01/arnold-schwarzenegger.jpg"
                    },

                    new Actor()
                    {
                        FullName = "Danny DeVito",
                        Biograhpy = "Daniel Michael DeVito Jr. (born November 17, 1944) is an American actor, film director, producer, and screenwriter. He gained prominence for his portrayal of the taxi dispatcher Louie De Palma in the television series Taxi .",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Danny_DeVito_cropped_and_edited_for_brightness.jpg/640px-Danny_DeVito_cropped_and_edited_for_brightness.jpg"
                    },

                    new Actor()
                    {
                        FullName = "Harrison Ford",
                        Biograhpy = "Ford was born in Chicago and was raised in the city’s suburbs. After attending Ripon College in Wisconsin, he took minor acting roles in movies and television for Columbia and Universal studios but soon fell back on a sideline career in carpentry. ",
                        ProfilePictureURL = "https://www.reuters.com/resizer/1NAfAajqMlXB9_Ay5ynfWCHTj98=/1920x2400/smart/filters:quality(80)/cloudfront-us-east-2.images.arcpublishing.com/reuters/R2SZUQN7NNMHFNCGUSGIGSCBJA.jpg"
                    },

                    new Actor()
                    {
                        FullName = "Michael J Fox",
                        Biograhpy = "Michael Andrew Fox OC (born June 9, 1961), known professionally as Michael J. Fox, is a Canadian-American retired actor. Beginning his career in the 1970s, he first rose to prominence for portraying Alex P. Keaton on the NBC sitcom Family Ties (1982–1989). Fox achieved further recognition as protagonist Marty McFly in the Back to the Future film trilogy (1985–1990). ",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/en/d/d8/Michael_J._Fox_as_Marty_McFly_in_Back_to_the_Future%2C_1985.jpg"
                    },

                     new Actor()
                    {
                        FullName = "Christopher Lloyd",
                        Biograhpy = "hristopher Allen Lloyd (born October 22, 1938) is an American actor. He has appeared in many theater productions, films, and on television since 1961, and is known for portraying Dr. Emmett (Doc) Brown in the Back to the Future trilogy ",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Christopher_Lloyd_2015_%28cropped%29.jpg/330px-Christopher_Lloyd_2015_%28cropped%29.jpg"
                    }

                });
                    context.SaveChanges();
                }

                /*For the Producers*/
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                    new Producer()
                        {
                            FullName = "Ivan Reitman",
                            Biograhpy = "Ivan Reitman was born in Komárno, Czechoslovakia, on October 27, 1946, the son of Klara and Ladislav (Leslie) Reitman. Both of Reitman's parents were Hungarian Jews; his mother survived the Auschwitz concentration camp and his father was an underground resistance fighter.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/06/Ivan_Reitman_2011.jpg"
                        },
                    new Producer()
                        {
                            FullName = "Robert Zemeckis",
                            Biograhpy = "Zemeckis studied filmmaking at the University of Southern California (B.A., 1973), where he met fellow student Robert Gale, who would become his longtime screenwriting partner. Even before Zemeckis graduated, his work caught the eye of famed American director Steven Spielberg, who produced Zemeckis and Gale’s first full-length film, I Wanna Hold Your Hand (1978). ",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTgyMTMzMDUyNl5BMl5BanBnXkFtZTcwODA0ODMyMw@@._V1_.jpg"
                        },
                    new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Biograhpy = "Spielberg developed an interest in filmmaking as a child, and during his teens his Escape to Nowhere (1962), a 40-minute war movie, won first prize at a film festival. He next directed Firelight (1964), a feature-length science-fiction yarn, which was followed by an accomplished short about hitchhikers called Amblin’ (1968).",
                            ProfilePictureURL = "https://cdn.britannica.com/95/176995-050-609666E2/Steven-Spielberg-2013.jpg"
                        },
                    new Producer()
                        {
                            FullName = "Bob Gale",
                            Biograhpy = "Gale was born and raised in St. Louis, Missouri, and graduated Phi Beta Kappa with a B.A. in Cinema from the University of Southern California in 1973. He has written over 30 screenplays",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTU1OTAxNzAwNl5BMl5BanBnXkFtZTcwMjk5NTQzMQ@@._V1_.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                /*For the Movies*/
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Back to the Future",
                            Descripiton = "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the eccentric scientist Doc Brown.",
                            Price = 5,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(10),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId =1,
                            ProducerId =4,
                            MovieCategory =MovieCategory.Science_Ficiton
                        },

                         new Movie()
                        {
                            Name = "Indiana Jones and the Raiders of the Lost Ark",
                            Descripiton = "In 1936, archaeologist and adventurer Indiana Jones is hired by the U.S. government to find the Ark of the Covenant before Adolf Hitler's Nazis can obtain its awesome powers.",
                            Price = 7,
                            ImageURL = "https://m.media-amazon.com/images/I/51K8ouYrHeL.jpg",
                            StartDate = DateTime.Now.AddDays(20),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId =2,
                            ProducerId =3,
                            MovieCategory =MovieCategory.Action
                        },

                         new Movie()
                        {
                            Name = "Twins",
                            Descripiton = "A physically perfect but innocent man goes in search of his long-lost twin brother, who is short, a womanizer, and small-time crook.",
                            Price = 6,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMWUzN2VkY2ItYmQ4YS00MjFmLWJhZDQtYWY1NWQ2NTA5NDNlXkEyXkFqcGdeQXVyNDc2NjEyMw@@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId =3,
                            ProducerId =1,
                            MovieCategory =MovieCategory.Comedy
                        },
                    });
                    context.SaveChanges();
                }
                /*relationship betweeen the actors and the movies*/
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId =4,
                            MovieId =1,
                        },
                        new Actor_Movie()
                        {
                            ActorId =5,
                            MovieId =1,
                        },
                        new Actor_Movie()
                        {
                            ActorId =3,
                            MovieId =2,
                        },
                        new Actor_Movie()
                        {
                            ActorId =1,
                            MovieId =3,
                        },
                        new Actor_Movie()
                        {
                            ActorId =2,
                            MovieId =1,
                        }
                    });
                    context.SaveChanges();
                }

            }

        }
    }
}
