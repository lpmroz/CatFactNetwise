using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFactNetwise.Services
{
    public interface IFileService
    {
       void MessageWriteToFile(string text);
    }
}
