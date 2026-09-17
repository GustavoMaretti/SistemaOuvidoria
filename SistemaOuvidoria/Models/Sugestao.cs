
namespace SistemaOuvidoria.Models
{
    internal class Sugestao : Manifestacao
    {
        public Sugestao(Cidadao solicitante) : base(solicitante)
        {
        }

        public override string DescreverTipo()
        {
            return "Sugestão";
        }
    }
}
