using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOS
{
    public class ReadTarefaDTO
    {
        public int IdTarefa { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? DataAbertura { get; set; }
        public string? DataFechamento { get; set; }
        public string? Status { get; set; }
    }
}
