using AutoMapper;
using Commando.Dtos;
using Commando.Models;

namespace Commando.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //to map between a source object and a destination object
            //Source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command,CommandUpdateDto>();
        }
    }
}