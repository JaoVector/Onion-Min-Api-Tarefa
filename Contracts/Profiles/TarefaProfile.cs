using AutoMapper;
using Contracts.DTOS;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Profiles
{
    public class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<CreateTarefaDTO, Tarefa>();
            CreateMap<Tarefa, ReadTarefaDTO>()
                .ForMember(d => d.Status, opt => opt.MapFrom(src => src.Status.ToString()));
            CreateMap<ReadTarefaDTO, Tarefa>();
            CreateMap<Tarefa, UpdateTarefaDTO>();
            CreateMap<UpdateTarefaDTO, Tarefa>();
        }
    }
}
