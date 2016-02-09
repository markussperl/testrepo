using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// bauteil typen sollen konfigurationsübergreifend verwaltet werden
    /// </summary>
    public class PartType
    {
        /// <summary>
        /// künstlicher schlüssel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// parttype unique, G30-321BX7 ...
        /// </summary>
        public string Matchcode { get; set; }
        /// <summary>
        /// informative zwecke
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// regex-muster zur typenerkennung innerhalb der bauteilkennung (datamatrix)
        /// </summary>
        public string Regex { get; set; }
    }
}
