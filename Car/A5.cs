namespace Car
{
    public class A5 : Audi
    {
        private int _trimLevel;
        
        public A5(int trimLevel)
        {
            this._trimLevel = trimLevel;
            HasJumperCables = false;
            FuelLevel = 15;
        }
    }
}
