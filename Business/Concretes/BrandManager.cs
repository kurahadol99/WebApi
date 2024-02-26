﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        // business rules

        //mapping =>> automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate = DateTime.Now;

        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createdBrandResponse = new();
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.Id = 4;
        createdBrandResponse.CreatedDate = brand.CreatedDate;
        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        throw new NotImplementedException();
    }
}