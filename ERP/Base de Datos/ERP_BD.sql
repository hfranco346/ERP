Create database ERP
GO

Use ERP
GO

CREATE SCHEMA Inventario
GO
CREATE SCHEMA Usuario
GO
CREATE SCHEMA Contacto
GO
CREATE SCHEMA Compra
GO
CREATE SCHEMA Venta
GO
CREATE SCHEMA ClienteProveedor
GO

/*Usuario*/
Create table [Usuario].[Usuarios] (
	[IdUsuario] Integer Identity(1,1) NOT NULL UNIQUE,
	[IdEmpleado] Integer NOT NULL,
	[IdSeguridad] Integer NOT NULL,
	[Alias] Nchar(15) NOT NULL UNIQUE,
	[Clave] Nchar(30) NOT NULL,
	[Estado] bit NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
Constraint [pk_Usuarios] Primary Key  ([IdUsuario],[IdEmpleado],[IdSeguridad])
) 
go
Create table [Usuario].[Permisos] (
	[IdPermiso] Integer Identity(1,1) NOT NULL UNIQUE,
	[NombrePermiso] varchar(30) NOT NULL,
	[IdRol] Integer NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
Constraint [pk_UsuariosPermisos] Primary Key  ([IdPermiso],[NombrePermiso])
) 
go
Create table [Usuario].[Empleado] (
	[IdEmpleado] Integer Identity(1,1) NOT NULL UNIQUE,
	[Identidad] Char(15) NOT NULL UNIQUE,
	[Nombres] Varchar(30) NOT NULL,
	[Apellidos] Varchar(30) NOT NULL,
	[Direccion] Varchar(255) NOT NULL,
	[Genero] Bit NOT NULL,
	[EstadoCivil] Bit NOT NULL,
	[EstadoEmpleado] Bit NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[Id_PuestoEmpleado] Integer NOT NULL,
Constraint [pk_Empleado] Primary Key  ([IdEmpleado])
) 
go
Create table [Usuario].[Seguridad] (
	[IdSeguridad] Integer Identity(1,1) NOT NULL UNIQUE,
	[Rol] Varchar(25) NOT NULL UNIQUE,
	[Descripcion] Varchar(255) NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
Constraint [pk_Seguridad] Primary Key  ([IdSeguridad])
) 
go
Create table [Usuario].[Puesto_Empleados] (
	[Id_PuestoEmpleado] Integer Identity(1,1) NOT NULL UNIQUE,
	[Nombre_Puesto] Varchar(50) NOT NULL UNIQUE,
Constraint [pk_Puesto_Empleados] Primary Key  ([Id_PuestoEmpleado])
) 
go

/*Contacto*/
Create table [Contacto].[Telefonos] (
	[IdTelefono] Integer Identity(1,1) NOT NULL UNIQUE,
	[IdTipoContacto] BIT NOT NULL,
	[IdEmpleado] Integer NOT NULL,
	[NumeroFijo] Char(9) NULL UNIQUE,
	[NumeroMovil] Char(9) NULL UNIQUE,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[IdClientesProveedores] Integer NOT NULL
) 
go

/*Cliente Proveedor*/
Create table [ClienteProveedor].[Clientes_Proveedores] (
	[IdClientesProveedores] Integer Identity(1,1) NOT NULL UNIQUE,
	[RTN] Nchar(14) NOT NULL UNIQUE,
	[Nombres] Varchar(30) NOT NULL,
	[Apellidos] Varchar(30) NULL,
	[CorreoElectronico] Nvarchar(30) NOT NULL UNIQUE,
	[Direccion] Varchar(30) NULL,
	[TipoUsuarioCompraVenta] Bit NOT NULL,
	[EstadoClienteProveedor] Bit NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[Observaciones] text NOT NULL,
Constraint [pk_Clientes_Proveedores] Primary Key  ([IdClientesProveedores])
) 
go
Create table [ClienteProveedor].[Sucursal] (
	[IdSucursal] Integer Identity(1,1) NOT NULL UNIQUE,
	[NombreSucursal] Varchar(30) NOT NULL UNIQUE,
	[DireccionSucursal] Text NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[IdClientesProveedores] Integer NOT NULL,
	[EstadoSucursal] bit NOT NULL,
	[Observaciones] text NOT NULL,
Constraint [pk_Sucursal] Primary Key  ([IdSucursal],[IdClientesProveedores])
) 
go

/*Compras*/
Create table [Compra].[Compras] (
	[IdCompra] Integer Identity(1,1) NOT NULL UNIQUE,
	[FechaCompra] Datetime NOT NULL,
	[NumeroFactura] Varchar(15) NULL,
	[Total] Money NOT NULL,
	[Observaciones] Text NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Char(10) NOT NULL,
	[IdClientesProveedores] Integer NOT NULL,
    [EstadoCompra] char(1) NOT NULL,
Constraint [pk_Compras] Primary Key  ([IdCompra])
) 
go
Create table [Compra].[Detalle_Compras] (
	[IdDetalleCompra] Integer Identity(1,1) NOT NULL UNIQUE,
	[NumeroProducto] Integer NOT NULL,
	[CantidadProducto] Integer NOT NULL,
	[PrecioUnitario] Money NOT NULL,
	[Descripcion] Text NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[IdInventario] Integer NOT NULL,
	[IdCompra] Integer NOT NULL,
Constraint [pk_Detalle_Compras] Primary Key  ([IdDetalleCompra],[IdInventario])
) 
go

