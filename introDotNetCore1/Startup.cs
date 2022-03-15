using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // MVC framework'ünü kullanmak için MVC
            //services.add
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //// Her request'te çalışan ve adım adım bazı işlemleri yapan bir metot.
        {
            //app.UseWelcomePage();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //middleware
            }

            app.UseRouting();   //middleware

            app.UseEndpoints(endpoints => //middleware. en son yönlendirmeyi yapan middleware
            {
                endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
                //ismi home olan controller'a git bu home içerisindeki index isimli action'a git ve opsiyonel olarak id olabilir.
            });
        }
    }
}
