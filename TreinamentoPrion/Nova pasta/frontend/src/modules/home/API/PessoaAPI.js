import baseAPI from '@/http'

const router = 'API/pessoa'

export const pessoaAPI = {
    get: (id) => baseAPI.get(`${router}/${id}`),
    list: (id) => baseAPI.get(router),
    create: (id) => baseAPI.post(router, pessoa),
    update: (id) => baseAPI.put(router, pessoa),
    delete: (id) => baseAPI.delete(`${router}/${id}`),
