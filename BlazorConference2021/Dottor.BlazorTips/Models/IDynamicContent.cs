namespace Dottor.BlazorTips.Models
{
    using System;

    public interface IDynamicContent
    {
        Type ComponentType { get; }
    }
}
