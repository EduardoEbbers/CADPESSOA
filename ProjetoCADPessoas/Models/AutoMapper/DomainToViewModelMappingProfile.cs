using AutoMapper;
using ProjetoCADPessoas.Models.Dtos;

namespace ProjetoCADPessoas.Models.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<PessoaDto, pessoa>();
            Mapper.CreateMap<EnderecoDto, endereco>();
            Mapper.CreateMap<PessoaTelefoneDto, pessoa_telefone>();
            Mapper.CreateMap<TelefoneDto, telefone>();
            Mapper.CreateMap<TelefoneTipoDto, telefone_tipo>();
        }
    }
}