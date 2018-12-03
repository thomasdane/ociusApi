using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OciusApi.Controllers;

namespace OciusApi.Repositories
{
    public interface IVesselRepository
    {
        List<Vessel> GetAllVessels();
    }

    public class VesselRespository : IVesselRepository
    {
        public List<Vessel> GetAllVessels()
        {
            var ocius = new Vessel("Ocius", new int[] { 1, 1 });
            var csiro = new Vessel("CSIRO", new int[] { 3, 3 });
            return new List<Vessel> { ocius, csiro };
        }
    }
}