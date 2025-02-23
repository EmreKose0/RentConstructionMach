﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.MachineLocationCommands
{
    public class CreateMachineLocationCommand :IRequest
    {
        public int MachineID { get; set; }
        public int LocationID { get; set; }
    }
}
