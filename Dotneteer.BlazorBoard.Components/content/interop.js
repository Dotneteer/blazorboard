(function () {
    const blazorBoardExtensions = "BlazorBoardExtensions";

    const blazorEditors = [];

    const extensionObject = {
        // --- Monaco editor interop methods
        editorInitialize: (editorModel) => {
            console.log(`Registering new editor ${editorModel.id}...`);
            let thisEditor = monaco.editor.create(document.getElementById(editorModel.id), {
                value: editorModel.script,
                language: editorModel.language,
                automaticLayout: true,
                readOnly: true,
                cursorStyle: "line",
                cursorWidth: 0
            });

            if (blazorEditors.find(e => e.id === editorModel.id)) {
                console.error(`Refused to register duplicate editor ${editorModel.id}`);
            }
            else {
                console.debug(`Registered new editor ${editorModel.id}`);
                blazorEditors.push({ id: editorModel.id, editor: thisEditor });
            }
        },

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