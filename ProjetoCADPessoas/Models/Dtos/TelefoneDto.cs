namespace ProjetoCADPessoas.Models.Dtos
{
    public class TelefoneDto
    {
        public int id_telefone { get; set; }
        public long numero { get; set; }
        public int ddd { get; set; }
        public int id_telefone_tipo { get; set; }

        public int GetIdTelefone()
        {
            return this.id_telefone;
        }

        public void SetIdTelefone(int idTelefone)
        {
            this.id_telefone = idTelefone;
        }

        public long GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(long numero)
        {
            this.numero = numero;
        }

        public int GetDdd()
        {
            return this.ddd;
        }

        public void SetDdd(int ddd)
        {
            this.ddd = ddd;
        }

        public int GetIdTelefoneTipo()
        {
            return this.id_telefone_tipo;
        }

        public void SetIdTelefoneTipo(int idTelefoneTipo)
        {
            this.id_telefone_tipo = idTelefoneTipo;
        }
    }
}