using System;
using Calendar.Abstract;
using Calendar.Common;
namespace Calendar.Entities
{
    class ToDo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this to-do: { Title}");
        }
    }
}

