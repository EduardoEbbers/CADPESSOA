using AutoMapper;
using Ninject;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers
{
    public class PessoaController : Controller<pessoa>, IPessoaController
    {
        [Inject]
        private IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public async Task<PessoaDto> Insert(PessoaDto PessoaDto)
        {
            PessoaDto _pessoaDto;
            try
            {
                _pessoaDto = Mapper
                    .Map<pessoa, PessoaDto>(await _pessoaService
                        .Insert(Mapper.Map<PessoaDto, pessoa>(PessoaDto)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaDto;
        }

        public async Task<IEnumerable<PessoaDto>> GetAll()
        {
            IEnumerable<PessoaDto> _pessoaDtoAll;
            try
            {
                _pessoaDtoAll = Mapper
                    .Map<IEnumerable<pessoa>, IEnumerable<PessoaDto>>(await _pessoaService.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaDtoAll;
        }

        public async Task<PessoaDto> GetById(int id)
        {
            PessoaDto _pessoaDto;
            try
            {
                _pessoaDto = Mapper
                    .Map<pessoa, PessoaDto>(await _pessoaService.GetById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaDto;
        }

        public async Task Update(PessoaDto PessoaDto)
        {
            try
            {
                await _pessoaService
                    .Update(Mapper.Map<PessoaDto, pessoa>(PessoaDto));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                await _pessoaService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}