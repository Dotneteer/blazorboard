(function () {
    const blazorBoardExtensions = "BlazorBoardExtensions";

    const extensionObject = {
        getFibonacci: async (count) => {
            var array = await DotNet.invokeMethodAsync(
                "Dotneteer.BlazorBoard.Client",
                "GetFiboAsync",
                count);
            return array.join(",");
        }
    };

    if (typeof window !== 'undefined' && !window[blazorBoardExtensions]) {
        window[blazorBoardExtensions] = {
            ...extensionObject
        };
    } else {
        window[blazorBoardExtensions] = {
            ...window[blazorBoardExtensions],
            ...extensionObject
        };
    }
})();