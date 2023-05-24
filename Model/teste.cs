using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Clinica.Model
{

    public class json
    {
        public string type { get; set; }

        public Attachments attachments { get; set; }
    }

    public class Attachments
    {
        public string contentType { get; set; }

        public string contentUrl { get; set; }

        public Content content { get; set; }
    }

    public class Content
    {

        public string schema { get; set; }

        public string type { get; set; }


        public string version { get; set; }

        public Body body { get; set; }

    }

    public class Body
    {

        public string type { get; set; }

        public string text { get; set; }


    }

}
