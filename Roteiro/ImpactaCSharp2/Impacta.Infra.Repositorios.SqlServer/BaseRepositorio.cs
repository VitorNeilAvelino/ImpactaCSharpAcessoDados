using System;
using System.Configuration;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public static class BaseRepositorio
    {
        public static String OficinaConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["oficinaConnectionString"].ConnectionString;
            }
        }
    }
}