namespace Dottor.BlazorTips.Models
{
    using System;
    using Dottor.BlazorTips.Components.Sample2;

    public class CardModel
    {

        public Type ComponentType { get; set; } = typeof(BootstrapCard);
        public string Title { get; set; }
        public string Text { get; set; }

    }
}
