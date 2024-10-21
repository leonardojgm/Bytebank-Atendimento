using bytebank.Modelos.ADM.SistemaInterno;
using bytebank.Modelos.ADMs.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil Autenticador { get; set; }
      
        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenhas(this.Senha, senha);
        }
    }
}
