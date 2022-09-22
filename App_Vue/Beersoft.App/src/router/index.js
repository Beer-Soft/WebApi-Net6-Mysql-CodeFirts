import { createRouter, createWebHistory } from 'vue-router'
import { useAuthStore } from '@/stores';
import{ HomeView, LoginView,Categoria } from '@/views';
import {Dashboard} from '@/components';


export const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/', redirect: { name: 'Home' } },
    { path: '/login', component: LoginView
    },
    {path:'/dashboard',component:Dashboard,children:[
       { path: '/', redirect: { name: 'Home' } },
       { path: 'HomeView', name: 'Home', component: HomeView },
        { path: 'Categoria', name: 'Categoria', component: Categoria }
    ]}
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
