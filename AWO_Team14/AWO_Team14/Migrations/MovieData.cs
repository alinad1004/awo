using AWO_Team14.Models;
using AWO_Team14.DAL;
using System.Data.Entity.Migrations;
using System;
using System.Linq;

namespace AWO_Team14.Migrations
{
	public class MovieData
	{
		public void SeedMovies(AppDbContext db)
		{
			Movie m1 = new Movie();
			m1.MovieNumber = 3001;
			m1.Title = "42nd Street";
			m1.Overview = "A producer puts on what may be his last Broadway show, and at the last moment a chorus girl has to replace the star.";
			m1.Tagline = "OK. Say, Jones and Barry are doin' a show! - That's great. Jones and Barry are doin' a show.";
			m1.MPAA_Rating = MPAA.Unrated;
			m1.Actors = "Warner Baxter, Bebe Daniels, George Brent, Ruby Keeler, Guy Kibbee, Una Merkel";
			m1.ReleaseYear = 1933;
			m1.Runtime = new TimeSpan(0, 89, 0);
			db.Movies.AddOrUpdate(m => m.Title, m1);
			db.SaveChanges();
			m1 = db.Movies.FirstOrDefault(m => m.MovieNumber == m1.MovieNumber);
			m1.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m1.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m1.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m2 = new Movie();
			m2.MovieNumber = 3002;
			m2.Title = "It Happened One Night";
			m2.Overview = "Ellie Andrews has just tied the knot with society aviator King Westley when she is whisked away to her father's yacht and out of King's clutches. Ellie jumps ship and eventually winds up on a bus headed back to her husband. Reluctantly she must accept the help of out-of- work reporter Peter Warne. Actually, Warne doesn't give her any choice: either she sticks with him until he gets her back to her husband, or he'll blow the whistle on Ellie to her father. Either way, Peter gets what he wants... a really juicy newspaper story!";
			m2.Tagline = "TOGETHER... for the first time";
			m2.MPAA_Rating = MPAA.Unrated;
			m2.Actors = "Clark Gable, Claudette Colbert, Walter Connolly, Roscoe Karns, Jameson Thomas, Alan Hale";
			m2.ReleaseYear = 1934;
			m2.Runtime = new TimeSpan(0, 105, 0);
			db.Movies.AddOrUpdate(m => m.Title, m2);
			db.SaveChanges();
			m2 = db.Movies.FirstOrDefault(m => m.MovieNumber == m2.MovieNumber);
			m2.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m2.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m3 = new Movie();
			m3.MovieNumber = 3003;
			m3.Title = "Snow White and the Seven Dwarfs";
			m3.Overview = "A beautiful girl, Snow White, takes refuge in the forest in the house of seven dwarfs to hide from her stepmother, the wicked Queen. The Queen is jealous because she wants to be known as 'the fairest in the land,' and Snow White's beauty surpasses her own.";
			m3.Tagline = "The Happiest, Dopiest, Grumpiest, Sneeziest movie of the year.";
			m3.MPAA_Rating = MPAA.G;
			m3.Actors = "Adriana Caselotti, Lucille La Verne, Harry Stockwell, Roy Atwell, Pinto Colvig, Otis Harlan";
			m3.ReleaseYear = 1937;
			m3.Runtime = new TimeSpan(0, 83, 0);
			db.Movies.AddOrUpdate(m => m.Title, m3);
			db.SaveChanges();
			m3 = db.Movies.FirstOrDefault(m => m.MovieNumber == m3.MovieNumber);
			m3.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m3.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m3.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m4 = new Movie();
			m4.MovieNumber = 3004;
			m4.Title = "The Wizard of Oz";
			m4.Overview = "Young Dorothy finds herself in a magical world where she makes friends with a lion, a scarecrow and a tin man as they make their way along the yellow brick road to talk with the Wizard and ask for the things they miss most in their lives. The Wicked Witch of the West is the only thing that could stop them.";
			m4.Tagline = "We're off to see the Wizard, the wonderful Wizard of Oz!";
			m4.MPAA_Rating = MPAA.PG;
			m4.Actors = "Judy Garland, Frank Morgan, Ray Bolger, Bert Lahr, Jack Haley, Billie Burke";
			m4.ReleaseYear = 1939;
			m4.Runtime = new TimeSpan(0, 102, 0);
			db.Movies.AddOrUpdate(m => m.Title, m4);
			db.SaveChanges();
			m4 = db.Movies.FirstOrDefault(m => m.MovieNumber == m4.MovieNumber);
			m4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m5 = new Movie();
			m5.MovieNumber = 3005;
			m5.Title = "Mr. Smith Goes to Washington";
			m5.Overview = "Naive and idealistic Jefferson Smith, leader of the Boy Rangers, is appointed on a lark by the spineless governor of his state. He is reunited with the state's senior senator--presidential hopeful and childhood hero, Senator Joseph Paine. In Washington, however, Smith discovers many of the shortcomings of the political process as his earnest goal of a national boys' camp leads to a conflict with the state political boss, Jim Taylor. Taylor first tries to corrupt Smith and then later attempts to destroy Smith through a scandal.";
			m5.Tagline = "Romance, drama, laughter and heartbreak... created out of the very heart and soil of America!";
			m5.MPAA_Rating = MPAA.Unrated;
			m5.Actors = "James Stewart, Jean Arthur, Claude Rains, Edward Arnold, Guy Kibbee, Thomas Mitchell";
			m5.ReleaseYear = 1939;
			m5.Runtime = new TimeSpan(0, 129, 0);
			db.Movies.AddOrUpdate(m => m.Title, m5);
			db.SaveChanges();
			m5 = db.Movies.FirstOrDefault(m => m.MovieNumber == m5.MovieNumber);
			m5.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m5.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m5.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));

			db.SaveChanges();

			Movie m6 = new Movie();
			m6.MovieNumber = 3006;
			m6.Title = "Gone with the Wind";
			m6.Overview = "An American classic in which a manipulative woman and a roguish man carry on a turbulent love affair in the American south during the Civil War and Reconstruction.";
			m6.Tagline = "The greatest romance of all time!";
			m6.MPAA_Rating = MPAA.G;
			m6.Actors = "Vivien Leigh, Clark Gable, Olivia de Havilland, Thomas Mitchell, Leslie Howard, Barbara O'Neil";
			m6.ReleaseYear = 1939;
			m6.Runtime = new TimeSpan(0, 238, 0);
			db.Movies.AddOrUpdate(m => m.Title, m6);
			db.SaveChanges();
			m6 = db.Movies.FirstOrDefault(m => m.MovieNumber == m6.MovieNumber);
			m6.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m6.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m7 = new Movie();
			m7.MovieNumber = 3007;
			m7.Title = "Casablanca";
			m7.Overview = "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.";
			m7.Tagline = "They had a date with fate in Casablanca!";
			m7.MPAA_Rating = MPAA.PG;
			m7.Actors = "Humphrey Bogart, Ingrid Bergman, Paul Henreid, Claude Rains, Conrad Veidt, Sydney Greenstreet";
			m7.ReleaseYear = 1942;
			m7.Runtime = new TimeSpan(0, 102, 0);
			db.Movies.AddOrUpdate(m => m.Title, m7);
			db.SaveChanges();
			m7 = db.Movies.FirstOrDefault(m => m.MovieNumber == m7.MovieNumber);
			m7.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m7.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m8 = new Movie();
			m8.MovieNumber = 3008;
			m8.Title = "It's a Wonderful Life";
			m8.Overview = "George Bailey has spent his entire life giving of himself to the people of Bedford Falls. He has always longed to travel but never had the opportunity in order to prevent rich skinflint Mr. Potter from taking over the entire town. All that prevents him from doing so is George's modest building and loan company, which was founded by his generous father. But on Christmas Eve, George's Uncle Billy loses the business's $8,000 while intending to deposit it in the bank. Potter finds the misplaced money, hides it from Billy, and George's troubles begin.";
			m8.Tagline = "It's a wonderful laugh! It's a wonderful love!";
			m8.MPAA_Rating = MPAA.PG;
			m8.Actors = "James Stewart, Donna Reed, Lionel Barrymore, Thomas Mitchell, Henry Travers, Beulah Bondi";
			m8.ReleaseYear = 1946;
			m8.Runtime = new TimeSpan(0, 130, 0);
			db.Movies.AddOrUpdate(m => m.Title, m8);
			db.SaveChanges();
			m8 = db.Movies.FirstOrDefault(m => m.MovieNumber == m8.MovieNumber);
			m8.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m8.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m8.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m9 = new Movie();
			m9.MovieNumber = 3009;
			m9.Title = "Annie Get Your Gun";
			m9.Overview = "This film adaptation of Irving Berlin's classic musical stars Betty Hutton as gunslinger Annie Oakley, who romances fellow sharpshooter Frank Butler (Howard Keel) as they travel with Buffalo Bill's Wild West Show. Previously off target when it comes to love, Annie proves you can get a man with a gun in this battle-of-the-sexes extravaganza, which features timeless numbers like 'Anything You Can Do' and 'There's No Business Like Show Business.'";
			m9.Tagline = "Biggest musical under the sun!";
			m9.MPAA_Rating = MPAA.Unrated;
			m9.Actors = "Betty Hutton, Howard Keel, Louis Calhern, J. Carrol Naish, Edward Arnold, Keenan Wynn";
			m9.ReleaseYear = 1950;
			m9.Runtime = new TimeSpan(0, 107, 0);
			db.Movies.AddOrUpdate(m => m.Title, m9);
			db.SaveChanges();
			m9 = db.Movies.FirstOrDefault(m => m.MovieNumber == m9.MovieNumber);
			m9.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m9.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m9.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m9.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Western"));

			db.SaveChanges();

