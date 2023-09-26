using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicEdil.Models
{
    public class Dipendente
    {
        public int IdDipendente { get; set; }
        public string Nome { get; set; } 
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Cdf { get; set; }
        public string Mansione { get; set; }
        public bool IsSposato { get; set; }
        public int Nfigli { get; set; }
        public string IconToUse()
        {
            string icon = "";
            if (IsSposato)
            {
                icon = "bi bi-check-lg text-success";

            }
            else
            {
                icon = "bi bi-x-lg text-danger";
            }
            return icon;
        }
        public Dipendente() { }
        public Dipendente(int idDipendente, string nome, string cognome, string indirizzo, string cdf, string mansione, bool isSposato, int nfigli)
        {
            IdDipendente = idDipendente;
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Cdf = cdf;
            Mansione = mansione;
            IsSposato = isSposato;
            Nfigli = nfigli;
        }
    }
}