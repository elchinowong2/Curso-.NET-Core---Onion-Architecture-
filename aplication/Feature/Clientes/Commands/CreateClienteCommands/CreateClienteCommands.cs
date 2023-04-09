﻿using aplication.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplication.Feature.Clientes.Commands.CreateClienteCommands
{
    public class CreateClienteCommands : IRequest<Response<int>>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommands, Response<int>>
    {
        public Task<Response<int>> Handle(CreateClienteCommands request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
