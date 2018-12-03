using Microsoft.AspNetCore.Mvc;
using OciusApi.Services;

namespace OciusApi.Controllers
{
    public class Vessel
    {
        public string Name { get; }
        public int[] Position { get; }

        public Vessel(string name, int[] position)
        {
            Name = name;
            Position = position;
        }
    }

    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class VesselsController : ControllerBase
    {
        private IVesselService _vesselService;

        public VesselsController(IVesselService vesselService)
        {
            _vesselService = vesselService;
        }
        
        // GET api/vessels
        [HttpGet]
        public ActionResult<string> Get()
        {
            var response = _vesselService.GetAllVessels();
            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Not available";
        }
    }
}

//api service
//receives request for boat locations
//gets boat location from repository
//returns

//scraper service
//make api request for all boats
//save to DB in raw form
//transform xml into json
//raw json now in DB
