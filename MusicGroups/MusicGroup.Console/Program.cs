using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicGroup.DataAccess;
using MusicGroup.Console;


namespace MusicGroup.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicGroups.Models.MusicGroup musicGroup = new MusicGroups.Models.MusicGroup();
            DataContextUseServices dataContextUseServices = new DataContextUseServices();
            List<MusicGroups.Models.MusicGroup> musicGroups = dataContextUseServices.GetDescendSortedMusicGroups();
            foreach (var group  in musicGroups)
            {
                System.Console.WriteLine(group.Name);
            }
            System.Console.ReadLine();
        }
    }
}
