using System.Collections.Generic;

public class LibraryEvent
{
    public int EventID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public List<Member> Participants { get; set; }

    public LibraryEvent()
    {
        Participants = new List<Member>();
    }
}
