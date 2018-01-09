using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    class PassangersList : IMaintanable<Passenger>
    {
        List<Passenger> PassengerList = new List<Passenger> { };

        public void Create(Passenger obj)
        {
            PassengerList.Add(obj);
            
        }

        public void Delete(int key)
        {
            PassengerList.RemoveAt(key);
        }

        public Passenger Get(int key)
        {
            Passenger Pass = PassengerList[key];
            return Pass;
        }

        public void Update(Passenger obj)
        {
            Passenger updatePassenger = null;
            foreach (Passenger Pass in PassengerList)
            {
                if (Pass.Passport == obj.Passport)
                {
                    updatePassenger = Pass;
                }        
            }

            if (updatePassenger != null)
            {
                PassengerList.Remove(updatePassenger);
                PassengerList.Add(obj);

            }
            else
            {
                Console.WriteLine("Passenger with passport Id {0} doesn't exist", obj.Passport);
            }
        }
    }
}
