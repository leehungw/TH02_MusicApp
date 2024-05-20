using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using TH02_MusicApp.Config;
using TH02_MusicApp.Model;
using TH02_MusicApp.Repository;

namespace TH02_MusicApp.Shared_Preferences
{
    public static class DataStore
    {
        public static List<Song> Songs { get; private set; }
        public static List<Playlist> Playlists { get; private set; }
        public static List<Comment> Comments { get; private set; }

        public static Song PlayingSong { get; set; }

        static DataStore()
        {
            LoadData();
        }

        private static void LoadData()
        {
            Songs = SongRepo.GetSongList();
            Playlists = PlaylistRepo.GetPlaylistList();
            Comments = CommentRepo.GetCommentsList();
        }

        // add or update song
        public static void AddOrUpdateSong(Song song)
        {
            if (Songs.Exists(s => s.Id == song.Id))
            {
                Songs[Songs.FindIndex(s => s.Id == song.Id)] = song;
            }
            else
            {
                Songs.Add(song);
            }
            SongRepo.SaveSong(Songs);
        }

        // add or update playlist
        public static void AddOrUpdatePlaylist(Playlist playlist)
        {
            if (Playlists.Exists(p => p.Id == playlist.Id))
            {
                Playlists[Playlists.FindIndex(p => p.Id == playlist.Id)] = playlist;
            }
            else
            {
                Playlists.Add(playlist);
            }
            PlaylistRepo.SavePlaylist(Playlists);
        }

        public static void AddComment(Comment comment)
        {
            Comments.Add(comment);
            CommentRepo.AddComment(comment);
        }

        // delete song
        public static void DeleteSong(string songId)
        {
            Songs.RemoveAll(s => s.Id == songId);
            SongRepo.SaveSong(Songs);
        }

        // delete playlist
        public static void DeletePlaylist(Guid playlistId)
        {
            Playlists.RemoveAll(p => p.Id == playlistId);
            PlaylistRepo.SavePlaylist(Playlists);
        }

        // get song by id
        public static Song GetSongById(string songId)
        {
            return Songs.FirstOrDefault(s => s.Id == songId);
        }

        // get playlist by id
        public static Playlist GetPlaylistById(Guid playlistId)
        {
            return Playlists.FirstOrDefault(p => p.Id == playlistId);
        }

        public static List<Comment> GetCommentListBySongId(string songId)
        {
            return Comments.Where(x => x.songId == songId).ToList();
        }

        // add song to playlist
        public static void AddSongToPlaylist(Guid playlistId, string songId)
        {
            Playlist playlist = Playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
                return;

            if (playlist.SongIds.Contains(songId))
                return;

            playlist.SongIds.Add(songId);
            AddOrUpdatePlaylist(playlist);
        }
    }
}
