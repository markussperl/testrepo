using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// dient als arbeitsschritt vorlage, diese vorlagen werden als kopie in 
    /// eine liste der auszuführenden schritt am bauteil selbst hinterlegt,
    /// damit man immer den aktuellen status + noch notwendige bearbeitungen etc.
    /// auswerten kann
    /// </summary>
    public class WorkPlanStep
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// workplanstep-unique
        /// </summary>
        public string Matchcode { get; set; }
        /// <summary>
        /// dient informationszwecken
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// dieser schritt muss nicht durchgeführt werden, benutzer einstellung
        /// </summary>
        public bool IsOptional { get; set; }
        /// <summary>
        /// liste gültiger datenquellen
        /// zB kann es 2 Tabellen Bearbeitung1,Bearbeitung2 geben welche unterschiedliche Datenstrukturen haben
        /// jedoch ein Bearbeitungsergebnis enthalten, zB (byte,int) mit wert 1 == IO in tabelle1 und wert 4 == IO in tabelle2
        /// bewertung von diesem arbeitsschritt als OK soll also datenquellen abhängig am besten via SQL möglich sein
        /// eine funktion soll bei arbeitsschritt-validierung anschließend alle möglichen datenquellen auf IO prüfen
        /// </summary>
        public List<Datasource> ValidDatasources { get; set; }
    }
}
