using MediatorConsole.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole.CollegueClasses
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
