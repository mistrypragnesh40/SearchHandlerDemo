using SearchHandlerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerDemo.ViewModels
{
    [QueryProperty(nameof(StudentDetail), "StudentDetailObj")]
    public class StudentDetailViewModel : BaseViewModel
    {

        private StudentModel _studentDetail;
        public StudentModel StudentDetail
        {
            get => _studentDetail;
            set => SetProperty(ref _studentDetail, value);
        }
    }
}
