﻿using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color entity);
        IResult Delete(Color entity);
        IResult Update(Color entity);
    }
}
