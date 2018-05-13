using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaDatabaseLibrary
{
    public class AriaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperaModel Opera { get; set; }
        public ComposerModel Composer { get; set; }
        public VoiceTypeModel Voice { get; set; }
        public VoiceTypeModel SecondVoice { get; set; }
        public string Character { get; set; }
        public string Fach { get; set; }
        public string SecondFach { get; set; }
        public LanguageModel Language { get; set; }
        public LanguageModel SecondLanguage { get; set; }
        public string PdfLink { get; set; }
        public string Keywords { get; set; }
        public string Length { get; set; }
        public RangeModel LowerRange { get; set; }
        public RangeModel UpperRange { get; set; }

    }
}
