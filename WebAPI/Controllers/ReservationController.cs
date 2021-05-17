using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        IReservationService _reservationService;
        //IRoomService _roomService;
        //IGuestService _guestService;
        //IPaymentService _paymentService;

        public ReservationController(
            IReservationService reservationService
            //, IRoomService roomService,
            //IGuestService guestService,
            //IPaymentService paymentService
            )
        {
            _reservationService = reservationService;
            //_roomService = roomService;
            //_guestService = guestService;
            //_paymentService = paymentService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _reservationService.GetAll();

            if (result.Success) return Ok(result);

            return BadRequest(result);

        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _reservationService.GetThreeIncludes(i=>i.Rooms,i=>i.Guests,i=>i.Payment.PaidFees,i => i.ReservationId == id);

            if (result.Success) return Ok(result);

            return BadRequest(result);            
        }

        [HttpPost("AddReservation")]
        public IActionResult Add(Reservation reservation)
        {
            var result = _reservationService.Add(reservation);

            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}
