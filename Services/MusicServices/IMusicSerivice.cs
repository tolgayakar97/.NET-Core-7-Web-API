using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Services.MusicServices
{
    public interface IMusicSerivice
    {
        //CRUD işlemleri burada olacak
        public List<Music> GetAllMusics();
        public Music GetMusic(int id);

        public List<Music> AddMusic(Music music);

        public List<Music> UpdateMusic(int id, Music music);

        public List<Music> DeleteMusic(int id);
    }
}
