using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCADPessoas.Models
{
    [Table("cadastropessoa.pessoa")]
    public partial class pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pessoa()
        {
            pessoa_telefone = new HashSet<pessoa_telefone>();
        }

        [Key]
        public int id_pessoa { get; set; }

        [Required]
        [StringLength(256)]
        public string nome { get; set; }

        [Required]
        [MaxLength(11)]
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

        public virtual endereco endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pessoa_telefone> pessoa_telefone { get; set; }
    }
}
