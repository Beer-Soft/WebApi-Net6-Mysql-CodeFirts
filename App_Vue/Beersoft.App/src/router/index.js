import { createRouter, createWebHistory } from 'vue-router'
import { useAuthStore } from '@/stores';
import{ HomeView, LoginView } from '@/views';

export const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/', component: HomeView },
    { path: '/login', component: LoginView
    }
  ]
});

router.beforeEach(async (to) => {
  //console.log(to)
const publicPages = ['/login'];
const authRequired = !publicPages.includes(to.path);
 const auth = useAuthStore();

    if (authRequired && !auth.user) {
        auth.returnUrl = to.fullPath;
        return '/login';
    }

});


 export default router
