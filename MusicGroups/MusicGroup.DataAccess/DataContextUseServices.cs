using MusicGroups.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup.DataAccess
{
    public class DataContextUseServices
    {
        public void AddGroup(MusicGroups.Models.MusicGroup musicGroup)
        {
            using (var context = new DataContext())
            {
                context.MusicGroups.Add(musicGroup);
                context.SaveChanges();
            }
        }
        public void AddSong(MusicGroups.Models.Song song)
        {
            using (var context = new DataContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        public List <MusicGroups.Models.MusicGroup> GetMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicGroups.ToList();
            }
        }

        public List<MusicGroups.Models.MusicGroup> GetSortedMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicGroups.OrderBy(mus=>mus.Rating).ToList();
            }
        }

        public List<MusicGroups.Models.MusicGroup> GetDescendSortedMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicGroups.OrderByDescending(mus => mus.Rating).ToList();
            }
        }

        public List<Song> GetSongs()
        {
            using (var context = new DataContext())
            {
                return context.Songs.ToList();
            }
        }
        public MusicGroups.Models.MusicGroup GetMusicGroupByGroupName(string groupName)
        {
            using(var context = new DataContext())
            {
                return context.MusicGroups.FirstOrDefault(msGr => msGr.Name == groupName);
            }
        }
        public MusicGroups.Models.MusicGroup GetMusicGroupBySong(string songName)
        {
            using (var context = new DataContext())
            {
                return context.Songs.FirstOrDefault(song => song.Name == songName).MusicGroup;
            }
        }
    }
}
