using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Parking
{
    class Solve
    {
        public void Resolve()
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ');
                int parkingNumber = Convert.ToInt32(input[0]);
                int carNumber = Convert.ToInt32(input[1]);

                List<Car> allCars = new List<Car>();

                List<Parking> allParking = new List<Parking>();
                List<Parking> originalOrderParking = new List<Parking>();


                for (int i = 0; i < parkingNumber; i++)
                {
                    string[] inputp = Console.ReadLine().Split(' ');
                    Parking temp = new Parking(inputp[0], Convert.ToInt32(inputp[1]), Convert.ToDouble(inputp[2]));
                    allParking.Add(temp);
                }

                for (int i = 0; i < allParking.Count; i++)
                {
                    originalOrderParking.Add(allParking[i]);
                }

                for (int i = 0; i < carNumber; i++)
                {
                    string[] inputc = Console.ReadLine().Split(' ');
                    Car temp = new Car(inputc[0], Convert.ToDouble(inputc[1]));
                    allCars.Add(temp);
                }

                for (int i = 0; i < parkingNumber; i++)
                {
                    for (int j = i + 1; j < parkingNumber; j++)
                    {
                        if (allParking[i].MaxHeight > allParking[j].MaxHeight)
                        {
                            Parking temp = allParking[i];
                            allParking[i] = allParking[j];
                            allParking[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < parkingNumber; i++)
                {
                    for (int j = 0; j < carNumber; j++)
                    {
                        if (allCars[j].Height <= allParking[i].MaxHeight && allParking[i].FreePlaces > 0 && allCars[j].Parked == "no")
                        {
                            allCars[j].Parked = allParking[i].Name;
                            allParking[i].FreePlaces--;
                        }
                    }
                }

                foreach (var item in allCars)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in originalOrderParking)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
