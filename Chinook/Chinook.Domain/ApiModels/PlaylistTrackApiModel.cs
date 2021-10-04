using Chinook.Domain.Converters;
using Chinook.Domain.Entities;

namespace Chinook.Domain.ApiModels
{
    public class PlaylistTrackApiModel : IConvertModel<PlaylistTrack>
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }

        public PlaylistApiModel Playlist { get; set; }

        public TrackApiModel Track { get; set; }

        public PlaylistTrack Convert() =>
            new()
            {
                PlaylistId = PlaylistId,
                TrackId = TrackId
            };
    }
}