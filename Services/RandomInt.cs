using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ServerBlazor.Services
{
    public class RandomInt
    {
        [JSInvokable]
        public static Task<int> Generate (int maxValue)
        {
            return Task.FromResult (new Random ().Next (maxValue));
        }
    }
}