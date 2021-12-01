using System;

namespace ProjetoFinalAnalise.Models
{
    public class seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Double BaseSalary { get; set; }
        public department department { get; set; }

    }
}