namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state
{
    class DemoStateOrdinary : IState
    {
        public int CalculatePrice(int price)
        {
            return price;
        }

        public IState NextState(bool IsOffer)
        {
            return IsOffer ? new DemoStateOffer() : this;
        }
    }
}
