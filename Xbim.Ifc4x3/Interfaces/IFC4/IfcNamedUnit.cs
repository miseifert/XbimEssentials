// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.MeasureResource
{
	public partial class @IfcNamedUnit : IIfcNamedUnit
	{

		[CrossSchemaAttribute(typeof(IIfcNamedUnit), 1)]
		IIfcDimensionalExponents IIfcNamedUnit.Dimensions 
		{ 
			get
			{
				return Dimensions;
			} 
			set
			{
				Dimensions = value as IfcDimensionalExponents;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcNamedUnit), 2)]
		Ifc4.Interfaces.IfcUnitEnum IIfcNamedUnit.UnitType 
		{ 
			get
			{
				//## Custom code to handle enumeration of UnitType
				//##
				switch (UnitType)
				{
					case IfcUnitEnum.ABSORBEDDOSEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ABSORBEDDOSEUNIT;
					case IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT;
					case IfcUnitEnum.AREAUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.AREAUNIT;
					case IfcUnitEnum.DOSEEQUIVALENTUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.DOSEEQUIVALENTUNIT;
					case IfcUnitEnum.ELECTRICCAPACITANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICCAPACITANCEUNIT;
					case IfcUnitEnum.ELECTRICCHARGEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICCHARGEUNIT;
					case IfcUnitEnum.ELECTRICCONDUCTANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICCONDUCTANCEUNIT;
					case IfcUnitEnum.ELECTRICCURRENTUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICCURRENTUNIT;
					case IfcUnitEnum.ELECTRICRESISTANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICRESISTANCEUNIT;
					case IfcUnitEnum.ELECTRICVOLTAGEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ELECTRICVOLTAGEUNIT;
					case IfcUnitEnum.ENERGYUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ENERGYUNIT;
					case IfcUnitEnum.FORCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.FORCEUNIT;
					case IfcUnitEnum.FREQUENCYUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.FREQUENCYUNIT;
					case IfcUnitEnum.ILLUMINANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.ILLUMINANCEUNIT;
					case IfcUnitEnum.INDUCTANCEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.INDUCTANCEUNIT;
					case IfcUnitEnum.LENGTHUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.LENGTHUNIT;
					case IfcUnitEnum.LUMINOUSFLUXUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.LUMINOUSFLUXUNIT;
					case IfcUnitEnum.LUMINOUSINTENSITYUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.LUMINOUSINTENSITYUNIT;
					case IfcUnitEnum.MAGNETICFLUXDENSITYUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.MAGNETICFLUXDENSITYUNIT;
					case IfcUnitEnum.MAGNETICFLUXUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.MAGNETICFLUXUNIT;
					case IfcUnitEnum.MASSUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.MASSUNIT;
					case IfcUnitEnum.PLANEANGLEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.PLANEANGLEUNIT;
					case IfcUnitEnum.POWERUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.POWERUNIT;
					case IfcUnitEnum.PRESSUREUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.PRESSUREUNIT;
					case IfcUnitEnum.RADIOACTIVITYUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.RADIOACTIVITYUNIT;
					case IfcUnitEnum.SOLIDANGLEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.SOLIDANGLEUNIT;
					case IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT;
					case IfcUnitEnum.TIMEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.TIMEUNIT;
					case IfcUnitEnum.VOLUMEUNIT:
						return Ifc4.Interfaces.IfcUnitEnum.VOLUMEUNIT;
					case IfcUnitEnum.USERDEFINED:
						//## Optional custom handling of UnitType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcUnitEnum.USERDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of UnitType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcUnitEnum.ABSORBEDDOSEUNIT:
						UnitType = IfcUnitEnum.ABSORBEDDOSEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT:
						UnitType = IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.AREAUNIT:
						UnitType = IfcUnitEnum.AREAUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.DOSEEQUIVALENTUNIT:
						UnitType = IfcUnitEnum.DOSEEQUIVALENTUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICCAPACITANCEUNIT:
						UnitType = IfcUnitEnum.ELECTRICCAPACITANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICCHARGEUNIT:
						UnitType = IfcUnitEnum.ELECTRICCHARGEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICCONDUCTANCEUNIT:
						UnitType = IfcUnitEnum.ELECTRICCONDUCTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICCURRENTUNIT:
						UnitType = IfcUnitEnum.ELECTRICCURRENTUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICRESISTANCEUNIT:
						UnitType = IfcUnitEnum.ELECTRICRESISTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ELECTRICVOLTAGEUNIT:
						UnitType = IfcUnitEnum.ELECTRICVOLTAGEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ENERGYUNIT:
						UnitType = IfcUnitEnum.ENERGYUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.FORCEUNIT:
						UnitType = IfcUnitEnum.FORCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.FREQUENCYUNIT:
						UnitType = IfcUnitEnum.FREQUENCYUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.ILLUMINANCEUNIT:
						UnitType = IfcUnitEnum.ILLUMINANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.INDUCTANCEUNIT:
						UnitType = IfcUnitEnum.INDUCTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.LENGTHUNIT:
						UnitType = IfcUnitEnum.LENGTHUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.LUMINOUSFLUXUNIT:
						UnitType = IfcUnitEnum.LUMINOUSFLUXUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.LUMINOUSINTENSITYUNIT:
						UnitType = IfcUnitEnum.LUMINOUSINTENSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.MAGNETICFLUXDENSITYUNIT:
						UnitType = IfcUnitEnum.MAGNETICFLUXDENSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.MAGNETICFLUXUNIT:
						UnitType = IfcUnitEnum.MAGNETICFLUXUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.MASSUNIT:
						UnitType = IfcUnitEnum.MASSUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.PLANEANGLEUNIT:
						UnitType = IfcUnitEnum.PLANEANGLEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.POWERUNIT:
						UnitType = IfcUnitEnum.POWERUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.PRESSUREUNIT:
						UnitType = IfcUnitEnum.PRESSUREUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.RADIOACTIVITYUNIT:
						UnitType = IfcUnitEnum.RADIOACTIVITYUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.SOLIDANGLEUNIT:
						UnitType = IfcUnitEnum.SOLIDANGLEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT:
						UnitType = IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.TIMEUNIT:
						UnitType = IfcUnitEnum.TIMEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.VOLUMEUNIT:
						UnitType = IfcUnitEnum.VOLUMEUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitEnum.USERDEFINED:
						UnitType = IfcUnitEnum.USERDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
		/// <summary>
		/// Get the full name of the IfcNamedUnit
		/// </summary>
		/// <returns>string holding full name</returns>
		public virtual string FullName
		{
			get
			{
				var unit = this as IfcSIUnit;
				if (unit != null)
					return unit.FullName;
				var basedUnit = this as IfcConversionBasedUnit;
				if (basedUnit != null)
					return basedUnit.Name;
				var dependentUnit = this as IfcContextDependentUnit;
				if (dependentUnit != null)
					return dependentUnit.Name;
				return string.Empty;
			}
		}

		/// <summary>
		/// Get the symbol of the IfcNamedUnit
		/// </summary>
		/// <returns>string holding symbol</returns>
		public virtual string Symbol
		{
			get
			{
				var unit = this as IfcSIUnit;
				if (unit != null)
					return unit.Symbol;
				var basedUnit = this as IfcConversionBasedUnit;
				if (basedUnit != null)
					return basedUnit.Name;  //elected not to get symbol as a small potential for a infinite loop is same object references itself
				var dependentUnit = this as IfcContextDependentUnit;
				if (dependentUnit != null)
					return dependentUnit.Name; //no symbol calc here
				return string.Empty;
			}
		}
		//##
	}
}