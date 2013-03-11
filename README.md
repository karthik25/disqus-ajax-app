# Disqus Ajax Tutorial

This is just a demo project to show how Disqus could be integrated in an ASP.Net MVC 3 site.
It contains 2 approaches. In the first approach disqus is loaded without the use of any additional 
ajax and in the second approach comment threads are loaded asynchronously by using ajax.

## Getting Started

To get started with this project, download the source code and extract it to a folder. Then open the
web.config file and in the appSettings section you will find the following key.

```xml
<add key="DisqusShortName" value=""/>
```

Go to the disqus site at https://disqus.com/admin/signup/ and register for a shortname. Enter the value
in the appSettings section and that's it! You are ready to go!!!
