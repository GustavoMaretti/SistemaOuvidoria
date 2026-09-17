using SistemaOuvidoria.Enums;
using System;


namespace SistemaOuvidoria.Models
{
    abstract class Manifestacao
    {
        public string Protocolo { get; set; }
        public DateTime DataAbertura { get; set; }
        public StatusChamado Status { get; set; }
        public Cidadao Solicitante { get; set; }

        protected Manifestacao(Cidadao solicitante)
        {
            if (solicitante == null)
            {
                throw new ArgumentNullException(nameof(solicitante));
            }
            
            Solicitante = solicitante;
            Protocolo = GerarProtocolo();
            DataAbertura = DateTime.Now;
            Status = StatusChamado.Aberto;
        }
        
        public abstract string DescreverTipo();

        public string GerarProtocolo()
        {
            return $"OUV-{DateTime.Now:yyyyMMddHHmmssfff}";
        }
        

    }
}
