(function () {
    const blazorBoardExtensions = "BlazorBoardExtensions";

    const blazorEditors = [];

    const extensionObject = {
        hello: () => { console.log("Hello"); },

        editorInitialize: (editorModel) => {
            console.log(`Registering new editor ${editorModel.id}...`);
            let thisEditor = monaco.editor.create(document.getElementById(editorModel.id), {
                value: editorModel.script,
                language: editorModel.language,
                automaticLayout: true
            });

            if (blazorEditors.find(e => e.id === editorModel.id)) {
                console.error(`Refused to register duplicate editor ${editorModel.id}`);
            }
            else {
                console.debug(`Registered new editor ${editorModel.id}`);
                blazorEditors.push({ id: editorModel.id, editor: thisEditor });
            }
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