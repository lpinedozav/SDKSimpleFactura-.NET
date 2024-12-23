﻿using System.Threading.Tasks;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;

namespace SDKSimpleFactura.Interfaces
{
    public interface IConfiguracionService
    {
        Task<Response<EmisorApiEnt>?> DatosEmpresaAsync(Credenciales credenciales);
    }
}
