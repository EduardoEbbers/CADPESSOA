using AutoMapper;
using ProjetoCADPessoas.Models.Dtos;

namespace ProjetoCADPessoas.Models.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<pessoa, PessoaDto>();
            Mapper.CreateMap<endereco, EnderecoDto>();
            Mapper.CreateMap<pessoa_telefone, PessoaTelefoneDto>();
            Mapper.CreateMap<telefone, TelefoneDto>();
            Mapper.CreateMap<telefone_tipo, TelefoneTipoDto>();
        }
    }
}