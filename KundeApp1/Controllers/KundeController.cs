using KundeApp1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KundeApp1.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();
            kunde1.navn = "Per Hansen";
            kunde1.adresse = "Osloveien 82";

            var kunde2 = new Kunde
            {
                navn = "Line Jensen",
                adresse = "Askerveien 82"
            };


            kundene.Add(kunde1);
            kundene.Add(kunde2);

            return kundene;
        }

    }
}
