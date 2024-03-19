namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state
{
    interface IState
    {
        IState NextState(bool IsOffer);

        int CalculatePrice(int price);
    }
}
