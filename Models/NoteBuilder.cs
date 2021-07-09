using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternTPfinal.Models
{
    public abstract class NoteBuilder
    {
        protected Note note;
        public Note Note
        {
            get { return note; }
        }

        public abstract void ConvertType();
    }
}