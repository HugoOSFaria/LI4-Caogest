using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace trial2.Results
{
    public class RecieveFoto
    {
        public string path { get; set; }
        public int cao_idCao { get; set; }
        public IFormCollection file { get; set; }
    }
}
