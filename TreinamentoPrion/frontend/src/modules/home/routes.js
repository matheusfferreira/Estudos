export const routes = [
  {
    path: '/home',
    component: () => import(/* webpackChunkName: "home" */ './Home'),
    name: 'home',
  },
  {
    path: '/lista-pessoas',
    component: () => import(/* webpackChunkName: "home" */ './ListaPessoas'),
    name: 'lista.pessoas',
  },
  {
    path: '/insert',
    component: () => import(/* webpackChunkName: "home" */ './Insert'),
    name: 'insert',
  },
];

export default routes;
