namespace BaCS.Application.Handlers.Resources.Queries;

using Abstractions.Persistence;
using Contracts.Dto;
using Contracts.Exceptions;
using Domain.Core.Entities;
using MapsterMapper;
using MediatR;

public static class GetResourceQuery
{
    public record Query(Guid ResourceId) : IRequest<ResourceDto>;

    internal class Handler(IBaCSDbContext dbContext, IMapper mapper)
        : IRequestHandler<Query, ResourceDto>
    {
        public async Task<ResourceDto> Handle(Query request, CancellationToken cancellationToken)
        {
            var resource = await dbContext.Resources.FindAsync([request.ResourceId], cancellationToken)
                           ?? throw new EntityNotFoundException<Resource>(request.ResourceId);

            return mapper.Map<ResourceDto>(resource);
        }
    }
}
