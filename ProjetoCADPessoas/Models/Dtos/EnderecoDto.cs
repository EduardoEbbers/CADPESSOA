namespace ProjetoCADPessoas.Models.Dtos
{
    public class EnderecoDto
    {
        public int id_endereco { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public int GetIdEndereco()
        {
            return this.id_endereco;
        }

        public void SetIdEndereco(int idEndereco)
        {
            this.id_endereco = idEndereco;
        }

        public string GetLogradouro()
        {
            return this.logradouro;
        }

        public void SetLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetCep()
        {
            return this.cep;
        }

        public void SetCep(int cep)
        {
            this.cep = cep;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string GetEstado()
        {
            return this.estado;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }
    }
}