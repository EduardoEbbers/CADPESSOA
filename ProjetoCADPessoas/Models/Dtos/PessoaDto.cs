namespace ProjetoCADPessoas.Models.Dtos
{
    public class PessoaDto
    {
        public int id_pessoa { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public int id_endereco { get; set; }

        public int GetIdPessoa()
        {
            return this.id_pessoa;
        }

        public void SetIdPessoa(int idPessoa)
        {
            this.id_pessoa = idPessoa;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public long GetCpf()
        {
            return this.cpf;
        }

        public void SetCpf(long cpf)
        {
            this.cpf = cpf;
        }

        public int GetIdEndereco()
        {
            return this.id_endereco;
        }

        public void SetIdEndereco(int idEndereco)
        {
            this.id_endereco = idEndereco;
        }
    }
}