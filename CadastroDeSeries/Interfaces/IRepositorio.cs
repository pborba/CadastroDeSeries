﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
        void Exclui(int id);
        void Atualiza(int id, T objeto);
        int ProximoId();
    }
}
