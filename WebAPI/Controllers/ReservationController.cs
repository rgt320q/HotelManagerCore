using AutoMapper;
using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
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
        IMapper _mapper;
        //IRoomService _roomService;
        //IGuestService _guestService;
        //IPaymentService _paymentService;

        public ReservationController(
            IReservationService reservationService,
            IMapper mapper
            //, IRoomService roomService,
            //IGuestService guestService,
            //IPaymentService paymentService
            )
        {
            _reservationService = reservationService;
            _mapper = mapper;
            //_roomService = roomService;
            //_guestService = guestService;
            //_paymentService = paymentService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _reservationService.GetAll();

            var reservationMap = _mapper.Map<List<ReservationGetDto>>(result.Data);

            if (result.Success) return Ok(reservationMap);

            return BadRequest(result);

        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _reservationService.GetThreeIncludes(i=>i.Rooms,i=>i.Guests,i=>i.Payment.PaidFees,i => i.ReservationId == id);           

            if (result.Success) {

                var reservationMap = _mapper.Map<ReservationGetDto>(result.Data);
                return Ok(reservationMap);
            }            

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
