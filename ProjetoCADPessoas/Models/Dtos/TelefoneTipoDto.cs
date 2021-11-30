namespace ProjetoCADPessoas.Models.Dtos
{
    public class TelefoneTipoDto
    {
        public int id_telefone_tipo { get; set; }
        public string tipo { get; set; }

    public int GetIdTelefoneTipo()
        {
            return this.id_telefone_tipo;
        }

        public void SetIdTelefoneTipo(int idTelefoneTipo)
        {
            this.id_telefone_tipo = idTelefoneTipo;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
}