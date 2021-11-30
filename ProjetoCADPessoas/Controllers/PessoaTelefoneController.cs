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
    public class PessoaTelefoneController : Controller<pessoa_telefone>, IPessoaTelefoneController
    {
        [Inject]
        private IPessoaTelefoneService _pessoaTelefoneService;

        public PessoaTelefoneController(IPessoaTelefoneService pessoaTelefoneService) : base(pessoaTelefoneService)
        {
            _pessoaTelefoneService = pessoaTelefoneService;
        }

        public async Task<PessoaTelefoneDto> Insert(PessoaTelefoneDto PessoaTelefoneDto)
        {
            PessoaTelefoneDto _pessoaTelefoneDto;
            try
            {
                _pessoaTelefoneDto = Mapper
                    .Map<pessoa_telefone, PessoaTelefoneDto>(await _pessoaTelefoneService
                        .Insert(Mapper.Map<PessoaTelefoneDto, pessoa_telefone>(PessoaTelefoneDto)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaTelefoneDto;
        }

        public async Task<IEnumerable<PessoaTelefoneDto>> GetAll()
        {
            IEnumerable<PessoaTelefoneDto> _pessoaTelefoneDtoAll;
            try
            {
                _pessoaTelefoneDtoAll = Mapper
                    .Map<IEnumerable<pessoa_telefone>, IEnumerable<PessoaTelefoneDto>>(await _pessoaTelefoneService.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaTelefoneDtoAll;
        }

        public async Task<PessoaTelefoneDto> GetById(int id)
        {
            PessoaTelefoneDto _pessoaTelefoneDto;
            try
            {
                _pessoaTelefoneDto = Mapper
                    .Map<pessoa_telefone, PessoaTelefoneDto>(await _pessoaTelefoneService.GetById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaTelefoneDto;
        }

        public async Task Update(PessoaTelefoneDto PessoaTelefoneDto)
        {
            try
            {
                await _pessoaTelefoneService
                    .Update(Mapper.Map<PessoaTelefoneDto, pessoa_telefone>(PessoaTelefoneDto));
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
                await _pessoaTelefoneService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}