using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class ValidacaoDeCampos
    {
        public bool CampoVazio(string campo)
        {
            return campo == string.Empty;
        }
    }
}
