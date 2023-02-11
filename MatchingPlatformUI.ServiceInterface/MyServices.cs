using System;
using ServiceStack;
using MatchingPlatformUI.ServiceModel;

namespace MatchingPlatformUI.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
