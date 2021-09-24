using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS.WebApplication.Models
{
    public class OperationsCalculatorModel
    {
        public decimal Parameter1 { get; set; }
        public decimal Parameter2 { get; set; }
        public string Operator { get; set; }
        public string Result { get; set; }
    }
}