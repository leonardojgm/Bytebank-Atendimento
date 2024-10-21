namespace bytebank.Modelos.ADMs.Utilitario
{
    public class AutenticacaoUtil
    {
        public bool ValidarSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira.Equals(senhaTentativa);
        }
    }
}