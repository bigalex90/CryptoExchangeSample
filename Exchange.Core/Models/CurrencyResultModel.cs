using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Core.Models
{
    public class CurrencyResultModel
    {
        public bool success { get; set; }
        public List<Currency> result { get; set; }
    }
}
