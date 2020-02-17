using Microsoft.AspNetCore.Components;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService Singleton { get; set; }
        [Inject] TransientService Transient { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            Singleton.Value = currentCount;
            Transient.Value = currentCount;
        }
    }
}