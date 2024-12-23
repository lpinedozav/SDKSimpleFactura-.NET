﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace SDKSimpleFactura.Enum
{
    public class TipoDTE
    {
        public enum DTEType : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [Description("No Asignado")]
            [XmlEnum("")]
            NotSet = 0,
            [Description("Factura")]
            [XmlEnum("30")]
            Factura = 30,
            [Description("Factura Exenta")]
            [XmlEnum("32")]
            FacturaExenta = 32,
            [Description("Factura Electrónica")]
            [XmlEnum("33")]
            FacturaElectronica = 33,
            [Description("Factura Electrónica Exenta")]
            [XmlEnum("34")]
            FacturaElectronicaExenta = 34,
            [Description("Factura Compra Electrónica")]
            [XmlEnum("46")]
            FacturaCompraElectronica = 46,
            [Description("Factura Exportación Electrónica")]
            [XmlEnum("110")]
            FacturaExportacionElectronica = 110,
            [Description("Nota Credito Exportación Electrónica")]
            [XmlEnum("112")]
            NotaCreditoExportacionElectronica = 112,
            [Description("Nota Debito Exportación Electrónica")]
            [XmlEnum("111")]
            NotaDebitoExportacionElectronica = 111,
            [Description("Guia Despacho Electrónica")]
            [XmlEnum("52")]
            GuiaDespachoElectronica = 52,
            [Description("Nota Debito Electrónica")]
            [XmlEnum("56")]
            NotaDebitoElectronica = 56,
            [Description("Nota Credito")]
            [XmlEnum("60")]
            NotaCredito = 60,
            [Description("Nota Credito Electrónica")]
            [XmlEnum("61")]
            NotaCreditoElectronica = 61,
            [Description("Boleta Electrónica")]
            [XmlEnum("39")]
            BoletaElectronica = 39,
            [Description("Boleta Exenta Electrónica")]
            [XmlEnum("41")]
            BoletaElectronicaExenta = 41,
            [Description("Liquidación Factura Electrónica")]
            [XmlEnum("43")]
            LiquidacionFacturaElectronica = 43
        }
        public enum DOCType : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("33")]
            FacturaElectronica = 33,
            [XmlEnum("34")]
            FacturaElectronicaExenta = 34,
            [XmlEnum("46")]
            FacturaCompraElectronica = 46,
            [XmlEnum("52")]
            GuiaDespachoElectronica = 52,
            [XmlEnum("56")]
            NotaDebitoElectronica = 56,
            [XmlEnum("61")]
            NotaCreditoElectronica = 61
        }
        public enum DTEFacturasType : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("33")]
            FacturaElectronica = 33,
            [XmlEnum("34")]
            FacturaElectronicaExcenta = 34,
            [XmlEnum("46")]
            FacturaCompraElectronica = 46,
            [XmlEnum("43")]
            LiquidacionFacturaElectronica = 43
        }
        public enum TipoDocumentoLibro : int
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            /// <summary>
            /// Factura manual
            /// </summary>
            [XmlEnum("30")]
            FacturaManual = 30,
            /// <summary>
            /// Factura exenta manual
            /// </summary>
            [XmlEnum("32")]
            FacturaExentaManual = 32,
            /// <summary>
            /// Factura electrónica
            /// </summary>
            [XmlEnum("33")]
            FacturaElectronica = 33,
            ///Factura exenta electrónica
            [XmlEnum("34")]
            FacturaExentaElectronica = 34,
            /// <summary>
            /// Boletas de ventas y servicios
            /// </summary>
            [XmlEnum("35")]
            BoletaVentasServicios = 36,
            /// <summary>
            /// Boleta no afectas o exentas
            /// </summary>
            [XmlEnum("38")]
            BoletaExenta = 38,
            /// <summary>
            /// Boletas electrónica
            /// </summary>
            [XmlEnum("39")]
            BoletaElectronica = 39,
            /// <summary>
            /// Liquidación Factura Manual
            /// </summary>
            [XmlEnum("40")]
            LiquidacionFacturaManual = 40,
            /// <summary>
            /// Boletas no afectas o exentas electronicas
            /// </summary>
            [XmlEnum("41")]
            BoletaExentaElectronica = 41,
            /// <summary>
            /// Liquidación factura electrónica
            /// </summary>
            [XmlEnum("43")]
            LiquidacionFacturaElectroncia = 43,
            /// <summary>
            /// Factura de compra
            /// </summary>
            [XmlEnum("45")]
            FacturaCompra = 45,
            /// <summary>
            /// Factura de compra electrónica
            /// </summary>
            [XmlEnum("46")]
            FacturaCompraElectronica = 46,
            /// <summary>
            /// Nota de débito manual
            /// </summary>
            [XmlEnum("55")]
            NotaDebito = 55,
            /// <summary>
            /// Nota de débito electrónica
            /// </summary>
            [XmlEnum("56")]
            NotaDebitoElectronica = 56,
            /// <summary>
            /// Nota de crédito manual
            /// </summary>
            [XmlEnum("60")]
            NotaCredito = 60,
            /// <summary>
            /// Nota de crédito electrónica
            /// </summary>
            [XmlEnum("61")]
            NotaCreditoElectronica = 61,
            /// <summary>
            /// Factura de exportación
            /// </summary>
            [XmlEnum("101")]
            FacturaExportacion = 101,
            /// <summary>
            /// Factura de venta exenta a zona franca primaria (Res. Ex. N° 601 de 07.05.82)
            /// </summary>
            [XmlEnum("102")]
            FacturaVentaExentaAZonaFrancaPrimaria = 102,
            /// <summary>
            /// Liquidación
            /// </summary>
            [XmlEnum("103")]
            Liquidacion = 103,
            /// <summary>
            /// Nota de débito de exportación
            /// </summary>
            [XmlEnum("104")]
            NotaDebitoExportacion = 104,
            /// <summary>
            /// Boletas liquidación (Res. Ex. N° 1423 del 23.12.76)
            /// </summary>
            [XmlEnum("105")]
            BoletaLiquidacion = 105,
            /// <summary>
            /// Nota de crédito de exportación
            /// </summary>
            [XmlEnum("106")]
            NotaCreditoExportacion = 106,
            /// <summary>
            /// SRF: Solicitud de registro de factura.
            /// </summary>
            [XmlEnum("108")]
            SRF = 108,
            /// <summary>
            /// Factura a turista (Res. Ex. N° 6428 de 06.12.93)
            /// </summary>
            [XmlEnum("109")]
            FacturaTurista = 109,
            /// <summary>
            /// DEPRECATED! DO NOT USE.
            /// Liquidación recibida por el mandante
            /// </summary>
            [XmlEnum("900")]
            LiquidacionRecibidaPorMandante = 900,
            /// <summary>
            /// Factura de ventas a empresas del territorio preferencial (Res. Ex. N° 1057, del 25.04.85)
            /// </summary>
            [XmlEnum("901")]
            FacturaVentaaEmpresasTerritorioPreferencial = 901,
            /// <summary>
            /// Conocimiento de Embarque (Marítimo o aéreo)
            /// </summary>
            [XmlEnum("902")]
            ConocimientoEmbarque = 902,
            /// <summary>
            /// Documento Único de Salida (DUS)
            /// </summary>
            [XmlEnum("903")]
            DUS = 903,
            /// <summary>
            /// Para usuarios zona franca:
            /// Factura de traspaso.
            /// </summary>
            [XmlEnum("904")]
            ZonaFranca_FacturaTraspaso = 904,
            /// <summary>
            /// Usuarios Zona Franca y mercaderías no nacionales:
            /// Factura de reexpedición (Usuario Zona Franca)
            /// </summary>
            [XmlEnum("905")]
            FacturaReexpedicion = 905,
            /// <summary>
            /// Usuarios Zona Franca y mercaderías no nacionales:            
            /// Boletas de venta Modulos Zona Franca (Usuario Zona Franca)
            /// </summary>
            [XmlEnum("906")]
            BoletaVentaModuloZonaFranca = 906,
            /// <summary>
            /// Usuarios Zona Franca y mercaderías no nacionales:
            /// Facturas de venta Módulos Zona Franca (Usuario Zona Franca)
            /// </summary>
            [XmlEnum("907")]
            FacturaVentaModuloZonaFranca = 907,
            /// <summary>
            /// Para usuarios zona franca:
            /// Facturas venta módulo Zona franca
            /// </summary>
            [XmlEnum("909")]
            ZonaFranca_FacturaVentaModuloZF = 909,
            /// <summary>
            /// Para usuarios zona franca:
            /// Solicitud de traslado Zona Franca (Z)
            /// </summary>
            [XmlEnum("910")]
            ZonaFranca_SolicitudTrasladoZF = 910,
            /// <summary>
            /// Declaración de ingreso a Zona Franca Primaria
            /// </summary>
            [XmlEnum("911")]
            DeclaracionIngresoZonaFrancaPrimaria = 912,
            /// <summary>
            /// Declaración de Ingreso
            /// </summary>
            [XmlEnum("914")]
            DIN = 914,
            /// <summary>
            /// DEPRECATED! DO NOT USE!
            /// Declaración de Ingreso de Zona Franca
            /// </summary>
            [XmlEnum("918")]
            DeclaracionIngresoZonaFranca = 918,
            /// <summary>
            /// Resumen Ventas de nacionales pasajes sin Factura
            /// </summary>
            [XmlEnum("919")]
            ResumenVentasNacionalesPasajesSinFactura = 919,
            /// <summary>
            /// Otros registros no documentados. Aumenta débito.
            /// </summary>
            [XmlEnum("920")]
            OtroRegistroAumentaDebito = 920,
            /// <summary>
            /// DEPRECATED! DO NOT USE!
            /// Liquidación recibida por mandatario
            /// </summary>
            [XmlEnum("921")]
            LiquidacionRecibidaMandatario = 921,
            /// <summary>
            /// Otros registros. Disminuye débito.
            /// </summary>
            [XmlEnum("922")]
            OtrosRegistrosDisminuyeDebito = 922,
            /// <summary>
            ///  Factura de Exportación Electrónica
            /// </summary>
            [XmlEnum("110")]
            FacturaExportacionElectronica = 110,
            /// <summary>
            /// Nota de Débito de Exportación Electrónica
            /// </summary>
            [XmlEnum("111")]
            NotaDebitoExportacionElectronica = 111,
            /// <summary>
            /// Nota de Crédito de Exportación Electrónica
            /// </summary>
            [XmlEnum("112")]
            NotaCreditoExportacionElectronica = 112,
            /// <summary>
            /// Resumen ventas de internacionales pasajes sin Factura
            /// </summary>
            [XmlEnum("924")]
            ResumenVentasInternacionalPasajesSinFactura = 924,
            /// <summary>
            /// Ajuste aumento Tipo de Cambio (código 500): a utilizar cuando la paridad (moneda extranjera)/(moneda nacional) aumente entre 
            /// la fecha de emisión del documento y la fecha de cierre del periodo, debe indicarse sólo en el Resumen
            /// </summary>
            [XmlEnum("500")]
            AjusteAumentoTipoCambio = 500,
            /// <summary>
            /// Ajuste disminución Tipo de Cambio (código 501): a utilizar cuando la paridad (moneda extranjera)/(moneda nacional) disminuya
            /// entre la fecha de emisión del documento y la fecha de cierre del periodo, debe indicarse sólo en el Resumen
            /// </summary>
            [XmlEnum("501")]
            AjusteDisminucionTipoCambio = 501
        }
    }
}
