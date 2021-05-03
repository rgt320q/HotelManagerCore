using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EFCore;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Dal Register.

            builder.RegisterType<EfReservationDal>().As<IReservationDal>();
            builder.RegisterType<EfBaseConfigurationDal>().As<IBaseConfigurationDal>();
            builder.RegisterType<EfGuestDal>().As<IGuestDal>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>();

            //Service Register

            builder.RegisterType<ReservationManager>().As<IReservationService>();
            builder.RegisterType<BaseConfigurationManager>().As<IBaseConfigurationService>();
            builder.RegisterType<GuestManager>().As<IGuestService>();
            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<RoomManager>().As<IRoomService>();

            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
