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
            switch (Value)
            {
                case long:
                case int:
                case short:
                    return "/images/numbers.png";
                case DateTime:
                    return "/images/calendar.png";
                case string:
                    return "/images/letters.png";
                default:
                    return "/images/question_mark.png";
            }
        }

    }
}
