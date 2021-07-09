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
            var noteEntity = DbEntities.DbNotesEntities.Note.FirstOrDefault();
            NoteModel note = new NoteModel(noteEntity.Id, noteEntity.Description, noteEntity.Titre, noteEntity.Date, noteEntity.Type)
            if(note.Type == "1")
            {
                NoteProBuilder builderPro = new NoteProBuilder();
                builderPro.ConvertType(note);
            }
            else if(note.Type == "2")
            {
                NotePersoBuilder builderPerso = new NotePersoBuilder();
                builderPerso.ConvertType(note);
            }

            var noteModel = new NoteIndex();

            noteModel.Notes = DbEntities.DbNotesEntities.Note.Take(3).Select(n => new Models.Note() { Id = n.Id, Description = n.Description, Titre = n.Titre, Date = n.Date ?? DateTime.MinValue }).ToList();

            return View(noteModel);
        }
    }
}