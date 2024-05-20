using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH02_MusicApp.Config
{
    public class DirectoryConsts
    {
        // song json file path
        public static string SONG_JSON_FILE_PATH = @"Data\music_info.json";

        // playlist json file path
        public static string PLAYLIST_JSON_FILE_PATH = @"Data\playlist_info.json";

        // comments json file path
        public static string COMMENTS_JSON_FILE_PATH = @"Data\comments_info.json";

        // image folder path stored in the debug folder of the project
        public static string IMAGE_FOLDER_PATH = @"Images\";

        // music folder path stored in the debug folder of the project
        public static string MUSIC_FOLDER_PATH = @"Songs\";
    }
}
