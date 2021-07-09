using DesignPatternTPfinal.Entities;
using DesignPatternTPfinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternTPfinal.Controllers
{
    public class NoteController : Controller
    {
        /// <summary>
        /// GET: Note
        /// Retourne 3 notes publiques (Type =0)
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var noteModel = new NoteIndex
            {
                Notes = DbEntities.DbNotesEntities.Note.Where(x=>x.Type ==0).Take(3).Select(n => new NoteModel() { Id = n.Id, Description = n.Description, Titre = n.Titre, Date = n.Date ?? DateTime.MinValue }).ToList()
            };

            return View(noteModel);
        }

        public ActionResult showAll()
        {
            //NoteModel note = DbEntities.DbNotesEntities.Note.FirstOrDefault();
            //if (note.Type == 1)
            //{
            //    NoteProBuilder builderPro = new NoteProBuilder();
            //    builderPro.ConvertType(note);
            //}
            //else if (note.Type == 2)
            //{
            //    NotePersoBuilder builderPerso = new NotePersoBuilder();
            //    builderPerso.ConvertType(note);
            //}
            return View();
        }
    }
}