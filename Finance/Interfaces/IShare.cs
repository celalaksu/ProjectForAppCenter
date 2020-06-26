using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Interfaces
{
    public interface IShare
    {
        Task Show(string title, string url);
    }
}
