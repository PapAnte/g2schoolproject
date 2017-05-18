using Bravo.Models.DatabaseEntities;
using Bravo.Models.DatabaseEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models
{
    public interface ILieferant : IEntity, IName
    {
        ICollection<IRoom> Rooms { get; }
    }

    public class Lieferant
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Strasse { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }

        public ICollection<Geraet> Geraete { get; set; }
        public ICollection<Software> Softwares { get; set; }
    }
}
