﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesAndDepartmentsAPI.Models
{
    public class FamilyMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
