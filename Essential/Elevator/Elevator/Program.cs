using System.Threading;

namespace Elevator
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            
            person.CallElevator(5);
            person.MoveAtFloor(9);
        }
    }

    public class Person
    {
        private static readonly Elevator _elevator = new Elevator();

        private readonly ElevatorController _elevatorController = new ElevatorController(_elevator);
        readonly FloorController _floorController = new FloorController(_elevator);

        //Можно методы Call and Move вынести в интерфейс.
        public void CallElevator(int floor)
        {
            _elevatorController.CallElevator(floor);
        }

        public void MoveAtFloor(int floor)
        {
            _floorController.CallElevator(floor);
        }
    }

    public class Elevator
    {
        public int CurrentFloor { get; set; }
    }

    public class ElevatorController
    {
        private readonly Elevator _elevator;

        public ElevatorController(Elevator elevator)
        {
            _elevator = elevator;
        }

        public void CallElevator(int floor)
        {
            if (floor > _elevator.CurrentFloor)
            {
                Up(floor);
                return;
            }

            Down(floor);
        }

        private void Down(int floor)
        {
            for (int i = floor; i > _elevator.CurrentFloor; i--)
            {
                _elevator.CurrentFloor -= 1;
                Thread.Sleep(5000);
            }
        }

        private void Up(int floor)
        {
            for (int i = _elevator.CurrentFloor; i < floor; i++)
            {
                _elevator.CurrentFloor += 1;
                Thread.Sleep(5000);
            }
        }


    }

    public class FloorController
    {
        private readonly Elevator _elevator;

        public FloorController(Elevator elevator)
        {
            _elevator = elevator;
        }

        public void CallElevator(int floor)
        {
            if (floor > _elevator.CurrentFloor)
            {
                Up(floor);
                return;
            }

            Down(floor);
        }

        private void Down(int floor)
        {
            for (int i = floor; i > _elevator.CurrentFloor; i--)
            {
                _elevator.CurrentFloor -= 1;
                Thread.Sleep(5000);
            }
        }

        private void Up(int floor)
        {
            for (int i = _elevator.CurrentFloor; i < floor; i++)
            {
                _elevator.CurrentFloor += 1;
                Thread.Sleep(5000);
            }
        }
    }
}
