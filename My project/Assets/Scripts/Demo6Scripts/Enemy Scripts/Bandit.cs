namespace AD1020
{

    public class Bandit : Enemy
    {
        private void Start()
        {
            SetStatistics("Bandit Thug", 20, 2, 5, 200);
            PrintGreeting();
        }
    }
}
