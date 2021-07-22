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
