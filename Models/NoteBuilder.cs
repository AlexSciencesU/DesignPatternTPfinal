using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternTPfinal.Models
{
    public abstract class NoteBuilder
    {
        protected NoteModel note;
        public NoteModel Note
        {
            get { return note; }
        }

        public abstract void ConvertType(NoteModel note);
    }
}