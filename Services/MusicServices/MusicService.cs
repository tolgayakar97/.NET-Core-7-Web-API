using webAPI.Models;

namespace webAPI.Services.MusicServices
{
    public class MusicService : IMusicSerivice
    {

        public List<Music> musicDBExample = new List<Music>()
        {
            new Music ()
            {
                Id = 1,
                Name = "Nothing Else Matters",
                ArtistName = "Metallica",
                ArtistLastName = ""
            },

            new Music()
            {
                Id = 2,
                Name = "Careless Whisper",
                ArtistName = "George",
                ArtistLastName = "Michael"
            }
        };
        public List<Music> AddMusic(Music music)
        {
            musicDBExample.Add(music);
            return musicDBExample;
        }

        public List<Music> DeleteMusic(int id)
        {
            var result = musicDBExample.Find(x => x.Id == id);
            
            if (result is null)
            {
                return null;
            }

            musicDBExample.Remove(result);

            return musicDBExample;
        }

        public List<Music> GetAllMusics()
        {
            return musicDBExample;
        }

        public Music GetMusic(int id)
        {
            var result = musicDBExample.Find(x => x.Id == id);

            if (result is null)
            {
                return null;
            }

            return result;
        }

        public List<Music> UpdateMusic(int id, Music music)
        {
            //Once guncellemek istedigimiz datayi ariyoruz.
            var result = musicDBExample.Find(x => x.Id == id);
            if (result is null)
            {
                return null;
            }

            result = music;

            return musicDBExample;
        }
    }
}
