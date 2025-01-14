public class ReturnTransaction
{
    public int TransactionID { get; set; }
    public Member Member { get; set; }
    public Book Book { get; set; }
    public DateTime ReturnDate { get; set; }
    public double FineAmount { get; set; }
}
