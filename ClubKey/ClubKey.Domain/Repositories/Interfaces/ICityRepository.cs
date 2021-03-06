﻿using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface ICityRepository
    {
        List<City> GetAllCities();
        City GetCityByClubId(int clubId);
    }
}