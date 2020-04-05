using Ninject;
using ROSESHIELD.DOMAIN.CORE.IRepository;
using ROSESHIELD.DOMAIN.CORE.Repository;
using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ROSESHIELD.DOMAIN.CORE.InjectionDependency
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {

        private IKernel ninjectKernnel;

        public NinjectControllerFactory()
        {
            ninjectKernnel = new StandardKernel();
            AdBinding();
        }

        private void AdBinding()
        {           
            ninjectKernnel.Bind<IRepository<Cadastro>>().To<CadastroRepository>();
            ninjectKernnel.Bind<IRepository<CadastroBasico>>().To<CadastroBasicoRepository>();
            ninjectKernnel.Bind<IRepository<Login>>().To<LoginRepository>();
            ninjectKernnel.Bind<IRepository<PreCadastroUsuario>>().To<PreCadastroRepository>();
            ninjectKernnel.Bind<IRepository<ProfissionalVoluntario>>().To<ProfissionalVoluntarioRepository>();
            ninjectKernnel.Bind<IRepository<ProfissionalDesconto>>().To<ProfissionalDescontoRepository>();
            ninjectKernnel.Bind<IRepository<PoliciaMilitarEntity>>().To<PoliciaMilitarRepository>();
            ninjectKernnel.Bind<IRepository<Ong>>().To<CadastroOngRepository>();
            ninjectKernnel.Bind<IRepository<CadastroDeVitimas>>().To<CadastroDeVitimasRepository>();


            ninjectKernnel.Bind<IRepository<CadastroDeOcorrencia>>().To<CadastroDeOcorrenciaRepository>();
            ninjectKernnel.Bind<IRepository<CadastroSOS>>().To<CadastroSOSRepository>();
            ninjectKernnel.Bind<IRepository<CadastroFilho>>().To<CadastroFilhoRepository>();
            ninjectKernnel.Bind<IRepository<CadastroIdoso>>().To<CadastroIdosoRepository>();
            ninjectKernnel.Bind<IRepository<CadastroComplementar>>().To<CadastroComplementarRepository>();
            ninjectKernnel.Bind<IRepository<EmpresaParceira>>().To<CadastroEmpresaParceiraRepository>();

            ninjectKernnel.Bind<IRepository<ExcelImportado>>().To<ExcelImportadoBasicoRepository>();

            


        }



    }
}
