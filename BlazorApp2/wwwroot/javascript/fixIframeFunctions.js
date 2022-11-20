//#region Elements



//#endregion

//#region Functions

// Ajusta o tamanho do iframe para o tamanho correto, se baseando no tamanho
// do corpo do site
function fixIframeSize() {
    try {
      let iframes = document.getElementsByClassName("iframe-import-section");

      // Para cada elemento na página que precisa de tradução
      for(
        indexIframe = 0;
        indexIframe < iframes.length;
        indexIframe++) {
          iframes[indexIframe].style.height = iframes[indexIframe].contentWindow.document.body.scrollHeight + "px";
      }
    } catch { }
}

//#endregion

//#region Run

setInterval(fixIframeSize, 500);

//#endregion