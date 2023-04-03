using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aplication.Exception
{
    public class ValidacionesExcepciones : System.Exception
    {
        public List<string> Errors { get; set; }
        public ValidacionesExcepciones() : base ("Una o mas validaciones")
        {
            Errors = new List<string>();
        }
        public ValidacionesExcepciones(IEnumerable<ValidationFailure> failures)  : this ()
        {
            foreach (var fauler in failures)
            {
                Errors.Add(fauler.ErrorMessage);
            }
        }
    }
}
