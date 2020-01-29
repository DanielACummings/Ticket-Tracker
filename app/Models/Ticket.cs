using System;

namespace tickets.Models
{
  class Ticket
  {
    public string Title { get; private set; }
    private string Description { get; set; }

    public void PrintDescription()
    {
      Console.WriteLine($"{Title} - {Description}");
    }

    public Ticket(string title, string desc)
    {
      Description = desc;
    }
  }
}