namespace Dottor.BlazorTips.Models
{

    public class WidgetModel<T>
    {

        public string Title { get; set; }

        public T Value { get; set; }
    }
}
