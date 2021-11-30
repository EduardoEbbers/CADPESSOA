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
    public class EnderecoController : Controller<endereco>, IEnderecoController
    {
        [Inject]
        private IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public async Task<EnderecoDto> Insert(EnderecoDto EnderecoDto)
        {
            EnderecoDto _enderecoDto;
            try
            {
                _enderecoDto = Mapper
                    .Map<endereco, EnderecoDto>(await _enderecoService
                        .Insert(Mapper.Map<EnderecoDto, endereco>(EnderecoDto)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _enderecoDto;
        }

        public async Task<IEnumerable<EnderecoDto>> GetAll()
        {
            IEnumerable<EnderecoDto> _enderecoDtoAll;
            try
            {
                _enderecoDtoAll = Mapper
                    .Map<IEnumerable<endereco>, IEnumerable<EnderecoDto>>(await _enderecoService.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _enderecoDtoAll;
        }

        public async Task<EnderecoDto> GetById(int id)
        {
            EnderecoDto _enderecoDto;
            try
            {
                _enderecoDto = Mapper
                    .Map<endereco, EnderecoDto>(await _enderecoService.GetById(id));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _enderecoDto;
        }

        public async Task Update(EnderecoDto EnderecoDto)
        {
            try
            {
                await _enderecoService.Update(Mapper.Map<EnderecoDto, endereco>(EnderecoDto));
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
                await _enderecoService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}