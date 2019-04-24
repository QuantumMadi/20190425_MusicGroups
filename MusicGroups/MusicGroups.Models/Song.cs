using System;

namespace MusicGroups.Models
{
    public class Song : Entity
    {
        public string Name { get; set; }
        public virtual Guid MusicGroupId { get; set; }
        public virtual MusicGroup MusicGroup { get; set; }
        public string Text { get; set; }
        public int LenghtInSeconds { get; set; }
    }
}