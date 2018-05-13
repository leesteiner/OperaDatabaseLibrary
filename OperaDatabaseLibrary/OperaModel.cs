using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaDatabaseLibrary
{
    public class OperaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ComposerModel Composer { get; set; }
        //TODO: Replace Dates w/ datetime
        public string Date { get; set; }
        public LanguageModel Language { get; set; }
        public LanguageModel SecondaryLanguage { get; set; }
        public string Librettist { get; set; }
        //TODO: Add Librettist to Composer List --> Extend Generic People Class?
        public string PremiereYear { get; set; }
        public LocationModel PremiereLocation { get; set; }
        public string ImslpLink { get; set; }
        public string SynopsisLink { get; set; }
        public string WikiLink { get; set; }
        public string LibrettoLink { get; set; }
        public string OperaBaseLink { get; set; }
        public string Keywords { get; set; }
        //TODO: Keyword as concatenated string
        public string Length { get; set; }
        //TODO: Change Length to Datetime

    }
}
