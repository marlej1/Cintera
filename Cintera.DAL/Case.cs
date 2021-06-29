using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cintera.DAL
{
    public class Case
    {
        public int Id { get; set; }
        public ICollection<Sightging> Sightgings { get; set; }
    }

    public class Sightging
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Case Case { get; set; }
        public int CaseId  { get; set; }
        public DateTime Date { get; set; }
    }
}
