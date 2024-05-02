using HotelProject.Data;
using HotelProject.Repository.Interfaces;
using HotelProject.Repository;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerLocalConnection")));

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddScoped<IHotelRepository, HotelRepositoryEF>();
            builder.Services.AddScoped<IManagerRepository, ManagerRepositoryEF>();
            builder.Services.AddScoped<IRoomRepository, RoomRepositoryEF>();
            builder.Services.AddScoped<IGuestRepository, GuestRepositoryEF>();
            builder.Services.AddScoped<IReservationRepository, ReservationRepositoryEF>();
            builder.Services.AddScoped<IGuestReservationRepository, GuestReservationRepositoryEF>();

            builder.Services.AddControllers();

            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
