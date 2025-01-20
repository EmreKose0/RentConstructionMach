using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.AppUserQueries;
using RentConstructionMach.Application.Features.Mediator.Results.AppUserResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepository<AppUser> _appUserRepo;
        private readonly IRepository<AppRole> _appRoleRepo;

        public GetCheckAppUserQueryHandler(IRepository<AppRole> appRoleRepo, IRepository<AppUser> appUserRepo)
        {
            _appRoleRepo = appRoleRepo;
            _appUserRepo = appUserRepo;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _appUserRepo.GetByFilterAsync(x => x.UserName == request.Username && x.Password == request.Password);
            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.IsExist = true;
                values.Username = request.Username;
                values.Role = (await _appRoleRepo.GetByFilterAsync(y => y.AppRoleID == user.AppRoleID)).AppRoleName;
                values.Id = user.AppUserID;
            }
            return values;
        }
    }
}
