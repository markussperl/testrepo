using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// für jedes bauteil soll eine virtuelle id erstellt werden, falls ein bauteil 
    /// mit selbem datamatrix (warum auch immer) eines tages erneut in eine linie etc. 
    /// eingeschleust werden sollte
    /// </summary>
    public class Part
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// bauteil kennung idR 23Zeichen, enthält TypKennung
        /// </summary>
        public string Datamatrix { get; set; }
        /// <summary>
        /// für dieses Teil auszuführende arbeitsschritte, stationen
        /// wird vom WorkPlan hereingeladen, anhand von ConfigurationId, PartType, DateTime wird dieser ausgewählt
        /// </summary>
        public List<WorkStep> WorkSteps { get; set; }
    }
}
