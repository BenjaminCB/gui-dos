using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gui_dos.Areas.Identity
{
    public class TokenProvider
    {
        public string XsrfToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
