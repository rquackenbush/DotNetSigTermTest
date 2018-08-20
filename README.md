# .NET Core SIGTERM Test

While watching [this video](https://dockercon2018.hubs.vidyard.com/watch/AKygsfpxSNuixBEXk5tLjD) from dockercon sf 18, I learned that handling SIGTERM correctly is important in container applications.

This [stackoverflow answer](https://stackoverflow.com/a/47474693/232566) had some good information. 

This repo tests the above approach in a trivial .NET Core container application. The key is to handle the `AppDomain.CurrentDomain.ProcessExit` event.