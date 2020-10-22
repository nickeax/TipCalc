using MvvmCross;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
