using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// dienst als vorlage klasse, zum laden von der worksteps auf die instanz
    /// vom bauteil, gültig von-bis + validierung auf zugelassene konfigurationen
    /// und bauteil-typen
    /// </summary>
    public class WorkPlan
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// WorkPlan-unique
        /// </summary>
        public string Matchcode { get; set; }
        /// <summary>
        /// dient informationszwecken
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// liste für das bauteil auszuführender schritte
        /// </summary>
        public List<WorkPlanStep> WorkSteps { get; set; }

        #region validität

        /// <remarks>
        /// planerstellung soll keine überschneidungen der folgenden properties
        /// zulassen, von kann offen bleiben, planzuweisungen sind demnach immer 
        /// stichtagbezogen 
        /// </remarks>

        /// <summary>
        /// dieser plan gilt von
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// dieser plan gilt bis
        /// </summary>
        public DateTime? ValidUntil { get; set; }
        /// <summary>
        /// dieser plan gilt für folgende konfigurationen
        /// </summary>
        public List<Configuration> ValidConfiguration { get; set; }
        /// <summary>
        /// dieser plan gilt für folgende typen
        /// </summary>
        public List<PartType> ValidPartTypes { get; set; }

        #endregion
    }
}
