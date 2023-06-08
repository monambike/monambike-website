//#region Elements

const langDropdown = document.getElementById("ul-dropdown-language").style;

//#endregion

//#region Functions

function openLanguageDropdown() {
    try{    
        langDropdown.display = (langDropdown.display === "none") ? "block" : "none";
    } catch {
        console.log("Ocorreu um erro desconhecido ao tentar abrir a guia de seleção de idiomas.")
     }
}

function changePageLanguageByLanguageDropdown(chosenLanguage) {
    try {
        window.parent.translateAllItemsOnThePage(chosenLanguage);
    } catch (exception) { 
        console.log("Ocorreu um erro desconhecido ao tentar selecionar o idioma na guia de seleção de idiomas.");
    }
}

//#endregion