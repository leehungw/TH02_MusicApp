using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH02_MusicApp.Config;
using TH02_MusicApp.Model;

namespace TH02_MusicApp.Repository
{
    internal class CommentRepo
    {
        public static void SaveComment(List<Comment> comments)
        {
            string json = JsonConvert.SerializeObject(comments);
            File.WriteAllText(DirectoryConsts.COMMENTS_JSON_FILE_PATH, json);
        }

        public static List<Comment> GetCommentsList()
        {
            if (File.Exists(DirectoryConsts.COMMENTS_JSON_FILE_PATH))
            {
                string json = File.ReadAllText(DirectoryConsts.COMMENTS_JSON_FILE_PATH);
                List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(json);
                return comments == null ? new List<Comment>() : comments;
            }
            return new List<Comment>();
        }

        public static void AddComment(Comment comment)
        {
            List<Comment> comments = GetCommentsList();
            comments.Add(comment);
            SaveComment(comments);
        }
    }
}
