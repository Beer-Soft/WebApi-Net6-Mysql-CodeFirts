<script setup>
import { Form, Field } from "vee-validate";
import { useAuthStore } from "@/stores";

import * as Yup from "yup";

const schema = Yup.object().shape({
  username: Yup.string().required("Ingrese el usuario"),
  password: Yup.string().required("Ingrese el usuario"),
});

function onSubmit(values, { setErrors }) {
  const authStore = useAuthStore();
  const { username, password } = values;

  // console.log(Mensaje);
  // const response = authStore
  //   .login(username, password)
  //   .catch((error) => setErrors({ apiError: error }));

  return authStore
    .login(username, password)
    .catch((error) => setErrors({ apiError: error }));
}
</script>

<template>
  <div
    class="flex min-h-full items-center justify-center py-12 px-4 sm:px-6 lg:px-8"
  >
    <Form
      @submit="onSubmit"
      :validation-schema="schema"
      v-slot="{ errors, isSubmitting }"
      class="bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4"
    >
      <div class="mb-4">
        <label class="block text-gray-700 text-sm font-bold mb-2"
          >Username</label
        >
        <Field
          name="username"
          type="text"
          class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight"
          :class="{ 'border-red-500': errors.username }"
        />
        <div class="text-red-500 text-xs italic">{{ errors.username }}</div>
      </div>
      <div class="mb-4">
        <label class="block text-gray-700 text-sm font-bold mb-2"
          >Password</label
        >
        <Field
          name="password"
          type="password"
          class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight"
          :class="{ 'border-red-500': errors.password }"
        />
        <div class="text-red-500 text-xs italic">{{ errors.password }}</div>
      </div>
      <div class="flex items-center justify-between mb-2">
        <button
          class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded"
          :disabled="isSubmitting"
        >
          <span
            v-show="isSubmitting"
            class="spinner-border spinner-border-sm mr-1"
          ></span>
          Login
        </button>
      </div>
      <div
        v-if="errors.apiError"
        class="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative"
        role="alert"
      >
        <span class="block sm:inline"> {{ errors.apiError }}</span>
      </div>
    </Form>
  </div>
</template>
