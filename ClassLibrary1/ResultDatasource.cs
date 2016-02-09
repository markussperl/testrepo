using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// das ergebnis 
    /// </summary>
    public class ResultFromDatasource 
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// rückreferenz auf IO datasource
        /// </summary>
        public int DatasourceId { get; set; }





        /// <summary>
        /// am besten kann man hier string.format ähnlich arbeiten 
        /// und ein Muster hinterlegen, welches die verfügbaren Datenbank-spalten 
        /// in eine ordentliche Meldung o.ä. verwandelt
        /// </summary>
        public string InWelcherFormAuchImmer { get; set; }

        public DateTime RecordDateTime { get; set; }

        public string RecordOrigin { get; set; }

        // etc.
    }
}
