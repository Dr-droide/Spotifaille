using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Spotifaille
{
    class FileReader
    {
        private string userDataPath;
        private string playlistPath;
        private string logPath;

        public FileReader()
        {
            userDataPath = "userDataBase.csv";
            playlistPath = "The Hot 100's All Time.txt";
            logPath = "log.txt";
        }

        /// <summary>
        /// Lit la UserData à l'emplacement par défaut et stock chaque utilisateur dans un User
        /// </summary>
        /// <returns>Une liste de User</returns>
        public List<User> ReadUserData()
        {
            List<User> list = new List<User>();
            var reader = new StreamReader(userDataPath);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                User user = new User();
                user.MailAddress = values[0];
                user.PassWord = values[1];

                list.Add(user);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// Ajoute un User à userData
        /// </summary>
        /// <param name="user">Le User à ajouter</param>
        public void AddUserData(User user)
        {
            var writer = new StreamWriter(userDataPath, true);

            writer.WriteLine("{0};{1}", user.MailAddress, user.PassWord);

            writer.Close();

        }

        /// <summary>
        /// Lis la playlist par défaut
        /// </summary>
        /// <returns>Une liste de Song</returns>
        public List<Song> ReadPlaylist()
        {
            List<Song> list = new List<Song>();
            var reader = new StreamReader(playlistPath);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                Song song = new Song();
                song.Artiste = values[0];
                song.Titre = values[1].Remove(0, 1);
                song.Duree = values[2].Remove(0, 1);
                if (values.Length > 3)
                {
                    song.SongPath = values[3].Remove(0, 1);
                    if (values.Length > 4)
                    {
                        song.ImgPath = values[4].Remove(0, 1);
                    }
                }
                list.Add(song);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// Lis la playlist dans le chemin entrée en paramètre
        /// </summary>
        /// <param name="playlistPath">Le chemin de la playlist à lire</param>
        /// <returns>Une liste de Song</returns>
        public List<Song> ReadPlaylist(String playlistPath)
        {
            List<Song> list = new List<Song>();
            var reader = new StreamReader(playlistPath);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                Song song = new Song();
                song.Artiste = values[0];
                song.Titre = values[1].Remove(0, 1);
                song.Duree = values[2].Remove(0, 1);
                if (values.Length > 3)
                {
                    song.SongPath = values[3].Remove(0, 1);
                    if (values.Length > 4)
                    {
                        song.ImgPath = values[4].Remove(0, 1);
                    }
                }
                list.Add(song);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// Ecrit les logs de l'écoute de musique
        /// </summary>
        /// <param name="email">E-mail de l'utilisateur</param>
        /// <param name="artiste">Artiste</param>
        /// <param name="titre">Titre de la musique</param>
        public void WriteLog(String email,String artiste, String titre)
        {
            var writer = new StreamWriter(logPath, true);

            writer.WriteLine("{0} : {1} ; {2} ; {3}", DateTime.Now, email, artiste, titre);

            writer.Close();
        }
    }
}