			Movie m10 = new Movie();
			m10.MovieNumber = 3010;
			m10.Title = "A Streetcar Named Desire";
			m10.Overview = "Disturbed Blanche DuBois moves in with her sister in New Orleans and is tormented by her brutish brother-in-law while her reality crumbles around her.";
			m10.Tagline = "...Blanche, who wanted so much to stay a lady...";
			m10.MPAA_Rating = MPAA.PG;
			m10.Actors = "Vivien Leigh, Marlon Brando, Kim Hunter, Karl Malden, Rudy Bond, Nick Dennis";
			m10.ReleaseYear = 1951;
			m10.Runtime = new TimeSpan(0, 125, 0);
			db.Movies.AddOrUpdate(m => m.Title, m10);
			db.SaveChanges();
			m10 = db.Movies.FirstOrDefault(m => m.MovieNumber == m10.MovieNumber);
			m10.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m11 = new Movie();
			m11.MovieNumber = 3011;
			m11.Title = "Singin' in the Rain";
			m11.Overview = "In 1927 Hollywood, Don Lockwood and Lina Lamont are a famous on-screen romantic pair in silent movies, but Lina mistakes the on-screen romance for real love. When their latest film is transformed into a musical, Don has the perfect voice for the songs, but strident voice faces the studio to dub her voice. Aspiring actress, Kathy Selden is brought in and, while she is working on the movie, Don falls in love with her.";
			m11.Tagline = "What a Glorious Feeling!";
			m11.MPAA_Rating = MPAA.G;
			m11.Actors = "Gene Kelly, Donald O'Connor, Debbie Reynolds, Jean Hagen, Millard Mitchell, Cyd Charisse";
			m11.ReleaseYear = 1952;
			m11.Runtime = new TimeSpan(0, 103, 0);
			db.Movies.AddOrUpdate(m => m.Title, m11);
			db.SaveChanges();
			m11 = db.Movies.FirstOrDefault(m => m.MovieNumber == m11.MovieNumber);
			m11.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m11.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m11.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m12 = new Movie();
			m12.MovieNumber = 3012;
			m12.Title = "Cat on a Hot Tin Roof";
			m12.Overview = "Brick, an alcoholic ex-football player, drinks his days away and resists the affections of his wife, Maggie. His reunion with his father, Big Daddy, who is dying of cancer, jogs a host of memories and revelations for both father and son.";
			m12.Tagline = "Just one pillow on her bed ... and just one desire in her heart!";
			m12.MPAA_Rating = MPAA.Unrated;
			m12.Actors = "Elizabeth Taylor, Paul Newman, Burl Ives, Judith Anderson, Jack Carson, Madeleine Sherwood";
			m12.ReleaseYear = 1958;
			m12.Runtime = new TimeSpan(0, 108, 0);
			db.Movies.AddOrUpdate(m => m.Title, m12);
			db.SaveChanges();
			m12 = db.Movies.FirstOrDefault(m => m.MovieNumber == m12.MovieNumber);
			m12.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m12.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m13 = new Movie();
			m13.MovieNumber = 3013;
			m13.Title = "Some Like It Hot";
			m13.Overview = "Two musicians witness a mob hit and struggle to find a way out of the city before they are found by the gangsters. Their only opportunity is to join an all-girl band as they leave on a tour. To make their getaway they must first disguise themselves as women, then keep their identities secret and deal with the problems this brings - such as an attractive bandmate and a very determined suitor.";
			m13.Tagline = "The movie too HOT for words!";
			m13.MPAA_Rating = MPAA.Unrated;
			m13.Actors = "Marilyn Monroe, Tony Curtis, Jack Lemmon, George Raft, Pat O\u2019Brien, Joe E. Brown";
			m13.ReleaseYear = 1959;
			m13.Runtime = new TimeSpan(0, 122, 0);
			db.Movies.AddOrUpdate(m => m.Title, m13);
			db.SaveChanges();
			m13 = db.Movies.FirstOrDefault(m => m.MovieNumber == m13.MovieNumber);
			m13.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m13.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m14 = new Movie();
			m14.MovieNumber = 3014;
			m14.Title = "Psycho";
			m14.Overview = "When larcenous real estate clerk Marion Crane goes on the lam with a wad of cash and hopes of starting a new life, she ends up at the notorious Bates Motel, where manager Norman Bates cares for his housebound mother. The place seems quirky, but fine… until Marion decides to take a shower.";
			m14.Tagline = "The master of suspense moves his cameras into the icy blackness of the unexplored!";
			m14.MPAA_Rating = MPAA.R;
			m14.Actors = "Anthony Perkins, Vera Miles, John Gavin, Janet Leigh, Martin Balsam, John McIntire";
			m14.ReleaseYear = 1960;
			m14.Runtime = new TimeSpan(0, 109, 0);
			db.Movies.AddOrUpdate(m => m.Title, m14);
			db.SaveChanges();
			m14 = db.Movies.FirstOrDefault(m => m.MovieNumber == m14.MovieNumber);
			m14.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m14.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m14.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m15 = new Movie();
			m15.MovieNumber = 3015;
			m15.Title = "West Side Story";
			m15.Overview = "In the slums of the upper West Side of Manhattan, New York, a gang of Polish-American teenagers called the Jets compete with a rival gang of recently immigrated Puerto Ricans, the Sharks, to'own' the neighborhood streets. Tensions are high between the gangs but two kids, one from each rival gang, fall in love leading to tragedy.";
			m15.Tagline = "The screen achieves one of the great entertainments in the history of motion pictures";
			m15.MPAA_Rating = MPAA.Unrated;
			m15.Actors = "Natalie Wood, Richard Beymer, Russ Tamblyn, Rita Moreno, George Chakiris, Simon Oakland";
			m15.ReleaseYear = 1961;
			m15.Runtime = new TimeSpan(0, 152, 0);
			db.Movies.AddOrUpdate(m => m.Title, m15);
			db.SaveChanges();
			m15 = db.Movies.FirstOrDefault(m => m.MovieNumber == m15.MovieNumber);
			m15.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m15.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m15.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));

			db.SaveChanges();

			Movie m16 = new Movie();
			m16.MovieNumber = 3016;
			m16.Title = "The Man Who Shot Liberty Valance";
			m16.Overview = "A senator, who became famous for killing a notorious outlaw, returns for the funeral of an old friend and tells the truth about his deed.";
			m16.Tagline = "Together For The First Time - James Stewart - John Wayne - in the masterpiece of four-time Academy Award winner John Ford";
			m16.MPAA_Rating = MPAA.Unrated;
			m16.Actors = "John Wayne, James Stewart, Vera Miles, Lee Marvin, Edmond O'Brien, Ken Murray";
			m16.ReleaseYear = 1962;
			m16.Runtime = new TimeSpan(0, 123, 0);
			db.Movies.AddOrUpdate(m => m.Title, m16);
			db.SaveChanges();
			m16 = db.Movies.FirstOrDefault(m => m.MovieNumber == m16.MovieNumber);
			m16.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Western"));

			db.SaveChanges();

			Movie m17 = new Movie();
			m17.MovieNumber = 3017;
			m17.Title = "Dr. No";
			m17.Overview = "In the film that launched the James Bond saga, Agent 007 battles mysterious Dr. No, a scientific genius bent on destroying the U.S. space program. As the countdown to disaster begins, Bond must go to Jamaica, where he encounters beautiful Honey Ryder, to confront a megalomaniacal villain in his massive island headquarters.";
			m17.Tagline = "NOW meet the most extraordinary gentleman spy in all fiction!";
			m17.MPAA_Rating = MPAA.PG;
			m17.Actors = "Sean Connery, Ursula Andress, Joseph Wiseman, Jack Lord, Bernard Lee, Anthony Dawson";
			m17.ReleaseYear = 1962;
			m17.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m17);
			db.SaveChanges();
			m17 = db.Movies.FirstOrDefault(m => m.MovieNumber == m17.MovieNumber);
			m17.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m17.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m17.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m18 = new Movie();
			m18.MovieNumber = 3018;
			m18.Title = "Lawrence of Arabia";
			m18.Overview = "An epic about British officer T.E. Lawrence's mission to aid the Arab tribes in their revolt against the Ottoman Empire during the First World War. Lawrence becomes a flamboyant, messianic figure in the cause of Arab unity but his psychological instability threatens to undermine his achievements.";
			m18.Tagline = "A Mighty Motion Picture Of Action And Adventure!";
			m18.MPAA_Rating = MPAA.PG;
			m18.Actors = "Peter O'Toole, Alec Guinness, Anthony Quinn, Jack Hawkins, Omar Sharif, Claude Rains";
			m18.ReleaseYear = 1962;
			m18.Runtime = new TimeSpan(0, 216, 0);
			db.Movies.AddOrUpdate(m => m.Title, m18);
			db.SaveChanges();
			m18 = db.Movies.FirstOrDefault(m => m.MovieNumber == m18.MovieNumber);
			m18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "History"));
			m18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));

			db.SaveChanges();

			Movie m19 = new Movie();
			m19.MovieNumber = 3019;
			m19.Title = "To Kill a Mockingbird";
			m19.Overview = "In a small Alabama town in the 1930s, scrupulously honest and highly respected lawyer, Atticus Finch puts his career on the line when he agrees to represent Tom Robinson, a black man accused of rape. The trial and the events surrounding it are seen through the eyes of Finch's six-year-old daughter, Scout. While Robinson's trial gives the movie its momentum, there are plenty of anecdotal occurrences before and after the court date: Scout's ever-strengthening bond with older brother, Jem, her friendship with precocious young Dill Harris, her father's no-nonsense reactions to such life-and-death crises as a rampaging mad dog, and especially Scout's reactions to, and relationship with, Boo Radley, the reclusive 'village idiot' who turns out to be her salvation when she is attacked by a venomous bigot.";
			m19.Tagline = "The most beloved Pulitzer Prize book now comes vividly alive on the screen!�";
			m19.MPAA_Rating = MPAA.Unrated;
			m19.Actors = "Gregory Peck, Brock Peters, James Anderson, Mary Badham, Phillip Alford, John Megna";
			m19.ReleaseYear = 1962;
			m19.Runtime = new TimeSpan(0, 129, 0);
			db.Movies.AddOrUpdate(m => m.Title, m19);
			db.SaveChanges();
			m19 = db.Movies.FirstOrDefault(m => m.MovieNumber == m19.MovieNumber);
			m19.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m19.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m20 = new Movie();
			m20.MovieNumber = 3020;
			m20.Title = "A Hard Day's Night";
			m20.Overview = "Capturing John Lennon, Paul McCartney, George Harrison and Ringo Starr in their electrifying element, 'A Hard Day's Night' is a wildly irreverent journey through this pastiche of a day in the life of The Beatles during 1964. The band have to use all their guile and wit to avoid the pursuing fans and press to reach their scheduled television performance, in spite of Paul's troublemaking grandfather and Ringo's arrest.";
			m20.Tagline = "The Beatles, starring in their first full-length, hilarious, action-packed film!";
			m20.MPAA_Rating = MPAA.G;
			m20.Actors = "John Lennon, Paul McCartney, George Harrison, Ringo Starr, Wilfrid Brambell, Norman Rossington";
			m20.ReleaseYear = 1964;
			m20.Runtime = new TimeSpan(0, 88, 0);
			db.Movies.AddOrUpdate(m => m.Title, m20);
			db.SaveChanges();
			m20 = db.Movies.FirstOrDefault(m => m.MovieNumber == m20.MovieNumber);
			m20.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m20.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));

			db.SaveChanges();

			Movie m21 = new Movie();
			m21.MovieNumber = 3021;
			m21.Title = "Mary Poppins";
			m21.Overview = "The movie combines a diverting story, songs, color and sequences of live action blended with the movements of animated figures. Mary Poppins is a kind of Super-nanny who flies in with her umbrella in response to the request of the Banks children and proceeds to put things right with the aid of her rather extraordinary magical powers before flying off again.";
			m21.Tagline = "It's supercalifragilisticexpialidocious!";
			m21.MPAA_Rating = MPAA.G;
			m21.Actors = "Julie Andrews, Dick Van Dyke, David Tomlinson, Glynis Johns, Hermione Baddeley, Reta Shaw";
			m21.ReleaseYear = 1964;
			m21.Runtime = new TimeSpan(0, 139, 0);
			db.Movies.AddOrUpdate(m => m.Title, m21);
			db.SaveChanges();
			m21 = db.Movies.FirstOrDefault(m => m.MovieNumber == m21.MovieNumber);
			m21.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m21.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m21.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m22 = new Movie();
			m22.MovieNumber = 3022;
			m22.Title = "My Fair Lady";
			m22.Overview = "A misogynistic and snobbish phonetics professor agrees to a wager that he can take a flower girl and make her presentable in high society.";
			m22.Tagline = "The loverliest motion picture of them all!";
			m22.MPAA_Rating = MPAA.G;
			m22.Actors = "Audrey Hepburn, Rex Harrison, Stanley Holloway, Wilfrid Hyde-White, Gladys Cooper, Jeremy Brett";
			m22.ReleaseYear = 1964;
			m22.Runtime = new TimeSpan(0, 170, 0);
			db.Movies.AddOrUpdate(m => m.Title, m22);
			db.SaveChanges();
			m22 = db.Movies.FirstOrDefault(m => m.MovieNumber == m22.MovieNumber);
			m22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m23 = new Movie();
			m23.MovieNumber = 3023;
			m23.Title = "The Sound of Music";
			m23.Overview = "Film adaptation of a classic Rodgers and Hammerstein musical based on a nun who becomes a governess for an Austrian family.";
			m23.Tagline = "The happiest sound in all the world!";
			m23.MPAA_Rating = MPAA.G;
			m23.Actors = "Julie Andrews, Christopher Plummer, Eleanor Parker, Richard Haydn, Peggy Wood, Charmian Carr";
			m23.ReleaseYear = 1965;
			m23.Runtime = new TimeSpan(0, 174, 0);
			db.Movies.AddOrUpdate(m => m.Title, m23);
			db.SaveChanges();
			m23 = db.Movies.FirstOrDefault(m => m.MovieNumber == m23.MovieNumber);
			m23.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m23.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m23.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m23.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m24 = new Movie();
			m24.MovieNumber = 3024;
			m24.Title = "Butch Cassidy and the Sundance Kid";
			m24.Overview = "In late 1890s Wyoming, Butch Cassidy is the affable, clever and talkative leader of the outlaw Hole in the Wall Gang. His closest companion is the laconic dead-shot 'Sundance Kid'. As the west rapidly becomes civilized, the law finally catches up to Butch, Sundance and their gang.  Chased doggedly by a special posse, the two decide to make their way to South America in hopes of evading their pursuers once and for all.";
			m24.Tagline = "Not that it matters, but most of it is true.";
			m24.MPAA_Rating = MPAA.PG;
			m24.Actors = "Paul Newman, Robert Redford, Katharine Ross, Strother Martin, Henry Jones, Jeff Corey";
			m24.ReleaseYear = 1969;
			m24.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m24);
			db.SaveChanges();
			m24 = db.Movies.FirstOrDefault(m => m.MovieNumber == m24.MovieNumber);
			m24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "History"));
			m24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Western"));
			m24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m25 = new Movie();
			m25.MovieNumber = 3025;
			m25.Title = "Catch-22";
			m25.Overview = "A bombardier in World War II tries desperately to escape the insanity of the war. However, sometimes insanity is the only sane way to cope with a crazy situation. Catch-22 is a parody of a 'military mentality' and of a bureaucratic society in general.";
			m25.Tagline = "The anti-war satire of epic proportions.";
			m25.MPAA_Rating = MPAA.R;
			m25.Actors = "Martin Balsam, Richard Benjamin, Art Garfunkel, Jack Gilford, Buck Henry, Bob Newhart";
			m25.ReleaseYear = 1970;
			m25.Runtime = new TimeSpan(0, 121, 0);
			db.Movies.AddOrUpdate(m => m.Title, m25);
			db.SaveChanges();
			m25 = db.Movies.FirstOrDefault(m => m.MovieNumber == m25.MovieNumber);
			m25.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));
			m25.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m25.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m26 = new Movie();
			m26.MovieNumber = 3026;
			m26.Title = "Willy Wonka & the Chocolate Factory";
			m26.Overview = "Eccentric candy man Willy Wonka prompts a worldwide frenzy when he announces that golden tickets hidden inside five of his delicious candy bars will admit their lucky holders into his top-secret confectionary. But does Wonka have an agenda hidden amid a world of Oompa Loompas and chocolate rivers?";
			m26.Tagline = "It's Scrumdiddlyumptious!";
			m26.MPAA_Rating = MPAA.G;
			m26.Actors = "Gene Wilder, Jack Albertson, Peter Ostrum, Roy Kinnear, Denise Nickerson, Leonard Stone";
			m26.ReleaseYear = 1971;
			m26.Runtime = new TimeSpan(0, 100, 0);
			db.Movies.AddOrUpdate(m => m.Title, m26);
			db.SaveChanges();
			m26 = db.Movies.FirstOrDefault(m => m.MovieNumber == m26.MovieNumber);
			m26.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m26.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m27 = new Movie();
			m27.MovieNumber = 3027;
			m27.Title = "Fiddler on the Roof";
			m27.Overview = "This lavishly produced and critically acclaimed screen adaptation of the international stage sensation tells the life-affirming story of Tevye (Topol), a poor milkman whose love, pride and faith help him face the oppression of turn-of-the-century Czarist Russia. Nominated for eight Academy Awards.";
			m27.Tagline = "To Life!";
			m27.MPAA_Rating = MPAA.G;
			m27.Actors = "Chaim Topol, Norma Crane, Leonard Frey, Molly Picon, Paul Mann, Rosalind Harris";
			m27.ReleaseYear = 1971;
			m27.Runtime = new TimeSpan(0, 181, 0);
			db.Movies.AddOrUpdate(m => m.Title, m27);
			db.SaveChanges();
			m27 = db.Movies.FirstOrDefault(m => m.MovieNumber == m27.MovieNumber);
			m27.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m27.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m28 = new Movie();
			m28.MovieNumber = 3028;
			m28.Title = "Diamonds Are Forever";
			m28.Overview = "Diamonds are stolen only to be sold again in the international market. James Bond infiltrates a smuggling mission to find out who’s guilty. The mission takes him to Las Vegas where Bond meets his archenemy Blofeld.";
			m28.Tagline = "The man who made 007 a household number";
			m28.MPAA_Rating = MPAA.PG;
			m28.Actors = "Sean Connery, Jill St. John, Charles Gray, Lana Wood, Jimmy Dean, Bruce Cabot";
			m28.ReleaseYear = 1971;
			m28.Runtime = new TimeSpan(0, 120, 0);
			db.Movies.AddOrUpdate(m => m.Title, m28);
			db.SaveChanges();
			m28 = db.Movies.FirstOrDefault(m => m.MovieNumber == m28.MovieNumber);
			m28.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m28.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m28.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m29 = new Movie();
			m29.MovieNumber = 3029;
			m29.Title = "American Graffiti";
			m29.Overview = "A couple of high school graduates spend one final night cruising the strip with their buddies before they go off to college.";
			m29.Tagline = "Where were you in '62?";
			m29.MPAA_Rating = MPAA.PG;
			m29.Actors = "Richard Dreyfuss, Ron Howard, Paul Le Mat, Charles Martin Smith, Cindy Williams, Candy Clark";
			m29.ReleaseYear = 1973;
			m29.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m29);
			db.SaveChanges();
			m29 = db.Movies.FirstOrDefault(m => m.MovieNumber == m29.MovieNumber);
			m29.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m29.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m30 = new Movie();
			m30.MovieNumber = 3030;
			m30.Title = "The Sting";
			m30.Overview = "Set in the 1930's this intricate caper deals with an ambitious small-time crook and a veteran con man who seek revenge on a vicious crime lord who murdered one of their gang.";
			m30.Tagline = "...all it takes is a little confidence.";
			m30.MPAA_Rating = MPAA.PG;
			m30.Actors = "Paul Newman, Robert Redford, Robert Shaw, Charles Durning, Ray Walston, Eileen Brennan";
			m30.ReleaseYear = 1973;
			m30.Runtime = new TimeSpan(0, 129, 0);
			db.Movies.AddOrUpdate(m => m.Title, m30);
			db.SaveChanges();
			m30 = db.Movies.FirstOrDefault(m => m.MovieNumber == m30.MovieNumber);
			m30.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m30.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m30.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m31 = new Movie();
			m31.MovieNumber = 3031;
			m31.Title = "The Exorcist";
			m31.Overview = "12-year-old Regan MacNeil begins to adapt an explicit new personality as strange events befall the local area of Georgetown. Her mother becomes torn between science and superstition in a desperate bid to save her daughter, and ultimately turns to her last hope: Father Damien Karras, a troubled priest who is struggling with his own faith.";
			m31.Tagline = "Something almost beyond comprehension is happening to a girl on this street, in this house... and a man has been sent for as a last resort. This man is The Exorcist.";
			m31.MPAA_Rating = MPAA.R;
			m31.Actors = "Linda Blair, Max von Sydow, Ellen Burstyn, Jason Miller, Lee J. Cobb, Kitty Winn";
			m31.ReleaseYear = 1973;
			m31.Runtime = new TimeSpan(0, 122, 0);
			db.Movies.AddOrUpdate(m => m.Title, m31);
			db.SaveChanges();
			m31 = db.Movies.FirstOrDefault(m => m.MovieNumber == m31.MovieNumber);
			m31.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m31.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m31.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m32 = new Movie();
			m32.MovieNumber = 3032;
			m32.Title = "Blazing Saddles";
			m32.Overview = "A town – where everyone seems to be named Johnson – is in the way of the railroad and, in order to grab their land, Hedley Lemar, a politically connected nasty person, sends in his henchmen to make the town unlivable. After the sheriff is killed, the town demands a new sheriff from the Governor, so Hedley convinces him to send the town the first black sheriff in the west.";
			m32.Tagline = "Never give a saga an even break!";
			m32.MPAA_Rating = MPAA.R;
			m32.Actors = "Cleavon Little, Gene Wilder, Harvey Korman, Slim Pickens, Madeline Kahn, Mel Brooks";
			m32.ReleaseYear = 1974;
			m32.Runtime = new TimeSpan(0, 93, 0);
			db.Movies.AddOrUpdate(m => m.Title, m32);
			db.SaveChanges();
			m32 = db.Movies.FirstOrDefault(m => m.MovieNumber == m32.MovieNumber);
			m32.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Western"));
			m32.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m33 = new Movie();
			m33.MovieNumber = 3033;
			m33.Title = "Monty Python and the Holy Grail";
			m33.Overview = "King Arthur, accompanied by his squire, recruits his Knights of the Round Table, including Sir Bedevere the Wise, Sir Lancelot the Brave, Sir Robin the Not-Quite-So-Brave-As-Sir-Lancelot and Sir Galahad the Pure. On the way, Arthur battles the Black Knight who, despite having had all his limbs chopped off, insists he can still fight. They reach Camelot, but Arthur decides not  to enter, as 'it is a silly place'.";
			m33.Tagline = "And now! At Last! Another film completely different from some of the other films which aren't quite the same as this one is.";
			m33.MPAA_Rating = MPAA.PG;
			m33.Actors = "Graham Chapman, John Cleese, Terry Gilliam, Eric Idle, Terry Jones, Michael Palin";
			m33.ReleaseYear = 1975;
			m33.Runtime = new TimeSpan(0, 91, 0);
			db.Movies.AddOrUpdate(m => m.Title, m33);
			db.SaveChanges();
			m33 = db.Movies.FirstOrDefault(m => m.MovieNumber == m33.MovieNumber);
			m33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m34 = new Movie();
			m34.MovieNumber = 3034;
			m34.Title = "Jaws";
			m34.Overview = "An insatiable great white shark terrorizes the townspeople of Amity Island, The police chief, an oceanographer and a grizzled shark hunter seek to destroy the bloodthirsty beast.";
			m34.Tagline = "Don't go in the water.";
			m34.MPAA_Rating = MPAA.PG;
			m34.Actors = "Roy Scheider, Robert Shaw, Richard Dreyfuss, Lorraine Gary, Murray Hamilton, Carl Gottlieb";
			m34.ReleaseYear = 1975;
			m34.Runtime = new TimeSpan(0, 124, 0);
			db.Movies.AddOrUpdate(m => m.Title, m34);
			db.SaveChanges();
			m34 = db.Movies.FirstOrDefault(m => m.MovieNumber == m34.MovieNumber);
			m34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m35 = new Movie();
			m35.MovieNumber = 3035;
			m35.Title = "Star Wars";
			m35.Overview = "Princess Leia is captured and held hostage by the evil Imperial forces in their effort to take over the galactic Empire. Venturesome Luke Skywalker and dashing captain Han Solo team together with the loveable robot duo R2-D2 and C-3PO to rescue the beautiful princess and restore peace and justice in the Empire.";
			m35.Tagline = "A long time ago in a galaxy far, far away...";
			m35.MPAA_Rating = MPAA.PG;
			m35.Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing, Alec Guinness, Anthony Daniels";
			m35.ReleaseYear = 1977;
			m35.Runtime = new TimeSpan(0, 121, 0);
			db.Movies.AddOrUpdate(m => m.Title, m35);
			db.SaveChanges();
			m35 = db.Movies.FirstOrDefault(m => m.MovieNumber == m35.MovieNumber);
			m35.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m35.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m35.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));

			db.SaveChanges();

			Movie m36 = new Movie();
			m36.MovieNumber = 3036;
			m36.Title = "The Spy Who Loved Me";
			m36.Overview = "Russian and British submarines with nuclear missiles on board both vanish from sight without a trace. England and Russia both blame each other as James Bond tries to solve the riddle of the disappearing ships. But the KGB also has an agent on the case.";
			m36.Tagline = "It's the BIGGEST. It's the BEST. It's BOND. And B-E-Y-O-N-D.";
			m36.MPAA_Rating = MPAA.PG;
			m36.Actors = "Roger Moore, Barbara Bach, Curd Joergens, Richard Kiel, Caroline Munro, Walter Gotell";
			m36.ReleaseYear = 1977;
			m36.Runtime = new TimeSpan(0, 125, 0);
			db.Movies.AddOrUpdate(m => m.Title, m36);
			db.SaveChanges();
			m36 = db.Movies.FirstOrDefault(m => m.MovieNumber == m36.MovieNumber);
			m36.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m36.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m36.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m37 = new Movie();
			m37.MovieNumber = 3037;
			m37.Title = "Close Encounters of the Third Kind";
			m37.Overview = "After an encounter with UFOs, a line worker feels undeniably drawn to an isolated area in the wilderness where something spectacular is about to happen.";
			m37.Tagline = "We are not alone.";
			m37.MPAA_Rating = MPAA.PG;
			m37.Actors = "Richard Dreyfuss, Francois Truffaut, Teri Garr, Melinda Dillon, Bob Balaban, J. Patrick McNamara";
			m37.ReleaseYear = 1977;
			m37.Runtime = new TimeSpan(0, 135, 0);
			db.Movies.AddOrUpdate(m => m.Title, m37);
			db.SaveChanges();
			m37 = db.Movies.FirstOrDefault(m => m.MovieNumber == m37.MovieNumber);
			m37.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m37.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m38 = new Movie();
			m38.MovieNumber = 3038;
			m38.Title = "Grease";
			m38.Overview = "Australian good girl Sandy and greaser Danny fell in love over the summer. But when they unexpectedly discover they're now in the same high school, will they be able to rekindle their romance despite their eccentric friends?";
			m38.Tagline = "Grease is the word";
			m38.MPAA_Rating = MPAA.PG13;
			m38.Actors = "John Travolta, Olivia Newton-John, Stockard Channing, Jeff Conaway, Didi Conn, Barry Pearl";
			m38.ReleaseYear = 1978;
			m38.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m38);
			db.SaveChanges();
			m38 = db.Movies.FirstOrDefault(m => m.MovieNumber == m38.MovieNumber);
			m38.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m39 = new Movie();
			m39.MovieNumber = 3039;
			m39.Title = "Animal House";
			m39.Overview = "At a 1962 College, Dean Vernon Wormer is determined to expel the entire Delta Tau Chi Fraternity, but those troublemakers have other plans for him.";
			m39.Tagline = "It was the Deltas against the rules... the rules lost!";
			m39.MPAA_Rating = MPAA.R;
			m39.Actors = "John Belushi, Tim Matheson, John Vernon, Verna Bloom, Tom Hulce, Cesare Danova";
			m39.ReleaseYear = 1978;
			m39.Runtime = new TimeSpan(0, 109, 0);
			db.Movies.AddOrUpdate(m => m.Title, m39);
			db.SaveChanges();
			m39 = db.Movies.FirstOrDefault(m => m.MovieNumber == m39.MovieNumber);
			m39.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m40 = new Movie();
			m40.MovieNumber = 3040;
			m40.Title = "Halloween";
			m40.Overview = "In John Carpenter's horror classic, a psychotic murderer, institutionalized since childhood for the murder of his sister, escapes and stalks a bookish teenage girl and her friends while his doctor chases him through the streets.";
			m40.Tagline = "The Night He Came Home";
			m40.MPAA_Rating = MPAA.R;
			m40.Actors = "Donald Pleasence, Jamie Lee Curtis, P.J. Soles, Nancy Kyes, Nick Castle, Tony Moran";
			m40.ReleaseYear = 1978;
			m40.Runtime = new TimeSpan(0, 91, 0);
			db.Movies.AddOrUpdate(m => m.Title, m40);
			db.SaveChanges();
			m40 = db.Movies.FirstOrDefault(m => m.MovieNumber == m40.MovieNumber);
			m40.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m40.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			;
			db.SaveChanges();

			Movie m41 = new Movie();
			m41.MovieNumber = 3041;
			m41.Title = "Alien";
			m41.Overview = "During its return to the earth, commercial spaceship Nostromo intercepts a distress signal from a distant planet. When a three-member team of the crew discovers a chamber containing thousands of eggs on the planet, a creature inside one of the eggs attacks an explorer. The entire crew is unaware of the impending nightmare set to descend upon them when the alien parasite planted inside its unfortunate host is birthed.";
			m41.Tagline = "In space no one can hear you scream.";
			m41.MPAA_Rating = MPAA.R;
			m41.Actors = "Tom Skerritt, Sigourney Weaver, Veronica Cartwright, Harry Dean Stanton, John Hurt, Ian Holm";
			m41.ReleaseYear = 1979;
			m41.Runtime = new TimeSpan(0, 117, 0);
			db.Movies.AddOrUpdate(m => m.Title, m41);
			db.SaveChanges();
			m41 = db.Movies.FirstOrDefault(m => m.MovieNumber == m41.MovieNumber);
			m41.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m41.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m41.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			m41.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m42 = new Movie();
			m42.MovieNumber = 3042;
			m42.Title = "The Muppet Movie";
			m42.Overview = "Kermit the Frog is persuaded by agent Dom DeLuise to pursue a career in Hollywood. Along the way, Kermit picks up Fozzie Bear, Miss Piggy, Gonzo, and a motley crew of other Muppets with similar aspirations. Meanwhile, Kermit must elude the grasp of a frog-leg restaurant magnate.";
			m42.Tagline = "More entertaining than humanly possible.";
			m42.MPAA_Rating = MPAA.G;
			m42.Actors = "Jim Henson, Frank Oz, Jerry Nelson, Richard Hunt, Dave Goelz, Charles Durning";
			m42.ReleaseYear = 1979;
			m42.Runtime = new TimeSpan(0, 97, 0);
			db.Movies.AddOrUpdate(m => m.Title, m42);
			db.SaveChanges();
			m42 = db.Movies.FirstOrDefault(m => m.MovieNumber == m42.MovieNumber);
			m42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m43 = new Movie();
			m43.MovieNumber = 3043;
			m43.Title = "Apocalypse Now";
			m43.Overview = "At the height of the Vietnam war, Captain Benjamin Willard is sent on a dangerous mission that, officially, 'does not exist, nor will it ever exist.' His goal is to locate - and eliminate - a mysterious Green Beret Colonel named Walter Kurtz, who has been leading his personal army on illegal guerrilla missions into enemy territory.";
			m43.Tagline = "This is the end...";
			m43.MPAA_Rating = MPAA.R;
			m43.Actors = "Martin Sheen, Marlon Brando, Robert Duvall, Frederic Forrest, Sam Bottoms, Laurence Fishburne";
			m43.ReleaseYear = 1979;
			m43.Runtime = new TimeSpan(0, 153, 0);
			db.Movies.AddOrUpdate(m => m.Title, m43);
			db.SaveChanges();
			m43 = db.Movies.FirstOrDefault(m => m.MovieNumber == m43.MovieNumber);
			m43.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m43.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));

			db.SaveChanges();

			Movie m44 = new Movie();
			m44.MovieNumber = 3044;
			m44.Title = "The Empire Strikes Back";
			m44.Overview = "The epic saga continues as Luke Skywalker, in hopes of defeating the evil Galactic Empire, learns the ways of the Jedi from aging master Yoda. But Darth Vader is more determined than ever to capture Luke. Meanwhile, rebel leader Princess Leia, cocky Han Solo, Chewbacca, and droids C-3PO and R2-D2 are thrown into various stages of capture, betrayal and despair.";
			m44.Tagline = "The Adventure Continues...";
			m44.MPAA_Rating = MPAA.PG;
			m44.Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams, Anthony Daniels, David Prowse";
			m44.ReleaseYear = 1980;
			m44.Runtime = new TimeSpan(0, 124, 0);
			db.Movies.AddOrUpdate(m => m.Title, m44);
			db.SaveChanges();
			m44 = db.Movies.FirstOrDefault(m => m.MovieNumber == m44.MovieNumber);
			m44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m45 = new Movie();
			m45.MovieNumber = 3045;
			m45.Title = "The Shining";
			m45.Overview = "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, along with his wife Wendy and their son Danny, must live isolated from the rest of the world for the winter. But they aren't prepared for the madness that lurks within.";
			m45.Tagline = "A masterpiece of modern horror.";
			m45.MPAA_Rating = MPAA.R;
			m45.Actors = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson, Philip Stone";
			m45.ReleaseYear = 1980;
			m45.Runtime = new TimeSpan(0, 144, 0);
			db.Movies.AddOrUpdate(m => m.Title, m45);
			db.SaveChanges();
			m45 = db.Movies.FirstOrDefault(m => m.MovieNumber == m45.MovieNumber);
			m45.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m45.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m46 = new Movie();
			m46.MovieNumber = 3046;
			m46.Title = "Airplane!";
			m46.Overview = "Alcoholic pilot, Ted Striker has developed a fear of flying due to wartime trauma, but nevertheless boards a passenger jet in an attempt to woo back his stewardess girlfriend. Food poisoning decimates the passengers and crew, leaving it up to Striker to land the plane with the help of a glue-sniffing air traffic controller and Striker's vengeful former Air Force captain, who must both talk him down.";
			m46.Tagline = "What's slower than a speeding bullet, and able to hit tall buildings at a single bound?";
			m46.MPAA_Rating = MPAA.PG;
			m46.Actors = "Robert Hays, Julie Hagerty, Kareem Abdul-Jabbar, Lloyd Bridges, Peter Graves, Leslie Nielsen";
			m46.ReleaseYear = 1980;
			m46.Runtime = new TimeSpan(0, 88, 0);
			db.Movies.AddOrUpdate(m => m.Title, m46);
			db.SaveChanges();
			m46 = db.Movies.FirstOrDefault(m => m.MovieNumber == m46.MovieNumber);
			m46.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m47 = new Movie();
			m47.MovieNumber = 3047;
			m47.Title = "Caddyshack";
			m47.Overview = "At an exclusive country club, an ambitious young caddy, Danny Noonan, eagerly pursues a caddy scholarship in hopes of attending college and, in turn, avoiding a job at the lumber yard. In order to succeed, he must first win the favour of the elitist Judge Smails, and then the caddy golf tournament which Smails sponsors.";
			m47.Tagline = "The snobs against the slobs!";
			m47.MPAA_Rating = MPAA.R;
			m47.Actors = "Chevy Chase, Rodney Dangerfield, Ted Knight, Michael O'Keefe, Bill Murray, Sarah Holcomb";
			m47.ReleaseYear = 1980;
			m47.Runtime = new TimeSpan(0, 98, 0);
			db.Movies.AddOrUpdate(m => m.Title, m47);
			db.SaveChanges();
			m47 = db.Movies.FirstOrDefault(m => m.MovieNumber == m47.MovieNumber);
			m47.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m48 = new Movie();
			m48.MovieNumber = 3048;
			m48.Title = "Raging Bull";
			m48.Overview = "When Jake LaMotta steps into a boxing ring and obliterates his opponent, he's a prizefighter. But when he treats his family and friends the same way, he's a ticking time bomb, ready to go off at any moment. Though LaMotta wants his family's love, something always seems to come between them. Perhaps it's his violent bouts of paranoia and jealousy. This kind of rage helped make him a champ, but in real life, he winds up in the ring alone.";
			m48.Tagline = "";
			m48.MPAA_Rating = MPAA.R;
			m48.Actors = "Robert De Niro, Joe Pesci, Cathy Moriarty, Frank Vincent, Nicholas Colasanto, Theresa Saldana";
			m48.ReleaseYear = 1980;
			m48.Runtime = new TimeSpan(0, 129, 0);
			db.Movies.AddOrUpdate(m => m.Title, m48);
			db.SaveChanges();
			m48 = db.Movies.FirstOrDefault(m => m.MovieNumber == m48.MovieNumber);
			m48.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));


			db.SaveChanges();

			Movie m49 = new Movie();
			m49.MovieNumber = 3049;
			m49.Title = "Raiders of the Lost Ark";
			m49.Overview = "When Dr. Indiana Jones – the tweed-suited professor who just happens to be a celebrated archaeologist – is hired by the government to locate the legendary Ark of the Covenant, he finds himself up against the entire Nazi regime.";
			m49.Tagline = "Indiana Jones - the new hero from the creators of JAWS and STAR WARS.";
			m49.MPAA_Rating = MPAA.PG;
			m49.Actors = "Harrison Ford, Karen Allen, Paul Freeman, Ronald Lacey, John Rhys-Davies, Denholm Elliott";
			m49.ReleaseYear = 1981;
			m49.Runtime = new TimeSpan(0, 115, 0);
			db.Movies.AddOrUpdate(m => m.Title, m49);
			db.SaveChanges();
			m49 = db.Movies.FirstOrDefault(m => m.MovieNumber == m49.MovieNumber);
			m49.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m49.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));

			db.SaveChanges();

			Movie m50 = new Movie();
			m50.MovieNumber = 3050;
			m50.Title = "E.T. the Extra-Terrestrial";
			m50.Overview = "After a gentle alien becomes stranded on Earth, the being is discovered and befriended by a young boy named Elliott. Bringing the extraterrestrial into his suburban California house, Elliott introduces E.T., as the alien is dubbed, to his brother and his little sister, Gertie, and the children decide to keep its existence a secret. Soon, however, E.T. falls ill, resulting in government intervention and a dire situation for both Elliott and the alien.";
			m50.Tagline = "He is afraid. He is alone. He is three million light years from home.";
			m50.MPAA_Rating = MPAA.PG;
			m50.Actors = "Henry Thomas, Drew Barrymore, Robert MacNaughton, Dee Wallace, Peter Coyote, Erika Eleniak";
			m50.ReleaseYear = 1982;
			m50.Runtime = new TimeSpan(0, 115, 0);
			db.Movies.AddOrUpdate(m => m.Title, m50);
			db.SaveChanges();
			m50 = db.Movies.FirstOrDefault(m => m.MovieNumber == m50.MovieNumber);
			m50.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m50.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m50.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m50.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m51 = new Movie();
			m51.MovieNumber = 3051;
			m51.Title = "Fast Times at Ridgemont High";
			m51.Overview = "Follows a group of high school students growing up in southern California, based on the real-life adventures chronicled by Cameron Crowe. Stacy Hamilton and Mark Ratner are looking for a love interest, and are helped along by their older classmates, Linda Barrett and Mike Damone, respectively. The center of the film is held by Jeff Spicoli, a perpetually stoned surfer dude who faces off with the resolute Mr. Hand, who is convinced that everyone is on dope.";
			m51.Tagline = "Fast Cars, Fast Girls, Fast Carrots...Fast Carrots?";
			m51.MPAA_Rating = MPAA.R;
			m51.Actors = "Sean Penn, Jennifer Jason Leigh, Judge Reinhold, Phoebe Cates, Brian Backer, Robert Romanus";
			m51.ReleaseYear = 1982;
			m51.Runtime = new TimeSpan(0, 90, 0);
			db.Movies.AddOrUpdate(m => m.Title, m51);
			db.SaveChanges();
			m51 = db.Movies.FirstOrDefault(m => m.MovieNumber == m51.MovieNumber);
			m51.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m52 = new Movie();
			m52.MovieNumber = 3052;
			m52.Title = "Return of the Jedi";
			m52.Overview = "As Rebel leaders map their strategy for an all-out attack on the Emperor's newer, bigger Death Star. Han Solo remains frozen in the cavernous desert fortress of Jabba the Hutt, the most loathsome outlaw in the universe, who is also keeping Princess Leia as a slave girl. Now a master of the Force, Luke Skywalker rescues his friends, but he cannot become a true Jedi Knight until he wages his own crucial battle against Darth Vader, who has sworn to win Luke over to the dark side of the Force.";
			m52.Tagline = "The Empire Falls...";
			m52.MPAA_Rating = MPAA.PG;
			m52.Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams, Anthony Daniels, David Prowse";
			m52.ReleaseYear = 1983;
			m52.Runtime = new TimeSpan(0, 135, 0);
			db.Movies.AddOrUpdate(m => m.Title, m52);
			db.SaveChanges();
			m52 = db.Movies.FirstOrDefault(m => m.MovieNumber == m52.MovieNumber);
			m52.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m52.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m52.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m53 = new Movie();
			m53.MovieNumber = 3053;
			m53.Title = "WarGames";
			m53.Overview = "High School student David Lightman (Matthew Broderick) has a talent for hacking. But while trying to hack into a computer system to play unreleased video games, he unwittingly taps into the Defense Department's war computer and initiates a confrontation of global proportions! Together with his girlfriend (Ally Sheedy) and a wizardly computer genius (John Wood), David must race against time to outwit his opponent...and prevent a nuclear Armageddon.";
			m53.Tagline = "Is it a game, or is it real?";
			m53.MPAA_Rating = MPAA.PG;
			m53.Actors = "Matthew Broderick, Dabney Coleman, Ally Sheedy, John Wood, Barry Corbin, Juanin Clay";
			m53.ReleaseYear = 1983;
			m53.Runtime = new TimeSpan(0, 114, 0);
			db.Movies.AddOrUpdate(m => m.Title, m53);
			db.SaveChanges();
			m53 = db.Movies.FirstOrDefault(m => m.MovieNumber == m53.MovieNumber);
			m53.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			m53.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m54 = new Movie();
			m54.MovieNumber = 3054;
			m54.Title = "Trading Places";
			m54.Overview = "A snobbish investor and a wily street con-artist find their positions reversed as part of a bet by two callous millionaires.";
			m54.Tagline = "Some very funny business.";
			m54.MPAA_Rating = MPAA.R;
			m54.Actors = "Eddie Murphy, Dan Aykroyd, Jamie Lee Curtis, Jim Belushi, Denholm Elliott, Ralph Bellamy";
			m54.ReleaseYear = 1983;
			m54.Runtime = new TimeSpan(0, 116, 0);
			db.Movies.AddOrUpdate(m => m.Title, m54);
			db.SaveChanges();
			m54 = db.Movies.FirstOrDefault(m => m.MovieNumber == m54.MovieNumber);
			m54.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m55 = new Movie();
			m55.MovieNumber = 3055;
			m55.Title = "A Christmas Story";
			m55.Overview = "The comic mishaps and adventures of a young boy named Ralph, trying to convince his parents, teachers, and Santa that a Red Ryder B.B. gun really is the perfect Christmas gift for the 1940s.";
			m55.Tagline = "Peace, Harmony, Comfort and Joy... Maybe Next Year.";
			m55.MPAA_Rating = MPAA.PG;
			m55.Actors = "Melinda Dillon, Darren McGavin, Peter Billingsley, Jean Shepherd, Ian Petrella, Scott Schwartz";
			m55.ReleaseYear = 1983;
			m55.Runtime = new TimeSpan(0, 94, 0);
			db.Movies.AddOrUpdate(m => m.Title, m55);
			db.SaveChanges();
			m55 = db.Movies.FirstOrDefault(m => m.MovieNumber == m55.MovieNumber);
			m55.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m55.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m56 = new Movie();
			m56.MovieNumber = 3056;
			m56.Title = "Footloose";
			m56.Overview = "When teenager Ren and his family move from big-city Chicago to a small town in the West, he's in for a real case of culture shock.";
			m56.Tagline = "He's a big-city kid in a small town. They said he'd never win. He knew he had to.";
			m56.MPAA_Rating = MPAA.PG;
			m56.Actors = "Kevin Bacon, John Lithgow, Dianne Wiest, Chris Penn, Lori Singer, Sarah Jessica Parker";
			m56.ReleaseYear = 1984;
			m56.Runtime = new TimeSpan(0, 107, 0);
			db.Movies.AddOrUpdate(m => m.Title, m56);
			db.SaveChanges();
			m56 = db.Movies.FirstOrDefault(m => m.MovieNumber == m56.MovieNumber);
			m56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m57 = new Movie();
			m57.MovieNumber = 3057;
			m57.Title = "Back to the Future";
			m57.Overview = "Eighties teenager Marty McFly is accidentally sent back in time to 1955, inadvertently disrupting his parents' first meeting and attracting his mother's romantic interest. Marty must repair the damage to history by rekindling his parents' romance and - with the help of his eccentric inventor friend Doc Brown - return to 1985.";
			m57.Tagline = "He's the only kid ever to get into trouble before he was born.";
			m57.MPAA_Rating = MPAA.PG;
			m57.Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, Thomas F. Wilson, Claudia Wells";
			m57.ReleaseYear = 1985;
			m57.Runtime = new TimeSpan(0, 116, 0);
			db.Movies.AddOrUpdate(m => m.Title, m57);
			db.SaveChanges();
			m57 = db.Movies.FirstOrDefault(m => m.MovieNumber == m57.MovieNumber);
			m57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m58 = new Movie();
			m58.MovieNumber = 3058;
			m58.Title = "The Color Purple";
			m58.Overview = "An epic tale spanning forty years in the life of Celie (Whoopi Goldberg), an African-American woman living in the South who survives incredible abuse and bigotry.  After Celie's abusive father marries her off to the equally debasing 'Mister' Albert Johnson (Danny Glover), things go from bad to worse, leaving Celie to find companionship anywhere she can.  She perseveres, holding on to her dream of one day being reunited with her sister in Africa.  Based on the novel by Alice Walker.";
			m58.Tagline = "It's about life. It's about love. It's about us.";
			m58.MPAA_Rating = MPAA.PG13;
			m58.Actors = "Whoopi Goldberg, Margaret Avery, Danny Glover, Akosua Busia, Oprah Winfrey, Willard E. Pugh";
			m58.ReleaseYear = 1985;
			m58.Runtime = new TimeSpan(0, 154, 0);
			db.Movies.AddOrUpdate(m => m.Title, m58);
			db.SaveChanges();
			m58 = db.Movies.FirstOrDefault(m => m.MovieNumber == m58.MovieNumber);
			m58.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m59 = new Movie();
			m59.MovieNumber = 3059;
			m59.Title = "Top Gun";
			m59.Overview = "For Lieutenant Pete 'Maverick' Mitchell and his friend and Co-Pilot Nick 'Goose' Bradshaw being accepted into an elite training school for fighter pilots is a dream come true.  A tragedy, as well as personal demons, threaten Pete's dreams of becoming an Ace pilot.";
			m59.Tagline = "Up there with the best of the best.";
			m59.MPAA_Rating = MPAA.PG;
			m59.Actors = "Tom Cruise, Kelly McGillis, Val Kilmer, Anthony Edwards, Tom Skerritt, Michael Ironside";
			m59.ReleaseYear = 1986;
			m59.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m59);
			db.SaveChanges();
			m59 = db.Movies.FirstOrDefault(m => m.MovieNumber == m59.MovieNumber);
			m59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));

			db.SaveChanges();

			Movie m60 = new Movie();
			m60.MovieNumber = 3060;
			m60.Title = "Little Shop of Horrors";
			m60.Overview = "Seymour Krelborn is a nerdy orphan working at Mushnik's, a flower shop in urban Skid Row. He harbors a crush on fellow co-worker Audrey Fulquard, and is berated by Mr. Mushnik daily. One day as Seymour is seeking a new mysterious plant, he finds a very mysterious unidentified plant which he calls Audrey II. The plant seems to have a craving for blood and soon begins to sing for his supper.";
			m60.Tagline = "Don't feed the plants.";
			m60.MPAA_Rating = MPAA.PG13;
			m60.Actors = "Rick Moranis, Ellen Greene, Vincent Gardenia, Steve Martin, Tisha Campbell-Martin, John Candy";
			m60.ReleaseYear = 1986;
			m60.Runtime = new TimeSpan(0, 94, 0);
			db.Movies.AddOrUpdate(m => m.Title, m60);
			db.SaveChanges();
			m60 = db.Movies.FirstOrDefault(m => m.MovieNumber == m60.MovieNumber);
			m60.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Horror"));
			m60.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m60.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m61 = new Movie();
			m61.MovieNumber = 3061;
			m61.Title = "Spaceballs";
			m61.Overview = "When the nefarious Dark Helmet hatches a plan to snatch Princess Vespa and steal her planet's air, space-bum-for-hire Lone Starr and his clueless sidekick fly to the rescue. Along the way, they meet Yogurt, who puts Lone Starr wise to the power of 'The Schwartz' Can he master it in time to save the day?";
			m61.Tagline = "May the schwartz be with you";
			m61.MPAA_Rating = MPAA.PG;
			m61.Actors = "Mel Brooks, Rick Moranis, Bill Pullman, Daphne Zuniga, John Candy, George Wyner";
			m61.ReleaseYear = 1987;
			m61.Runtime = new TimeSpan(0, 96, 0);
			db.Movies.AddOrUpdate(m => m.Title, m61);
			db.SaveChanges();
			m61 = db.Movies.FirstOrDefault(m => m.MovieNumber == m61.MovieNumber);
			m61.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m61.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m62 = new Movie();
			m62.MovieNumber = 3062;
			m62.Title = "The Princess Bride";
			m62.Overview = "In this enchantingly cracked fairy tale, the beautiful Princess Buttercup and the dashing Westley must overcome staggering odds to find happiness amid six-fingered swordsmen, murderous princes, Sicilians and rodents of unusual size. But even death can't stop these true lovebirds from triumphing.";
			m62.Tagline = "It's as real as the feelings you feel.";
			m62.MPAA_Rating = MPAA.PG;
			m62.Actors = "Cary Elwes, Robin Wright, Mandy Patinkin, Andre the Giant, Chris Sarandon, Christopher Guest";
			m62.ReleaseYear = 1987;
			m62.Runtime = new TimeSpan(0, 98, 0);
			db.Movies.AddOrUpdate(m => m.Title, m62);
			db.SaveChanges();
			m62 = db.Movies.FirstOrDefault(m => m.MovieNumber == m62.MovieNumber);
			m62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m63 = new Movie();
			m63.MovieNumber = 3063;
			m63.Title = "Big";
			m63.Overview = "A young boy, Josh Baskin makes a wish at a carnival machine to be big. He wakes up the following morning to find that it has been granted and his body has grown older overnight. But he is still the same 13-year-old boy inside. Now he must learn how to cope with the unfamiliar world of grown-ups including getting a job and having his first romantic encounter with a woman. What will he find out about this strange world?";
			m63.Tagline = "You're Only Young Once But For Josh It Might Just Last A Lifetime.";
			m63.MPAA_Rating = MPAA.PG;
			m63.Actors = "Tom Hanks, Elizabeth Perkins, Robert Loggia, John Heard, Jared Rushton, David Moscow";
			m63.ReleaseYear = 1988;
			m63.Runtime = new TimeSpan(0, 104, 0);
			db.Movies.AddOrUpdate(m => m.Title, m63);
			db.SaveChanges();
			m63 = db.Movies.FirstOrDefault(m => m.MovieNumber == m63.MovieNumber);
			m63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m64 = new Movie();
			m64.MovieNumber = 3064;
			m64.Title = "The Land Before Time";
			m64.Overview = "An orphaned brontosaurus named Littlefoot sets off in search of the legendary Great Valley. A land of lush vegetation where the dinosaurs can thrive and live in peace. Along the way he meets four other young dinosaurs, each one a different species, and they encounter several obstacles as they learn to work together in order to survive.";
			m64.Tagline = "A new adventure is born.";
			m64.MPAA_Rating = MPAA.G;
			m64.Actors = "Gabriel Damon, Candace Hutson, Judith Barsi, Will Ryan, Pat Hingle, Helen Shaver";
			m64.ReleaseYear = 1988;
			m64.Runtime = new TimeSpan(0, 69, 0);
			db.Movies.AddOrUpdate(m => m.Title, m64);
			db.SaveChanges();
			m64 = db.Movies.FirstOrDefault(m => m.MovieNumber == m64.MovieNumber);
			m64.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m64.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m64.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m65 = new Movie();
			m65.MovieNumber = 3065;
			m65.Title = "Rain Man";
			m65.Overview = "Selfish yuppie Charlie Babbitt's father left a fortune to his savant brother Raymond and a pittance to Charlie; they travel cross-country.";
			m65.Tagline = "A journey through understanding and fellowship.";
			m65.MPAA_Rating = MPAA.R;
			m65.Actors = "Dustin Hoffman, Tom Cruise, Valeria Golino, Gerald R. Molen, Jack Murdock, Michael D. Roberts";
			m65.ReleaseYear = 1988;
			m65.Runtime = new TimeSpan(0, 133, 0);
			db.Movies.AddOrUpdate(m => m.Title, m65);
			db.SaveChanges();
			m65 = db.Movies.FirstOrDefault(m => m.MovieNumber == m65.MovieNumber);
			m65.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m66 = new Movie();
			m66.MovieNumber = 3066;
			m66.Title = "Bill & Ted's Excellent Adventure";
			m66.Overview = "In the small town of San Dimas, a few miles away from Los Angeles, there are two nearly brain dead teenage boys going by the names of Bill S, Preston ESQ. and Ted Theodore Logan, they have a dream together of starting their own rock and roll band called the 'Wyld Stallyns'. Unfortunately, they are still in high school and on the verge of failing out of their school as well, and if they do not pass their upcoming history report, they will be separated as a result of Ted's father sending him to military school. But, what Bill and Ted do not know is that they must stay together to save the future. So, a man from the future named Rufus came to help them pass their report. So, both Bill and Ted decided to gather up historical figures which they need for their report. They are hoping that this will help them pass their report so they can stay together.";
			m66.Tagline = "History is about to be rewritten by two guys who can't spell.";
			m66.MPAA_Rating = MPAA.PG;
			m66.Actors = "Keanu Reeves, Alex Winter, George Carlin, Dan Shor, Hal Landon Jr., Amy Stock-Poynton";
			m66.ReleaseYear = 1989;
			m66.Runtime = new TimeSpan(0, 90, 0);
			db.Movies.AddOrUpdate(m => m.Title, m66);
			db.SaveChanges();
			m66 = db.Movies.FirstOrDefault(m => m.MovieNumber == m66.MovieNumber);
			m66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m67 = new Movie();
			m67.MovieNumber = 3067;
			m67.Title = "Dead Poets Society";
			m67.Overview = "At an elite, old-fashioned boarding school in New England, a passionate English teacher inspires his students to rebel against convention and seize the potential of every day, courting the disdain of the stern headmaster.";
			m67.Tagline = "He was their inspiration. He made their lives extraordinary.";
			m67.MPAA_Rating = MPAA.PG;
			m67.Actors = "Robin Williams, Ethan Hawke, Robert Sean Leonard, Gale Hansen, Josh Charles, Dylan Kussman";
			m67.ReleaseYear = 1989;
			m67.Runtime = new TimeSpan(0, 129, 0);
			db.Movies.AddOrUpdate(m => m.Title, m67);
			db.SaveChanges();
			m67 = db.Movies.FirstOrDefault(m => m.MovieNumber == m67.MovieNumber);
			m67.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));


			db.SaveChanges();

			Movie m68 = new Movie();
			m68.MovieNumber = 3068;
			m68.Title = "When Harry Met Sally...";
			m68.Overview = "During their travels from Chicago to New York, Harry and Sally Will debate whether or not sex ruins a perfect relationship between a man and a woman. Eleven years and later, they're still no closer to finding the answer.";
			m68.Tagline = "Can two friends sleep together and still love each other in the morning?";
			m68.MPAA_Rating = MPAA.R;
			m68.Actors = "Meg Ryan, Billy Crystal, Carrie Fisher, Bruno Kirby, Steven Ford, Lisa Jane Persky";
			m68.ReleaseYear = 1989;
			m68.Runtime = new TimeSpan(0, 96, 0);
			db.Movies.AddOrUpdate(m => m.Title, m68);
			db.SaveChanges();
			m68 = db.Movies.FirstOrDefault(m => m.MovieNumber == m68.MovieNumber);
			m68.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m68.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m68.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m69 = new Movie();
			m69.MovieNumber = 3069;
			m69.Title = "Back to the Future Part II";
			m69.Overview = "Marty and Doc are at it again in this wacky sequel to the 1985 blockbuster as the time-traveling duo head to 2015 to nip some McFly family woes in the bud. But things go awry thanks to bully Biff Tannen and a pesky sports almanac. In a last-ditch attempt to set things straight, Marty finds himself bound for 1955 and face to face with his teenage parents -- again.";
			m69.Tagline = "Roads? Where we're going, we don't need roads!";
			m69.MPAA_Rating = MPAA.PG;
			m69.Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson, Elisabeth Shue, James Tolkan, Jeffrey Weissman";
			m69.ReleaseYear = 1989;
			m69.Runtime = new TimeSpan(0, 108, 0);
			db.Movies.AddOrUpdate(m => m.Title, m69);
			db.SaveChanges();
			m69 = db.Movies.FirstOrDefault(m => m.MovieNumber == m69.MovieNumber);
			m69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m70 = new Movie();
			m70.MovieNumber = 3070;
			m70.Title = "Back to the Future Part III";
			m70.Overview = "The final installment of the Back to the Future trilogy finds Marty digging the trusty DeLorean out of a mineshaft and looking up Doc in the Wild West of 1885. But when their time machine breaks down, the travelers are stranded in a land of spurs. More problems arise when Doc falls for pretty schoolteacher Clara Clayton, and Marty tangles with Buford Tannen.";
			m70.Tagline = "They've saved the best trip for last... But this time they may have gone too far.";
			m70.MPAA_Rating = MPAA.PG;
			m70.Actors = "Michael J. Fox, Christopher Lloyd, Mary Steenburgen, Thomas F. Wilson, Lea Thompson, Elisabeth Shue";
			m70.ReleaseYear = 1990;
			m70.Runtime = new TimeSpan(0, 118, 0);
			db.Movies.AddOrUpdate(m => m.Title, m70);
			db.SaveChanges();
			m70 = db.Movies.FirstOrDefault(m => m.MovieNumber == m70.MovieNumber);
			m70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m71 = new Movie();
			m71.MovieNumber = 3071;
			m71.Title = "Robin Hood: Prince of Thieves";
			m71.Overview = "When the dastardly Sheriff of Nottingham murders Robin's father, the legendary archer vows vengeance. To accomplish his mission, Robin joins forces with a band of exiled villagers (and comely Maid Marian), and together they battle to end the evil sheriff's reign of terror.";
			m71.Tagline = "For the good of all men, and the love of one woman, he fought to uphold justice by breaking the law.";
			m71.MPAA_Rating = MPAA.PG13;
			m71.Actors = "Kevin Costner, Morgan Freeman, Christian Slater, Mary Elizabeth Mastrantonio, Alan Rickman, Geraldine McEwan";
			m71.ReleaseYear = 1991;
			m71.Runtime = new TimeSpan(0, 143, 0);
			db.Movies.AddOrUpdate(m => m.Title, m71);
			db.SaveChanges();
			m71 = db.Movies.FirstOrDefault(m => m.MovieNumber == m71.MovieNumber);
			m71.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));

			db.SaveChanges();

			Movie m72 = new Movie();
			m72.MovieNumber = 3072;
			m72.Title = "Wayne's World";
			m72.Overview = "When a sleazy TV exec offers Wayne and Garth a fat contract to tape their late-night public access show at his network, they can't believe their good fortune. But they soon discover the road from basement to big-time is a gnarly one, fraught with danger, temptation and ragin' party opportunities.";
			m72.Tagline = "You'll laugh. You'll cry. You'll hurl.";
			m72.MPAA_Rating = MPAA.PG13;
			m72.Actors = "Mike Myers, Dana Carvey, Rob Lowe, Tia Carrere, Lara Flynn Boyle, Chris Farley";
			m72.ReleaseYear = 1992;
			m72.Runtime = new TimeSpan(0, 94, 0);
			db.Movies.AddOrUpdate(m => m.Title, m72);
			db.SaveChanges();
			m72 = db.Movies.FirstOrDefault(m => m.MovieNumber == m72.MovieNumber);
			m72.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m73 = new Movie();
			m73.MovieNumber = 3073;
			m73.Title = "A League of Their Own";
			m73.Overview = "Small-town sisters Dottie and Kit join an all-female baseball league formed after World War II brings pro baseball to a standstill. When their team hits the road with its drunken coach, the siblings find troubles and triumphs on and off the field.";
			m73.Tagline = "To achieve the incredible, you have to attempt the impossible.";
			m73.MPAA_Rating = MPAA.PG;
			m73.Actors = "Tom Hanks, Geena Davis, Madonna, Lori Petty, Jon Lovitz, David Strathairn";
			m73.ReleaseYear = 1992;
			m73.Runtime = new TimeSpan(0, 128, 0);
			db.Movies.AddOrUpdate(m => m.Title, m73);
			db.SaveChanges();
			m73 = db.Movies.FirstOrDefault(m => m.MovieNumber == m73.MovieNumber);
			m73.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m74 = new Movie();
			m74.MovieNumber = 3074;
			m74.Title = "The Last of the Mohicans";
			m74.Overview = "As the English and French soldiers battle for control of the American colonies in the 18th century, the settlers and native Americans are forced to take sides. Cora and her sister Alice unwittingly walk into trouble but are reluctantly saved by Hawkeye, an orphaned settler adopted by the last of the Mohicans.";
			m74.Tagline = "The first American hero.";
			m74.MPAA_Rating = MPAA.R;
			m74.Actors = "Daniel Day-Lewis, Madeleine Stowe, Russell Means, Eric Schweig, Jodhi May, Steven Waddington";
			m74.ReleaseYear = 1992;
			m74.Runtime = new TimeSpan(0, 112, 0);
			db.Movies.AddOrUpdate(m => m.Title, m74);
			db.SaveChanges();
			m74 = db.Movies.FirstOrDefault(m => m.MovieNumber == m74.MovieNumber);
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "History"));
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "War"));
			db.SaveChanges();

			Movie m75 = new Movie();
			m75.MovieNumber = 3075;
			m75.Title = "Aladdin";
			m75.Overview = "Princess Jasmine grows tired of being forced to remain in the palace and she sneaks out into the marketplace  in disguise where she meets street-urchin Aladdin and the two fall in love, although she may only marry a prince. After being thrown in jail, Aladdin and becomes embroiled in a plot to find a mysterious lamp with which the evil Jafar hopes to rule the land.";
			m75.Tagline = "Wish granted!";
			m75.MPAA_Rating = MPAA.G;
			m75.Actors = "Scott Weinger, Robin Williams, Linda Larkin, Jonathan Freeman, Frank Welker, Gilbert Gottfried";
			m75.ReleaseYear = 1992;
			m75.Runtime = new TimeSpan(0, 90, 0);
			db.Movies.AddOrUpdate(m => m.Title, m75);
			db.SaveChanges();
			m75 = db.Movies.FirstOrDefault(m => m.MovieNumber == m75.MovieNumber);
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			db.SaveChanges();

			Movie m76 = new Movie();
			m76.MovieNumber = 3076;
			m76.Title = "The Muppet Christmas Carol";
			m76.Overview = "A retelling of the classic Dickens tale of Ebenezer Scrooge, miser extraordinaire. He is held accountable for his dastardly ways during night-time visitations by the Ghosts of Christmas Past, Present, and future.";
			m76.Tagline = "";
			m76.MPAA_Rating = MPAA.G;
			m76.Actors = "Michael Caine, Don Austen, Meredith Braun, Don Austen, Ed Sanders, Dave Goelz";
			m76.ReleaseYear = 1992;
			m76.Runtime = new TimeSpan(0, 85, 0);
			db.Movies.AddOrUpdate(m => m.Title, m76);
			db.SaveChanges();
			m76 = db.Movies.FirstOrDefault(m => m.MovieNumber == m76.MovieNumber);
			m76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m77 = new Movie();
			m77.MovieNumber = 3077;
			m77.Title = "A Few Good Men";
			m77.Overview = "When cocky military lawyer Lt. Daniel Kaffee and his co-counsel, Lt. Cmdr. JoAnne Galloway, are assigned to a murder case, they uncover a hazing ritual that could implicate high-ranking officials such as shady Col. Nathan Jessep.";
			m77.Tagline = "You can't handle the truth!";
			m77.MPAA_Rating = MPAA.R;
			m77.Actors = "Tom Cruise, Jack Nicholson, Demi Moore, Kevin Bacon, Kevin Pollak, James Marshall";
			m77.ReleaseYear = 1992;
			m77.Runtime = new TimeSpan(0, 138, 0);
			db.Movies.AddOrUpdate(m => m.Title, m77);
			db.SaveChanges();
			m77 = db.Movies.FirstOrDefault(m => m.MovieNumber == m77.MovieNumber);
			m77.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m78 = new Movie();
			m78.MovieNumber = 3078;
			m78.Title = "Jurassic Park";
			m78.Overview = "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.";
			m78.Tagline = "An adventure 65 million years in the making.";
			m78.MPAA_Rating = MPAA.PG13;
			m78.Actors = "Sam Neill, Laura Dern, Jeff Goldblum, Richard Attenborough, Bob Peck, Martin Ferrero";
			m78.ReleaseYear = 1993;
			m78.Runtime = new TimeSpan(0, 127, 0);
			db.Movies.AddOrUpdate(m => m.Title, m78);
			db.SaveChanges();
			m78 = db.Movies.FirstOrDefault(m => m.MovieNumber == m78.MovieNumber);
			m78.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m78.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m79 = new Movie();
			m79.MovieNumber = 3079;
			m79.Title = "Hocus Pocus";
			m79.Overview = "After 300 years of slumber, three sister witches are accidentally resurrected in Salem on Halloween night, and it us up to three kids and their newfound feline friend to put an end to the witches' reign of terror once and for all.";
			m79.Tagline = "It's just a bunch of Hocus Pocus.";
			m79.MPAA_Rating = MPAA.PG;
			m79.Actors = "Bette Midler, Sarah Jessica Parker, Kathy Najimy, Omri Katz, Thora Birch, Vinessa Shaw";
			m79.ReleaseYear = 1993;
			m79.Runtime = new TimeSpan(0, 96, 0);
			db.Movies.AddOrUpdate(m => m.Title, m79);
			db.SaveChanges();
			m79 = db.Movies.FirstOrDefault(m => m.MovieNumber == m79.MovieNumber);
			m79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m80 = new Movie();
			m80.MovieNumber = 3080;
			m80.Title = "Dazed and Confused";
			m80.Overview = "The adventures of a group of Texas teens on their last day of school in 1976, centering on student Randall Floyd, who moves easily among stoners, jocks and geeks. Floyd is a star athlete, but he also likes smoking weed, which presents a conundrum when his football coach demands he sign a 'no drugs' pledge.";
			m80.Tagline = "See it with a bud.";
			m80.MPAA_Rating = MPAA.R;
			m80.Actors = "Jason London, Rory Cochrane, Wiley Wiggins, Sasha Jenson, Michelle Burke, Adam Goldberg";
			m80.ReleaseYear = 1993;
			m80.Runtime = new TimeSpan(0, 102, 0);
			db.Movies.AddOrUpdate(m => m.Title, m80);
			db.SaveChanges();
			m80 = db.Movies.FirstOrDefault(m => m.MovieNumber == m80.MovieNumber);
			m80.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m80.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m81 = new Movie();
			m81.MovieNumber = 3081;
			m81.Title = "Four Weddings and a Funeral";
			m81.Overview = "Four Weddings And A Funeral is a British comedy about a British Man named Charles and an American Woman named Carrie who go through numerous weddings before they determine if they are right for one another.";
			m81.Tagline = "Five good reasons to stay single.";
			m81.MPAA_Rating = MPAA.R;
			m81.Actors = "Hugh Grant, Andie MacDowell, James Fleet, Simon Callow, John Hannah, Kristin Scott Thomas";
			m81.ReleaseYear = 1994;
			m81.Runtime = new TimeSpan(0, 117, 0);
			db.Movies.AddOrUpdate(m => m.Title, m81);
			db.SaveChanges();
			m81 = db.Movies.FirstOrDefault(m => m.MovieNumber == m81.MovieNumber);
			m81.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m81.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m81.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m82 = new Movie();
			m82.MovieNumber = 3082;
			m82.Title = "The Lion King";
			m82.Overview = "A young lion cub named Simba can't wait to be king. But his uncle craves the title for himself and will stop at nothing to get it.";
			m82.Tagline = "Life's greatest adventure is finding your place in the Circle of Life.";
			m82.MPAA_Rating = MPAA.G;
			m82.Actors = "Jonathan Taylor Thomas, Matthew Broderick, James Earl Jones, Jeremy Irons, Moira Kelly, Niketa Calame";
			m82.ReleaseYear = 1994;
			m82.Runtime = new TimeSpan(0, 89, 0);
			db.Movies.AddOrUpdate(m => m.Title, m82);
			db.SaveChanges();
			m82 = db.Movies.FirstOrDefault(m => m.MovieNumber == m82.MovieNumber);
			m82.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m82.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m82.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m83 = new Movie();
			m83.MovieNumber = 3083;
			m83.Title = "Forrest Gump";
			m83.Overview = "A man with a low IQ has accomplished great things in his life and been present during significant historic events - in each case, far exceeding what anyone imagined he could do. Yet, despite all the things he has attained, his one true love eludes him. 'Forrest Gump' is the story of a man who rose above his challenges, and who proved that determination, courage, and love are more important than ability.";
			m83.Tagline = "The world will never be the same, once you've seen it through the eyes of Forrest Gump.";
			m83.MPAA_Rating = MPAA.PG13;
			m83.Actors = "Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson, Sally Field, Michael Conner Humphreys";
			m83.ReleaseYear = 1994;
			m83.Runtime = new TimeSpan(0, 142, 0);
			db.Movies.AddOrUpdate(m => m.Title, m83);
			db.SaveChanges();
			m83 = db.Movies.FirstOrDefault(m => m.MovieNumber == m83.MovieNumber);
			m83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m84 = new Movie();
			m84.MovieNumber = 3084;
			m84.Title = "The Shawshank Redemption";
			m84.Overview = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.";
			m84.Tagline = "Fear can hold you prisoner. Hope can set you free.";
			m84.MPAA_Rating = MPAA.R;
			m84.Actors = "Tim Robbins, Morgan Freeman, Bob Gunton, Clancy Brown, Mark Rolston, James Whitmore";
			m84.ReleaseYear = 1994;
			m84.Runtime = new TimeSpan(0, 142, 0);
			db.Movies.AddOrUpdate(m => m.Title, m84);
			db.SaveChanges();
			m84 = db.Movies.FirstOrDefault(m => m.MovieNumber == m84.MovieNumber);
			m84.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m84.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m85 = new Movie();
			m85.MovieNumber = 3085;
			m85.Title = "Pulp Fiction";
			m85.Overview = "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.";
			m85.Tagline = "Just because you are a character doesn't mean you have character.";
			m85.MPAA_Rating = MPAA.R;
			m85.Actors = "John Travolta, Samuel L. Jackson, Uma Thurman, Bruce Willis, Ving Rhames, Harvey Keitel";
			m85.ReleaseYear = 1994;
			m85.Runtime = new TimeSpan(0, 154, 0);
			db.Movies.AddOrUpdate(m => m.Title, m85);
			db.SaveChanges();
			m85 = db.Movies.FirstOrDefault(m => m.MovieNumber == m85.MovieNumber);
			m85.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			m85.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m86 = new Movie();
			m86.MovieNumber = 3086;
			m86.Title = "The Usual Suspects";
			m86.Overview = "Held in an L.A. interrogation room, Verbal Kint attempts to convince the feds that a mythic crime lord, Keyser Soze, not only exists, but was also responsible for drawing him and his four partners into a multi-million dollar heist that ended with an explosion in San Pedro harbor – leaving few survivors. Verbal lures his interrogators with an incredible story of the crime lord's almost supernatural prowess.";
			m86.Tagline = "Five Criminals. One Line Up. No Coincidence.";
			m86.MPAA_Rating = MPAA.R;
			m86.Actors = "Stephen Baldwin, Gabriel Byrne, Chazz Palminteri, Kevin Pollak, Pete Postlethwaite, Kevin Spacey";
			m86.ReleaseYear = 1995;
			m86.Runtime = new TimeSpan(0, 106, 0);
			db.Movies.AddOrUpdate(m => m.Title, m86);
			db.SaveChanges();
			m86 = db.Movies.FirstOrDefault(m => m.MovieNumber == m86.MovieNumber);
			m86.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m86.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m86.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m87 = new Movie();
			m87.MovieNumber = 3087;
			m87.Title = "Toy Story";
			m87.Overview = "Led by Woody, Andy's toys live happily in his room until Andy's birthday brings Buzz Lightyear onto the scene. Afraid of losing his place in Andy's heart, Woody plots against Buzz. But when circumstances separate Buzz and Woody from their owner, the duo eventually learns to put aside their differences.";
			m87.Tagline = "Hang on for the comedy that goes to infinity and beyond!";
			m87.MPAA_Rating = MPAA.G;
			m87.Actors = "Tom Hanks, Tim Allen, Don Rickles, Jim Varney, Wallace Shawn, John Ratzenberger";
			m87.ReleaseYear = 1995;
			m87.Runtime = new TimeSpan(0, 81, 0);
			db.Movies.AddOrUpdate(m => m.Title, m87);
			db.SaveChanges();
			m87 = db.Movies.FirstOrDefault(m => m.MovieNumber == m87.MovieNumber);
			m87.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m87.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m87.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m88 = new Movie();
			m88.MovieNumber = 3088;
			m88.Title = "Sense and Sensibility";
			m88.Overview = "Rich Mr. Dashwood dies, leaving his second wife and her daughters poor by the rules of inheritance. Two daughters are the titular opposites.";
			m88.Tagline = "Lose your heart and come to your senses.";
			m88.MPAA_Rating = MPAA.PG;
			m88.Actors = "Kate Winslet, Emma Thompson, Hugh Grant, Tom Wilkinson, Alan Rickman, Imogen Stubbs";
			m88.ReleaseYear = 1995;
			m88.Runtime = new TimeSpan(0, 136, 0);
			db.Movies.AddOrUpdate(m => m.Title, m88);
			db.SaveChanges();
			m88 = db.Movies.FirstOrDefault(m => m.MovieNumber == m88.MovieNumber);
			m88.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m88.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m89 = new Movie();
			m89.MovieNumber = 3089;
			m89.Title = "Mission: Impossible";
			m89.Overview = "When Ethan Hunt, the leader of a crack espionage team whose perilous operation has gone awry with no explanation, discovers that a mole has penetrated the CIA, he's surprised to learn that he's the No. 1 suspect. To clear his name, Hunt now must ferret out the real double agent and, in the process, even the score.";
			m89.Tagline = "Expect the Impossible.";
			m89.MPAA_Rating = MPAA.PG13;
			m89.Actors = "Tom Cruise, Jon Voight, Emmanuelle Beart, Henry Czerny, Jean Reno, Ving Rhames";
			m89.ReleaseYear = 1996;
			m89.Runtime = new TimeSpan(0, 110, 0);
			db.Movies.AddOrUpdate(m => m.Title, m89);
			db.SaveChanges();
			m89 = db.Movies.FirstOrDefault(m => m.MovieNumber == m89.MovieNumber);
			m89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m90 = new Movie();
			m90.MovieNumber = 3090;
			m90.Title = "Independence Day";
			m90.Overview = "On July 2, a giant alien mothership enters orbit around Earth and deploys several dozen saucer-shaped 'destroyer' spacecraft that quickly lay waste to major cities around the planet. On July 3, the United States conducts a coordinated counterattack that fails. On July 4, a plan is devised to gain access to the interior of the alien mothership in space, in order to plant a nuclear missile.";
			m90.Tagline = "Earth. Take a good look. It might be your last.";
			m90.MPAA_Rating = MPAA.PG13;
			m90.Actors = "Will Smith, Bill Pullman, Jeff Goldblum, Mary McDonnell, Judd Hirsch, Robert Loggia";
			m90.ReleaseYear = 1996;
			m90.Runtime = new TimeSpan(0, 145, 0);
			db.Movies.AddOrUpdate(m => m.Title, m90);
			db.SaveChanges();
			m90 = db.Movies.FirstOrDefault(m => m.MovieNumber == m90.MovieNumber);
			m90.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m90.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m90.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m91 = new Movie();
			m91.MovieNumber = 3091;
			m91.Title = "Austin Powers: International Man of Mystery";
			m91.Overview = "As a swingin' fashion photographer by day and a groovy British superagent by night, Austin Powers is the '60s' most shagadelic spy, baby! But can he stop megalomaniac Dr. Evil after the bald villain freezes himself and unthaws in the '90s? With the help of sexy sidekick Vanessa Kensington, he just might.";
			m91.Tagline = "If he were any cooler, he'd still be frozen, baby!";
			m91.MPAA_Rating = MPAA.PG13;
			m91.Actors = "Mike Myers, Elizabeth Hurley, Michael York, Mimi Rogers, Seth Green, Fabiana Udenio";
			m91.ReleaseYear = 1997;
			m91.Runtime = new TimeSpan(0, 94, 0);
			db.Movies.AddOrUpdate(m => m.Title, m91);
			db.SaveChanges();
			m91 = db.Movies.FirstOrDefault(m => m.MovieNumber == m91.MovieNumber);
			m91.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m91.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m91.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m92 = new Movie();
			m92.MovieNumber = 3092;
			m92.Title = "Men in Black";
			m92.Overview = "Men in Black follows the exploits of agents Kay and Jay, members of a top-secret organization established to monitor and police alien activity on Earth. The two Men in Black find themselves in the middle of the deadly plot by an intergalactic terrorist who has arrived on Earth to assassinate two ambassadors from opposing galaxies. In order to prevent worlds from colliding, the MiB must track down the terrorist and prevent the destruction of Earth. It's just another typical day for the Men in Black.";
			m92.Tagline = "Protecting the Earth from the scum of the universe.";
			m92.MPAA_Rating = MPAA.PG13;
			m92.Actors = "Tommy Lee Jones, Will Smith, Linda Fiorentino, Vincent D'Onofrio, Rip Torn, Tony Shalhoub";
			m92.ReleaseYear = 1997;
			m92.Runtime = new TimeSpan(0, 98, 0);
			db.Movies.AddOrUpdate(m => m.Title, m92);
			db.SaveChanges();
			m92 = db.Movies.FirstOrDefault(m => m.MovieNumber == m92.MovieNumber);
			m92.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m92.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m92.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m92.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m93 = new Movie();
			m93.MovieNumber = 3093;
			m93.Title = "Titanic";
			m93.Overview = "84 years later, a 101-year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiancé, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.";
			m93.Tagline = "Nothing on Earth could come between them.";
			m93.MPAA_Rating = MPAA.PG13;
			m93.Actors = "Kate Winslet, Leonardo DiCaprio, Frances Fisher, Billy Zane, Kathy Bates, Gloria Stuart";
			m93.ReleaseYear = 1997;
			m93.Runtime = new TimeSpan(0, 194, 0);
			db.Movies.AddOrUpdate(m => m.Title, m93);
			db.SaveChanges();
			m93 = db.Movies.FirstOrDefault(m => m.MovieNumber == m93.MovieNumber);
			m93.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m93.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m93.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m94 = new Movie();
			m94.MovieNumber = 3094;
			m94.Title = "The Big Lebowski";
			m94.Overview = "Jeffrey 'The Dude' Lebowski, a Los Angeles slacker who only wants to bowl and drink white Russians, is mistaken for another Jeffrey Lebowski, a wheelchair-bound millionaire, and finds himself dragged into a strange series of events involving nihilists, adult film producers, ferrets, errant toes, and large sums of money.";
			m94.Tagline = "Times like these call for a Big Lebowski.";
			m94.MPAA_Rating = MPAA.R;
			m94.Actors = "Jeff Bridges, John Goodman, Julianne Moore, Steve Buscemi, Philip Seymour Hoffman, David Huddleston";
			m94.ReleaseYear = 1998;
			m94.Runtime = new TimeSpan(0, 117, 0);
			db.Movies.AddOrUpdate(m => m.Title, m94);
			db.SaveChanges();
			m94 = db.Movies.FirstOrDefault(m => m.MovieNumber == m94.MovieNumber);
			m94.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m94.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m95 = new Movie();
			m95.MovieNumber = 3095;
			m95.Title = "Shakespeare in Love";
			m95.Overview = "Young Shakespeare is forced to stage his latest comedy, 'Romeo and Ethel, the Pirate's Daughter,' before it's even written. When a lovely noblewoman auditions for a role, they fall into forbidden love -- and his play finds a new life (and title). As their relationship progresses, Shakespeare's comedy soon transforms into tragedy.";
			m95.Tagline = "Love is the only inspiration.";
			m95.MPAA_Rating = MPAA.R;
			m95.Actors = "Joseph Fiennes, Gwyneth Paltrow, Geoffrey Rush, Tom Wilkinson, Judi Dench, Imelda Staunton";
			m95.ReleaseYear = 1998;
			m95.Runtime = new TimeSpan(0, 122, 0);
			db.Movies.AddOrUpdate(m => m.Title, m95);
			db.SaveChanges();
			m95 = db.Movies.FirstOrDefault(m => m.MovieNumber == m95.MovieNumber);
			m95.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m95.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "History"));

			db.SaveChanges();

			Movie m96 = new Movie();
			m96.MovieNumber = 3096;
			m96.Title = "You've Got Mail";
			m96.Overview = "Book superstore magnate, Joe Fox and independent book shop owner, Kathleen Kelly fall in love in the anonymity of the Internet – both blissfully unaware that he's putting her out of business.";
			m96.Tagline = "Someone you pass on the street may already be the love of your life.";
			m96.MPAA_Rating = MPAA.PG;
			m96.Actors = "Tom Hanks, Meg Ryan, Katie Sagona, Greg Kinnear, Parker Posey, Jean Stapleton";
			m96.ReleaseYear = 1998;
			m96.Runtime = new TimeSpan(0, 119, 0);
			db.Movies.AddOrUpdate(m => m.Title, m96);
			db.SaveChanges();
			m96 = db.Movies.FirstOrDefault(m => m.MovieNumber == m96.MovieNumber);
			m96.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m96.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m97 = new Movie();
			m97.MovieNumber = 3097;
			m97.Title = "Office Space";
			m97.Overview = "Three office workers strike back at their evil employers by hatching a hapless attempt to embezzle money.";
			m97.Tagline = "Work sucks.";
			m97.MPAA_Rating = MPAA.R;
			m97.Actors = "Ron Livingston, Jennifer Aniston, David Herman, Ajay Naidu, Diedrich Bader, Stephen Root";
			m97.ReleaseYear = 1999;
			m97.Runtime = new TimeSpan(0, 89, 0);
			db.Movies.AddOrUpdate(m => m.Title, m97);
			db.SaveChanges();
			m97 = db.Movies.FirstOrDefault(m => m.MovieNumber == m97.MovieNumber);
			m97.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m97.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m98 = new Movie();
			m98.MovieNumber = 3098;
			m98.Title = "Notting Hill";
			m98.Overview = "The British comedy from director Roger Michell tells the love story between a famous actress and a simple book seller from London. A look into the attempt for famous people to have a personal and private life and the ramifications that follow. Nominated for three Golden Globes in 2000.";
			m98.Tagline = "Can the most famous film star in the world fall for the man on the street?";
			m98.MPAA_Rating = MPAA.PG13;
			m98.Actors = "Julia Roberts, Hugh Grant, Gina McKee, Tim McInnerny, Rhys Ifans, Emma Chambers";
			m98.ReleaseYear = 1999;
			m98.Runtime = new TimeSpan(0, 124, 0);
			db.Movies.AddOrUpdate(m => m.Title, m98);
			db.SaveChanges();
			m98 = db.Movies.FirstOrDefault(m => m.MovieNumber == m98.MovieNumber);
			m98.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m98.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m98.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m99 = new Movie();
			m99.MovieNumber = 3099;
			m99.Title = "Toy Story 2";
			m99.Overview = "Andy heads off to Cowboy Camp, leaving his toys to their own devices. Things shift into high gear when an obsessive toy collector named Al McWhiggen, owner of Al's Toy Barn kidnaps Woody. Andy's toys mount a daring rescue mission, Buzz Lightyear meets his match and Woody has to decide where he and his heart truly belong.";
			m99.Tagline = "The toys are back!";
			m99.MPAA_Rating = MPAA.G;
			m99.Actors = "Tom Hanks, Tim Allen, Joan Cusack, Kelsey Grammer, Don Rickles, Jim Varney";
			m99.ReleaseYear = 1999;
			m99.Runtime = new TimeSpan(0, 92, 0);
			db.Movies.AddOrUpdate(m => m.Title, m99);
			db.SaveChanges();
			m99 = db.Movies.FirstOrDefault(m => m.MovieNumber == m99.MovieNumber);
			m99.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m99.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m99.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m100 = new Movie();
			m100.MovieNumber = 3100;
			m100.Title = "Gladiator";
			m100.Overview = "In the year 180, the death of emperor Marcus Aurelius throws the Roman Empire into chaos. Maximus is one of the Roman army's most capable and trusted generals and a key advisor to the emperor. As Marcus' devious son Commodus ascends to the throne, Maximus is set to be executed. He escapes, but is captured by slave traders. Renamed Spaniard and forced to become a gladiator, Maximus must battle to the death with other men for the amusement of paying audiences. His battle skills serve him well, and he becomes one of the most famous and admired men to fight in the Colosseum. Determined to avenge himself against the man who took away his freedom and laid waste to his family, Maximus believes that he can use his fame and skill in the ring to avenge the loss of his family and former glory. As the gladiator begins to challenge his rule, Commodus decides to put his own fighting mettle to the test by squaring off with Maximus in a battle to the death.";
			m100.Tagline = "A Hero Will Rise.";
			m100.MPAA_Rating = MPAA.R;
			m100.Actors = "Russell Crowe, Joaquin Phoenix, Connie Nielsen, Oliver Reed, Richard Harris, Derek Jacobi";
			m100.ReleaseYear = 2000;
			m100.Runtime = new TimeSpan(0, 155, 0);
			db.Movies.AddOrUpdate(m => m.Title, m100);
			db.SaveChanges();
			m100 = db.Movies.FirstOrDefault(m => m.MovieNumber == m100.MovieNumber);
			m100.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m100.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m100.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));

			db.SaveChanges();

			Movie m101 = new Movie();
			m101.MovieNumber = 3101;
			m101.Title = "Gone in Sixty Seconds";
			m101.Overview = "Upon learning that he has to come out of retirement to steal 50 cars in one night to save his brother Kip's life, former car thief Randall 'Memphis' Raines enlists help from a few 'boost happy' pals to accomplish a seemingly impossible feat. From countless car chases to relentless cops, the high-octane excitement builds as Randall swerves around more than a few roadblocks to keep Kip alive.";
			m101.Tagline = "Ice Cold, Hot Wired.";
			m101.MPAA_Rating = MPAA.PG13;
			m101.Actors = "Nicolas Cage, Angelina Jolie, Giovanni Ribisi, Delroy Lindo, Will Patton, Christopher Eccleston";
			m101.ReleaseYear = 2000;
			m101.Runtime = new TimeSpan(0, 118, 0);
			db.Movies.AddOrUpdate(m => m.Title, m101);
			db.SaveChanges();
			m101 = db.Movies.FirstOrDefault(m => m.MovieNumber == m101.MovieNumber);
			m101.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m101.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m101.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m102 = new Movie();
			m102.MovieNumber = 3102;
			m102.Title = "X-Men";
			m102.Overview = "Two mutants, Rogue and Wolverine, come to a private academy for their kind whose resident superhero team, the X-Men, must oppose a terrorist organization with similar powers.";
			m102.Tagline = "Evolution Begins";
			m102.MPAA_Rating = MPAA.PG13;
			m102.Actors = "Patrick Stewart, Hugh Jackman, Ian McKellen, Halle Berry, Famke Janssen, James Marsden";
			m102.ReleaseYear = 2000;
			m102.Runtime = new TimeSpan(0, 104, 0);
			db.Movies.AddOrUpdate(m => m.Title, m102);
			db.SaveChanges();
			m102 = db.Movies.FirstOrDefault(m => m.MovieNumber == m102.MovieNumber);
			m102.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m102.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m102.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m103 = new Movie();
			m103.MovieNumber = 3103;
			m103.Title = "Miss Congeniality";
			m103.Overview = "When the local FBI office receives a letter from a terrorist known only as 'The Citizen', it's quickly determined that he's planning his next act at the Miss America beauty pageant. Because tough-as-nails Gracie Hart is the only female Agent at the office, she's chosen to go undercover as the contestant from New Jersey.";
			m103.Tagline = "Never Mess With An Agent In A Dress.";
			m103.MPAA_Rating = MPAA.PG13;
			m103.Actors = "Sandra Bullock, Benjamin Bratt, Michael Caine, Candice Bergen, William Shatner, Ernie Hudson";
			m103.ReleaseYear = 2000;
			m103.Runtime = new TimeSpan(0, 111, 0);
			db.Movies.AddOrUpdate(m => m.Title, m103);
			db.SaveChanges();
			m103 = db.Movies.FirstOrDefault(m => m.MovieNumber == m103.MovieNumber);
			m103.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m103.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m103.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));

			db.SaveChanges();

			Movie m104 = new Movie();
			m104.MovieNumber = 3104;
			m104.Title = "Bridget Jones's Diary";
			m104.Overview = "A chaotic Bridget Jones meets a snobbish lawyer, and he soon enters her world of imperfections.";
			m104.Tagline = "Health Warning: Adopting Bridget's lifestyle could seriously damage your health.";
			m104.MPAA_Rating = MPAA.R;
			m104.Actors = "Renee Zellweger, Colin Firth, Hugh Grant, Gemma Jones, Jim Broadbent, James Callis";
			m104.ReleaseYear = 2001;
			m104.Runtime = new TimeSpan(0, 97, 0);
			db.Movies.AddOrUpdate(m => m.Title, m104);
			db.SaveChanges();
			m104 = db.Movies.FirstOrDefault(m => m.MovieNumber == m104.MovieNumber);
			m104.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m104.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m104.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m105 = new Movie();
			m105.MovieNumber = 3105;
			m105.Title = "Legally Blonde";
			m105.Overview = "Elle Woods has it all. She's the president of her sorority, a Hawaiian Tropic girl, Miss June in her campus calendar, and, above all, a natural blonde. She dates the cutest fraternity boy on campus and wants nothing more than to be Mrs. Warner Huntington III. But, there's just one thing stopping Warner from popping the question: Elle is too blonde.";
			m105.Tagline = "Don't judge a book by its hair color!";
			m105.MPAA_Rating = MPAA.PG13;
			m105.Actors = "Reese Witherspoon, Luke Wilson, Selma Blair, Matthew Davis, Victor Garber, Jennifer Coolidge";
			m105.ReleaseYear = 2001;
			m105.Runtime = new TimeSpan(0, 96, 0);
			db.Movies.AddOrUpdate(m => m.Title, m105);
			db.SaveChanges();
			m105 = db.Movies.FirstOrDefault(m => m.MovieNumber == m105.MovieNumber);
			m105.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m106 = new Movie();
			m106.MovieNumber = 3106;
			m106.Title = "Monsters, Inc.";
			m106.Overview = "James Sullivan and Mike Wazowski are monsters, they earn their living scaring children and are the best in the business... even though they're more afraid of the children than they are of them. When a child accidentally enters their world, James and Mike suddenly find that kids are not to be afraid of and they uncover a conspiracy that could threaten all children across the world.";
			m106.Tagline = "We Scare Because We Care.";
			m106.MPAA_Rating = MPAA.G;
			m106.Actors = "John Goodman, Billy Crystal, Mary Gibbs, Steve Buscemi, James Coburn, Jennifer Tilly";
			m106.ReleaseYear = 2001;
			m106.Runtime = new TimeSpan(0, 92, 0);
			db.Movies.AddOrUpdate(m => m.Title, m106);
			db.SaveChanges();
			m106 = db.Movies.FirstOrDefault(m => m.MovieNumber == m106.MovieNumber);
			m106.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m106.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m106.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m107 = new Movie();
			m107.MovieNumber = 3107;
			m107.Title = "Harry Potter and the Philosopher's Stone";
			m107.Overview = "Harry Potter has lived under the stairs at his aunt and uncle's house his whole life. But on his 11th birthday, he learns he's a powerful wizard -- with a place waiting for him at the Hogwarts School of Witchcraft and Wizardry. As he learns to harness his newfound powers with the help of the school's kindly headmaster, Harry uncovers the truth about his parents' deaths -- and about the villain who's to blame.";
			m107.Tagline = "Let the Magic Begin.";
			m107.MPAA_Rating = MPAA.PG;
			m107.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Richard Harris, Tom Felton, Robbie Coltrane";
			m107.ReleaseYear = 2001;
			m107.Runtime = new TimeSpan(0, 152, 0);
			db.Movies.AddOrUpdate(m => m.Title, m107);
			db.SaveChanges();
			m107 = db.Movies.FirstOrDefault(m => m.MovieNumber == m107.MovieNumber);
			m107.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m107.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m107.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m108 = new Movie();
			m108.MovieNumber = 3108;
			m108.Title = "Ocean's Eleven";
			m108.Overview = "Less than 24 hours into his parole, charismatic thief Danny Ocean is already rolling out his next plan: In one night, Danny's hand-picked crew of specialists will attempt to steal more than $150 million from three Las Vegas casinos. But to score the cash, Danny risks his chances of reconciling with ex-wife, Tess.";
			m108.Tagline = "Are you in or out?";
			m108.MPAA_Rating = MPAA.PG13;
			m108.Actors = "George Clooney, Brad Pitt, Matt Damon, Andy Garcia, Julia Roberts, Casey Affleck";
			m108.ReleaseYear = 2001;
			m108.Runtime = new TimeSpan(0, 116, 0);
			db.Movies.AddOrUpdate(m => m.Title, m108);
			db.SaveChanges();
			m108 = db.Movies.FirstOrDefault(m => m.MovieNumber == m108.MovieNumber);
			m108.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			m108.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m109 = new Movie();
			m109.MovieNumber = 3109;
			m109.Title = "Harry Potter and the Chamber of Secrets";
			m109.Overview = "Ignoring threats to his life, Harry returns to Hogwarts to investigate – aided by Ron and Hermione – a mysterious series of attacks.";
			m109.Tagline = "Hogwarts is back in session.";
			m109.MPAA_Rating = MPAA.PG;
			m109.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Richard Harris, Alan Rickman, Tom Felton";
			m109.ReleaseYear = 2002;
			m109.Runtime = new TimeSpan(0, 161, 0);
			db.Movies.AddOrUpdate(m => m.Title, m109);
			db.SaveChanges();
			m109 = db.Movies.FirstOrDefault(m => m.MovieNumber == m109.MovieNumber);
			m109.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m109.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m109.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m110 = new Movie();
			m110.MovieNumber = 3110;
			m110.Title = "Finding Nemo";
			m110.Overview = "Nemo, an adventurous young clownfish, is unexpectedly taken from his Great Barrier Reef home to a dentist's office aquarium. It's up to his worrisome father Marlin and a friendly but forgetful fish Dory to bring Nemo home -- meeting vegetarian sharks, surfer dude turtles, hypnotic jellyfish, hungry seagulls, and more along the way.";
			m110.Tagline = "There are 3.7 trillion fish in the ocean, they're looking for one.";
			m110.MPAA_Rating = MPAA.G;
			m110.Actors = "Albert Brooks, Ellen DeGeneres, Alexander Gould, Willem Dafoe, Brad Garrett, Allison Janney";
			m110.ReleaseYear = 2003;
			m110.Runtime = new TimeSpan(0, 100, 0);
			db.Movies.AddOrUpdate(m => m.Title, m110);
			db.SaveChanges();
			m110 = db.Movies.FirstOrDefault(m => m.MovieNumber == m110.MovieNumber);
			m110.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m110.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m111 = new Movie();
			m111.MovieNumber = 3111;
			m111.Title = "Love Actually";
			m111.Overview = "Follows seemingly unrelated people as their lives begin to intertwine while they fall in – and out – of love. Affections languish and develop as Christmas draws near.";
			m111.Tagline = "The ultimate romantic comedy.";
			m111.MPAA_Rating = MPAA.R;
			m111.Actors = "Keira Knightley, Heike Makatsch, Emma Thompson, Laura Linney, Hugh Grant, January Jones";
			m111.ReleaseYear = 2003;
			m111.Runtime = new TimeSpan(0, 135, 0);
			db.Movies.AddOrUpdate(m => m.Title, m111);
			db.SaveChanges();
			m111 = db.Movies.FirstOrDefault(m => m.MovieNumber == m111.MovieNumber);
			m111.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m111.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m111.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m112 = new Movie();
			m112.MovieNumber = 3112;
			m112.Title = "Elf";
			m112.Overview = "When young Buddy falls into Santa's gift sack on Christmas Eve, he's transported back to the North Pole and raised as a toy-making elf by Santa's helpers. But as he grows into adulthood, he can't shake the nagging feeling that he doesn't belong. Buddy vows to visit Manhattan and find his real dad, a workaholic publisher.";
			m112.Tagline = "This holiday, discover your inner elf.";
			m112.MPAA_Rating = MPAA.PG;
			m112.Actors = "Will Ferrell, James Caan, Zooey Deschanel, Mary Steenburgen, Daniel Tay, Ed Asner";
			m112.ReleaseYear = 2003;
			m112.Runtime = new TimeSpan(0, 97, 0);
			db.Movies.AddOrUpdate(m => m.Title, m112);
			db.SaveChanges();
			m112 = db.Movies.FirstOrDefault(m => m.MovieNumber == m112.MovieNumber);
			m112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m113 = new Movie();
			m113.MovieNumber = 3113;
			m113.Title = "Mean Girls";
			m113.Overview = "Cady Heron is a hit with The Plastics, the A-list girl clique at her new school, until she makes the mistake of falling for Aaron Samuels, the ex-boyfriend of alpha Plastic Regina George.";
			m113.Tagline = "Welcome to girl world.";
			m113.MPAA_Rating = MPAA.PG13;
			m113.Actors = "Lindsay Lohan, Rachel McAdams, Tim Meadows, Ana Gasteyer, Amy Poehler, Tina Fey";
			m113.ReleaseYear = 2004;
			m113.Runtime = new TimeSpan(0, 97, 0);
			db.Movies.AddOrUpdate(m => m.Title, m113);
			db.SaveChanges();
			m113 = db.Movies.FirstOrDefault(m => m.MovieNumber == m113.MovieNumber);
			m113.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m114 = new Movie();
			m114.MovieNumber = 3114;
			m114.Title = "Harry Potter and the Prisoner of Azkaban";
			m114.Overview = "Harry, Ron and Hermione return to Hogwarts for another magic-filled year. Harry comes face to face with danger yet again, this time in the form of escaped convict, Sirius Black – and turns to sympathetic Professor Lupin for help.";
			m114.Tagline = "Something wicked this way comes.";
			m114.MPAA_Rating = MPAA.PG13;
			m114.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Gary Oldman, David Thewlis, Alan Rickman";
			m114.ReleaseYear = 2004;
			m114.Runtime = new TimeSpan(0, 141, 0);
			db.Movies.AddOrUpdate(m => m.Title, m114);
			db.SaveChanges();
			m114 = db.Movies.FirstOrDefault(m => m.MovieNumber == m114.MovieNumber);
			m114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m115 = new Movie();
			m115.MovieNumber = 3115;
			m115.Title = "Harry Potter and the Goblet of Fire";
			m115.Overview = "Harry starts his fourth year at Hogwarts, competes in the treacherous Triwizard Tournament and faces the evil Lord Voldemort. Ron and Hermione help Harry manage the pressure – but Voldemort lurks, awaiting his chance to destroy Harry and all that he stands for.";
			m115.Tagline = "Dark And Difficult Times Lie Ahead.";
			m115.MPAA_Rating = MPAA.PG13;
			m115.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Ralph Fiennes, Michael Gambon, Alan Rickman";
			m115.ReleaseYear = 2005;
			m115.Runtime = new TimeSpan(0, 157, 0);
			db.Movies.AddOrUpdate(m => m.Title, m115);
			db.SaveChanges();
			m115 = db.Movies.FirstOrDefault(m => m.MovieNumber == m115.MovieNumber);
			m115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m116 = new Movie();
			m116.MovieNumber = 3116;
			m116.Title = "Cars";
			m116.Overview = "Lightning McQueen, a hotshot rookie race car driven to succeed, discovers that life is about the journey, not the finish line, when he finds himself unexpectedly detoured in the sleepy Route 66 town of Radiator Springs. On route across the country to the big Piston Cup Championship in California to compete against two seasoned pros, McQueen gets to know the town's offbeat characters.";
			m116.Tagline = "Ahhh... it's got that new movie smell.";
			m116.MPAA_Rating = MPAA.G;
			m116.Actors = "Owen Wilson, Paul Newman, Bonnie Hunt, Larry the Cable Guy, Tony Shalhoub, Cheech Marin";
			m116.ReleaseYear = 2006;
			m116.Runtime = new TimeSpan(0, 117, 0);
			db.Movies.AddOrUpdate(m => m.Title, m116);
			db.SaveChanges();
			m116 = db.Movies.FirstOrDefault(m => m.MovieNumber == m116.MovieNumber);
			m116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m117 = new Movie();
			m117.MovieNumber = 3117;
			m117.Title = "The Departed";
			m117.Overview = "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the underworld, not realizing the syndicate has done likewise. While an undercover cop curries favor with the mob kingpin, a career criminal rises through the police ranks. But both sides soon discover there's a mole among them.";
			m117.Tagline = "Lies. Betrayal. Sacrifice. How far will you take it?";
			m117.MPAA_Rating = MPAA.R;
			m117.Actors = "Jack Nicholson, Matt Damon, Jack Nicholson, Mark Wahlberg, Martin Sheen, Ray Winstone";
			m117.ReleaseYear = 2006;
			m117.Runtime = new TimeSpan(0, 151, 0);
			db.Movies.AddOrUpdate(m => m.Title, m117);
			db.SaveChanges();
			m117 = db.Movies.FirstOrDefault(m => m.MovieNumber == m117.MovieNumber);
			m117.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m117.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));
			m117.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));

			db.SaveChanges();

			Movie m118 = new Movie();
			m118.MovieNumber = 3118;
			m118.Title = "Ratatouille";
			m118.Overview = "A rat named Remy dreams of becoming a great French chef despite his family's wishes and the obvious problem of being a rat in a decidedly rodent-phobic profession. When fate places Remy in the sewers of Paris, he finds himself ideally situated beneath a restaurant made famous by his culinary hero, Auguste Gusteau. Despite the apparent dangers of being an unlikely - and certainly unwanted - visitor in the kitchen of a fine French restaurant, Remy's passion for cooking soon sets into motion a hilarious and exciting rat race that turns the culinary world of Paris upside down.";
			m118.Tagline = "He's dying to become a chef.";
			m118.MPAA_Rating = MPAA.G;
			m118.Actors = "Patton Oswalt, Ian Holm, Lou Romano, Brian Dennehy, Peter Sohn, Peter O'Toole";
			m118.ReleaseYear = 2007;
			m118.Runtime = new TimeSpan(0, 111, 0);
			db.Movies.AddOrUpdate(m => m.Title, m118);
			db.SaveChanges();
			m118 = db.Movies.FirstOrDefault(m => m.MovieNumber == m118.MovieNumber);
			m118.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m118.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m118.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m118.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m119 = new Movie();
			m119.MovieNumber = 3119;
			m119.Title = "Transformers";
			m119.Overview = "Young teenager, Sam Witwicky becomes involved in the ancient struggle between two extraterrestrial factions of transforming robots – the heroic Autobots and the evil Decepticons. Sam holds the clue to unimaginable power and the Decepticons will stop at nothing to retrieve it.";
			m119.Tagline = "Their war. Our world.";
			m119.MPAA_Rating = MPAA.PG13;
			m119.Actors = "Shia LaBeouf, Josh Duhamel, Megan Fox, Rachael Taylor, Tyrese Gibson, Jon Voight";
			m119.ReleaseYear = 2007;
			m119.Runtime = new TimeSpan(0, 144, 0);
			db.Movies.AddOrUpdate(m => m.Title, m119);
			db.SaveChanges();
			m119 = db.Movies.FirstOrDefault(m => m.MovieNumber == m119.MovieNumber);
			m119.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m119.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m119.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));


			db.SaveChanges();

			Movie m120 = new Movie();
			m120.MovieNumber = 3120;
			m120.Title = "Harry Potter and the Order of the Phoenix";
			m120.Overview = "Returning for his fifth year of study at Hogwarts, Harry is stunned to find that his warnings about the return of Lord Voldemort have been ignored. Left with no choice, Harry takes matters into his own hands, training a small group of students – dubbed 'Dumbledore's Army' – to defend themselves against the dark arts.";
			m120.Tagline = "Evil Must Be Confronted.";
			m120.MPAA_Rating = MPAA.PG13;
			m120.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Michael Gambon, Ralph Fiennes, Tom Felton";
			m120.ReleaseYear = 2007;
			m120.Runtime = new TimeSpan(0, 138, 0);
			db.Movies.AddOrUpdate(m => m.Title, m120);
			db.SaveChanges();
			m120 = db.Movies.FirstOrDefault(m => m.MovieNumber == m120.MovieNumber);
			m120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"));

			db.SaveChanges();

			Movie m121 = new Movie();
			m121.MovieNumber = 3121;
			m121.Title = "The Dark Knight";
			m121.Overview = "Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.";
			m121.Tagline = "Why So Serious?";
			m121.MPAA_Rating = MPAA.PG13;
			m121.Actors = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine, Maggie Gyllenhaal, Gary Oldman";
			m121.ReleaseYear = 2008;
			m121.Runtime = new TimeSpan(0, 152, 0);
			db.Movies.AddOrUpdate(m => m.Title, m121);
			db.SaveChanges();
			m121 = db.Movies.FirstOrDefault(m => m.MovieNumber == m121.MovieNumber);
			m121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Crime"));
			m121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"));

			db.SaveChanges();

			Movie m122 = new Movie();
			m122.MovieNumber = 3122;
			m122.Title = "Star Trek";
			m122.Overview = "The fate of the galaxy rests in the hands of bitter rivals. One, James Kirk, is a delinquent, thrill-seeking Iowa farm boy. The other, Spock, a Vulcan, was raised in a logic-based society that rejects all emotion. As fiery instinct clashes with calm reason, their unlikely but powerful partnership is the only thing capable of leading their crew through unimaginable danger, boldly going where no one has gone before. The human adventure has begun again.";
			m122.Tagline = "The future begins.";
			m122.MPAA_Rating = MPAA.PG13;
			m122.Actors = "Chris Pine, Zachary Quinto, Leonard Nimoy, Eric Bana, Bruce Greenwood, Karl Urban";
			m122.ReleaseYear = 2009;
			m122.Runtime = new TimeSpan(0, 127, 0);
			db.Movies.AddOrUpdate(m => m.Title, m122);
			db.SaveChanges();
			m122 = db.Movies.FirstOrDefault(m => m.MovieNumber == m122.MovieNumber);
			m122.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m122.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m122.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));

			db.SaveChanges();

			Movie m123 = new Movie();
			m123.MovieNumber = 3123;
			m123.Title = "Up";
			m123.Overview = "Carl Fredricksen spent his entire life dreaming of exploring the globe and experiencing life to its fullest. But at age 78, life seems to have passed him by, until a twist of fate (and a persistent 8-year old Wilderness Explorer named Russell) gives him a new lease on life.";
			m123.Tagline = "Fly Up to Venezuela";
			m123.MPAA_Rating = MPAA.PG;
			m123.Actors = "Ed Asner, Christopher Plummer, Jordan Nagai, Bob Peterson, Delroy Lindo, Jerome Ranft";
			m123.ReleaseYear = 2009;
			m123.Runtime = new TimeSpan(0, 96, 0);
			db.Movies.AddOrUpdate(m => m.Title, m123);
			db.SaveChanges();
			m123 = db.Movies.FirstOrDefault(m => m.MovieNumber == m123.MovieNumber);
			m123.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m123.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m123.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m123.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));

			db.SaveChanges();

			Movie m124 = new Movie();
			m124.MovieNumber = 3124;
			m124.Title = "Harry Potter and the Half-Blood Prince";
			m124.Overview = "As Harry begins his sixth year at Hogwarts, he discovers an old book marked as 'Property of the Half-Blood Prince', and begins to learn more about Lord Voldemort's dark past.";
			m124.Tagline = "Dark Secrets Revealed";
			m124.MPAA_Rating = MPAA.PG;
			m124.Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Tom Felton, Michael Gambon, Jim Broadbent";
			m124.ReleaseYear = 2009;
			m124.Runtime = new TimeSpan(0, 153, 0);
			db.Movies.AddOrUpdate(m => m.Title, m124);
			db.SaveChanges();
			m124 = db.Movies.FirstOrDefault(m => m.MovieNumber == m124.MovieNumber);
			m124.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m124.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m124.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));

			db.SaveChanges();

			Movie m125 = new Movie();
			m125.MovieNumber = 3125;
			m125.Title = "The Princess and the Frog";
			m125.Overview = "A waitress, desperate to fulfill her dreams as a restaurant owner, is set on a journey to turn a frog prince back into a human being, but she has to do face the same problem after she kisses him.";
			m125.Tagline = "Every Love Story Begins With a Kiss...";
			m125.MPAA_Rating = MPAA.G;
			m125.Actors = "Anika Noni Rose, Bruno Campos, Keith David, Michael-Leon Wooley, Jennifer Cody, Jim Cummings";
			m125.ReleaseYear = 2009;
			m125.Runtime = new TimeSpan(0, 97, 0);
			db.Movies.AddOrUpdate(m => m.Title, m125);
			db.SaveChanges();
			m125 = db.Movies.FirstOrDefault(m => m.MovieNumber == m125.MovieNumber);
			m125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));
			m125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));

			db.SaveChanges();

			Movie m126 = new Movie();
			m126.MovieNumber = 3126;
			m126.Title = "Avatar";
			m126.Overview = "In the 22nd century, a paraplegic Marine is dispatched to the moon Pandora on a unique mission, but becomes torn between following orders and protecting an alien civilization.";
			m126.Tagline = "Enter the World of Pandora.";
			m126.MPAA_Rating = MPAA.PG13;
			m126.Actors = "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang, Michelle Rodriguez, Giovanni Ribisi";
			m126.ReleaseYear = 2009;
			m126.Runtime = new TimeSpan(0, 162, 0);
			db.Movies.AddOrUpdate(m => m.Title, m126);
			db.SaveChanges();
			m126 = db.Movies.FirstOrDefault(m => m.MovieNumber == m126.MovieNumber);
			m126.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m126.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m126.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			m126.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));

			db.SaveChanges();

			Movie m127 = new Movie();
			m127.MovieNumber = 3127;
			m127.Title = "Toy Story 3";
			m127.Overview = "Woody, Buzz, and the rest of Andy's toys haven't been played with in years. With Andy about to go to college, the gang find themselves accidentally left at a nefarious day care center. The toys must band together to escape and return home to Andy.";
			m127.Tagline = "No toy gets left behind.";
			m127.MPAA_Rating = MPAA.G;
			m127.Actors = "Tom Hanks, Tim Allen, Ned Beatty, Joan Cusack, Michael Keaton, Whoopi Goldberg";
			m127.ReleaseYear = 2010;
			m127.Runtime = new TimeSpan(0, 103, 0);
			db.Movies.AddOrUpdate(m => m.Title, m127);
			db.SaveChanges();
			m127 = db.Movies.FirstOrDefault(m => m.MovieNumber == m127.MovieNumber);
			m127.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m127.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m127.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

			Movie m128 = new Movie();
			m128.MovieNumber = 3128;
			m128.Title = "The King's Speech";
			m128.Overview = "The King's Speech tells the story of the man who became King George VI, the father of Queen Elizabeth II. After his brother abdicates, George ('Bertie') reluctantly assumes the throne. Plagued by a dreaded stutter and considered unfit to be king, Bertie engages the help of an unorthodox speech therapist named Lionel Logue. Through a set of unexpected techniques, and as a result of an unlikely friendship, Bertie is able to find his voice and boldly lead the country into war.";
			m128.Tagline = "Find your voice.";
			m128.MPAA_Rating = MPAA.R;
			m128.Actors = "Colin Firth, Geoffrey Rush, Helena Bonham Carter, Guy Pearce, Timothy Spall, Michael Gambon";
			m128.ReleaseYear = 2010;
			m128.Runtime = new TimeSpan(0, 118, 0);
			db.Movies.AddOrUpdate(m => m.Title, m128);
			db.SaveChanges();
			m128 = db.Movies.FirstOrDefault(m => m.MovieNumber == m128.MovieNumber);
			m128.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));
			m128.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "History"));

			db.SaveChanges();

			Movie m129 = new Movie();
			m129.MovieNumber = 3129;
			m129.Title = "Moneyball";
			m129.Overview = "The story of Oakland Athletics general manager Billy Beane's successful attempt to put together a baseball team on a budget, by employing computer-generated analysis to draft his players.";
			m129.Tagline = "What are you really worth?";
			m129.MPAA_Rating = MPAA.PG13;
			m129.Actors = "Brad Pitt, Jonah Hill, Philip Seymour Hoffman, Robin Wright, Chris Pratt, Stephen Bishop";
			m129.ReleaseYear = 2011;
			m129.Runtime = new TimeSpan(0, 133, 0);
			db.Movies.AddOrUpdate(m => m.Title, m129);
			db.SaveChanges();
			m129 = db.Movies.FirstOrDefault(m => m.MovieNumber == m129.MovieNumber);
			m129.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Drama"));

			db.SaveChanges();

			Movie m130 = new Movie();
			m130.MovieNumber = 3130;
			m130.Title = "Brave";
			m130.Overview = "Brave is set in the mystical Scottish Highlands, where Mérida is the princess of a kingdom ruled by King Fergus and Queen Elinor. An unruly daughter and an accomplished archer, Mérida one day defies a sacred custom of the land and inadvertently brings turmoil to the kingdom. In an attempt to set things right, Mérida seeks out an eccentric old Wise Woman and is granted an ill-fated wish. Also figuring into Mérida’s quest — and serving as comic relief — are the kingdom’s three lords: the enormous Lord MacGuffin, the surly Lord Macintosh, and the disagreeable Lord Dingwall.";
			m130.Tagline = "Change your fate.";
			m130.MPAA_Rating = MPAA.PG;
			m130.Actors = "Kelly Macdonald, Julie Walters, Billy Connolly, Emma Thompson, Kevin McKidd, Craig Ferguson";
			m130.ReleaseYear = 2012;
			m130.Runtime = new TimeSpan(0, 93, 0);
			db.Movies.AddOrUpdate(m => m.Title, m130);
			db.SaveChanges();
			m130 = db.Movies.FirstOrDefault(m => m.MovieNumber == m130.MovieNumber);
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));
			db.SaveChanges();

			Movie m131 = new Movie();
			m131.MovieNumber = 3131;
			m131.Title = "Pitch Perfect";
			m131.Overview = "College student Beca knows she does not want to be part of a clique, but that's exactly where she finds herself after arriving at her new school. Thrust in among mean gals, nice gals and just plain weird gals, Beca finds that the only thing they have in common is how well they sing together. She takes the women of the group out of their comfort zone of traditional arrangements and into a world of amazing harmonic combinations in a fight to the top of college music competitions.";
			m131.Tagline = "Get pitch slapped.";
			m131.MPAA_Rating = MPAA.PG13;
			m131.Actors = "Anna Kendrick, Skylar Astin, Brittany Snow, Anna Camp, Rebel Wilson, Ben Platt";
			m131.ReleaseYear = 2012;
			m131.Runtime = new TimeSpan(0, 112, 0);
			db.Movies.AddOrUpdate(m => m.Title, m131);
			db.SaveChanges();
			m131 = db.Movies.FirstOrDefault(m => m.MovieNumber == m131.MovieNumber);
			m131.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m131.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Musical"));
			m131.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Romance"));

			db.SaveChanges();

			Movie m132 = new Movie();
			m132.MovieNumber = 3132;
			m132.Title = "The Lego Movie";
			m132.Overview = "An ordinary Lego mini-figure, mistakenly thought to be the extraordinary MasterBuilder, is recruited to join a quest to stop an evil Lego tyrant from gluing the universe together.";
			m132.Tagline = "The story of a nobody who saved everybody.";
			m132.MPAA_Rating = MPAA.PG;
			m132.Actors = "Chris Pratt, Will Ferrell, Elizabeth Banks, Will Arnett, Nick Offerman, Alison Brie";
			m132.ReleaseYear = 2014;
			m132.Runtime = new TimeSpan(0, 100, 0);
			db.Movies.AddOrUpdate(m => m.Title, m132);
			db.SaveChanges();
			m132 = db.Movies.FirstOrDefault(m => m.MovieNumber == m132.MovieNumber);
			m132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));
			m132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Animation"));
			m132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));
			m132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Family"));
			m132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"));

			db.SaveChanges();

			Movie m133 = new Movie();
			m133.MovieNumber = 3133;
			m133.Title = "Guardians of the Galaxy";
			m133.Overview = "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.";
			m133.Tagline = "All heroes start somewhere.";
			m133.MPAA_Rating = MPAA.PG13;
			m133.Actors = "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel, Bradley Cooper, Lee Pace";
			m133.ReleaseYear = 2014;
			m133.Runtime = new TimeSpan(0, 121, 0);
			db.Movies.AddOrUpdate(m => m.Title, m133);
			db.SaveChanges();
			m133 = db.Movies.FirstOrDefault(m => m.MovieNumber == m133.MovieNumber);
			m133.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Action"));
			m133.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"));
			m133.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"));

			db.SaveChanges();

			Movie m134 = new Movie();
			m134.MovieNumber = 3134;
			m134.Title = "Bad Moms";
			m134.Overview = "When three overworked and under-appreciated moms are pushed beyond their limits, they ditch their conventional responsibilities for a jolt of long overdue freedom, fun, and comedic self-indulgence.";
			m134.Tagline = "Party like a mother.";
			m134.MPAA_Rating = MPAA.R;
			m134.Actors = "Mila Kunis, Kristen Bell, Kathryn Hahn, Christina Applegate, Jada Pinkett Smith, Annie Mumolo";
			m134.ReleaseYear = 2016;
			m134.Runtime = new TimeSpan(0, 100, 0);
			db.Movies.AddOrUpdate(m => m.Title, m134);
			db.SaveChanges();
			m134 = db.Movies.FirstOrDefault(m => m.MovieNumber == m134.MovieNumber);
			m134.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"));

			db.SaveChanges();

		}
	}
}
