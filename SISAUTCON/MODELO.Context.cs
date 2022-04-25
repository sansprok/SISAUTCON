﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISAUTCON
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TributosEntities : DbContext
    {
        public TributosEntities()
            : base("name=TributosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int SP_RENTAS_CARTA_RESUMEN_ESTADOCUENTA(string vestado, string vfacodcontr)
        {
            var vestadoParameter = vestado != null ?
                new ObjectParameter("vestado", vestado) :
                new ObjectParameter("vestado", typeof(string));
    
            var vfacodcontrParameter = vfacodcontr != null ?
                new ObjectParameter("vfacodcontr", vfacodcontr) :
                new ObjectParameter("vfacodcontr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_RENTAS_CARTA_RESUMEN_ESTADOCUENTA", vestadoParameter, vfacodcontrParameter);
        }
    
        public virtual int SP_RENTAS_CONSULTA_CUENTA_CORRIENTE(string lsp_facodcontr, string lsp_faanoini, string lsp_faanofin)
        {
            var lsp_facodcontrParameter = lsp_facodcontr != null ?
                new ObjectParameter("lsp_facodcontr", lsp_facodcontr) :
                new ObjectParameter("lsp_facodcontr", typeof(string));
    
            var lsp_faanoiniParameter = lsp_faanoini != null ?
                new ObjectParameter("lsp_faanoini", lsp_faanoini) :
                new ObjectParameter("lsp_faanoini", typeof(string));
    
            var lsp_faanofinParameter = lsp_faanofin != null ?
                new ObjectParameter("lsp_faanofin", lsp_faanofin) :
                new ObjectParameter("lsp_faanofin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_RENTAS_CONSULTA_CUENTA_CORRIENTE", lsp_facodcontrParameter, lsp_faanoiniParameter, lsp_faanofinParameter);
        }
    }
}
