using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TPModul9_1302213011.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> dataMhw = new List<Mahasiswa>
        {
            new Mahasiswa("Alif Taufiqurrahman","1302213011"),
            new Mahasiswa("Deva Angela Felisitas Toding", "1302213111"),
            new Mahasiswa("Iqro Banyuanto", "1302213061"),
            new Mahasiswa("Rahma Sakti Rahardian","1302210095"),
            new Mahasiswa("Regy Renanda Rahman","1302213117")
        };
        
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMhw;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMhw[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhw)
        {
            dataMhw.Add(newMhw);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa updatedMhw)
        {
            dataMhw[id] = updatedMhw;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMhw.RemoveAt(id);
        }
    }
}
