namespace DecoratorPattern.Observables
{
    public class Health : IObservable
    {
        int mValue;
        public int Value
        {
            set => mValue = value;
            get => mValue;
        }

        public Health(int value)
        {
            Value = value;
        }

        public void Decrease(int value)
        {
            Value -= value;
            NotifyAll(value);
        }
    }
}
