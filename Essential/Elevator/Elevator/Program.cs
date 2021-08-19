using System.Threading;

namespace Elevator
{
    class Program
    {
        static void Main()
        {
            Elevator elevator = new Elevator();
            ElevatorController floorController = new ElevatorController(elevator);

            floorController.CallElevator(3);
            elevator. MoveElevator(5);
        }
    }

    public class Elevator
    {
        public int CurrentFloor { get; set; }

        public void MoveElevator(int floor)
        {
            if (floor > CurrentFloor)
            {
                Up(floor);
                return;
            }

            Down(floor);
        }

        private void Down(int floor)
        {
            for (int i = floor; i > CurrentFloor; i--)
            {
                CurrentFloor -= 1;
                Thread.Sleep(5000);
            }
        }

        private void Up(int floor)
        {
            for (int i = CurrentFloor; i < floor; i++)
            {
                CurrentFloor += 1;
                Thread.Sleep(5000);
            }
        }
    }

    public class ElevatorController
    {
        private Elevator _elevator;

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
}
