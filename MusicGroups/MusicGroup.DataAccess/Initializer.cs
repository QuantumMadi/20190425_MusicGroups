using MusicGroups.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace MusicGroup.DataAccess
{
    internal class Initializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<Song> songs;
        private List<MusicGroups.Models.MusicGroup> musicGroups;
        public Initializer()
        {
            musicGroups = new List<MusicGroups.Models.MusicGroup>
            {
                new MusicGroups.Models.MusicGroup
                {
                    Name = "Gym class heroes",
                    Rating = 10,
                    
                },

                new MusicGroups.Models.MusicGroup
                {
                    Name = "21 pilots",
                    Rating = 8,
                    
                },

                new MusicGroups.Models.MusicGroup
                {
                    Name = "System of a down",
                    Rating = 12,
                },
            };
            songs = new List<Song>
            {
                new Song
                {
                    Name = "Cookie jar",
                    MusicGroupId = musicGroups[0].Id,
                    LenghtInSeconds = 140,
                    Text = "I like girls, they like me..."
                },
                new Song
                {
                    Name = "Fairly local",
                    LenghtInSeconds = 200,
                    MusicGroupId = musicGroups[1].Id,
                    Text = "I am fairly local..."
                    
                },
                new Song
                {
                    Name = "Toxicity",
                    LenghtInSeconds = 300,
                    MusicGroupId = musicGroups[2].Id,
                    Text = "The toxicty of our city..."
                },
            };
            musicGroups[0].Songs.Add(songs[0]);
            musicGroups[1].Songs.Add(songs[1]);
            musicGroups[2].Songs.Add(songs[2]);
        }
        protected override void Seed(DataContext context)
        {
            context.MusicGroups.AddRange(musicGroups);
            context.Songs.AddRange(songs);
            base.Seed(context);
        }
    }
}