﻿using System.Collections.Generic;

namespace WebApplication1.Domain.Moradores.Interfaces
{
    public interface IMoradorRepository
    {
        Morador Create(Morador morador);
        Morador FindById(long id);
        List<Morador> FindAll();
        Morador Update(Morador morador);
        void Delete(long id);
        bool Exists(long id);
    }
}