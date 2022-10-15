//#region Elements

var translationArchiveJsonContent = JSON.parse(translationArchiveJson)
var availableLanguages = Object.keys(translationArchiveJsonContent);

//#endregion

//#region Functions

function onPageLoadTranslate(){
    try {       
        // Pega o idioma do navegador do usuário
        var browserLanguage = navigator.language || navigator.userLanguage;
        
        // Se o usuário já escolheu um idioma alguma vez, utiliza o idioma escolhido
        if (localStorage !== null) language = localStorage.getItem("language");
        // Se o navegador está em um idioma que está disponível para realizar tradução
        // utiliza ele
        else if (availableLanguages.includes(browserLanguage)) language = browserLanguage;
        
        translateAllItemsOnThePage("ja-JP");
    } catch (exception) {
        console.log("Ocorreu um erro desconhecido ao realizar a tradução ao carregar a página pela primeira vez." + exception.stack)
    }
}

function translateAllItemsOnThePage(languageToTranslate) {
    try {
        // Se o idioma requisitado para tradução não existir, traduz a página para o
        // inglês
        if (!(availableLanguages.includes(languageToTranslate))) {
            alert(
                "Não foi possível realizar a tradução do site para '" + languageToTranslate + "', " +
                "traduzindo o site para inglês."
            );

            languageToTranslate = "en-US";
        }

        localStorage.setItem("language", languageToTranslate);

        var elementsToTranslate = document.getElementsByClassName("translate");
    
        // Para cada elemento na página que precisa de tradução
        for(counterCurrentElementToTranslate = 0; counterCurrentElementToTranslate < elementsToTranslate.length; counterCurrentElementToTranslate++) {
            // Realiza a tradução
            elementsToTranslate[counterCurrentElementToTranslate].innerHTML = translationArchiveJsonContent[languageToTranslate][elementsToTranslate[counterCurrentElementToTranslate].getAttribute("langSrc")];
        }

        return;
    } catch (exception) {
        alert("Ocorreu um erro desconhecido ao tentar realizar a tradução da página.");
    }
}

//#endregion