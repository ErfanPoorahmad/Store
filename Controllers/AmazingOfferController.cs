using Digisegal.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazingOfferController : BaseApiController
    {
        public AmazingOfferController(IUnitOfWork unitOfWork)
                 : base(unitOfWork)
        {
        }
        [HttpGet]
        [Route("GetAmazingOffer")]
        public IActionResult GetAmazingOffer(int AmazingOfferId)
        {
            var Offers = UnitOfWork.ProductRepository.entity().Where(n => n.AmazingofferId == AmazingOfferId);
            var Test = "jhdjh";
            return Ok(Offers);
        }
    }
}
