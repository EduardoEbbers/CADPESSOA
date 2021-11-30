using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCADPessoas.Models
{
    [Table("cadastropessoa.endereco")]
    public partial class endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public endereco()
        {
            pessoa = new HashSet<pessoa>();
        }

        [Key]
        public int id_endereco { get; set; }

        [Required]
        [StringLength(256)]
        public string logradouro { get; set; }

        [Required]
        [MaxLength(6)]
        public int numero { get; set; }

        [Required]
        [MaxLength(8)]
        public int cep { get; set; }

        [Required]
        [StringLength(50)]
        public string bairro { get; set; }

        [Required]
        [StringLength(30)]
        public string cidade { get; set; }

        [Required]
        [StringLength(20)]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pessoa> pessoa { get; set; }
    }
}
