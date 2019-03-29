<template>
  <div class="item-list">
    <h1>My Shopping List</h1>
    <ul>
      <li
        v-for="item in items"
        v-bind:key="item"
        v-bind:class="{ completed : item.completed }"
      >{{item.name}}</li>
    </ul>
  </div>
</template>

<script>
export default {
  data() {
    return {
      items: [
        { name: "Strawberries", completed: false },
        { name: "Lunch Meat", completed: false },
        { name: "Bread", completed: true },
        { name: "Grapes", completed: true },
        { name: "Steak", completed: true },
        { name: "Salad", completed: false },
        { name: "Oatmeal", completed: false },
        { name: "Milk", completed: false },
        { name: "Banana", completed: false },
        { name: "Strawberries", completed: false }
      ]
    };
  }
};
</script>

<style>
.item-list {
  width: 450px;
  background: #fff;
  margin: 50px auto;
  font-family: "Roboto Condensed", sans-serif;
  border-radius: 10px;
}
h1 {
  background: #f2f2f2;
  color: #4b86a6;
  padding: 10px;
  font-size: 24px;
  text-transform: uppercase;
  text-align: center;
  margin-bottom: 0px;
  border-top-left-radius: 10px;
  border-top-right-radius: 10px;
}
ul {
  list-style-type: none;
  margin: 0px;
  padding: 0px;
}
li {
  font-size: 24px;
  border-bottom: 1px solid #f2f2f2;
  padding: 10px 20px;
}
li:nth-child(odd) {
  /* background-color: rgb(129, 182, 129); */
}
li:last-child {
  border: 0px;
}
li.completed {
  text-decoration: line-through;
  color: darkgray;
}
i.far.fa-check-circle {
  float: right;
  color: darkgray;
}

i.far.fa-check-circle.completed {
  color: green;
}
</style>
