/**************************************************************************
Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
Contact: contact@monambike.com for more information.
For license information, please see the LICENSE file in the root directory.
**************************************************************************/
// Source: https://codepen.io/datCloud/pen/BaKEEqq

/**
 * CSS class name for the default rainstorm animation.
 * Used to identify elements to apply the default rainstorm animation.
 * @type {string}
 */
const rainstormAnimation = "rainstorm-animation";

/**
 * CSS class name for the hover-triggered rainstorm animation.
 * Used to identify elements to apply the rainstorm animation on hover.
 * @type {string}
 */
const rainstormAnimationHover = "rainstorm-animation-hover";

/**
 * Creates rainstorm animation elements and appends them to elements with the
 * specified class.
 * 
 * @param {string} className - The class name of elements to which the rainstorm animation will be applied.
 * @param {number} rainCount - The number of raindrops to create.
 */
function createRainstormAnimation(className, rainCount) {
    // Get all elements with the specified class name.
    var elements = document.getElementsByClassName(className);

    // Loop through each element with the specified class.
    for (let elementIndex = 0; elementIndex < elements.length; elementIndex++) {
        // Create raindrops for the current element.
        for (let rainIndex = 0; rainIndex < rainCount; rainIndex++) {
            // Create a new HR element for each raindrop.
            let hrElement = document.createElement("HR");

            // Apply thunder class to the last raindrop.
            if (rainIndex == rainCount - 1) {
                hrElement.className = "thunder";
            } else {
                // Set left position randomly within the window width.
                hrElement.style.left = Math.floor(Math.random() * window.innerWidth) + "px";
                // Set animation duration randomly between 0.2 and 0.5 seconds.
                hrElement.style.animationDuration = 0.2 + Math.random() * 0.3 + "s";
                // Set animation delay randomly between 0 and 5 seconds.
                hrElement.style.animationDelay = Math.random() * 5 + "s";
            }

            // Append the HR element to the current element.
            elements[elementIndex].appendChild(hrElement);
        }
    }
}

/**
 * Stops the rainstorm animation by removing all raindrop elements and the thunder effect with
 * the specified class.
 * 
 * @param {string} className - The class name of elements to which the rainstorm animation will be removed.
 */
function stopRainstormAnimation(className) {
    // Select all raindrop elements within elements with the class "rainstorm-animation".
    var rainstormElements = document.querySelectorAll(".rainstorm-animation-hover hr");

    // Remove each raindrop element.
    rainstormElements.forEach(function (element) {
        element.parentNode.removeChild(element);
    });
}

// Get all elements with the classes "rainstorm-animation" and "rainstorm-animation-hover".
var targetElements = document.querySelectorAll(`.${rainstormAnimation}, .${rainstormAnimationHover}`);

// Add event listeners to start and stop the rainstorm animation for each target element.
targetElements.forEach(function (element) {
    // Start the rainstorm animation when the mouse enters the element.
    element.addEventListener("mouseenter", function () {
        createRainstormAnimation(rainstormAnimationHover, 100);
    });

    // Stop the rainstorm animation when the mouse leaves the element.
    element.addEventListener("mouseleave", function () {
        stopRainstormAnimation(rainstormAnimationHover);
    });
});

// Start the rainstorm animation immediately for elements with the "rainstorm-animation" class.
createRainstormAnimation(rainstormAnimation, 100);
