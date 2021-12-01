using System;

namespace ProjetoFinalAnalise.Models
{
    public class salesRecord
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public saleStatus status { get; set; }
        public seller seller { get; set; }
    }
}