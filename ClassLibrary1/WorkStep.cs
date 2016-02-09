using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// erweiterung zur plan-schritt-klasse, enthält ausführungsstatus/zeitstempel
    /// </summary>
    public class WorkStep : WorkPlanStep
    {
        /// <summary>
        /// zeitstempel soll gesetzt werden, sobald dieser schritt durchgeführt wurde
        /// </summary>
        public DateTime? FinishedDateTime { get; set; }
        /// <summary>
        /// die datasource, welche die IO bewertung ausgelöst hat, samt detail informationen zum datensatz aus abfrage
        /// </summary>
        public ResultFromDatasource FinishedResult { get; set; }
    }
}
