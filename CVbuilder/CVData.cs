using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVbuilder
{
    public class CVData
    {
        public GeneralInfo GeneralInfo { get; set; }
        public Education Education { get; set; }
        public Skills Skills { get; set; }
        public Work Work { get; set; }

        public CVData()
        {
            GeneralInfo = new GeneralInfo();
            Education = new Education();
            Skills = new Skills();
            Work = new Work();
        }
    }
}
