using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luxury_Watches.Areas.Admin.Models
{
    public enum ErrorType
    {
        FailedLogin
    }
    public class Error
    {
        public ErrorType Type { get; set; }
        public string Msg { get; set; }
    }
}