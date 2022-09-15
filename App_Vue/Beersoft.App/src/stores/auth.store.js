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
            // console.log(user.estaAutenticado);
             this.user = user;
            localStorage.setItem('user', JSON.stringify(user));
            //rederije a la pagina anterior o default de la pagina de inicio
            router.push(this.returnUrl || '/');
            //}
        },
        logout() {
            this.user = null;
            localStorage.removeItem('user');
            router.push('/login');
        }
    }
});
