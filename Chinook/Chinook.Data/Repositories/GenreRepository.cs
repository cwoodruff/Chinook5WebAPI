﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Data.Data;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories
{
    public class GenreRepository : BaseRepository<Genre>, IDisposable, IGenreRepository
    {
        public GenreRepository(ChinookContext context) : base(context) {}

        public void Dispose() => _context.Dispose();
    }
}