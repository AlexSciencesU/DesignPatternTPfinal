﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternTPfinal.Models
{
    public class NotePersoBuilder : NoteBuilder
    {
        public override NoteModel ConvertType(Note note)
        {
            return new NoteModel(note.Id, note.Titre, note.Description, note.Date, "PERSO");
        }
    }
}