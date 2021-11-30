[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoCADPessoas.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoCADPessoas.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoCADPessoas.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using ProjetoCADPessoas.Controllers;
    using ProjetoCADPessoas.Controllers.Interfaces;
    using ProjetoCADPessoas.Repositories;
    using ProjetoCADPessoas.Repositories.Interfaces;
    using ProjetoCADPessoas.Services;
    using ProjetoCADPessoas.Services.Interfaces;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IController<>)).To(typeof(Controller<>));
            kernel.Bind<IPessoaController>().To<PessoaController>();
            kernel.Bind<IEnderecoController>().To<EnderecoController>();
            kernel.Bind<IPessoaTelefoneController>().To<PessoaTelefoneController>();
            kernel.Bind<ITelefoneController>().To<TelefoneController>();
            kernel.Bind<ITelefoneTipoController>().To<TelefoneTipoController>();

            kernel.Bind(typeof(IService<>)).To(typeof(Service<>));
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IEnderecoService>().To<EnderecoService>();
            kernel.Bind<IPessoaTelefoneService>().To<PessoaTelefoneService>();
            kernel.Bind<ITelefoneService>().To<TelefoneService>();
            kernel.Bind<ITelefoneTipoService>().To<TelefoneTipoService>();

            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IEnderecoRepository>().To<EnderecoRepository>();
            kernel.Bind<IPessoaTelefoneRepository>().To<PessoaTelefoneRepository>();
            kernel.Bind<ITelefoneRepository>().To<TelefoneRepository>();
            kernel.Bind<ITelefoneTipoRepository>().To<TelefoneTipoRepository>();
        }
    }
}