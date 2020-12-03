import baseAPI from '@/http';

const router = 'API/pessoa';

export const pessoaAPI = {
  get: (id) => baseAPI.get(`${router}/${id}`),
  list: () => baseAPI.get(router),
  create: (pessoa) => baseAPI.post(router, pessoa),
  update: (pessoa) => baseAPI.put(router, pessoa),
  delete: (id) => baseAPI.delete(`${router}/${id}`),
};

export default pessoaAPI;
