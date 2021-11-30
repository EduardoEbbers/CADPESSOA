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
    public class TelefoneController : Controller<telefone>, ITelefoneController
    {
        [Inject]
        private ITelefoneService _telefoneService;

        public TelefoneController(ITelefoneService telefoneService) : base(telefoneService)
        {
            _telefoneService = telefoneService;
        }

        public async Task<TelefoneDto> Insert(TelefoneDto TelefoneDto)
        {
            TelefoneDto _telefoneDto;
            try
            {
                _telefoneDto = Mapper
                    .Map<telefone, TelefoneDto>(await _telefoneService
                    .Insert(Mapper.Map<TelefoneDto, telefone>(TelefoneDto)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneDto;
        }

        public async Task<IEnumerable<TelefoneDto>> GetAll()
        {
            IEnumerable<TelefoneDto> _telefoneDtoAll;
            try
            {
                _telefoneDtoAll = Mapper
                    .Map<IEnumerable<telefone>, IEnumerable<TelefoneDto>>(await _telefoneService.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneDtoAll;
        }

        public async Task<TelefoneDto> GetById(int id)
        {
            TelefoneDto _telefoneDto;
            try
            {
                _telefoneDto = Mapper
                    .Map<telefone, TelefoneDto>(await _telefoneService.GetById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneDto;
        }

        public async Task Update(TelefoneDto TelefoneDto)
        {
            try
            {
                await _telefoneService
                    .Update(Mapper.Map<TelefoneDto, telefone>(TelefoneDto));
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
                await _telefoneService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}