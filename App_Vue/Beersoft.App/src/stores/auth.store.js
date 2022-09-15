import { defineStore } from 'pinia';

import { fetchWrapper } from '@/helpers';
import {router } from '@/router'

const baseUrl = `${import.meta.env.VITE_API_URL}/api/usuarios`;

export const useAuthStore = defineStore({
    id: 'auth',
    state: () => ({
      
        user: JSON.parse(localStorage.getItem('user')),
        returnUrl: null
    }),
    actions: {
        async login(username, password) {
            const user = await fetchWrapper.post(`${baseUrl}/token`, { username, password });

           
            this.user = user;

            console.log(user);

            
            localStorage.setItem('user', JSON.stringify(user));

            // redirect to previous url or default to home page
            router.push(this.returnUrl || '/');
        },
        logout() {
            this.user = null;
            localStorage.removeItem('user');
            router.push('/login');
        }
    }
});
