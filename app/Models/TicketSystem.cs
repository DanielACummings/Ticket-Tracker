using System.Collections.Generic;

namespace tickets.Models
{
  class TicketSystem
  {
    List<Ticket> log { get; set; }

    public void PrintAll();
    public void ViewTicket(int index);
    public void NewTicket();
    public void CloseTicket();

    public TicketSystem()
    {
      log = new List<Ticket>();
    }
  }
}