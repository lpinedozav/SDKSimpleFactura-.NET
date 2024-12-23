﻿using System.Xml.Serialization;

namespace SDKSimpleFactura.Enum
{
    public class TipoRecargoComision
    {
        public enum TipoRecargoComisionEnum
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet,            
            [XmlEnum("C")]
            Comision,
            [XmlEnum("O")]
            OtrosCargos
        }
    }
}
