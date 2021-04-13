namespace Dottor.BlazorTips.Models
{
    using System;
    using Dottor.BlazorTips.Attributes;
    using Dottor.BlazorTips.Components.Sample2;

    public class CardModel : IDynamicContent
    {

        public Type ComponentType { get; set; } = typeof(BootstrapCard);

        [Map]
        public string Title { get; set; }
        [Map]
        public string Text { get; set; }

    }
}
