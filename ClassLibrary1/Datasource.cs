using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// jede art von datenquelle, andere datenbanken, verschiedene tabellen, views, individuelle queries
    /// </summary>
    public class Datasource
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// aktuell ms sql server
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// von uns geschriebenes auf das kundensystem angepasstes sql
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// ggfs. sollte man auch stored procedures ermöglichen bzw. prüfen was das aufwand ist, 
        /// vielleicht geht das auch einfach, haben wir auch ab und zu, so könnten wir uns den #tmp 
        /// generierungsaufwand etc. sparen 
        /// </summary>
        public string Procedure { get; set; }
    }
}
