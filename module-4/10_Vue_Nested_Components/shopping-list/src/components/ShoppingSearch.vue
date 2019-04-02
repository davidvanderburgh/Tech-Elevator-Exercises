<template>
  <div class="search">
    <input
      type="text"
      id="search"
      name="search"
      v-on:keyup="filterItems"
      placeholder="Search Items..."
    >
  </div>
</template>

<script>
export default {
  methods: {
    filterItems() {
      const query = document.getElementById("search").value;
      this.$emit("filter-items", query);
    }
  }
};
</script>

<style>
#search {
  width: 100%;
  font-size: 24px;
  font-family: "Roboto Condensed", sans-serif;
  padding: 10px;
}
</style>