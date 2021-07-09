namespace DesignPatternTPfinal.Entities
{
    /// <summary>
    /// Singleton de l'objet d'appelle à la base de données
    /// </summary>
    public static class DbEntities
    {
        private static dbNotesEntities _dbNotesEntities;

        public static dbNotesEntities DbNotesEntities
        {
            get
            {
                if (_dbNotesEntities == null)
                {
                    _dbNotesEntities = new dbNotesEntities();
                }

                return _dbNotesEntities;
            }
        }
    }
}