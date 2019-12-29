using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Interfaces
{
    public interface IOutputPort<in TResponse>
    {
        void Handle(TResponse response);
    }
}
