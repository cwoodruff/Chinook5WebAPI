﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;
using Microsoft.Data.SqlClient;

namespace Chinook.DataJson.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly SqlConnection _sqlconn;

        public PlaylistRepository(SqlConnection sqlconn)
        {
            _sqlconn = sqlconn;
        }

        public void Dispose()
        {
        }

        public async Task<bool> EntityExists(int id)
        {
            var sqlcomm = new SqlCommand("dbo.sproc_CheckPlaylist", _sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlcomm.Parameters.Add(new SqlParameter("PlaylistId", id));
            var dset = new DataSet();
            var adap = new SqlDataAdapter(sqlcomm);
            adap.Fill(dset);

            return Convert.ToBoolean(dset.Tables[0].Rows[0][0]);
        }

        public async Task<List<Playlist>> GetAll()
        {
            var sqlcomm = new SqlCommand("dbo.sproc_GetPlaylist", _sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var dset = new DataSet();
            var adap = new SqlDataAdapter(sqlcomm);
            adap.Fill(dset);
            var converted =
                JsonSerializer.Deserialize(dset.Tables[0].Rows[0][0].ToString(), typeof(List<Playlist>)) as
                    List<Playlist>;
            return converted;
        }

        public async Task<Playlist> GetById(int id)
        {
            var sqlcomm = new SqlCommand("dbo.sproc_GetPlaylistDetails", _sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlcomm.Parameters.Add(new SqlParameter("PlaylistId", id));
            var dset = new DataSet();
            var adap = new SqlDataAdapter(sqlcomm);
            adap.Fill(dset);
            var converted =
                JsonSerializer.Deserialize(dset.Tables[0].Rows[0][0].ToString(), typeof(List<Playlist>)) as
                    List<Playlist>;

            return converted.FirstOrDefault();
        }

        public async Task<Playlist> Add(Playlist newPlaylist)
        {
            return newPlaylist;
        }

        public async Task<bool> Update(Playlist playlist)
        {
            if (!await EntityExists(playlist.Id))
                return false;

            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Playlist>> GetByTrackId(int id)
        {
            var sqlcomm = new SqlCommand("dbo.sproc_GetPlaylistByTrack", _sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlcomm.Parameters.Add(new SqlParameter("TrackId", id));
            var dset = new DataSet();
            var adap = new SqlDataAdapter(sqlcomm);
            adap.Fill(dset);
            var converted =
                JsonSerializer.Deserialize(dset.Tables[0].Rows[0][0].ToString(), typeof(List<Playlist>)) as
                    List<Playlist>;
            return converted;
        }
    }
}