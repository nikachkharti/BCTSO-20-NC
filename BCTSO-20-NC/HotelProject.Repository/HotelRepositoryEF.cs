﻿using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class HotelRepositoryEF : IHotelRepository
    {
        private readonly ApplicationDbContext _context;
        public HotelRepositoryEF(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddHotel(Hotel hotel)
        {
            if (hotel is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotel(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.Hotels.FirstAsync(h => h.Id == id);

            _context.Hotels.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Hotel>> GetHotels()
        {
            var entities = await _context.Hotels.ToListAsync();

            if (entities == null)
            {
                throw new NullReferenceException("Entities not  found");
            }

            return entities;
        }

        public async Task<List<Hotel>> GetHotelsWithoutManager()
        {
            var entities = await _context.Hotels
                .Where(x => x.Manager == null)
                .ToListAsync();

            return entities;
        }

        public async Task<Hotel> GetSingleHotel(int id)
        {
            var entity = await _context.Hotels.FirstAsync(h => h.Id == id);
            return entity;
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            if (hotel.Id <= 0 || hotel == null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.Hotels.FirstAsync(h => h.Id == hotel.Id);

            entity.Name = hotel.Name;
            entity.Rating = hotel.Rating;
            entity.Country = hotel.Country;
            entity.City = hotel.City;
            entity.PhyisicalAddress = hotel.PhyisicalAddress;

            _context.Hotels.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
