using System.Collections.Generic;
using Chinook.Domain.ApiModels;
using Chinook.Domain.Converters;

namespace Chinook.Domain.Entities
{
    public sealed class Playlist : BaseEntity, IConvertModel<PlaylistApiModel>
    {
        public Playlist()
        {
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }
        
        public string Name { get; set; }


        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }

        public PlaylistApiModel Convert() =>
            new()
            {
                Id = Id,
                Name = Name
            };
    }
}