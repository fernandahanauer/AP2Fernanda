
using AP2POOFER.Models.Domains;
using AP2POOFER.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AP2POO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private IAddressRepository repository;
       
        public AddressController(IAddressRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Address>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Address address)
        {
            repository.Create(address);
            return Ok(new {
                message = "Endereço cadastrado com sucesso.",
                httpCode=202,
                objectCreated = address
            });
        } 
    }
}