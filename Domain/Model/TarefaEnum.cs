using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TarefaEnum
    {
        Aberta,
        Concluida,
        Excluida,
        Atrasada
    }
}
