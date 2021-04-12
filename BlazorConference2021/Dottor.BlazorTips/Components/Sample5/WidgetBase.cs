namespace Dottor.BlazorTips.Components
{
    using Microsoft.AspNetCore.Components;
    using System;

    public class WidgetBase<TValue> : ComponentBase
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public TValue Value { get; set; }

        protected string GetImagePath()
        {
            return Value switch
            {
                long or int or short => "/images/numbers.png",
                DateTime or DateTimeOffset => "/images/calendar.png",
                string or char => "/images/letters.png",
                _ => "/images/question_mark.png",
            };
        }

    }
}
