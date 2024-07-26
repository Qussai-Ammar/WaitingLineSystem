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

        // initialize an Empty Line and zero WaitingTimes
        private List<int> Line = new List<int>();
        
        //private List<double> WaitingTimes = new List<double>(); 


        //Next Ticket Number
        private int NextPersonTicket = 2; 
        private int NextHandicappedTicket = 1; 
        private static int Turn = 0;

        private int TicketNumber;


        // Add a person to the line with the next even ticket number
        public void AddPerson()
        {
            Line.Add(NextPersonTicket);
            NextPersonTicket += 2;
            TicketNumber = Line.Last();
        }

        // Add a handicapped person to the line with the next odd ticket number
        public void AddHandicapped()
        {
            // give Piorty for handicapped
            Line.Insert(0, NextHandicappedTicket); 
            NextHandicappedTicket += 2;
            TicketNumber = Line[0];
        }

        // Next turn in list (Will return odd ticket number if any )
        public int NextTurn()
        {
            if (Line.Count == 0)
            {
                return 0; 
            }
            
            int nextPerson = Line[0];
            Turn = Line[0];
            Line.RemoveAt(0); 
            return nextPerson;
        }

       /* public void AddWaitingTime(double Time)
        {
            WaitingTimes.Add(Time);
        }

        public double AverageWaitingTime()
        {
            if (WaitingTimes.Count == 0)
            {
                return 0;
            }
            return WaitingTimes.Average();
        }*/

        public int GetTurn() 
        {
            return Turn;
        }

        public int Total() 
        {
            return Line.Count;
        }

        public void ResetLine() 
        {
            Line.Clear();
        }

        public int GetTicketNumber() 
        {
            return TicketNumber;
        }
        
    }
}
