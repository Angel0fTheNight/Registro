using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    class ValidacaoDeCampos
    {
        public bool CampoVazio(string campo)
        {
            if(campo == string.Empty)
            {
                return true;
            }
            return false;

        }

    }
}
