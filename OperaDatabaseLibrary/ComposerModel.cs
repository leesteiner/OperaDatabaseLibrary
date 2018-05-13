using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaDatabaseLibrary
{
    public class ComposerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationModel Nationality { get; set; }
        public string Dates { get; set; }
        public string WikiLink { get; set; }
        public string ImslpLink { get; set; }
    }
}
