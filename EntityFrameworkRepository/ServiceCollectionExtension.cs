using EntityFrameworkRepository.Mapper;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterEntityFrameworkRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserEntityFrameworkRepository>();
            services.AddScoped<IParticipationRepository, ParticipationEntityFrameworkRepository>();
            services.AddScoped<IGroupMemberRepository, GroupMemberEntityFrameworkRepository>();
            services.AddScoped<IGroupRepository, GroupEntityFrameworkRepository>();
            services.AddScoped<IEventRepository, EventEntityFrameworkRepository>();
        }

        public static void RegisterDataMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDataMapper, UserDataMapper>();
            services.AddScoped<IParticipationDataMapper, ParticipationDataMapper>();
            services.AddScoped<IGroupMemberDataMapper, GroupMemberDataMapper>();
            services.AddScoped<IGroupDataMapper, GroupDataMapper>();
            services.AddScoped<IEventDataMapper, EventDataMapper>();
        }
    }
}
