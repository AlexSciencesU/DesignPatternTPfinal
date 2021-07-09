using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternTPfinal.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Titre { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }

        public NoteModel(int id, string description, string titre, DateTime? date, string type)
        {
            this.Id = id;
            this.Description = description;
            this.Titre = titre;
            this.Date = date;
            this.Type = type;
        }
    }
}