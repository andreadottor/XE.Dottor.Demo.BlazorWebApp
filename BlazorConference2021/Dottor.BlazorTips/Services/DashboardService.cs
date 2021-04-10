namespace Dottor.BlazorTips.Services
{
    using Dottor.BlazorTips.Components.Sample2;
    using Dottor.BlazorTips.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DashboardService
    {


        public IEnumerable<CardModel> GetCards()
        {
            // https://quotes-react.netlify.app/
            List<CardModel> list = new();


            list.Add(new CardModel
            {
                Title = "Thomas Edison",
                Text = "Genius is one percent inspiration and ninety-nine percent perspiration.",
                ComponentType = typeof(BootstrapDarkCard)
            });

            list.Add(new CardModel
            {
                Title = "Abraham Lincoln",
                Text = "A house divided against itself cannot stand."
            });

            list.Add(new CardModel
            {
                Title = "Lao Tzu",
                Text = "Be the chief but never the lord.",
            });

            list.Add(new CardModel
            {
                Title = "Aristotle",
                Text = "Well begun is half done.",
                ComponentType = typeof(BootstrapAccentCard)
            });

            list.Add(new CardModel
            {
                Title = "Buddha",
                Text = "Peace comes from within. Do not seek it without."
            });

            list.Add(new CardModel
            {
                Title = "Albert Einstein",
                Text = "Learn from yesterday, live for today, hope for tomorrow.",
                ComponentType = typeof(BootstrapDarkCard)
            });

            return list;
        }

    }
}
