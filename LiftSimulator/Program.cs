using System.Runtime.CompilerServices;

namespace LiftSimulator
{
    class Lift
    {
       
        public int CurrentFloor { get; set; }
        public int destinationFloor { get; set; }
        public int TotalRiders { get; set; }
        public int NumberOfFloors { get; set; }
        public bool ElevatorUp { get; set; }
        public bool ElevatorDown { get; set; }
        public int RiderLimit {
            get
            {
                return 10;
            }
        }

        public List<int> floors { get; set; }


        public Lift()
        {
            floors = new List<int>();
            CurrentFloor = 0;
        }

        public void LiftCall(int calledFloor)
        {
            if(this.CurrentFloor <  calledFloor)
            {
                for(int floor = this.CurrentFloor; floor <= calledFloor; floor++)
                {
                    Console.WriteLine($"Floor:{floor}");
                }

                Console.WriteLine("Lift Arrived!");
            }
            else if(this.CurrentFloor > calledFloor)
            {
                for (int floor = this.CurrentFloor; floor >= calledFloor; floor--)
                {
                    Console.Write($"Floor:{floor}");
                }

                Console.WriteLine("Lift Arrived!");
            }
            else
            {
                Console.WriteLine("Lift Arrived!");
            }
        }
        public void LoadingRiders()
        {
            Console.WriteLine("Loading the riders....");
            if(this.TotalRiders > this.RiderLimit)
            {
                Console.WriteLine("Lift Overloaded");
            }
            Console.WriteLine("Enter the Destination Floors:");
            string destinationFloor = Console.ReadLine();

            floors.AddRange(destinationFloor.Split(' ').Select(floor => Convert.ToInt32(floor)).ToList());
           
        }

        public void UnloadingRiders()
        {
            Console.WriteLine("Unloading the riders.......");
        }

        public async Task  GoUp()
        {
            floors.Sort();
            List<int> downFloors = floors.Where(floor => floor < this.CurrentFloor).ToList();
        
            floors.RemoveAll(floor => floor < this.CurrentFloor); 
           
            for(int floor= this.CurrentFloor;floor <=10;floor++)
            {
                Console.WriteLine($"Floor:{floor}");
                if(floors.Contains(floor))
                {
                    Console.WriteLine("Destination arrived .. Doors Opened");
                    floors.Remove(floor);
                }
                this.CurrentFloor = floor;
                if (floors.Count == 0)
                    break;
            }

            if(downFloors.Count > 0)
            {
                this.ElevatorUp = false;
                this.ElevatorDown = true;

                for (int floor = this.CurrentFloor; floor >= 0; floor--)
                {
                    this.CurrentFloor = floor;
                    Console.WriteLine($"Floor:{floor}");
                    if (downFloors.Contains(floor))
                    {
                        Console.WriteLine("Destination arrived .. Doors Opened");
                    }


                }
            }
        }

        public async Task GoDown()
        {
            floors.Sort();
            List<int> upFloors = floors.Where(floor => floor > this.CurrentFloor).ToList();
            floors.RemoveAll(floor => floor > this.CurrentFloor);
            floors.Reverse();

            for (int floor = this.CurrentFloor; floor >= 0; floor--)
            {
                this.CurrentFloor = floor;
                Console.WriteLine($"Floor:{floor}");
                if (floors.Contains(floor))
                {
                    Console.WriteLine("Destination arrived .. Doors Opened");
                    floors.Remove(floor);
                }
                if (floors.Count == 0  )
                    break; 
                
            }

           if(upFloors.Count > 0)
            {
                this.ElevatorUp = true;
                this.ElevatorDown = false;

                for (int floor = this.CurrentFloor; floor <= upFloors[upFloors.Count - 1]; floor++)
                {
                    Console.WriteLine($"Floor:{floor}");
                    if (upFloors.Contains(floor))
                    {
                        Console.WriteLine("Destination arrived .. Doors Opened");
                    }
                    this.CurrentFloor = floor;
                }
            }
        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            await system();
        }

        static  async Task  system()
        {
            Lift lift = new Lift();
            Console.WriteLine("Enter the floor to call the Lift: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            do
            {
               
                
                lift.LiftCall(floor);
                lift.CurrentFloor = floor;
                Console.WriteLine("Enter The Direction, UP(1), Down(0): ");
                int direction = Convert.ToInt32(Console.ReadLine());
                lift.ElevatorUp = direction == 1 ? true : false;
                lift.ElevatorDown = direction==0 ? true : false;
                lift.LoadingRiders();
               if (lift.ElevatorUp)
                {
                     await lift.GoUp();
                }
                if (lift.ElevatorDown)
                {
                     await lift.GoDown();
                }


                Console.WriteLine("Enter the floor to call the Lift: ");
                floor = Convert.ToInt32(Console.ReadLine());
            } while (true);
        }
    }
}
