using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicEdil.Models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public DateTime Data { get; set; }
        public double Importo { get; set; }
        public bool IsStipendio { get; set; }
        public int IdDipendente { get; set; }
        public string IconToUse()
        {
            string icon = "";
            if (IsStipendio)
            {
                icon = "bi bi-check-lg text-success";

            }
            else
            {
                icon = "bi bi-x-lg text-danger";
            }
            return icon;
        }
        public Pagamento() { }
        public Pagamento(int idPagamento, DateTime data, double importo, bool isStipendio, int idDipendente)
        {
            IdPagamento = idPagamento;
            Data = data;
            Importo = importo;
            IsStipendio = isStipendio;
            IdDipendente = idDipendente;
        }
    }
}