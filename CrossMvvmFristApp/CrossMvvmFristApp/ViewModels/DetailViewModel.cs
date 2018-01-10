using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace CrossMvvmFristApp.Core.ViewModels
{
    public class DetailViewModel : MvxViewModel<int>
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public override void Prepare(int parameter)
        {
            Id = parameter;
        }


    }
}
