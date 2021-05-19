using AutoMapper;
using Entity.Concrete;
using Entity.DTOs;
using System;

namespace WebAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Reservation, ReservationGetDto>()
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => Enum.GetName(typeof(StatusEnum), source.Status)))
                .ForMember(destination => destination.AccommodationType, operation => operation.MapFrom(source => Enum.GetName(typeof(AccommodationTypeEnum), source.AccommodationType)))
                .ForMember(destination => destination.BoardType, operation => operation.MapFrom(source => Enum.GetName(typeof(BoardTypeEnum), source.BoardType)));
           
            CreateMap<Guest, GuestDto>()
                .ForMember(destination => destination.Gender, operation => operation.MapFrom(source => Enum.GetName(typeof(GenderEnum), source.Gender)))
                .ForMember(destination => destination.MartialStatus, operation => operation.MapFrom(source => Enum.GetName(typeof(MartialStatusEnum), source.MartialStatus)));
            
            CreateMap<PaidFee, PaidFeeDto>()
                .ForMember(destination => destination.PaymentType, operation => operation.MapFrom(source => Enum.GetName(typeof(PaymentTypeEnum), source.PaymentType)));

            CreateMap<Payment, PaymentDto>();
            CreateMap<Room, RoomDto>();

        }

        public enum AccommodationTypeEnum
        {
            Room,
            Person
        }

        public enum BoardTypeEnum
        {
            BB,
            HB,
            FB,
            AI
        }

        public enum StatusEnum
        {
            Reservation,
            CheckIn,
            CheckOut,
            Canceled
        }

        public enum GenderEnum
        {
            Female,
            Male
        }

        public enum MartialStatusEnum
        {
            Single,
            Married,
            Divorced,
            Widowed
        }

        public enum PaymentTypeEnum
        {
            Cash,
            CreditCard,
            Other
        }
    }
}
