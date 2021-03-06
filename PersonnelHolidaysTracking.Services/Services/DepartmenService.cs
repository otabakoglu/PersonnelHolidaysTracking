﻿using PersonnelHolidaysTracking.Core.DTOs;
using PersonnelHolidaysTracking.Core.Models;
using PersonnelHolidaysTracking.Core.Repository;
using PersonnelHolidaysTracking.Core.Services;
using PersonnelHolidaysTracking.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelHolidaysTracking.Service.Services
{
    public class DepartmenService : Service<Department>, IDepartmentService
    {
        public DepartmenService(IUnitOfWork unitOfWork, IRepository<Department> repository) : base(unitOfWork, repository)
        {

        }

        public IList<DepartmentDto> GetDepartmentsDto()
        {
            return _unitOfWork.Departments.GetDepartmentsDto();
        }

        public void RemoveWithStatus(Department entity)
        {
            _unitOfWork.Departments.RemoveWithStatus(entity);
            _unitOfWork.Commit();
        }
    }
}
