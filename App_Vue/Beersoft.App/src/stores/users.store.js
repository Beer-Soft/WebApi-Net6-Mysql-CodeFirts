import { defineStore } from "pinia";
// import {fetchWrapper} from '@/helpers';

export const useUsersStore = defineStore({
    id: 'users',
    state: () => ({
        users: {}
    }),
    actions: {
        async getAll() {
            this.users = { loading: true };
            // fetchWrapper.get(baseUrl)
            //     .then(users => this.users = users)
            //     .catch(error => this.users = { error })
        }
    }
});
