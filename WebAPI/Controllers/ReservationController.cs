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

        public ReservationController(
            IReservationService reservationService,
            IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _reservationService.GetAll(i => i.Active);

            var reservationMap = _mapper.Map<List<ReservationGetDto>>(result.Data);

            if (result.Success) return Ok(reservationMap);

            return BadRequest(result);

        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _reservationService.GetThreeIncludes(i => i.Rooms, i => i.Guests, i => i.Payment.PaidFees, i => i.Active && i.ReservationId == id);

            if (result.Success)
            {

                var reservationMap = _mapper.Map<ReservationGetDto>(result.Data);
                return Ok(reservationMap);
            }

            return BadRequest(result);
        }

        [HttpPost("")]
        public IActionResult Add(Reservation reservation)
        {
            var result = _reservationService.Add(reservation);

            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("Update")]
        public IActionResult Update(Reservation reservation)
        {
            var result = _reservationService.Update(reservation);

            if (result.Success) return Ok(result);

            return BadRequest(result);            
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(Reservation reservation)
        {
            var result = _reservationService.Delete(reservation);

            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("HardDelete")]
        public IActionResult HardDelete(Reservation reservation)
        {
            var result = _reservationService.HardDelete(reservation);

            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

    }
}