/*Ventas*/
Create table [Venta].[Ventas] (
	[IdVenta] Integer Identity(1,1) NOT NULL UNIQUE,
	[FechaVenta] Datetime NOT NULL,
        [SubTotal] Money NOT NULL,
	[Total] Money NOT NULL,
	[Observaciones] Text NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Char(10) NOT NULL,
	[IdClientesProveedores] Integer NOT NULL,
	[EstadoFactura] Bit NOT NULL,
        [IdUsuario] Integer NOT NULL,
Constraint [pk_Ventas] Primary Key  ([IdVenta])
) 
go
Create table [Venta].[Detalle_Ventas] (
	[IdDetalleVenta] Integer Identity(1,1) NOT NULL UNIQUE,
	[NumeroProducto] Integer NOT NULL,
	[CantidadProducto] Integer NOT NULL,
	[PrecioUnitario] Money NOT NULL,
	[Descripcion] Text NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[IdInventario] Integer NOT NULL,
	[IdVenta] Integer NOT NULL,

Constraint [pk_Detalle_Ventas] Primary Key  ([IdDetalleVenta],[IdInventario])
) 
go

/*Inventario*/
Create table [Inventario].[Inventario] (
	[IdInventario] Integer Identity(1,1) NOT NULL UNIQUE,
	[CodigoBarra] Varchar(25) NOT NULL UNIQUE,
	[NombreProducto] Varchar(30) NOT NULL,
	[DescripcionProducto] Text NOT NULL,
	[CantidadProducto] INT NOT NULL,
	[PrecioCompra] Money NOT NULL,
	[PrecioVenta] Money NULL,
	[PuntoReorden] Integer NOT NULL,
	[FechaElaboracionProducto] Datetime NOT NULL,
	[FechaVencimientoProducto] Datetime NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[EstadoProducto] Bit NOT NULL,
    [Observaciones] Text NULL,
    [IdProveedor] INT NOT NULL,
Constraint [pk_Inventario] Primary Key  ([IdInventario])
) 
GO

Create table [Inventario].[Impuesto] (
	[IDImpuesto] Integer Identity(1,1) NOT NULL UNIQUE,
	[Descripcion] VARCHAR(50) NOT NULL,
	[Valor] Decimal(2,2) NOT NULL,
	[FechaCreacion] Datetime NOT NULL,
	[CreadoPor] Integer NOT NULL,
	[FechaModificacion] Datetime NOT NULL,
	[ModificadoPor] Integer NOT NULL,
	[IdInventario] Integer NOT NULL,
    [EstadoImpuesto] Bit NOT NULL,
	[Observaciones] Text NOT NULL,
Constraint [pk_Impuesto] Primary Key  ([IDImpuesto])
) 
go

Alter table [Usuario].[Usuarios] add Constraint [FK_Empleado-Usuario] foreign key([IdEmpleado]) references [Usuario].[Empleado] ([IdEmpleado]) 
go
Alter table [Usuario].[Usuarios] add Constraint [FK_Seguridad-Usuarios] foreign key([IdSeguridad]) references [Usuario].[Seguridad] ([IdSeguridad]) 
go
Alter table [Usuario].[Empleado] add Constraint [FK_PuestoEmpleado-Empleado] foreign key([Id_PuestoEmpleado]) references [Usuario].[Puesto_Empleados] ([Id_PuestoEmpleado]) 
go
Alter table [Usuario].[Permisos] add Constraint [FK_Permisos-Seguridad] foreign key([IdRol]) references [Usuario].[Seguridad] ([IdSeguridad]) 
go

Alter table [Contacto].[Telefonos] add Constraint [FK_Empleado-Telefono] foreign key([IdEmpleado]) references [Usuario].[Empleado] ([IdEmpleado]) 
go

Alter table [ClienteProveedor].[Sucursal] add Constraint [FK_Cliente_Poveedores-Sucursal] foreign key([IdClientesProveedores]) references [ClienteProveedor].[Clientes_Proveedores] ([IdClientesProveedores]) 
go

Alter table [Compra].[Compras] add Constraint [FK_Cliente_Proveedores-Compras] foreign key([IdClientesProveedores]) references [ClienteProveedor].[Clientes_Proveedores] ([IdClientesProveedores]) 
go
Alter table [Compra].[Detalle_Compras] add Constraint [FK_Compras-Detalle_Compras] foreign key([IdCompra]) references [Compra].[Compras] ([IdCompra]) 
go
Alter table [Compra].[Detalle_Compras] add Constraint [FK_Inventario-Detalle_Compra] foreign key([IdInventario]) references [Inventario].[Inventario] ([IdInventario]) 
go
Alter table [Venta].[Ventas] add Constraint [FK_Cliente_Proveedores-Ventas] foreign key([IdClientesProveedores]) references [ClienteProveedor].[Clientes_Proveedores] ([IdClientesProveedores]) 
go
Alter table [Venta].[Detalle_Ventas] add Constraint [FK_Ventas-Detalle_Ventas] foreign key([IdVenta]) references [Venta].[Ventas] ([IdVenta]) 
go
Alter table [Venta].[Detalle_Ventas] add Constraint [FK_Inventario-Detalle_Venta] foreign key([IdInventario]) references [Inventario].[Inventario] ([IdInventario]) 
go
Alter table [Venta].[Ventas] add Constraint [FK_Ventas-IdUsuario] foreign key([IdUsuario]) references [Usuario].[Usuarios] ([IdUsuario]) 
go

Alter table [Inventario].[Impuesto] add Constraint [FK_Inventario-Inventario_Impuesto] foreign key([IdInventario]) references [Inventario].[Inventario] ([IdInventario]) 
go
Alter table [Inventario].[Inventario] add Constraint [FK_Inventario-IdProveedor] foreign key([IdProveedor]) references [ClienteProveedor].[Clientes_Proveedores] ([IdClientesProveedores]) 
go

