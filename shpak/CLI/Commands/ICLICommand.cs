using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shpak.CLI.Commands
{
    public interface ICLICommand
    {
        int Execute(string[] args);
    }
}
