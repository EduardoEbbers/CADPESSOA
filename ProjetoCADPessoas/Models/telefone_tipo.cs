using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCADPessoas.Models
{
    [Table("cadastropessoa.telefone_tipo")]
    public partial class telefone_tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public telefone_tipo()
        {
            telefone = new HashSet<telefone>();
        }

        [Key]
        public int id_telefone_tipo { get; set; }

        [Required]
        [StringLength(10)]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<telefone> telefone { get; set; }
    }
}
