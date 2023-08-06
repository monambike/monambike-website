// Handle the scroll event
window.registerScrollEvent = (dotNetObjRef) => {
    window.onscroll = () => {
        dotNetObjRef.invokeMethodAsync('OnScroll');
    };
};

/**
 * Checks and applies or undo a reveal effect to elements starting with "reveal__" on
 * their class names.
 * E.g.: Bypass "translate" if desired to check animation for .reveal__translate,
 * and activate animation with active
 *
 * @param {string} propertyName - The property name to apply the reveal effect.
 */
function checkAndApplyRevealEffect() {
    // Select all elements with the specified property name "reveal__{any suffix}"
    var revealClasses = document.querySelectorAll('[class*="reveal__"],[class*=" page"]');

    // Constantly checks all elements
    revealClasses.forEach((revealClass) => {
        // Get the height of the viewport
        var windowHeight = window.innerHeight;
        // Get the top position of the current element relative to the viewport
        var elementTop = revealClass.getBoundingClientRect().top;
        // The number of pixels from the bottom of the viewport where the element should start revealing
        var elementVisible = 100;

        // Check if the element is within the reveal range
        if (elementTop > 0 && elementTop < windowHeight - elementVisible) {
            revealClass.classList.add(`active`); // // Make the effect active
        } else {
            revealClass.classList.remove(`active`); // Make the effect inactive
        }
    });
}

// When scrolling it checks all elements for applying scroll reveal effects
window.addEventListener("scroll", checkAndApplyRevealEffect)
