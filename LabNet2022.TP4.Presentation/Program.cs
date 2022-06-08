using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain.Entities;
using LabNet2022.TP4.Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var service = new ServiceCollection();
            Configservices(service);
            using (var serviceProvider = service.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Principal>();
                Application.Run(form1);
            }
        }

        public static void Configservices(ServiceCollection service)
        {
            service.AddTransient<IServiceCategories, ServiceCategories>()
                .AddTransient<Principal>()
                .AddTransient<IServiceProducts, ServiceProducts>()
                .AddTransient<ICategoriesRepository, CategoriesRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>();
        }


    }
}
