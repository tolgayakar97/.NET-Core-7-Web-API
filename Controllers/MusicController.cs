using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Services.MusicServices;
using System.Runtime.CompilerServices;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        //#region BEFORE DI
        ////Front end sayfasındaki CRUD işlemlerinin backend kismi, controller bolumunde gerceklesir.

        //public List<Music> musicDBExample = new List<Music>()
        //{
        //new Music()
        //{
        //    Id = 1,
        //        Name = "Nothing Else Matters",
        //        ArtistName = "Metallica",
        //        ArtistLastName = ""
        //    },

        //    new Music()
        //{
        //    Id = 2,
        //        Name = "Careless Whisper",
        //        ArtistName = "George",
        //        ArtistLastName = "Michael"
        //    }


        ///// <summary>
        ///// Get metodu ile databaseden butun elemanlari getirme islemi.
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public async Task<ActionResult<List<Music>>> GetAllMusics()
        //{
        //    return Ok(musicDBExample);
        //}


        ///// <summary>
        ///// Get metodu ile database den belirli id ye sahip olan elemanı getirme islemi.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Music>> GetMusic(int id)
        //{
        //    var result = musicDBExample.Find(x => x.Id == id);

        //    if (result is null)
        //    {
        //        return NotFound("Böyle bir şarkı yok");
        //    }

        //    return Ok(result);
        //}

        ///// <summary>
        ///// Post metodu ile database'e eleman ekleme islemi.<br/>
        ///// (Ne ekleyecegim? Music tipinde bir obje.)
        ///// </summary>
        ///// <param name="music"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<ActionResult<List<Music>>> AddMusic(Music music)
        //{
        //    musicDBExample.Add(music);
        //    return Ok(musicDBExample);
        //}

        ///// <summary>
        ///// Put metodu ile databasede music datasını guncelleme islemi.<br/>
        ///// Guncellemek istedigimiz datanin id sini ve, yeni guncellenmis music objesini paramtre olarak aliyoruz.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="musicToUpdate"></param>
        ///// <returns></returns>
        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<Music>>> UpdateMusic(int id, Music musicToUpdate)
        //{
        //    //Once guncellemek istedigimiz datayi ariyoruz.
        //    var result = musicDBExample.Find(x => x.Id == id);
        //    if(result is null)
        //    { 
        //        return NotFound("Boyle bir music yok.");
        //    }

        //    result = musicToUpdate;

        //    return Ok(musicDBExample);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<List<Music>>> DeleteMusic(int id)
        //{
        //    var result = musicDBExample.Find(x => x.Id == id);
        //    if (result is null)
        //    {
        //        return NotFound("Boyle bir music yok.");
        //    }

        //    musicDBExample.Remove(result);

        //    return Ok(musicDBExample);
        //}

        //#endregion

        #region AFTER DI

        //DEPENDENCY INJECTION
        private readonly IMusicSerivice _musicService;
        public MusicController(IMusicSerivice musicService)
        {
            _musicService = musicService; //This is called dependency injection.
        }

        //After dependency injection, crud operations can be used.

        /// <summary>
        /// Get metodu ile databaseden butun elemanlari getirme islemi.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Music>>> GetAllMusics()
        {

            return Ok(_musicService.GetAllMusics());
        }


        /// <summary>
        /// Get metodu ile database den belirli id ye sahip olan elemanı getirme islemi.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Music>> GetMusic(int id)
        {
            var result = _musicService.GetMusic(id);

            if (result is null)
            {
                return NotFound("Böyle bir şarkı yok");
            }

            return Ok(result);
        }

        /// <summary>
        /// Post metodu ile database'e eleman ekleme islemi.<br/>
        /// (Ne ekleyecegim? Music tipinde bir obje.)
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<List<Music>>> AddMusic(Music music)
        {
            _musicService.AddMusic(music);
            return Ok(_musicService);
        }

        /// <summary>
        /// Put metodu ile databasede music datasını guncelleme islemi.<br/>
        /// Guncellemek istedigimiz datanin id sini ve, yeni guncellenmis music objesini paramtre olarak aliyoruz.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="musicToUpdate"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Music>>> UpdateMusic(int id, Music musicToUpdate)
        {
            //Once guncellemek istedigimiz datayi ariyoruz.
            var result = _musicService.UpdateMusic(id, musicToUpdate);
            if (result is null)
            {
                return NotFound("Boyle bir music yok.");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Music>>> DeleteMusic(int id)
        {
            var result = _musicService.DeleteMusic(id);
            if (result is null)
            {
                return NotFound("Boyle bir music yok.");
            }

            return Ok(result);
        }


        #endregion
    }
}
