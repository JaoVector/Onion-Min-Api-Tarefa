using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Tarefa
    {
        [Key]
        public int IdTarefa { get; set; }
        [Required]
        [StringLength(225)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(550)]
        public string? Descricao { get; set; }
        [Required]
        public TarefaEnum Status { get; set; } = TarefaEnum.Aberta;
    }
}
