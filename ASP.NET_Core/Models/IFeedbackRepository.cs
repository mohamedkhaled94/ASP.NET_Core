using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
