using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplication.Behavius
{
    public class ValidacionBehavies<trequest, tresponse> : IPipelineBehavior<trequest, tresponse> where trequest : IRequest<tresponse>
    {
        private readonly IEnumerable<IValidator<trequest>> _validators;

        public ValidacionBehavies(IEnumerable<IValidator<trequest>> validators)
        {
            _validators = validators;
        }

      

        public async Task<tresponse> Handle(trequest request, CancellationToken cancellationToken, RequestHandlerDelegate<tresponse> next)
        {
            if (_validators.Any())
            {

                var context = new FluentValidation.ValidationContext<trequest>(request);
                var validatorResultar = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validatorResultar.SelectMany(r => r.Errors).Where(f => f != null).ToList();
                if (failures.Count() > 0)
                {
                    throw new Exception.ValidacionesExcepciones(failures);
                }
            }
            return await next();
        }
    }   
}
