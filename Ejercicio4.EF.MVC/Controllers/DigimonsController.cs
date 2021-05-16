using Ejercicio4.EF.Entities;
using Ejercicio4.EF.Logic;
using Ejercicio4.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio4.EF.MVC.Controllers
{
    public class DigimonsController : Controller
    {

        DigimonsLogica logic = new DigimonsLogica();
        // GET: Digimons
        public ActionResult Index()
        {
            List<Digimons> digimons = logic.GetAll(); //Traemos la entidad territories
            List<AnimeView> digimonsViews = digimons.Select(d => new AnimeView
            {
                Nombre = d.Name,//traigo de la entidad lo que necesito y lo asigno a el view de territorio
                Nivel = d.Level,
                Imagen = d.Img

            }).ToList();


            return View(digimonsViews);
        }
    }
}