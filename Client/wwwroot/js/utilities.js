function my_function(message) {
    console.log("from utilities: " + message);
}

function dotnetStaticInvokation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => console.log("count from javascript: " + result));
}