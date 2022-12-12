using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodgingSearchSystem {

    public class Rootobject {
        public Areaclasses areaClasses { get; set; }
    }

    public class Areaclasses {
        public Largeclass[] largeClasses { get; set; }
    }

    public class Largeclass {
        public Largeclass1[] largeClass { get; set; }
    }

    public class Largeclass1 {
        public string largeClassCode { get; set; }
        public string largeClassName { get; set; }
        public Middleclass[] middleClasses { get; set; }
    }

    public class Middleclass {
        public Middleclass1[] middleClass { get; set; }
    }

    public class Middleclass1 {
        public string middleClassCode { get; set; }
        public string middleClassName { get; set; }
        public Smallclass[] smallClasses { get; set; }
    }

    public class Smallclass {
        public Smallclass1[] smallClass { get; set; }
    }

    public class Smallclass1 {
        public string smallClassCode { get; set; }
        public string smallClassName { get; set; }
        public Detailclass[] detailClasses { get; set; }
    }

    public class Detailclass {
        public Detailclass1 detailClass { get; set; }
    }

    public class Detailclass1 {
        public string detailClassCode { get; set; }
        public string detailClassName { get; set; }
    }

}
