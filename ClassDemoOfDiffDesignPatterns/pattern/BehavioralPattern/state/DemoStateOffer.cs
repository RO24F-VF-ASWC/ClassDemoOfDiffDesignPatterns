namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state
{
    class DemoStateOffer : IState
    {
        public int CalculatePrice(int price)
        {
            return (int)(price * 0.80);
        }

        public IState NextState(bool IsOffer)
        {
            return IsOffer ? this : new DemoStateOrdinary();
        }
    }
}
