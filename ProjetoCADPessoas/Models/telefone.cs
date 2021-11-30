using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCADPessoas.Models
{
    [Table("cadastropessoa.telefone")]
    public partial class telefone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public telefone()
        {
            pessoa_telefone = new HashSet<pessoa_telefone>();
        }

        [Key]
        public int id_telefone { get; set; }

        [Required]
        [MaxLength(12)]
        public long numero { get; set; }

        [Required]
        [MaxLength(3)]
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

        public virtual telefone_tipo telefone_tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pessoa_telefone> pessoa_telefone { get; set; }
    }
}
