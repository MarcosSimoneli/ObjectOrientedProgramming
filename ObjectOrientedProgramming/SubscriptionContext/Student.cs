using ObjectOrientedProgramming.SharedContext;

namespace ObjectOrientedProgramming.SubscriptionContext
{
    internal class Student : Base
    {
        public User? User { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
