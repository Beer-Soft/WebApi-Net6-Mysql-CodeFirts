using API.Dtos;
using AutoMapper;
using BeerSoft.API.Dtos;
using BeerSoft.API.Helpers;
using BeerSoft.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BeerSoft.API.Controllers
{
    [Authorize]
    public class MenusController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenusController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MenuDto>>> Get()
        {

            ////var user = base.HttpContext.User;
            // var identity = HttpContext.User.Identity as ClaimsIdentity;
            var user = new UserClaim(HttpContext).UserID;

            var menus = await _unitOfWork.Menus
                                   .GetAllAsync();

            return _mapper.Map<List<MenuDto>>(menus);
        }
    }
}
