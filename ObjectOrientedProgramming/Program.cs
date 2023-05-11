using ObjectOrientedProgramming.ContentContext;
using ObjectOrientedProgramming.SubscriptionContext;

namespace ObjectOrientedProgramming
{
    static class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP","orientacao-objetos"));
            articles.Add(new Article("Artigo sobre c#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}


            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var coursecSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(coursecSharp);
            courses.Add(courseAspNet);


            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", coursecSharp);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPal = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPal);

        }

    }
}