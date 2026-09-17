using SistemaOuvidoria.Interfaces;

namespace SistemaOuvidoria.Models
{
    internal class Reclamacao : Manifestacao, IPrioritizavel
    {
        public bool Reincidente { get; set; }

        public Reclamacao(Cidadao solicitante, bool reincidente) : base(solicitante)
        {
            Reincidente = reincidente;
        }
        public override string DescreverTipo() => "Reclamação";

        public int CalcularPrioridade() => 0;
        
    }
}
