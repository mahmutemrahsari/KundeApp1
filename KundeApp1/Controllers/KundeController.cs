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
        private readonly KundeDB _kundeDB;

        public KundeController(KundeDB kundeDb)
        {
            _kundeDB = kundeDb;
        }

        public List<Kunde> HentAlle()
        {
            List<Kunde> alleKundene = _kundeDB.Kunder.ToList();
            return alleKundene;

        }

    }
}
