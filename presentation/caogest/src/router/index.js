import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: () => import(/* webpackChunkName: "about" */ '../views/Home.vue')
  },
  {
    path: '/sobre/:id',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/About.vue')
  },
  {
    path: '/sobre/canil/:id',
    name: 'AboutKennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/AboutKennel.vue')
  },
  {
    path: '/sobre/admin',
    name: 'AboutAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/AboutAdmin.vue')
  },
  {
    path: '/faqs/:id',
    name: 'FAQs',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/FAQs.vue')
  },
  {
    path: '/faqs/canil/:id',
    name: 'FAQsKennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/FAQsKennel.vue')
  },
  {
    path: '/faqs/admin',
    name: 'FAQsAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/FAQsAdmin.vue')
  },
  {
    path: '/antesdeadotar/:id',
    name: 'Antes De Adotar',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/BeforeAdopting.vue')
  },
  {
    path: '/donativos/:id',
    name: 'Donativos',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Infos/Donations.vue')
  },
  {
    path: '/donativos/canil/:id',
    name: 'DonativosKennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/DonationsKennel.vue')
  },
  {
    path: '/donativos/admin',
    name: 'Donativosrealizados',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/DonationsAdmin.vue')
  },
  {
    path: '/pedidos/adocao/canil/:id',
    name: 'AdoptionRequest',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/AdoptionRequest.vue')
  },
  {
    path: '/pedido/adocao/admin',
    name: 'AdoptionRequestAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/AdoptionRequestAdmin.vue')
  },
  {
    path: '/horario/canil/:id',
    name: 'Schedule',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/ScheduleKennel.vue')
  },
  {
    path: '/horario/admin/canil/:id',
    name: 'HorarioCanil',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/HorarioCanil.vue')
  },
  {
    path: '/pagina/utilizador/:id',
    name: 'Main Page',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/HomeUser.vue')
  },
  {
    path: '/pagina/canil/:id',
    name: 'MainPageKennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/HomeKennel.vue')
  },
  {
    path: '/pagina/admin',
    name: 'Main Page Admin',
    component: () => import('../views/Admin/HomeAdmin.vue')
  },
  {
    path: '/registar/utilizador',
    name: 'User Register',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/RegistoUsers/UserRegister.vue')
  },
  {
    path: '/registar/canil',
    name: 'Kennel Register',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/RegistoUsers/CanilRegister.vue')
  },
  {
    path: '/registar/cao/:id',
    name: 'Dog Register',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/DogRegister.vue')
  },
  {
    path: '/formulario/adocao',
    name: 'Adoption Form',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/AdoptionForm.vue')
  },
  {
    path: '/caes/:id',
    name: 'Dogs',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Dogs.vue')
  },
  {
    path: '/caes/admin',
    name: 'DogsAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/DogsAdmin.vue')
  },
  {
    path: '/canis/:id',
    name: 'Kennels',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Kennels.vue')
  },
  {
    path: '/canis/admin',
    name: 'KennelsAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/KennelsAdmin.vue')
  },
  {
    path: '/canil/:id',
    name: 'Kennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Kennel.vue')
  },
  {
    path: '/canil/admin/:id',
    name: 'KennelAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/KennelAdmin.vue')
  },
  {
    path: '/preferencias/:id',
    name: 'Preferences',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Preferences.vue')
  },
  {
    path: '/preferencias/canil/:id',
    name: 'PreferencesKennel',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/PreferencesKennel.vue')
  },
  {
    path: '/preferencias/admin',
    name: 'PreferencesAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/Preferencias.vue')
  },
  {
    path: '/parcerias/canil/:id',
    name: 'Parcerias',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/Partnerships.vue')
  },
  {
    path: '/parcerias/admin/:id',
    name: 'Partnerships',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/Parcerias.vue')
  },
  {
    path: '/parcerias/utilizador/:id',
    name: 'Parceria',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Parcerias.vue')
  },
  {
    path: '/voluntarios/canil/:id',
    name: 'VoluntariosCanil',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/Volunteers.vue')
  },
  {
    path: '/voluntarios/admin',
    name: 'Voluntarios',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/Voluntarios.vue')
  },
  {
    path: '/regista/horario/:id',
    name: 'RegistaHorario',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/RegistaHorario.vue')
  },
  {
    path: '/informacoes/:id',
    name: 'Informacoes',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/Informations.vue')
  },
  {
    path: '/informacoes/admin/:id',
    name: 'Informations',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/Informacoes.vue')
  },
  {
    path: '/informacoes/utilizador/:id',
    name: 'Informações',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Informacoes.vue')
  },
  {
    path: '/pedido/registo/:id',
    name: 'PedidoRegisto',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/RequestKennel.vue')
  },
  {
    path: '/pedido/adocao/admin/:id',
    name: 'PedidoAdocaoAdmin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/PedidosAdocao.vue')
  },
  {
    path: '/pedido/adocao/:id',
    name: 'PedidoAdocao',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/PedidosAdocaoUser.vue')
  },
  {
    path: '/pedido/adocao/canil/:id',
    name: 'PedidoAdocaoCanil',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/PedidosAdocaoCanil.vue')
  },
  {
    path: '/entre/contacto',
    name: 'EntreEmContacto',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/EntreEmContacto.vue')
  },
  {
    path: '/entre/contacto/canil/:id',
    name: 'EntreEmContactoCanil',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Canil/EntreEmContacto.vue')
  },

  {
    path: '/entre/contacto/utilizador/:id',
    name: 'EntreEmContactoUtilizador',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/EntreEmContacto.vue')
  },
  {
    path: '/estatisticas',
    name: 'Estatisticas',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Admin/Estatisticas.vue')
  },
  {
    path: '/documentos/:id',
    name: 'Documentos',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Utilizador/Textos.vue')
  },
  {
    path: '/documentos/direitosanimais',
    name: 'DireitosAnimais',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Docs/DireitosUser.vue')
  },
  {
    path: '/documentos/esterilizar',
    name: 'PorquêEsterilizar',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Docs/Esterilizar.vue')
  },
  {
    path: '/documentos/motivos/adotar',
    name: 'MotivosAdotar',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Docs/Adotar.vue')
  },
  {
    path: '/documentos/treino',
    name: 'TreinarCao',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Docs/Treinar.vue')
  },
  {
    path: '/documentos/doencas',
    name: 'DoencasETratamentos',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/Docs/Doencas.vue')
  },


]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes, 
  scrollBehavior (to, from, savedPosition) {
    if (savedPosition) {
      return savedPosition
    } else {
      return { x: 0, y: 0 }
    }
  }
})

export default router
