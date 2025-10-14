using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands
{
    public class RemoveeCastCommand : IRequest
    {
        public int CastId { get; set; }
        public RemoveeCastCommand(int castId)
        {
            CastId = castId;
        }

        
    }
}
