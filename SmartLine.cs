using System;
using System.Collections.Generic;

namespace WaitingLineSystem
{
    public class SmartLine
    {
        private static SmartLine _instance;
        
        private SmartLine() 
        {

        }
        //Singleton Pattern
        public static SmartLine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SmartLine();
                }
                return _instance;
            }
        }

        // initialize an Empty Line  
        private List<int> Line = new List<int>();
        
        //Next Ticket Number
        private int NextPersonTicket = 2; 
        private int NextHandicappedTicket = 1; 

        // Add a person to the line with the next even ticket number
        public void AddPerson()
        {
            Line.Add(NextPersonTicket);
            NextPersonTicket += 2;
        }

        // Add a handicapped person to the line with the next odd ticket number
        public void AddHandicapped()
        {
            // give Piorty for handicapped
            Line.Insert(0, NextHandicappedTicket); 
            NextHandicappedTicket += 2;
        }

        // Next turn in list (Will return odd ticket number if any )
        public int NextTurn()
        {
            if (Line.Count == 0)
            {
                return 0; 
            }

            int nextPerson = Line[0];
            Line.RemoveAt(0); 
            return nextPerson;
        }
    }
}
