let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();

  const checks = document.querySelectorAll('li');

  checks.forEach((check) => {
    // when you click on a check mark it completed
    check.addEventListener('click', () => {
      if (!check.classList.contains('completed')) {
        check.classList.add('completed');
        check.querySelector('i').classList.add('completed');
      }
    });

    // when you double click a check remove the completed class
    check.addEventListener('dblclick', () => {
      if (check.classList.contains('completed')) {
        check.classList.remove('completed');
        check.querySelector('i').classList.remove('completed');
      }
    });
  });

  const toggleComplete = document.getElementById('toggleAll');

  toggleComplete.addEventListener('click', () => {
    if (allItemsIncomplete)
    {
      checks.forEach((check) => {
        if (!check.classList.contains('completed')) {
          check.classList.add('completed');
          check.querySelector('i').classList.add('completed');          
        }
      });
      //set button to say "mark all incomplete"
      toggleComplete.innerText = 'MARK ALL INCOMPLETE';
      allItemsIncomplete = false;
    }
    else{
      checks.forEach((check) => {
        if (check.classList.contains('completed')) {
          check.classList.remove('completed');
          check.querySelector('i').classList.remove('completed');
        }
      });
      //set button to say "mark all complete"
      toggleComplete.innerText = 'MARK ALL COMPLETE';
      allItemsIncomplete = true;
    }
  });  
});