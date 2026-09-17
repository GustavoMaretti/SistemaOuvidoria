using SistemaOuvidoria.Interfaces;

namespace SistemaOuvidoria.Models
{
    internal class Denuncia : Manifestacao, IPrioritizavel
    {
        public string Gravidade { get; set; }

        public Denuncia(Cidadao solicitante, string gravidade) : base(solicitante)
        {
            Gravidade = gravidade;
        }

        public override string DescreverTipo() => "Denúncia";

        public int CalcularPrioridade() => 0;
    }
}
