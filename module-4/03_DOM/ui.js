document.addEventListener("DOMContentLoaded", () => {


  if(typeof addToCart !== 'undefined') {
    let addToCardButtons = document.querySelectorAll('a#add-to-cart');
    addToCardButtons.forEach( (element) => {
      element.addEventListener('click', (event) => {
        event.stopPropagation();
        event.preventDefault();

        addToCart(event.currentTarget);
        updateTotal();
      });
    });
  }
});

/**
 * Get a template DOM object from the DOM and return a usable DOM object
 * from the main node within it. Assumes that there is only one main parent
 * node in the template.
 * 
 * @param {string} id the id of the template element
 * @returns {Object} a deep clone of the templated element
 */
function getElementFromTemplate(id) {
  let domNode = document.importNode(document.getElementById(id).content, true).firstElementChild;
  attachEventHandlers(domNode);

  return domNode;
}

/**
 * Add event listeners to the passed in row.
 * 
 * @param {HTMLElement} row the `<tr>` to add listeners to
 */
function attachEventHandlers(row) {
  let button = row.querySelector('button.update-quantity');
  button.parentNode.addEventListener('submit', (event) => {
    event.stopPropagation();
    event.preventDefault();

    updateQuantity(event.currentTarget);
    updateTotal();
  });

  row.querySelector('.move-up').addEventListener('click', (event) => {
    moveRowUp(event.currentTarget);
  });
  row.querySelector('.move-down').addEventListener('click', (event) => {
    moveRowDown(event.currentTarget);
  });
}