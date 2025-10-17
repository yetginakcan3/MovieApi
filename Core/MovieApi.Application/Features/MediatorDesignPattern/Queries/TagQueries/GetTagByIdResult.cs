using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdResult : IRequest<GetTagByIdResult>
    {
        public int TagId { get; set; }

        public GetTagByIdResult(int tagId)
        {
            TagId = tagId;
        }
    }
}
