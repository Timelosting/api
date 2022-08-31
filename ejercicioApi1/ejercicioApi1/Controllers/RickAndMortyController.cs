using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ejercicioApi1.Controllers
{
    [Route("Rick-and-Morty")]
    [ApiController]
    public class RickAndMortyController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public Task<string> Get()
        {
            var url = "https://rickandmortyapi.com/api/character";

            using (var client = new HttpClient())
            { 
                var response = client.GetAsync(url).Result;
                var content = response.Content.ReadAsStringAsync();
                return content;
            }
           
            //return new string[] { "value1", "value2" };
            
        }        
    }
    public class info 
    { 
        
    }
}
