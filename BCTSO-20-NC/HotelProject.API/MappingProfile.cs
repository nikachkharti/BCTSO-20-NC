﻿using AutoMapper;
using HotelProject.Models;
using HotelProject.Models.Dtos;

namespace HotelProject.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GuestReservation, GuestWithReservationDto>()
                    .ForMember(destination => destination.Id, options => options.MapFrom(source => source.Id))
                    .ForMember(destination => destination.GuestId, options => options.MapFrom(source => source.GuestId))
                    .ForMember(destination => destination.FirstName, options => options.MapFrom(source => source.Guest.FirstName))
                    .ForMember(destination => destination.LastName, options => options.MapFrom(source => source.Guest.LastName))
                    .ForMember(destination => destination.PersonalNumber, options => options.MapFrom(source => source.Guest.PersonalNumber))
                    .ForMember(destination => destination.PhoneNumber, options => options.MapFrom(source => source.Guest.PhoneNumber))
                    .ForMember(destination => destination.ReservationId, options => options.MapFrom(source => source.ReservationId))
                    .ForMember(destination => destination.CheckInDate, options => options.MapFrom(source => source.Reservation.CheckInDate))
                    .ForMember(destination => destination.CheckOutDate, options => options.MapFrom(source => source.Reservation.CheckOutDate))
                    .ReverseMap();
            CreateMap<GuestWithReservationForUpdatingDto, Guest>()
                    .ForMember(destination => destination.Id, options => options.MapFrom(srouce => srouce.GuestId))
                    .ReverseMap();
            CreateMap<GuestWithReservationForUpdatingDto, Reservation>()
                    .ForMember(destination => destination.Id, options => options.MapFrom(srouce => srouce.ReservationId))
                    .ReverseMap();

            CreateMap<GuestReservation, GuestWithReservationForUpdatingDto>()
                    .ForMember(destination => destination.FirstName, options => options.MapFrom(source => source.Guest.FirstName))
                    .ForMember(destination => destination.LastName, options => options.MapFrom(source => source.Guest.LastName))
                    .ForMember(destination => destination.PersonalNumber, options => options.MapFrom(source => source.Guest.PersonalNumber))
                    .ForMember(destination => destination.PhoneNumber, options => options.MapFrom(source => source.Guest.PhoneNumber))
                    .ForMember(destination => destination.CheckInDate, options => options.MapFrom(source => source.Reservation.CheckInDate))
                    .ForMember(destination => destination.CheckOutDate, options => options.MapFrom(source => source.Reservation.CheckOutDate))
                    .ReverseMap();


            CreateMap<GuestWithReservationForCreatingDto, Guest>().ReverseMap();
            CreateMap<GuestWithReservationForCreatingDto, Reservation>().ReverseMap();
            CreateMap<GuestWithReservationForCreatingDto, GuestReservation>().ReverseMap();
            CreateMap<UserRegistrationDto, ApplicationUser>()
                    .ForMember(destintaion => destintaion.UserName, options => options.MapFrom(source => source.Email))
                    .ReverseMap();

            CreateMap<UserLoginDto, ApplicationUser>().ReverseMap();
        }

    }
}
