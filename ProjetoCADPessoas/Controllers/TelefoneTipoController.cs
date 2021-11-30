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
    public class TelefoneTipoController : Controller<telefone_tipo>, ITelefoneTipoController
    {
        [Inject]
        private ITelefoneTipoService _telefoneTipoService;

        public TelefoneTipoController(ITelefoneTipoService telefoneTipoService) : base(telefoneTipoService)
        {
            _telefoneTipoService = telefoneTipoService;
        }

        public async Task<TelefoneTipoDto> Insert(TelefoneTipoDto TelefoneTipoDto)
        {
            TelefoneTipoDto _telefoneTipoDto;
            try
            {
                _telefoneTipoDto = Mapper
                    .Map<telefone_tipo, TelefoneTipoDto>(await _telefoneTipoService
                    .Insert(Mapper.Map<TelefoneTipoDto, telefone_tipo>(TelefoneTipoDto)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneTipoDto;
        }

        public async Task<IEnumerable<TelefoneTipoDto>> GetAll()
        {
            IEnumerable<TelefoneTipoDto> _telefoneTipoDtoAll;
            try
            {
                _telefoneTipoDtoAll = Mapper
                    .Map<IEnumerable<telefone_tipo>, IEnumerable<TelefoneTipoDto>>(await _telefoneTipoService.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneTipoDtoAll;
        }

        public async Task<TelefoneTipoDto> GetById(int id)
        {
            TelefoneTipoDto _telefoneTipoDto;
            try
            {
                _telefoneTipoDto = Mapper
                    .Map<telefone_tipo, TelefoneTipoDto>(await _telefoneTipoService.GetById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneTipoDto;
        }

        public async Task Update(TelefoneTipoDto TelefoneTipoDto)
        {
            try
            {
                await _telefoneTipoService.Update(Mapper.Map<TelefoneTipoDto, telefone_tipo>(TelefoneTipoDto));
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
                await _telefoneTipoService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}