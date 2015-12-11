using System;

namespace Car
{
    public class Car
    {
        public int BatteryLevel { get; protected set; }
        public int FuelLevel { get; protected set; }
        public bool HasJumperCables { get; protected set; }
        public bool IsStarted { get; private set; }

        protected Car()
        {
            BatteryLevel = 0;
            FunWithRecursion(0);
        }

        public void Start()
        {
            try
            {
                CheckFuelLevel();
                CheckBatteryLevel();
                IsStarted = true;
            }
            catch (BatteryDeadException)
            {
                JumpCar("one", "two", "three", "four", "five");
                IsStarted = true;
            }
            finally
            {
                Console.WriteLine("Car.Start() completed!");
            }
        }

        private void JumpCar(string s1, string s2, string s3, string s4, string s5)
        {
            Console.WriteLine(s1, s2, s3, s4, s5);
            FindJumperCables();
        }

        private void FindJumperCables()
        {
            if (!HasJumperCables)
            {
                throw new JumperCablesNotFoundException();
            }
        }

        private void CheckBatteryLevel()
        {
            if (BatteryLevel < 1)
            {
                throw new BatteryDeadException();
            }
        }

        private void CheckFuelLevel()
        {
            if (FuelLevel < 1)
            {
                throw new NoFuelException();
            }
        }

        private void FunWithRecursion(int recursionLevel)
        {
            if (recursionLevel < 20)
            {
                FunWithRecursion(recursionLevel+1);
            }
        }
    }
}
