using DesignPatternTPfinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternTPfinal.Models
{
    public class NoteProBuilder : NoteBuilder
    {
        public override void ConvertType()
        {
            var note = DbEntities.DbNotesEntities.Note.FirstOrDefault();
            

        }
    }
}