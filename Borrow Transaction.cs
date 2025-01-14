public class BorrowTransaction
{
    public int TransactionID { get; set; }
    public Member Member { get; set; }
    public Book Book { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
}
