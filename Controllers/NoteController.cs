using DesignPatternTPfinal.Entities;
using DesignPatternTPfinal.Models;
using System;
using System.Linq;
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
            var noteModel = new NoteIndex()
            {
                Notes = DbEntities.DbNotesEntities.Note.Where(x => x.Type == 0).Take(3).Select(n => new NoteModel() { Id = n.Id, Description = n.Description, Titre = n.Titre, Date = n.Date ?? DateTime.MinValue }).ToList()
            };

            return View(noteModel);
        }

        public ActionResult ShowAll()
        {
            var noteModel = new NoteIndex();
            foreach (var noteEntity in DbEntities.DbNotesEntities.Note.ToList())
            {
                if (noteEntity.Type == 0)
                {
                    NoteProBuilder builderPro = new NoteProBuilder();
                    noteModel.Notes.Add(builderPro.ConvertType(noteEntity));
                }
                else if (noteEntity.Type == 1)
                {
                    NotePersoBuilder builderPro = new NotePersoBuilder();
                    noteModel.Notes.Add(builderPro.ConvertType(noteEntity));
                }
            }

            return View(noteModel);
        }
    }
}