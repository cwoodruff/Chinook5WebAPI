using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chinook.Data.Data;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories
{
    public class PlaylistRepository : BaseRepository<Playlist>, IDisposable, IPlaylistRepository
    {
        public PlaylistRepository(ChinookContext context) : base(context) {}

        public void Dispose() => _context.Dispose();

        public async Task<List<Playlist>> GetByTrackId(int id)
        {
            return await _context.Playlists
                .Where(c => c.PlaylistTracks.Any(o => o.TrackId == id))
                .AsNoTrackingWithIdentityResolution().ToListAsync();
        }
    }
}