using System;
using tickets.Models;

namespace tickets
{
  class Program
  {
    static void Main(string[] args)
    {
      TicketsController tC = new TicketsController();
      tC.Run();
    }
  }
}
