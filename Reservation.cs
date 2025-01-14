public class Reservation
{
    public int ReservationID { get; set; }
    public Member Member { get; set; }
    public Book Book { get; set; }
    public DateTime ReservationDate { get; set; }
}
