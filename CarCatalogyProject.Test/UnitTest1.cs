using CarCatalogyProject.Controllers;
using CarCatalogyProject.Data;
using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Data.Repository;
using CarCatalogyProject.Test.Mock;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;

namespace CarCatalogyProject.Test
{
    public abstract class UnitTest1
    {
        protected ContactsController ContactsController { get; }

        protected UnitTest1()
        {
            var services = new ServiceCollection();

            // ��� ��� AppDBContent
            var mockDbContext = new Mock<AppDBContent>();
            services.AddScoped(_ => mockDbContext.Object);

            // ���������� �����������
            services.AddControllersWithViews();

            // ���������� ���-����� ���������� ����������
            var mockHostEnvironment = new Mock<IHostEnvironment>();
            services.AddScoped<IHostEnvironment>(_ => mockHostEnvironment.Object);

            var serviceProvider = services.BuildServiceProvider();
            ContactsController = new ContactsController(serviceProvider.GetRequiredService<AppDBContent>());
        }
    }    
}