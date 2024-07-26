using System;
using System.Collections.Generic;

namespace WaitingLineSystem
{
    public class SmartLine
    {
        // List to maintain the line
        private List<int> line = new List<int>();
        private int nextPersonTicket = 2; // Next ticket number for regular person
        private int nextHandicappedTicket = 1; // Next ticket number for handicapped person

        // Add a person to the line with the next available even ticket number
        public void AddPerson()
        {
            line.Add(nextPersonTicket);
            nextPersonTicket += 2;
        }

        // Add a handicapped person to the line with the next available odd ticket number
        public void AddHandicapped()
        {
            line.Insert(0, nextHandicappedTicket); // Handicapped person goes to the front of the line
            nextHandicappedTicket += 2;
        }

        // Return the ticket number of the next person in line without removing them
        public int NextTurn()
        {
            if (line.Count == 0)
            {
                return -1; // Indicating no one is in line
            }

            int nextPerson = line[0];
            line.RemoveAt(0); // Remove the first person in line
            return nextPerson;
        }
    }
}
