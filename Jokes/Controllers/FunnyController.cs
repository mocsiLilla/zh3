using Jokes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jokes.Models;

namespace Jokes.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FunnyController : ControllerBase
    {
        [HttpGet]
        [Route("jokes/all")]
        public IActionResult M1()
        {
            FunnyContext context = new FunnyContext();
            var viccek = from x in context.Jokes
                         select x;
            return Ok(viccek);
        }

        [HttpGet]
        [Route("jokes/{id}")]
        public IActionResult M2(int id)
        {
            FunnyContext context = new FunnyContext();
            var választottVicc = (from x in context.Jokes
                                 where x.JokeSk == id
                                 select x).FirstOrDefault();
            if (választottVicc == null) return BadRequest("Nincs ilyen sorszámú vicc");
            return Ok(választottVicc);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            FunnyContext context = new FunnyContext();
            var törlendő = (from x in context.Jokes
                           where x.JokeSk == id
                           select x).FirstOrDefault();
            context.Remove(törlendő);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("add")]
        public void Add(string vicc)
        {
            FunnyContext context = new FunnyContext();
            Joke ujVicc = new Joke();
            ujVicc.JokeText = vicc;
            context.Jokes.Add(ujVicc);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("like/{id}")]
        public void Like(int id)
        {
            FunnyContext context = new FunnyContext();
            var jóVicc = (from x in context.Jokes
                          where x.JokeSk == id
                          select x).FirstOrDefault();
            jóVicc.UpVotes++;
            context.Update(jóVicc);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("dislike/{id}")]
        public void Dislike(int id)
        {
            FunnyContext context = new FunnyContext();
            var jóVicc = (from x in context.Jokes
                          where x.JokeSk == id
                          select x).FirstOrDefault();
            jóVicc.DownVotes++;
            context.Update(jóVicc);
            context.SaveChanges();
        }
    }
}
