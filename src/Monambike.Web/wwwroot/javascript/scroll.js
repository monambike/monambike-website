/**************************************************************************
Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
Contact: contact@monambike.com for more information.
For license information, please see the LICENSE file in the root directory.
**************************************************************************/
// Source: https://codepen.io/datCloud/pen/BaKEEqq

// Registers scroll events for the window
window.registerScrollEvent = (dotNetObjRef) => {
    window.onscroll = () => {
        dotNetObjRef.invokeMethodAsync('OnScroll');
    };
};

/**
 * Checks and applies or undo a reveal effect to elements with reveal-animation on 
 * their class names.
 *
 * @param {string} propertyName - The property name to apply the reveal effect.
 */
function checkAndApplyRevealEffect() {
    // Select all elements with reveal-animation
    var revealClasses = document.querySelectorAll('[class*="reveal-animation"]');

    // Constantly checks all elements
    revealClasses.forEach((revealClass) => {
        // Gets the height of the viewport
        var windowHeight = window.innerHeight;

        // Gets the top position of the current element relative to the viewport (where the element should have its end position)
        var elementTop = revealClass.getBoundingClientRect().top;

        // Sets the number of pixels from the bottom of the viewport (where the element should start revealing)
        var elementVisible = 100;

        // Checks if the element is within the reveal range for revealing it
        if (elementTop > 0 && elementTop < windowHeight - elementVisible) {
            // Makes the element revealed
            revealClass.classList.add('revealed');
        } else {
            // Removes revealed from elemenet
            revealClass.classList.remove('revealed'); // Make the effect inactive
        }
    });
}

// Adds methods triggered on window scroll event
window.addEventListener("scroll", checkAndApplyRevealEffect)
