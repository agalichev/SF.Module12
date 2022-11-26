namespace SF.Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {   new User("joker85", "Алексей", false),
                new User("Dasha90", "Дарья", true),
                new User("Crazy8", "Владимир", true),
                new User("Parovoz", "Павел", false),
                new User("Rider", "Алёна", false)
            };

            foreach (User user in users)
            {
                Greetings(user);
            }
            
            Console.ReadLine();
        }

        static void Greetings(User user)
        {
            if (user.IsPremium == false)
                ShowAds();
            Console.WriteLine($"{user.Name}, приветствую Вас!\n");
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}