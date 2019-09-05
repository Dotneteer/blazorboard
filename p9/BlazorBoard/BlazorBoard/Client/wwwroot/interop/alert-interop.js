(function () {
    const blazorBoardExtensions = "BlazorBoardExtensions";

    const extensionObject = {
        alert: (message) => {
            alert(message);
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