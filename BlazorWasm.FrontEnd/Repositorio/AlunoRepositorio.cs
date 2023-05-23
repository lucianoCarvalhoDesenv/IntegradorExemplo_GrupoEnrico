using BlazorWasm.Compartilhado.Entidades;
using BlazorWasm.FrontEnd.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWasm.FrontEnd.Repositorio
{
    //api/aluno
    public class AlunoRepositorio : IRepository<Aluno>
    {
        private readonly IHttpService httpService;
        private string url = "api/aluno";

        public AlunoRepositorio(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Aluno>> Get()
        {
            var response = await httpService.Get<List<Aluno>>(url);

            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Aluno> Get(int Id)
        {
            var response = await httpService.Get<Aluno>($"{url}/{Id}");
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task Add(Aluno item)
        {

            var response = await httpService.Post(url, item);
            if (response.Sucesso == false)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<int> AddAndGetId(Aluno item)
        {
            var response = await httpService.Post<Aluno, int>(url, item);
            if (response.Sucesso == false)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task Update(Aluno item)
        {
            var response = await httpService.Put(url, item);
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task Delete(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
