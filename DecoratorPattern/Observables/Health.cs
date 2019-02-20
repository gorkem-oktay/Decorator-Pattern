namespace DecoratorPattern.Observables
{
    public class Health : IObservable
    {
        public int Value { get; set; }

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
