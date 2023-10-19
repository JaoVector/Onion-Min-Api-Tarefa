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
            CreateMap<CreateTarefaDTO, Tarefa>().ForMember(d => d.DataFechamento, opt => opt.MapFrom(src => DateTime.Parse(src.DataFechamento)));
            CreateMap<Tarefa, ReadTarefaDTO>()
                .ForMember(x => x.DataAbertura, opt => opt.MapFrom(src => ((DateTime)src.DataAbertura).ToString("dd/MM/yyyy")))
                .ForMember(x => x.DataFechamento, opt => opt.MapFrom(src => ((DateTime)src.DataFechamento).ToString("dd/MM/yyyy")))
                .ForMember(d => d.Status, opt => opt.MapFrom(src => src.Status.ToString()));
            CreateMap<ReadTarefaDTO, Tarefa>();
            CreateMap<Tarefa, UpdateTarefaDTO>();
            CreateMap<UpdateTarefaDTO, Tarefa>();
        }
    }
}
