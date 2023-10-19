using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOS
{
    public class CreateTarefaDTO
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
