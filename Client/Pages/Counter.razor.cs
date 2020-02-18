using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService Singleton { get; set; }
        [Inject] TransientService Transient { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        private async Task IncrementCount()
        {
            currentCount++;
            Singleton.Value = currentCount;
            Transient.Value = currentCount;

            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvokation");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}