using CursoMvc.Models.Enums;

namespace CursoMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusVendas Status { get; set; }
        public Funcionario Funcionario { get; set; }

        public RegistroVendas() { 
        
        }

        public RegistroVendas(int id, DateTime data, double quantia, StatusVendas status, Funcionario funcionario)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Funcionario = funcionario;
        }
    }
}
