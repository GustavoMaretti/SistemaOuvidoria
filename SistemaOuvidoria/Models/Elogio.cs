
namespace SistemaOuvidoria.Models
{
    internal class Elogio : Manifestacao
    {
        public Elogio(Cidadao solicitante) : base(solicitante)
        {
        }

        public override string DescreverTipo()
        {
            return "Elogio";
        }
    }
}
