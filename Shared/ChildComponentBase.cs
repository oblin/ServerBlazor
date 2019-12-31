using Microsoft.AspNetCore.Components;
using ServerBlazor.Services;

namespace ServerBlazor.Shared
{
    public class ChildComponentBase : ComponentBase
    {
        protected bool _darkThemeOn;
        protected string AlertTheme => _darkThemeOn ? "dark" : "light";

        [Inject]
        protected RandomService RandomService {get;set;}

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized ()
        {
            _darkThemeOn = true;
        }
    }
}