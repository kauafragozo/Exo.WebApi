using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Build.Tasks;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Exo.WebApi.Models{
    public class Projeto{
        public int id{get; set;}
        public string NomeDoProjeto {get; set;}
        public string Area {get; set;}
        public bool Status{get;set;}
    }
}