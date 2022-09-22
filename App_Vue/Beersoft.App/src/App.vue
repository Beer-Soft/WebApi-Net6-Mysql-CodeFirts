<script setup>
import { RouterLink, RouterView } from "vue-router";
import { useAuthStore } from "@/stores";

const authStore = useAuthStore();

//console.log(authStore);
</script>

<template>
  <div id="app">
    <router-view />
  </div>
</template>

<!-- <template>
  <div class="app-container bg-light">
    <nav
      v-show="authStore.user"
      class="navbar navbar-expand navbar-dark bg-dark"
    >
      <div class="navbar-nav">
        <RouterLink to="/" class="nav-item nav-link">Inicio</RouterLink>
        <a @click="authStore.logout()" class="nav-item nav-link">Salir</a>
      </div>
    </nav>
    <div class="container pt-4 pb-4">
      <RouterView />
    </div>
  </div>
</template> -->

<!-- <style>
@import "@/assets/base.css";
</style> -->
