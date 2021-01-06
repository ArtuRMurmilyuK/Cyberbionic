using System;

namespace TrainInfo
{
     public struct Train
     {
         private string _destination;
         private int _number;
         private DateTime _time;

         public Train(string destination, int number, DateTime time)
         {
             _destination = destination;
             _number = number;
             _time = time;
         }

         public string Destination
        {
             get { return _destination; }
         }

         public int Number
         {
             get { return _number; }
         }

         public DateTime Time
         {
             get { return _time; }
         }
     }
}
