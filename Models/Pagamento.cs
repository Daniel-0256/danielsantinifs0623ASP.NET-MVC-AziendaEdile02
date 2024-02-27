namespace AziendaEdile02.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime PeriodoPagamento { get; set; }
        public decimal Ammontare { get; set; }
        public bool Stipendio { get; set; }
    }
}
