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
        // GET: Note
        public ActionResult Index()
        {
            NoteModel note = DbEntities.DbNotesEntities.Note.FirstOrDefault();
            if(note.Type == 1)
            {
                NoteProBuilder builderPro = new NoteProBuilder();
                builderPro.ConvertType(note);
            }
            else if(note.Type == 2)
            {
                NotePersoBuilder builderPerso = new NotePersoBuilder();
                builderPerso.ConvertType(note);
            }

            return View();
        }
    }
}