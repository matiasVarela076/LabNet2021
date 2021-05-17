using Ejercicio4.EF.Entities;
using Ejercicio4.EF.Logic;
using Ejercicio4.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;

namespace Ejercicio4.EF.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriosLogica logic = new TerritoriosLogica();     
        // GET: Territories
        public ActionResult Index()
        {
           var territory = new TerritoriosLogica();
            List<Territories> territorios = logic.GetAll(); //Traemos la entidad territories
            List<TerritoriesView> territoriosViews = territorios.Select(t => new TerritoriesView
            {
                Id = t.TerritoryID,//traigo de la entidad lo que necesito y lo asigno a el view de territorio
                Descripcion = t.TerritoryDescription

            }).ToList();

            return View(territoriosViews);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriosViews)
        {
            try
            {
               var territoryEntity = new Territories
                {
                    TerritoryID = territoriosViews.Id,    //a la entidad le seteo los parametros del view
                    TerritoryDescription = territoriosViews.Descripcion}; 
                   
                    logic.Add(territoryEntity);  //Lo agrego
                 
                return RedirectToAction("Index", "Territories"); // vuelve al index para mostrar el nuevo campo
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }


        }
       
        public ActionResult Delete(string id)
        {
            logic.Delete(id); //Borramos el ID

            return RedirectToAction("Index"); //Una ves terminado vuelva a la pagina principal
        }
    }
}