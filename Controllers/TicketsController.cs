using System;
using tickets.Models;

namespace tickets
{
  class TicketsController
  {
    private bool _running = true;
    public void Run()
    {
      TicketSystem.PrintOptions();
      while (_running)
      {
        PrintMessages();
        GetUserInput();
      }
      Console.Clear();
      Console.WriteLine("Goodbye");
    }

    private void GetUserInput()
    {

    }
  }
}