(function () {
    const blazorBoardExtensions = "BlazorBoardExtensions";

    const extensionObject = {
        // --- Monaco editor interop methods
        editorInitialize: (editorModel) => {
            var element = document.getElementById(editorModel.id);
            var child = element.lastElementChild;
            while (child) {
                element.removeChild(child);
                child = element.lastElementChild;
            }
            monaco.editor.create(element, {
                value: editorModel.script,
                language: editorModel.language,
                fontSize: editorModel.fontSize,
                automaticLayout: true,
                readOnly: true,
                cursorStyle: "line",
                cursorWidth: 0
            });
        },

        setTheme: (themeName) => { monaco.editor.setTheme(themeName); },

        // --- Pointer interop methods
        setPointerCapture: (element, pointerId) => {
            if (element) {
                element.setPointerCapture(pointerId);
                return true;
            } else {
                return false;
            }
        },

        releasePointerCapture: function (element, pointerId) {
            if (element) {
                element.releasePointerCapture(pointerId);
                return true;
            } else {
                return false;
            }
        },

        // --- Element dimensions interop
        getElementDimensions: (element) => {
            return {
                width: element.offsetWidth,
                height: element.offsetHeight
            };
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