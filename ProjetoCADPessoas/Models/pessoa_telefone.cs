using System.ComponentModel.DataAnnotations;

namespace ProjetoCADPessoas.Models
{
    public partial class pessoa_telefone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pessoa_telefone()
        {
        }

        [Key]
        public int id_pessoa { get; set; }

        public int id_telefone { get; set; }

        public int GetIdPessoa()
        {
            return this.id_pessoa;
        }

        public void SetIdPessoa(int idPessoa)
        {
            this.id_pessoa = idPessoa;
        }

        public int GetIdTelefone()
        {
            return this.id_telefone;
        }

        public void SetIdTelefone(int idTelefone)
        {
            this.id_telefone = idTelefone;
        }
    }
}