﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace API_Clinica.Models
{
    public partial class Especialidade
    {
        public int IdEspecialidade { get; set; }
        public string NmEspecialidade { get; set; }
        public bool? FlGeral { get; set; }
        public bool? FlSecao { get; set; }
        public bool? FlCobrarConsulta { get; set; }
        public int? IdExameSessao { get; set; }
        public string CdAmb { get; set; }
        public string Cbo { get; set; }
        public bool? FlAtiva { get; set; }
        public bool? FlMasculino { get; set; }
        public bool? FlFeminino { get; set; }
        public int? Idade { get; set; }
        public int? Idadeate { get; set; }
        public string CodigoReceita { get; set; }
    }
}