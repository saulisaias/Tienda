﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCOMMON.Interfaces
{
    public interface IDB
    {
        string Error { get; }
        bool Comando(string command);
        object Consulta(string consulta);
    }
}
