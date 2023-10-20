using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces;
public interface IUnitOfWork
{
    ICargo Cargos { get; }
    ICliente Clientes { get; }
    IColor Colors { get; }
    IDepartamento Departamentos { get; }
    IDetalleOrden DetalleOrdenes { get; }
    IDetalleVenta DetalleVentas { get; }
    IEmpleado Empleados { get; }
    IEmpresa Empresas { get; }
    IEstado Estados { get; }
    IFormaPago FormaPagos { get; }
    IGenero Generos { get; }
    IInsumo Insumos { get; }
    IInventario Inventarios { get; }
    IMunicipio Municipios { get; }
    IOrden Ordenes { get; }
    IPais Paises { get; }
    IPrenda Prendas { get; }
    IProveedor Proveedores { get; }
    ITalla Tallas { get; }
    ITipoEstado TipoEstados { get; }
    ITipoPersona TipoPersonas { get; }
    ITipoProteccion TipoProtecciones { get; }
    IVenta Ventas { get; }

    Task<int> SaveAsync();
}
