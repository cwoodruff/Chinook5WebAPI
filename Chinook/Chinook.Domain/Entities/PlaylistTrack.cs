using Chinook.Domain.ApiModels;
using Chinook.Domain.Converters;

namespace Chinook.Domain.Entities
{
    public class PlaylistTrack : IConvertModel<PlaylistTrackApiModel>
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
        public virtual Playlist Playlist { get; set; }
        public virtual Track Track { get; set; }

        public PlaylistTrackApiModel Convert() =>
            new()
            {
                PlaylistId = PlaylistId,
                TrackId = TrackId
            };
    }
}