using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch26_Practice_2___Razor_Forms.Models
{
 
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
        public string NumberOfAttendees { get; set; }

        public int Id { get; set; }
        //static variable, beginning of app run is equals to 1

        public Event()
        {

        }

        public Event (string name, string description, string contactEmail, string location, string numberOfAttendees)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Location = location;
            NumberOfAttendees = numberOfAttendees;

        }

        //right click, refactoring, generate overrides
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }









    }
}
