using System.Collections.Generic;
using Newtonsoft.Json;
using OciusApi.Controllers;
using OciusApi.Repositories;

namespace OciusApi.Services
{
    public interface IVesselService
    {
        string GetAllVessels();
    }

    public class VesselService : IVesselService
    {   
        IVesselRepository _vesselRespository;
        
        public VesselService(IVesselRepository vesselRepository)
        {
            _vesselRespository = vesselRepository;
        }

        public string GetAllVessels()
        {
            var vessels = _vesselRespository.GetAllVessels();
            var vesselJson = JsonConvert.SerializeObject(vessels);
            return vesselJson;
        }
    }
}