using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.System
{
    public class ResultService<T>
    {
        public bool HasError { get { return Errors.Count > 0; } }
        public ICollection<ErrorItem> Errors { get; set; }
        public T Data { get; set; }
        public ResultService() { 
            Errors = new List<ErrorItem>();
        }
        public void AddError(string ErrorType, string ErrorMessage) {
            Errors.Add(
                new ErrorItem()
                {
                    ErrorType = ErrorType,
                    ErrorMessage = ErrorMessage
                });


        }

    }
}
