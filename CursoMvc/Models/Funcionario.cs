using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace CursoMvc.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double BaseSalarial { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> RegistroVendas = new List<RegistroVendas>();

        public Funcionario() { 
        
        }

        public Funcionario(int id, string nome, string email, DateTime nascimento, double baseSalarial, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas rv)
        {

            RegistroVendas.Add(rv);

        }

        public void RemoverVenda(RegistroVendas rv)
        {

            RegistroVendas.Remove(rv);

        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return RegistroVendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Quantia);  

        }
    }
}
