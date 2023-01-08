using System;
using System.Collections.Generic;

namespace ModelCartera
{
    public class googledrivefile
    {
        //Atributos de clase
        public int Id { get; set; }
        public string IdGoogle { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public long? Version { get; set; }
        public DateTime? CreatedTime { get; set; }
        public IList<string> Parents { get; set; }
        public string WebContentLink { get; set; }
        public string MimeType { get; set; }
        public string WebViewLink { get; set; }
        public string Modulo { get; set; }
        public string IdModulo { get; set; }
    }
}
