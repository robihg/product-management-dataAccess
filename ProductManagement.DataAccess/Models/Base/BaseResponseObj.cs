using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Models.Base
{
    public class BaseResponseObj
    {
        public string ResponseTime { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
    }
}
