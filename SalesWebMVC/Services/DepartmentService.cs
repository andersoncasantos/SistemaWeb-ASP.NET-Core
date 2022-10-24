﻿using SalesWebMvc.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
