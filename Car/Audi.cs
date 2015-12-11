namespace Car
{
    public class Audi : Car
    {
        public enum DriveArrangements
        {
            AllWheelDrive
        }

        public DriveArrangements DriveArrangement { get; private set; }

        protected Audi()
        {
            DriveArrangement = DriveArrangements.AllWheelDrive;
        }
    }
}
