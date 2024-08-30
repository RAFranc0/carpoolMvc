using System;

namespace carpoolmvc.Models
{
    public class Orçamento
    {
        public int Id { get; set;}
        public Double Abastecimento { get; set; } //usado para abastecimento do começo do mês (valores grandes)
        public Double Entrada { get; set; } //entrada de dinheiro de uma carona
        public Double Saida {get; set; } //saída de dinheiro de um dia (para casos de abastecimentos menores)
        public Double Ganhos { get; set; } //usado para somatória de ganhos
        public Double Gastos { get; set; } //usado para somatória de gastos

        public Double Orcamento(Double ganhosTotais, Double gastosTotais)
        {
            return ganhosTotais - gastosTotais;
        }    
    }
}