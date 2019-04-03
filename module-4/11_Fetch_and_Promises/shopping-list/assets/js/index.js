let items = [];

function loadItems() {
    console.log("Load items...");

    fetch('assets/data/shopping-list.json')
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            items = data;
            displayItems();
        })
        .catch((err) => console.error(err));
}

function displayItems() {
    console.log("Display items...");

    //If any list items are already in the list, do not do the rest of the function
    const listItem = document.querySelector("li");
    if (listItem != null) {
        console.log("Not loading again... list already loaded!")
        return;
    }

    if ('content' in document.createElement('template')) {
        const list = document.querySelector("ul");

        items.forEach((item) => {
            const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);
            tmpl.querySelector("li").insertAdjacentHTML('afterbegin', item.name);
            if (item.completed) {
                const check = tmpl.querySelector('i');
                check.className += " completed";
            }
            list.appendChild(tmpl);
        });
    } else {
        console.error('Your browser does not support templates');
    }
}

const button = document.querySelector(".loadingButton");
button.addEventListener("click", function () {
    loadItems();
    button.disabled = true;
});